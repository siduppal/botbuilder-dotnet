﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Bot.Builder.Ai.LanguageGeneration.Resolver
{
    public interface ILGEndpoint
    {
        string EndpointKey { get; }
        string LGAppId { get; }
        string EndpointURI { get; }
    }
}
