﻿using Merchello.Core.Gateways.Shipping.FixedRate;
using System;
using System.Collections.Generic;

namespace Merchello.Web.Models.ContentEditing
{
    public class RateTableShipMethodDisplay
    {
        public ShipMethodDisplay ShipMethod { get; set; }
        public GatewayResourceDisplay GatewayResource { get; set; }
        public ShipRateTableDisplay RateTable { get; set; }
        public FixedRateShipMethod.QuoteType RateTableType { get; set; }
    }
}