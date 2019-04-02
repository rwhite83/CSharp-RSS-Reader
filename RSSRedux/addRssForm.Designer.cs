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
            this.btnAddRss = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.tbRssAddress = new System.Windows.Forms.TextBox();
            this.lblRssAddress = new System.Windows.Forms.Label();
            this.lblRssName = new System.Windows.Forms.Label();
            this.tbRssName = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRss
            // 
            this.btnAddRss.Location = new System.Drawing.Point(149, 140);
            this.btnAddRss.Name = "btnAddRss";
            this.btnAddRss.Size = new System.Drawing.Size(133, 55);
            this.btnAddRss.TabIndex = 0;
            this.btnAddRss.Text = "Add";
            this.btnAddRss.UseVisualStyleBackColor = true;
            this.btnAddRss.Click += new System.EventHandler(this.btnAddRss_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(336, 140);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(133, 55);
            this.btnCancelAdd.TabIndex = 1;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.rssFeedPopUp1_cancelBtnEvent);
            // 
            // tbRssAddress
            // 
            this.tbRssAddress.Location = new System.Drawing.Point(149, 66);
            this.tbRssAddress.Name = "tbRssAddress";
            this.tbRssAddress.Size = new System.Drawing.Size(320, 29);
            this.tbRssAddress.TabIndex = 2;
            // 
            // lblRssAddress
            // 
            this.lblRssAddress.AutoSize = true;
            this.lblRssAddress.Location = new System.Drawing.Point(12, 66);
            this.lblRssAddress.Name = "lblRssAddress";
            this.lblRssAddress.Size = new System.Drawing.Size(137, 25);
            this.lblRssAddress.TabIndex = 3;
            this.lblRssAddress.Text = "RSS Address:";
            // 
            // lblRssName
            // 
            this.lblRssName.AutoSize = true;
            this.lblRssName.Location = new System.Drawing.Point(33, 21);
            this.lblRssName.Name = "lblRssName";
            this.lblRssName.Size = new System.Drawing.Size(116, 25);
            this.lblRssName.TabIndex = 5;
            this.lblRssName.Text = "RSS Name:";
            // 
            // tbRssName
            // 
            this.tbRssName.Location = new System.Drawing.Point(149, 21);
            this.tbRssName.Name = "tbRssName";
            this.tbRssName.Size = new System.Drawing.Size(320, 29);
            this.tbRssName.TabIndex = 4;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(33, 123);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 25);
            this.lbWarning.TabIndex = 6;
            // 
            // formAddRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 216);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lblRssName);
            this.Controls.Add(this.tbRssName);
            this.Controls.Add(this.lblRssAddress);
            this.Controls.Add(this.tbRssAddress);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAddRss);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAddRSS";
            this.Text = "RSS Adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRss;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.TextBox tbRssAddress;
        private System.Windows.Forms.Label lblRssAddress;
        private System.Windows.Forms.Label lblRssName;
        private System.Windows.Forms.TextBox tbRssName;
        private System.Windows.Forms.Label lbWarning;
    }
}