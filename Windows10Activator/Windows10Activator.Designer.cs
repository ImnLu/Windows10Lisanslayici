namespace Windows10Activator
{
    partial class Windows10Activator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows10Activator));
            this.comboOSList = new System.Windows.Forms.ComboBox();
            this.linkLabelOSSelect = new System.Windows.Forms.LinkLabel();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboOSList
            // 
            this.comboOSList.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboOSList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOSList.Enabled = false;
            this.comboOSList.FormattingEnabled = true;
            this.comboOSList.Items.AddRange(new object[] {
            "Home",
            "Home N",
            "Home Single Language",
            "Home Country Specific",
            "Professional",
            "Professional N",
            "Education",
            "Education N",
            "Enterprise",
            "Enterprise N"});
            this.comboOSList.Location = new System.Drawing.Point(0, 0);
            this.comboOSList.Name = "comboOSList";
            this.comboOSList.Size = new System.Drawing.Size(297, 34);
            this.comboOSList.TabIndex = 2;
            this.comboOSList.TabStop = false;
            this.comboOSList.TextChanged += new System.EventHandler(this.comboOSList_TextChanged);
            // 
            // linkLabelOSSelect
            // 
            this.linkLabelOSSelect.AutoSize = true;
            this.linkLabelOSSelect.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelOSSelect.Location = new System.Drawing.Point(72, 37);
            this.linkLabelOSSelect.Name = "linkLabelOSSelect";
            this.linkLabelOSSelect.Size = new System.Drawing.Size(225, 16);
            this.linkLabelOSSelect.TabIndex = 3;
            this.linkLabelOSSelect.TabStop = true;
            this.linkLabelOSSelect.Text = "İşletim sistemini el ile seçmek için tıklayın.";
            this.linkLabelOSSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOSSelect_LinkClicked);
            // 
            // buttonActivate
            // 
            this.buttonActivate.Location = new System.Drawing.Point(91, 92);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(113, 37);
            this.buttonActivate.TabIndex = 4;
            this.buttonActivate.Text = "Lisansla";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // Windows10Activator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 141);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.linkLabelOSSelect);
            this.Controls.Add(this.comboOSList);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Windows10Activator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 10 Lisanslayıcı";
            this.Load += new System.EventHandler(this.Windows10Activator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboOSList;
        private System.Windows.Forms.LinkLabel linkLabelOSSelect;
        private System.Windows.Forms.Button buttonActivate;
    }
}

