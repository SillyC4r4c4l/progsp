namespace higherlower
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picHigherLow = new System.Windows.Forms.PictureBox();
            this.picMineSweeper = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picDogs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHigherLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMineSweeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPlayer.Location = new System.Drawing.Point(422, 230);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(137, 96);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picHigherLow
            // 
            this.picHigherLow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picHigherLow.Location = new System.Drawing.Point(12, 30);
            this.picHigherLow.Name = "picHigherLow";
            this.picHigherLow.Size = new System.Drawing.Size(137, 96);
            this.picHigherLow.TabIndex = 1;
            this.picHigherLow.TabStop = false;
            // 
            // picMineSweeper
            // 
            this.picMineSweeper.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picMineSweeper.Location = new System.Drawing.Point(603, 3);
            this.picMineSweeper.Name = "picMineSweeper";
            this.picMineSweeper.Size = new System.Drawing.Size(137, 96);
            this.picMineSweeper.TabIndex = 2;
            this.picMineSweeper.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picDogs
            // 
            this.picDogs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picDogs.Location = new System.Drawing.Point(231, 55);
            this.picDogs.Name = "picDogs";
            this.picDogs.Size = new System.Drawing.Size(137, 96);
            this.picDogs.TabIndex = 4;
            this.picDogs.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDogs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picMineSweeper);
            this.Controls.Add(this.picHigherLow);
            this.Controls.Add(this.picPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHigherLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMineSweeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picHigherLow;
        private System.Windows.Forms.PictureBox picMineSweeper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picDogs;
    }
}

