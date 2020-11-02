﻿using FluentValidation;
using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.General.Exceptions;
using ThunderRaeder.API.General.Models;

namespace ThunderRaeder.API.Infrastructure.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Something went wrong");
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = HttpContentType.ApplicationJson;
            var error = exception switch
            {
                BadRequestException ex => GetBadRequest(context, new[] { ex.Message }),
                ValidationException ex => GetBadRequest(context, ex.Errors.Select(x => x.ErrorMessage)),
                _ => GetInternal(context)

            };
            return context.Response.WriteAsync(error.ToString());
        }

        private ErrorDetails GetBadRequest(HttpContext context, IEnumerable<string> messages = null)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Bad Request",
                Details = messages ?? null
            };
        }   

        private ErrorDetails GetInternal(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error"
            };
        }
    }
}
