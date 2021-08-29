namespace WinFormUI
{
   public partial class Transactions
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
            this.customerText = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountValue = new System.Windows.Forms.NumericUpDown();
            this.makePurchaseButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.denyOverdraft = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Location = new System.Drawing.Point(193, 96);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(95, 29);
            this.customerText.TabIndex = 5;
            this.customerText.Text = "<none>";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(45, 96);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(125, 29);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "Customer";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(23, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(360, 42);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Credit Card Machine";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(45, 157);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 29);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            // 
            // amountValue
            // 
            this.amountValue.Location = new System.Drawing.Point(199, 155);
            this.amountValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountValue.Name = "amountValue";
            this.amountValue.Size = new System.Drawing.Size(179, 35);
            this.amountValue.TabIndex = 7;
            // 
            // makePurchaseButton
            // 
            this.makePurchaseButton.Location = new System.Drawing.Point(81, 290);
            this.makePurchaseButton.Name = "makePurchaseButton";
            this.makePurchaseButton.Size = new System.Drawing.Size(249, 81);
            this.makePurchaseButton.TabIndex = 8;
            this.makePurchaseButton.Text = "Make Purchase";
            this.makePurchaseButton.UseVisualStyleBackColor = true;
            this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(93, 374);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(237, 29);
            this.errorMessage.TabIndex = 13;
            this.errorMessage.Text = "You Are Overdrafting";
            this.errorMessage.Visible = false;
            this.errorMessage.Click += new System.EventHandler(this.errorMessage_Click);
            // 
            // denyOverdraft
            // 
            this.denyOverdraft.AutoCheck = false;
            this.denyOverdraft.Location = new System.Drawing.Point(161, 207);
            this.denyOverdraft.Name = "denyOverdraft";
            this.denyOverdraft.Size = new System.Drawing.Size(217, 33);
            this.denyOverdraft.TabIndex = 14;
            this.denyOverdraft.Text = "Stop Overdraft";
            this.denyOverdraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.denyOverdraft.UseCompatibleTextRendering = true;
            this.denyOverdraft.UseVisualStyleBackColor = true;
            this.denyOverdraft.CheckedChanged += new System.EventHandler(this.denyOverdraft_CheckedChanged);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 431);
            this.Controls.Add(this.denyOverdraft);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.makePurchaseButton);
            this.Controls.Add(this.amountValue);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.amountValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerText;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.NumericUpDown amountValue;
        private System.Windows.Forms.Button makePurchaseButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.CheckBox denyOverdraft;
    }
}