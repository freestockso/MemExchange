﻿using System.Collections.Generic;
using MemExchange.Server.Processor.Book;
using MemExchange.Server.Processor.Book.Orders;

namespace MemExchange.Server.Processor
{
    public interface IOrderDispatcher
    {
        Dictionary<string, IOrderBook> OrderBooks { get; }
        void HandleAddLimitOrder(ILimitOrder limitOrder);
        void HandleMarketOrder(IMarketOrder marketOrder);
    }
}