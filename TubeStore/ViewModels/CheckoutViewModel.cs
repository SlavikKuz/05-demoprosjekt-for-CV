﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TubeStore.Models;
using TubeStore.Models.Cart;

namespace TubeStore.ViewModels
{
    public class CheckoutViewModel
    {
        public ShippingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public CustomerViewModel Customer { get; set; }
        public bool IsTheSame { get; set; }
    }
}
