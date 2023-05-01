using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    public class Account
    {
        public decimal currentAmount;
        public Currency currency;
        public string name;
        public TextBox textBox;
        public Account(decimal currentAmount, Currency currency, string name, TextBox textBox) { 
            this.currentAmount = currentAmount;
            this.currency = currency;
            this.name = name;
            this.textBox = textBox;
        }
        public void UpdateTextBox()
        {
            textBox.Text = currentAmount.ToString();
        }
        public override string ToString()
        { 
            return name;
        }
    }
}
