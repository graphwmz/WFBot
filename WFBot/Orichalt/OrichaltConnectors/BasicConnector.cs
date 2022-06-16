﻿using System;

namespace WFBot.Orichalt.OrichaltConnectors
{
    public class TestContext : PlatformContextBase
    {
        public string RawMessage { get; set; }
    }
    public class PlatformContextBase
    {

    }
    public partial class Connectors
    {
        private MessagePlatform Platform;
        public Connectors(MessagePlatform platform)
        {
            Platform = platform;
            switch (Platform)
            {
                case MessagePlatform.OneBot:
                    InitOneBot();
                    break;
                case MessagePlatform.Kaiheila:
                    throw new NotImplementedException();
                case MessagePlatform.QQChannel:
                    throw new NotImplementedException();
            }
        }
    }
}
