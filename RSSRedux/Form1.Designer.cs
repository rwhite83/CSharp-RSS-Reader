namespace RSSRedux
{
    partial class formAddRSS
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
            this.rssFeedPopUp1 = new RSSFeeedPopUp.RSSFeedPopUp();
            this.SuspendLayout();
            // 
            // rssFeedPopUp1
            // 
            this.rssFeedPopUp1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rssFeedPopUp1.firstThemeColor = System.Drawing.Color.CornflowerBlue;
            this.rssFeedPopUp1.fourthThemeColor = System.Drawing.Color.Black;
            this.rssFeedPopUp1.Location = new System.Drawing.Point(2, 2);
            this.rssFeedPopUp1.Name = "rssFeedPopUp1";
            this.rssFeedPopUp1.secondThemeColor = System.Drawing.Color.LightSeaGreen;
            this.rssFeedPopUp1.Size = new System.Drawing.Size(717, 276);
            this.rssFeedPopUp1.TabIndex = 0;
            this.rssFeedPopUp1.thirdThemeColor = System.Drawing.Color.PaleVioletRed;
            // 
            // formAddRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 279);
            this.Controls.Add(this.rssFeedPopUp1);
            this.Name = "formAddRSS";
            this.Text = "RSS Adder";
            this.ResumeLayout(false);

        }

        #endregion

        private RSSFeeedPopUp.RSSFeedPopUp rssFeedPopUp1;
    }
}