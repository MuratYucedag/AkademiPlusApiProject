﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusApi.ConsumeLayer.Models.BalanceViewModels
{
    public class BalanceAddViewModel
    {
        public string AccountNumber { get; set; }
        public decimal CustomerBalance { get; set; }
        public string Currency { get; set; }
    }
}
