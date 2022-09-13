﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLogic.Interfaces
{
    internal interface ICustomerActions
    {
        public string MyInfo();
        public string WatchBasket();
        public void UpdateInfo();
    }
}