namespace higherlower
{
    partial class HigherLow
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
            this.lblRandNumber = new System.Windows.Forms.Label();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.jsdkjlsadja = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRandNumber
            // 
            this.lblRandNumber.AutoSize = true;
            this.lblRandNumber.Location = new System.Drawing.Point(406, 102);
            this.lblRandNumber.Name = "lblRandNumber";
            this.lblRandNumber.Size = new System.Drawing.Size(18, 20);
            this.lblRandNumber.TabIndex = 0;
            this.lblRandNumber.Text = "0";
            // 
            // btnHigh
            // 
            this.btnHigh.Location = new System.Drawing.Point(59, 12);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(128, 63);
            this.btnHigh.TabIndex = 1;
            this.btnHigh.Text = "Higher";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnLow
            // 
            this.btnLow.Location = new System.Drawing.Point(59, 91);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(128, 63);
            this.btnLow.TabIndex = 2;
            this.btnLow.Text = "Lower";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // jsdkjlsadja
            // 
            this.jsdkjlsadja.AutoSize = true;
            this.jsdkjlsadja.Location = new System.Drawing.Point(553, 12);
            this.jsdkjlsadja.Name = "jsdkjlsadja";
            this.jsdkjlsadja.Size = new System.Drawing.Size(59, 20);
            this.jsdkjlsadja.TabIndex = 3;
            this.jsdkjlsadja.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(618, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // HigherLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.jsdkjlsadja);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.lblRandNumber);
            this.Name = "HigherLow";
            this.Text = "HigherLow";
            this.Load += new System.EventHandler(this.HigherLow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandNumber;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Label jsdkjlsadja;
        private System.Windows.Forms.Label lblScore;
    }
}