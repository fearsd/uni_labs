namespace lab4_2
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
            BuildButton = new Button();
            ReadButton = new Button();
            WriteButton = new Button();
            TimerInput = new TextBox();
            SuspendLayout();
            // 
            // BuildButton
            // 
            BuildButton.Location = new Point(640, 74);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(101, 23);
            BuildButton.TabIndex = 0;
            BuildButton.Text = "ПОСТРОИТЬ";
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(640, 117);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(101, 23);
            ReadButton.TabIndex = 1;
            ReadButton.Text = "СЧИТАТЬ";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(640, 161);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(101, 23);
            WriteButton.TabIndex = 2;
            WriteButton.Text = "ЗАПИСАТЬ";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // TimerInput
            // 
            TimerInput.Location = new Point(640, 265);
            TimerInput.Name = "TimerInput";
            TimerInput.Size = new Size(101, 23);
            TimerInput.TabIndex = 3;
            TimerInput.TextChanged += TimerInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TimerInput);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(BuildButton);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuildButton;
        private Button ReadButton;
        private Button WriteButton;
        private TextBox TimerInput;
    }
}