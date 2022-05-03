namespace higherlower
{
    partial class Minesweeper
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
            this.ifclick = new System.Windows.Forms.Label();
            this.btnAddFlag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ifclick
            // 
            this.ifclick.AutoSize = true;
            this.ifclick.Location = new System.Drawing.Point(452, 32);
            this.ifclick.Name = "ifclick";
            this.ifclick.Size = new System.Drawing.Size(51, 20);
            this.ifclick.TabIndex = 0;
            this.ifclick.Text = "label1";
            // 
            // btnAddFlag
            // 
            this.btnAddFlag.BackColor = System.Drawing.Color.Gray;
            this.btnAddFlag.Location = new System.Drawing.Point(522, 237);
            this.btnAddFlag.Name = "btnAddFlag";
            this.btnAddFlag.Size = new System.Drawing.Size(156, 76);
            this.btnAddFlag.TabIndex = 1;
            this.btnAddFlag.Text = "Add/remove flag";
            this.btnAddFlag.UseVisualStyleBackColor = false;
            this.btnAddFlag.Click += new System.EventHandler(this.btnAddFlag_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFlag);
            this.Controls.Add(this.ifclick);
            this.Name = "Minesweeper";
            this.Text = "minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ifclick;
        private System.Windows.Forms.Button btnAddFlag;
    }
}