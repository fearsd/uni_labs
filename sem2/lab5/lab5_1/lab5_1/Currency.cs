using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    public class Currency
    {
        public string currencyCode { get; }

        public Currency(string currencyCode)
        {
            this.currencyCode = currencyCode;
        }
    }
}
