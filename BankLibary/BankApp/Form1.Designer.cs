namespace BankApp
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
            this.formlabel = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formlabel
            // 
            this.formlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formlabel.AutoSize = true;
            this.formlabel.BackColor = System.Drawing.Color.Transparent;
            this.formlabel.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlabel.Location = new System.Drawing.Point(122, 80);
            this.formlabel.Name = "formlabel";
            this.formlabel.Size = new System.Drawing.Size(514, 62);
            this.formlabel.TabIndex = 0;
            this.formlabel.Text = "Welcome to SUS ATM";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnwithdraw.BackColor = System.Drawing.Color.CadetBlue;
            this.btnwithdraw.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnwithdraw.Location = new System.Drawing.Point(274, 275);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(287, 79);
            this.btnwithdraw.TabIndex = 1;
            this.btnwithdraw.Text = "Withdraw";
            this.btnwithdraw.UseVisualStyleBackColor = false;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexit.BackColor = System.Drawing.Color.Crimson;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(287, 472);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(259, 101);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankApp.Properties.Resources.mehdy_gigant_gif_among_us1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 708);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.formlabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formlabel;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btnexit;
    }
}

