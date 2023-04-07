namespace lab4_1
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
            WriteButton = new Button();
            ReadButton = new Button();
            SuspendLayout();
            // 
            // BuildButton
            // 
            BuildButton.Location = new Point(176, 29);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(108, 23);
            BuildButton.TabIndex = 0;
            BuildButton.Text = "ПОСТРОИТЬ";
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(336, 29);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(91, 23);
            WriteButton.TabIndex = 1;
            WriteButton.Text = "ЗАПИСАТЬ";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(486, 29);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(75, 23);
            ReadButton.TabIndex = 2;
            ReadButton.Text = "СЧИТАТЬ";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(ReadButton);
            Controls.Add(WriteButton);
            Controls.Add(BuildButton);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button BuildButton;
        private Button WriteButton;
        private Button ReadButton;
    }
}