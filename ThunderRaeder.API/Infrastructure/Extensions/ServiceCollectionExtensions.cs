using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.General.Types;
using ThunderRaeder.API.Handlers.AuthorizationHandlers;
using ThunderRaeder.API.Infrastructure.PipelineBehaviors;
using ThunderRaeder.API.Infrastructure.Utility;
using ThunderRaeder.API.QueryDefinitions.QueryDetailsConfigurations;
using ThunderRaeder.API.Repositories;
using ThunderRaeder.API.Repositories.Cached;
using ThunderRaeder.API.Repositories.Interfaces;
using ThunderRaeder.API.Security.Authorization;
using ThunderRaeder.API.Security.Settings;
using ThunderRaeder.API.Services;
using ThunderRaeder.API.Services.MicrosoftGraph;
using ThunderRaeder.Data.Contexts;

namespace ThunderRaeder.API.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ThunderRaederDbContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("sqlConn"),
                     x => x.MigrationsAssembly(typeof(ThunderRaederDbContext).Assembly.FullName)));
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ThunderRaederDbContext>();
        }

        public static void AddCors(this IServiceCollection services, string cors)
        {
            services.AddCors(policy =>
            {
                policy.AddPolicy(cors, opt => opt
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
        }

        public static void AddRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.Decorate<IRepositoryWrapper, CachedRepositoryWrapper>();
        }

        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(Startup));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(typeof(Startup).Assembly);
        }

        public static void AddServiceWrapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(new GraphServiceClientFactory(new MsGraphSettings().Bind(configuration)));
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
            services.AddScoped<IUriService>(provider =>
            {
                var accessor = provider.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var absoluteUri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent(), "/");
                return new UriService(absoluteUri);
            });
        }

        public static void AddJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = new JwtSettings().Bind(configuration);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.Secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true
                };
            });
        }

        public static void AddAuthorizationHandlers(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(AuthorizePolicy.AnagnosEmployee, policy =>
                {
                    policy.AddRequirements(new WorksForCompanyRequirement("anagnos.se"));
                });
            });
            services.AddSingleton<IAuthorizationHandler, WorksForCompanyHandler>();
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "ThunderRaeder API", Version = "v1" });

                x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the bearer scheme",
                });

                x.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id ="Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
        }

        public static void AddTypeContainerItems(this IServiceCollection services)
        {
            var types = new TypeContainer();
            types.HandlerTypes.ForEach(handlerType =>
            {
                services.AddScoped(handlerType[0], handlerType[1]);
            });
            var queryConfigurations = new Dictionary<string,
                                        ExpressionUtil.EmptyConstructorDelegate>();
            types.ForEach(type =>
            {
                if (type?.QueryConfiguration != null)
                    queryConfigurations.Add(
                        type.EntityType.Name,
                        ExpressionUtil.CreateEmptyConstructor(type.QueryConfiguration));
                var properties = type
                .GetType()
                .GetProperties()
                .Where(t => t.PropertyType.IsArray);
                foreach (var property in properties)
                {
                    if (property.GetValue(type) is Type[] handler)
                        services.AddScoped(handler[0], handler[1]);
                }
            });

            var managerContainer =
                new ReadOnlyDictionary<string,
                ExpressionUtil.EmptyConstructorDelegate>(queryConfigurations);
            services.AddSingleton(managerContainer);
            services.AddSingleton<QueryConfigurationUniversal>();
        }
    }
}



//AppDomain.CurrentDomain
//    .GetAssemblies()
//    .GetTypesAssignableFrom(typeof(IModifier<,>))
////    .GetTypesAssignableFrom<IEntityModifier>()
//    .ForEach(type =>
//    {
//        services.AddTransient(type); // typeof(ModifierBase<,>),
//    });
//var modifierConstructor = ExpressionUtil.CreateEmptyConstructor(type.Modifier);
//var a = modifierConstructor();
//var b = Convert.ChangeType(a, type.ModifierBase);
//var modifierDictionary = new Dictionary<string,
//                             ExpressionUtil.EmptyConstructorDelegate>();
//         services.AddSingleton(types);
//services.AddHttpClient("RestClient")
//                .AddPolicyHandler((services, request) => HttpPolicyExtensions.HandleTransientHttpError()
//                .WaitAndRetryAsync(new[]
//                {
//                    TimeSpan.FromSeconds(1),
//                    TimeSpan.FromSeconds(5),
//                    TimeSpan.FromSeconds(10),
//                    TimeSpan.FromSeconds(20),
//                    TimeSpan.FromSeconds(30)
//                })); // ?