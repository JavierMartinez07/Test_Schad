﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Schad.Maintenance.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double TotalTax { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
    }
}
