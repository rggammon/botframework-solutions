// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Microsoft.Bot.Connector.Authentication;

namespace SampleBot.Authentication
{
    public class MsiAppCredentials : MicrosoftAppCredentials
    {
        public MsiAppCredentials(string appId)
            : base (appId, string.Empty)
        {
        }

        protected override Lazy<IAuthenticator> BuildIAuthenticator()
        {
            return new Lazy<IAuthenticator>(
                () =>
                new MsiAuthenticator(),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }
    }
}
