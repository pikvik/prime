﻿using Prime.Common;

namespace Prime.Common
{
    public class TradeOrdersContext : MarketOrdersContext
    {
        public TradeOrdersContext(UserContext userContext, ILogger logger = null) : base(userContext, logger)
        {
        }
    }
}