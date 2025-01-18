using System;

namespace BenTech.Models
{
    class Prices
    {
        public DateTime Data { get; set; } //primary key
        public double TotalCouple { get; set; }
        public double TotalSingle { get; set; }
        public double TotalTriple { get; set; }
        public double TotalQuadruple { get; set; }
        public double TotalQuintuple { get; set; }
        public double TotalChild03To06 { get; set; }
        public double TotalChild07To10 { get; set; }
        public string ColorCode { get; set; }

    }
}
