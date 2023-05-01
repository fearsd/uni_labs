namespace lab5_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepositButton = new Button();
            AccountTextBox = new TextBox();
            AccountComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BetweenAccountsComboBox = new CheckBox();
            AccountTransactionComboBox = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            TransactionComboBox = new ComboBox();
            TransactionTextBox = new TextBox();
            WithdrawButton = new Button();
            groupBox3 = new GroupBox();
            Account2ComboBox = new ComboBox();
            Account2TextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(18, 240);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(75, 23);
            DepositButton.TabIndex = 0;
            DepositButton.Text = "Зачислить";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // AccountTextBox
            // 
            AccountTextBox.Location = new Point(108, 40);
            AccountTextBox.Name = "AccountTextBox";
            AccountTextBox.Size = new Size(121, 23);
            AccountTextBox.TabIndex = 1;
            // 
            // AccountComboBox
            // 
            AccountComboBox.FormattingEnabled = true;
            AccountComboBox.Location = new Point(108, 103);
            AccountComboBox.Name = "AccountComboBox";
            AccountComboBox.Size = new Size(121, 23);
            AccountComboBox.TabIndex = 2;
            AccountComboBox.SelectedIndexChanged += AccountComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AccountComboBox);
            groupBox1.Controls.Add(AccountTextBox);
            groupBox1.Location = new Point(47, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 155);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Баланс счета 1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 106);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Валюта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Сумма";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BetweenAccountsComboBox);
            groupBox2.Controls.Add(AccountTransactionComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TransactionComboBox);
            groupBox2.Controls.Add(TransactionTextBox);
            groupBox2.Controls.Add(WithdrawButton);
            groupBox2.Controls.Add(DepositButton);
            groupBox2.Location = new Point(247, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 288);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Транзакция";
            // 
            // BetweenAccountsComboBox
            // 
            BetweenAccountsComboBox.AutoSize = true;
            BetweenAccountsComboBox.Location = new Point(78, 198);
            BetweenAccountsComboBox.Name = "BetweenAccountsComboBox";
            BetweenAccountsComboBox.Size = new Size(113, 19);
            BetweenAccountsComboBox.TabIndex = 8;
            BetweenAccountsComboBox.Text = "Между счетами";
            BetweenAccountsComboBox.UseVisualStyleBackColor = true;
            // 
            // AccountTransactionComboBox
            // 
            AccountTransactionComboBox.FormattingEnabled = true;
            AccountTransactionComboBox.Location = new Point(108, 148);
            AccountTransactionComboBox.Name = "AccountTransactionComboBox";
            AccountTransactionComboBox.Size = new Size(121, 23);
            AccountTransactionComboBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 151);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 6;
            label7.Text = "Счет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 95);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Валюта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 37);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Сумма";
            // 
            // TransactionComboBox
            // 
            TransactionComboBox.FormattingEnabled = true;
            TransactionComboBox.Location = new Point(108, 92);
            TransactionComboBox.Name = "TransactionComboBox";
            TransactionComboBox.Size = new Size(121, 23);
            TransactionComboBox.TabIndex = 3;
            // 
            // TransactionTextBox
            // 
            TransactionTextBox.Location = new Point(108, 34);
            TransactionTextBox.Name = "TransactionTextBox";
            TransactionTextBox.Size = new Size(121, 23);
            TransactionTextBox.TabIndex = 2;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(154, 240);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(75, 23);
            WithdrawButton.TabIndex = 1;
            WithdrawButton.Text = "Снять";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Account2ComboBox);
            groupBox3.Controls.Add(Account2TextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(440, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 154);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Баланс счета 2";
            // 
            // Account2ComboBox
            // 
            Account2ComboBox.FormattingEnabled = true;
            Account2ComboBox.Location = new Point(104, 102);
            Account2ComboBox.Name = "Account2ComboBox";
            Account2ComboBox.Size = new Size(117, 23);
            Account2ComboBox.TabIndex = 3;
            Account2ComboBox.SelectedIndexChanged += Account2ComboBox_SelectedIndexChanged;
            // 
            // Account2TextBox
            // 
            Account2TextBox.Location = new Point(104, 39);
            Account2TextBox.Name = "Account2TextBox";
            Account2TextBox.Size = new Size(117, 23);
            Account2TextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 105);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 1;
            label6.Text = "Валюта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 39);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Сумма";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 538);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DepositButton;
        private TextBox AccountTextBox;
        private ComboBox AccountComboBox;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private ComboBox TransactionComboBox;
        private TextBox TransactionTextBox;
        private Button WithdrawButton;
        private CheckBox BetweenAccountsComboBox;
        private ComboBox AccountTransactionComboBox;
        private Label label7;
        private GroupBox groupBox3;
        private ComboBox Account2ComboBox;
        private TextBox Account2TextBox;
        private Label label6;
        private Label label5;
    }
}