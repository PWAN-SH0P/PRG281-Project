namespace PRG281_Nel_Pieter_Proj
{
    partial class PromptForPrimeInterestRate
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
            txtPrimeInterestRate = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtPrimeInterestRate
            // 
            txtPrimeInterestRate.Location = new Point(71, 86);
            txtPrimeInterestRate.Name = "txtPrimeInterestRate";
            txtPrimeInterestRate.Size = new Size(125, 27);
            txtPrimeInterestRate.TabIndex = 0;
            txtPrimeInterestRate.TextChanged += txtPrimeInterestRate_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(114, 137);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // PromptForPrimeInterestRate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtPrimeInterestRate);
            Name = "PromptForPrimeInterestRate";
            Text = "PromptForPrimeInterestRate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrimeInterestRate;
        private Button btnSubmit;
    }
}