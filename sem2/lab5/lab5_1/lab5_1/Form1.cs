
namespace lab5_1
{
    public partial class Form1 : Form
    {
        string[] _currencies = { "rub", "sgd", "tjs", "tmt", "try", "uah", "uzs", "zar", "hkd",
                                "huf", "inr", "usd", "jpy", "sek", "aud", "azn", "bgn",
                                "brl", "eur", "byn", "cad", "chf", "cny", "czk", "dkk",
                                "gbp", "ron", "pln", "nok", "mdl", "kzt", "krw", "kgs"
                                };
        Currency[] currencies;
        Account account1, account2;
        public Form1()
        {
            InitializeComponent();
            currencies = Helper.DoCurrencies(_currencies);
            account1 = new Account(0, currencies[0], "Первый счет", AccountTextBox);
            account2 = new Account(0, currencies[0], "Второй счет", Account2TextBox);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Account[] account_names = new Account[] { account1, account2 };
            AccountComboBox.Items.AddRange(_currencies);
            Account2ComboBox.Items.AddRange(_currencies);
            TransactionComboBox.Items.AddRange(_currencies);
            AccountTransactionComboBox.Items.AddRange(account_names);
            AccountComboBox.SelectedItem = _currencies[0];
            Account2ComboBox.SelectedItem = _currencies[0];
            TransactionComboBox.SelectedItem = _currencies[0];
            AccountTextBox.Text = "0";
            Account2TextBox.Text = "0";
            TransactionTextBox.Text = "0";
        }

        private async void DepositButton_Click(object sender, EventArgs e)
        {
            if (!BetweenAccountsComboBox.Checked)
            {
                ProcessTransaction();
                return;
            }
            Account? acc = getChosenAccount();
            if (acc != null)
            {
                Account acc2 = new List<Account> { account1, account2 }.Where(e => e != acc).First();
                Transaction tr = new Transaction(decimal.Parse(TransactionTextBox.Text), TransactionComboBox.Text, acc2, acc, 1);
                await tr.MakeTransaction();
            }
            

        }

        private async void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!BetweenAccountsComboBox.Checked)
            {
                ProcessTransaction(true);
                return;
            }
                
            Account? acc = getChosenAccount();
            if (acc != null)
            {
                Account acc2 = new List<Account> { account1, account2 }.Where(e => e != acc).First();
                Transaction tr = new Transaction(decimal.Parse(TransactionTextBox.Text), TransactionComboBox.Text, acc, acc2, 1);
                await tr.MakeTransaction();
            }
        }

        private async void AccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Helper.handleCurrencyChange(AccountComboBox, account1, currencies);
            account1.UpdateTextBox();
        }
        private async void Account2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Helper.handleCurrencyChange(Account2ComboBox, account2, currencies);
            account2.UpdateTextBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void ProcessTransaction(bool isMinus = false)
        {
            Account? acc = getChosenAccount();
            if (acc != null)
            {
                await Helper.depositAccount(TransactionTextBox.Text, TransactionComboBox.Text, acc, isMinus);
                acc.UpdateTextBox();
            }
            
        }

        private Account? getChosenAccount()
        {
            if (AccountTransactionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите счет!", "Ошибка");
                return null;
            }
            Account acc = AccountTransactionComboBox.SelectedItem as Account;
            return acc;
        }
    }
}