namespace DVD
{
    partial class CRT
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DVD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVD)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DVD
            // 
            this.DVD.BackColor = System.Drawing.Color.Transparent;
            this.DVD.BackgroundImage = global::DVD.Properties.Resources.blue;
            this.DVD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DVD.Location = new System.Drawing.Point(208, 174);
            this.DVD.Name = "DVD";
            this.DVD.Size = new System.Drawing.Size(97, 93);
            this.DVD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DVD.TabIndex = 0;
            this.DVD.TabStop = false;
            // 
            // CRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(518, 449);
            this.Controls.Add(this.DVD);
            this.Name = "CRT";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DVD;
        private System.Windows.Forms.Timer timer1;
    }
}

