﻿namespace BitcoinCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tulemusLabel = new System.Windows.Forms.Label();
            this.bitcoinAmountInput = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.currencySelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sisesta Bitocin arv";
            // 
            // tulemusLabel
            // 
            this.tulemusLabel.AutoSize = true;
            this.tulemusLabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulemusLabel.ForeColor = System.Drawing.Color.Lime;
            this.tulemusLabel.Location = new System.Drawing.Point(82, 277);
            this.tulemusLabel.Name = "tulemusLabel";
            this.tulemusLabel.Size = new System.Drawing.Size(88, 25);
            this.tulemusLabel.TabIndex = 1;
            this.tulemusLabel.Text = "Tulemus";
            this.tulemusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // bitcoinAmountInput
            // 
            this.bitcoinAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitcoinAmountInput.Location = new System.Drawing.Point(87, 92);
            this.bitcoinAmountInput.Name = "bitcoinAmountInput";
            this.bitcoinAmountInput.Size = new System.Drawing.Size(100, 30);
            this.bitcoinAmountInput.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.Wheat;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Lime;
            this.resultLabel.Location = new System.Drawing.Point(87, 328);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(675, 57);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Pole";
            this.resultLabel.TextChanged += new System.EventHandler(this.resultLabel_TextChanged);
            // 
            // currencySelector
            // 
            this.currencySelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySelector.FormattingEnabled = true;
            this.currencySelector.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "EEK",
            "GBP",
            "JPY"});
            this.currencySelector.Location = new System.Drawing.Point(471, 130);
            this.currencySelector.Name = "currencySelector";
            this.currencySelector.Size = new System.Drawing.Size(146, 33);
            this.currencySelector.TabIndex = 4;
            this.currencySelector.Text = "Vali valuuta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(87, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.Location = new System.Drawing.Point(91, 176);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 30);
            this.txtCurrency.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(86, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sisesta valuuta";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitcoinCalculator.Properties.Resources.BACK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencySelector);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bitcoinAmountInput);
            this.Controls.Add(this.tulemusLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemusLabel;
        private System.Windows.Forms.TextBox bitcoinAmountInput;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.ComboBox currencySelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label2;
    }
}

