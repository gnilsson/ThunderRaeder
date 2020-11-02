using Microsoft.AspNetCore.Http;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ThunderRaeder.API.General.Descriptive;
using ThunderRaeder.API.Infrastructure.Extensions;
using ThunderRaeder.API.Services.MicrosoftGraph.Instructions;

namespace ThunderRaeder.API.Services.MicrosoftGraph
{
    public class MicrosoftGraphService : MicrosoftGraphServiceBase, IMicrosoftGraphService
    {
        private readonly IGraphServiceClient _graphClient;

        public MicrosoftGraphService(IGraphServiceClient graphClient) : base(graphClient)
        {
            _graphClient = graphClient;
        }

        public async Task<User> GetUserAsync(string userPrincipalName)
        {
            var filterString = $"startswith(userPrincipalName,'{userPrincipalName}')";
            try
            {
                var result = await _graphClient.Users
                    .Request()
                    .Filter(filterString)
                    .GetAsync();

                return result.FirstOrDefault();

            }
            catch (ServiceException ex)
            {
                throw ex;
            }
        }

        public async Task<User> CreateUserAsync(CreateAzureAdUserInstruction instruction)
        {
            try
            {
                var acc = instruction.GetAccount();
                var user = await _graphClient.Users
                    .Request()
                    .AddAsync(instruction.BuildModel(acc.Item2));
                await SendMailAsync(
                    $"This is your temporary password to Azure AD: {acc.Item2} for account {instruction.UserPrincipalName}",
                    acc.Item1);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Invitation> CreateInvitationAsync(CreateAzureInvitationInstruction instruction)
        {
            return await _graphClient.Invitations
                 .Request()
                 .AddAsync(instruction.BuildModel());
        }


        public async Task SendMailAsync(string message, string email)
        {
            await _graphClient.Users["gnilsson@nackadomain.onmicrosoft.com"].SendMail(
                new Message
                {
                    Body = new ItemBody()
                    {
                        ContentType = BodyType.Text,
                        Content = message
                    },
                    ToRecipients = new List<Recipient>
                    { new Recipient { EmailAddress = new EmailAddress { Address = email } } }
                }).Request().PostAsync();
        }
        public async Task<string> GetAvailableUpnAsync(string email, int? attempt = null)
        {
            var userPrincipalName = email.ToUserPrincipalName(attempt);
            var user = await GetUserAsync(userPrincipalName);
            return user.UserPrincipalName.Equals(
                userPrincipalName, StringComparison.OrdinalIgnoreCase) ?
                userPrincipalName :
                await GetAvailableUpnAsync(
                    email, attempt == null ? 1 : attempt++);
        }

        public async Task<List> GetDocumentLibraryAsync()
        {
            return await _graphClient
                .Groups[SharePoint.GroupId]
                .Sites[SharePoint.SiteId]
                .Lists[SharePoint.LibraryId]
                .Request().GetAsync();
        }

        public async Task<DriveItem> AddDcoumentAsync(IFormFile file)
        {
            var fileName = ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.Trim('"');

            await _graphClient
                .Groups[SharePoint.GroupId]
                .Drives[SharePoint.DriveId]
                .Items.Request()
                .AddAsync(new DriveItem
                {
                    Name = fileName,
                    File = new Microsoft.Graph.File(),
                    ParentReference = new ItemReference
                    { Id = SharePoint.ParentContainerId }
                });

            return await _graphClient
                .Groups[SharePoint.GroupId]
                .Drives[SharePoint.DriveId]
                .Root.ItemWithPath(fileName)
                .Content.Request()
                .PutAsync<DriveItem>(file.OpenReadStream());
        }

        public async Task<DriveItem> GetDocumentAsync(string documentId)
        {
            return await _graphClient
                .Groups[SharePoint.GroupId]
                .Drives[SharePoint.DriveId]
                .Items[documentId].Request().GetAsync();
        }

        private async Task UpdateLibraryAsync()
        {
            var a = await _graphClient
            .Groups[SharePoint.GroupId]
            .Sites[SharePoint.SiteId]
            .Lists[SharePoint.LibraryId].Items
            .Request().AddAsync(new ListItem
            {
                ContentType = new ContentTypeInfo { Id = SharePoint.ContentTypeId }
                //           DriveItem = driveItem
            }); //  DriveItem = new DriveItem { Content = fs  }

            var abc = a;
        }
    }
}
