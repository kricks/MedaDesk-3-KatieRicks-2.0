namespace MegaDesk_3_KatieRicks_2._0
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.butAddQuote = new System.Windows.Forms.Button();
            this.butViewQuote = new System.Windows.Forms.Button();
            this.butSearchQuote = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddQuote
            // 
            this.butAddQuote.Location = new System.Drawing.Point(31, 50);
            this.butAddQuote.Name = "butAddQuote";
            this.butAddQuote.Size = new System.Drawing.Size(255, 63);
            this.butAddQuote.TabIndex = 0;
            this.butAddQuote.Text = "Add New Quote";
            this.butAddQuote.UseVisualStyleBackColor = true;
            this.butAddQuote.Click += new System.EventHandler(this.butAddQuote_Click);
            // 
            // butViewQuote
            // 
            this.butViewQuote.Location = new System.Drawing.Point(31, 152);
            this.butViewQuote.Name = "butViewQuote";
            this.butViewQuote.Size = new System.Drawing.Size(255, 63);
            this.butViewQuote.TabIndex = 1;
            this.butViewQuote.Text = "View All Quotes";
            this.butViewQuote.UseVisualStyleBackColor = true;
            this.butViewQuote.Click += new System.EventHandler(this.butViewQuote_Click);
            // 
            // butSearchQuote
            // 
            this.butSearchQuote.Location = new System.Drawing.Point(31, 255);
            this.butSearchQuote.Name = "butSearchQuote";
            this.butSearchQuote.Size = new System.Drawing.Size(255, 63);
            this.butSearchQuote.TabIndex = 2;
            this.butSearchQuote.Text = "Search Quotes";
            this.butSearchQuote.UseVisualStyleBackColor = true;
            this.butSearchQuote.Click += new System.EventHandler(this.butSearchQuote_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(31, 349);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(255, 63);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 239);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSearchQuote);
            this.Controls.Add(this.butViewQuote);
            this.Controls.Add(this.butAddQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAddQuote;
        private System.Windows.Forms.Button butViewQuote;
        private System.Windows.Forms.Button butSearchQuote;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

