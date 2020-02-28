// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Bot.Connector.Authentication;

namespace SampleBot.Authentication
{
    public class MsiAuthenticator : IAuthenticator
    {
        private AzureServiceTokenProvider _tokenProvider = new AzureServiceTokenProvider();

        public async Task<AuthenticatorResult> GetTokenAsync(bool forceRefresh)
        {
            var authResult = await _tokenProvider.GetAuthenticationResultAsync(AuthenticationConstants.ToChannelFromBotOAuthScope, "d6d49420-f39b-4df7-a1dc-d59a935871db");
            return new AuthenticatorResult()
            {
                AccessToken = authResult.AccessToken,
                ExpiresOn = authResult.ExpiresOn
            };
        }
    }
}