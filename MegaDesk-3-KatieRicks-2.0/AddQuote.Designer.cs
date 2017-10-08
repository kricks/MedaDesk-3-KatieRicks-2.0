namespace MegaDesk_3_KatieRicks_2._0
{
    partial class AddQuote
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
            this.butBack = new System.Windows.Forms.Button();
            this.butDisplayQuote = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comMaterial = new System.Windows.Forms.ComboBox();
            this.textCustName = new System.Windows.Forms.TextBox();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.comShipping = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(25, 364);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(206, 74);
            this.butBack.TabIndex = 5;
            this.butBack.Text = "Go Back to Main Menu";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butDisplayQuote
            // 
            this.butDisplayQuote.Location = new System.Drawing.Point(263, 364);
            this.butDisplayQuote.Name = "butDisplayQuote";
            this.butDisplayQuote.Size = new System.Drawing.Size(206, 74);
            this.butDisplayQuote.TabIndex = 6;
            this.butDisplayQuote.Text = "Display Quote";
            this.butDisplayQuote.UseVisualStyleBackColor = true;
            this.butDisplayQuote.Click += new System.EventHandler(this.butDisplayQuote_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add Desk Quote";
            // 
            // comMaterial
            // 
            this.comMaterial.FormattingEnabled = true;
            this.comMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.comMaterial.Location = new System.Drawing.Point(110, 254);
            this.comMaterial.Name = "comMaterial";
            this.comMaterial.Size = new System.Drawing.Size(121, 24);
            this.comMaterial.TabIndex = 4;
            // 
            // textCustName
            // 
            this.textCustName.Location = new System.Drawing.Point(110, 60);
            this.textCustName.Name = "textCustName";
            this.textCustName.Size = new System.Drawing.Size(121, 22);
            this.textCustName.TabIndex = 0;
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(111, 157);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(120, 22);
            this.numDepth.TabIndex = 2;
            this.numDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(111, 107);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 1;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Width (24\" min - 96\" max)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Depth (12\" min - 48\" max)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Number of Drawers (0 - 7)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Enter Surface Material";
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(111, 206);
            this.numDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(120, 22);
            this.numDrawers.TabIndex = 3;
            // 
            // comShipping
            // 
            this.comShipping.FormattingEnabled = true;
            this.comShipping.Items.AddRange(new object[] {
            "3 Rush Days",
            "5 Rush Days",
            "7 Rush Days",
            "14 Normal Days"});
            this.comShipping.Location = new System.Drawing.Point(110, 312);
            this.comShipping.Name = "comShipping";
            this.comShipping.Size = new System.Drawing.Size(121, 24);
            this.comShipping.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter Shipping Days";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comShipping);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.textCustName);
            this.Controls.Add(this.comMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butDisplayQuote);
            this.Controls.Add(this.butBack);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butDisplayQuote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comMaterial;
        private System.Windows.Forms.TextBox textCustName;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.ComboBox comShipping;
        private System.Windows.Forms.Label label7;
    }
}