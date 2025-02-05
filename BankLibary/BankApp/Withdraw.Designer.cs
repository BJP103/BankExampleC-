namespace BankApp
{
    partial class Withdraw
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
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelwithdraw = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAccounts.DropDownWidth = 121;
            this.cmbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(209, 77);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(655, 45);
            this.cmbAccounts.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmount.Location = new System.Drawing.Point(413, 287);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(244, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // labelwithdraw
            // 
            this.labelwithdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelwithdraw.AutoSize = true;
            this.labelwithdraw.BackColor = System.Drawing.Color.Transparent;
            this.labelwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwithdraw.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelwithdraw.Location = new System.Drawing.Point(226, 173);
            this.labelwithdraw.Name = "labelwithdraw";
            this.labelwithdraw.Size = new System.Drawing.Size(675, 73);
            this.labelwithdraw.TabIndex = 2;
            this.labelwithdraw.Text = "EnterWithdrawAmount";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnwithdraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnwithdraw.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnwithdraw.Image = global::BankApp.Properties.Resources.download;
            this.btnwithdraw.Location = new System.Drawing.Point(413, 421);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(244, 236);
            this.btnwithdraw.TabIndex = 3;
            this.btnwithdraw.Text = "Submit";
            this.btnwithdraw.UseVisualStyleBackColor = false;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankApp.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 669);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.labelwithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelwithdraw;
        private System.Windows.Forms.Button btnwithdraw;
    }
}