﻿namespace Smartwyre.DeveloperTest.Types
{
    public class CalculateRebateRequest
    {
        public string RebateIdentifier { get; set; }
        public string ProductIdentifier { get; set; }
        public int Volume { get; set; }
    }
}
