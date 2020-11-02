using Microsoft.Graph;
using System;
using System.Collections.Generic;

namespace ThunderRaeder.API.Services.MicrosoftGraph.Instructions
{
    public class CreateAzureAdUserInstruction
    {
        private readonly string _email;
        private string name;
        public bool AccountEnabled { get; set; } = true;
        public string DisplayName { get; set; }
        public string MailNickname { get; set; }
        public PasswordProfile PasswordProfile { get; set; }
        public string UserPrincipalName { get; }
        public CreateAzureAdUserInstruction(string userPrincipalName, string email)
        {
            UserPrincipalName = userPrincipalName;
            _email = email;
        }

        public User BuildModel(string pw)
        {
            return new User
            {
                AccountEnabled = AccountEnabled,
                DisplayName = name,
                UserPrincipalName = UserPrincipalName,
                MailNickname = name,
                PasswordProfile = new PasswordProfile { Password = pw, ForceChangePasswordNextSignIn = true },
                OtherMails = new List<string> { _email }
            };
        }

        public (string, string) GetAccount()
        {
            name = _email.Split('@')[0];
            var n5 = name.Substring(0, 5);
            var dt = DateTime.Now.Ticks.ToString().Substring(0, 5);
            var pw = $"{n5}_A%{dt}";
            return (_email, pw);
        }
    }
}
