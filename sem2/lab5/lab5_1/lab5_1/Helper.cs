using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    public class Helper
    {
        public static bool withFee = true;
        public static int Fee = 1;
        public static Currency[] DoCurrencies(string[] currencies)
        {
            List<Currency> result = new List<Currency>();
            foreach(string code in currencies)
            {
                result.Add(new Currency(code));
            }
            return result.ToArray();
        }
        public static async Task<decimal> convertCurrencies(decimal amount, string currency1, string currency2) {
            decimal? p = await CurrencyAPIWrapper.GetCurrentCurrencyAsync(currency1, currency2);
            if (p.HasValue)
            {
                return p.Value * amount;
            }
            return 0;
        }
        public static async Task depositAccount(
            string _amount, string currency,
            Account account,
            bool isMinus = false
        )
        {
            int fee = withFee && (currency != account.currency.currencyCode) ? Fee : 0;
            int m = isMinus ? -1 : 1;
            decimal amount = m * decimal.Parse(_amount);
            if (fee != 0)
                MessageBox.Show($"{Fee}% - комиссия\n{amount * fee / 100} {currency} уйдет как комиссия", "Информация");
            amount -= amount * fee / 100;
            
            decimal? result = await convertCurrencies(amount, currency, account.currency.currencyCode);
            if(result != null)
            {
                account.currentAmount += result.Value;
            }
        }
        public static async Task handleCurrencyChange(ComboBox AccountComboBox, Account account, Currency[] currencies)
        {
            int fee = withFee ? Fee : 0;
            string _currency = AccountComboBox.SelectedItem.ToString();
            Currency? currency = currencies.ToList().Where(e => e.currencyCode == _currency).FirstOrDefault();
            if (currency != null)
            {
                decimal? result = await convertCurrencies(account.currentAmount, account.currency.currencyCode, currency.currencyCode);
                if (account.currentAmount != 0)
                    MessageBox.Show($"{account.currentAmount} {account.currency.currencyCode} -> {result.Value} {currency.currencyCode}\n{Fee}% - комиссия\n{result.Value * fee / 100} {currency.currencyCode} уйдет с счета как комиссия", "Информация");
                account.currency = currency;
                account.currentAmount = result.Value - result.Value * fee / 100;
            }
        }
    }
}
