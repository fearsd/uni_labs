using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    public class Transaction
    {
        public decimal amount;
        public decimal fee;
        public string currency;
        public Account account1;
        public Account account2;
        public static string messageString = "{0}% - комиссия\n{1} {3} снимется с одного счета\n{2} {4} придет на другой счет\n{5} {3} уйдет как комиссия при снятии с одного счета\n{6} {4} уйдет как комиссия при пополнении другого счета";

        public Transaction(decimal amount, string currency, Account account1, Account account2, decimal fee = 0)
        {
            this.amount = amount;
            this.fee = fee;
            this.currency = currency;
            this.account1 = account1;
            this.account2 = account2;
        }

        public async Task MakeTransaction()
        {
            int ffee1 = (int)(currency != account1.currency.currencyCode ? fee : 0);
            decimal? convertionResult1 = await Helper.convertCurrencies(amount, currency, account1.currency.currencyCode);
            decimal firstFee = convertionResult1.Value * ffee1 / 100;
            decimal sequence = convertionResult1.Value - firstFee;
            amount -= amount * ffee1 / 100;
            int ffee2 = (int)(currency != account2.currency.currencyCode ? fee : 0);
            decimal? convertionResult2 = await Helper.convertCurrencies(amount, currency, account2.currency.currencyCode);
            decimal secondFee = convertionResult2.Value * ffee2 / 100;
            decimal res = convertionResult2.Value - secondFee;

            if (ffee1 != 0 || ffee2 != 0)
                MessageBox.Show(string.Format(messageString, fee, convertionResult1.Value, res, account1.currency.currencyCode, account2.currency.currencyCode, firstFee, secondFee), "Информация");
            account1.currentAmount -= convertionResult1.Value;
            account2.currentAmount += res;
            account1.UpdateTextBox();
            account2.UpdateTextBox();
        }
    }
}
