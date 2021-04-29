﻿using System;

namespace AsyncRepository.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public DateTime TradeDate { get; set; }
        public decimal MarketValue { get; set; }
        public int SecurityId { get; set; }
        public string AccountCode { get; set; }
    }
}
