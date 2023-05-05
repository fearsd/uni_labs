namespace lab6
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
            NewFigureButton = new Button();
            SaveFiguresButton = new Button();
            LoadFiguresButton = new Button();
            EraseButton = new Button();
            SuspendLayout();
            // 
            // NewFigureButton
            // 
            NewFigureButton.Location = new Point(847, 12);
            NewFigureButton.Name = "NewFigureButton";
            NewFigureButton.Size = new Size(75, 23);
            NewFigureButton.TabIndex = 0;
            NewFigureButton.Text = "Создать";
            NewFigureButton.UseVisualStyleBackColor = true;
            NewFigureButton.Click += NewFigureButton_Click;
            // 
            // SaveFiguresButton
            // 
            SaveFiguresButton.Location = new Point(847, 41);
            SaveFiguresButton.Name = "SaveFiguresButton";
            SaveFiguresButton.Size = new Size(75, 23);
            SaveFiguresButton.TabIndex = 1;
            SaveFiguresButton.Text = "Сохранить";
            SaveFiguresButton.UseVisualStyleBackColor = true;
            SaveFiguresButton.Click += SaveFiguresButton_Click;
            // 
            // LoadFiguresButton
            // 
            LoadFiguresButton.Location = new Point(847, 70);
            LoadFiguresButton.Name = "LoadFiguresButton";
            LoadFiguresButton.Size = new Size(75, 23);
            LoadFiguresButton.TabIndex = 2;
            LoadFiguresButton.Text = "Загрузить";
            LoadFiguresButton.UseVisualStyleBackColor = true;
            LoadFiguresButton.Click += LoadFiguresButton_Click;
            // 
            // EraseButton
            // 
            EraseButton.Location = new Point(847, 99);
            EraseButton.Name = "EraseButton";
            EraseButton.Size = new Size(75, 23);
            EraseButton.TabIndex = 3;
            EraseButton.Text = "Очистить";
            EraseButton.UseVisualStyleBackColor = true;
            EraseButton.Click += EraseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 491);
            Controls.Add(EraseButton);
            Controls.Add(LoadFiguresButton);
            Controls.Add(SaveFiguresButton);
            Controls.Add(NewFigureButton);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button NewFigureButton;
        private Button SaveFiguresButton;
        private Button LoadFiguresButton;
        private Button EraseButton;
    }
}