
namespace GordoLagTool
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.FPSLAG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FPS_NORMAL = new System.Windows.Forms.NumericUpDown();
            this.FPS_LAG = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.EnableButtom = new System.Windows.Forms.Button();
            this.listBox_GameNames = new System.Windows.Forms.ListBox();
            this.listBox_GameVersions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.CreatorLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_NORMAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_LAG)).BeginInit();
            this.SuspendLayout();
            // 
            // FPSLAG
            // 
            this.FPSLAG.AutoSize = true;
            this.FPSLAG.Location = new System.Drawing.Point(479, 17);
            this.FPSLAG.Name = "FPSLAG";
            this.FPSLAG.Size = new System.Drawing.Size(99, 13);
            this.FPSLAG.TabIndex = 1;
            this.FPSLAG.Text = "FPS lag (Default: 2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS normal (Default: 60)";
            // 
            // FPS_NORMAL
            // 
            this.FPS_NORMAL.Location = new System.Drawing.Point(496, 78);
            this.FPS_NORMAL.Name = "FPS_NORMAL";
            this.FPS_NORMAL.Size = new System.Drawing.Size(64, 20);
            this.FPS_NORMAL.TabIndex = 5;
            this.FPS_NORMAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FPS_NORMAL.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // FPS_LAG
            // 
            this.FPS_LAG.Location = new System.Drawing.Point(496, 39);
            this.FPS_LAG.Name = "FPS_LAG";
            this.FPS_LAG.Size = new System.Drawing.Size(64, 20);
            this.FPS_LAG.TabIndex = 6;
            this.FPS_LAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FPS_LAG.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lag button";
            // 
            // ButtonCode
            // 
            this.ButtonCode.Location = new System.Drawing.Point(496, 142);
            this.ButtonCode.Name = "ButtonCode";
            this.ButtonCode.Size = new System.Drawing.Size(64, 20);
            this.ButtonCode.TabIndex = 8;
            this.ButtonCode.Text = "0xA0";
            this.ButtonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Default: Left Shift ( 0xA0 )";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(467, 165);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Virtual Codes (click here)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EnableButtom
            // 
            this.EnableButtom.Enabled = false;
            this.EnableButtom.Location = new System.Drawing.Point(473, 241);
            this.EnableButtom.Name = "EnableButtom";
            this.EnableButtom.Size = new System.Drawing.Size(101, 23);
            this.EnableButtom.TabIndex = 11;
            this.EnableButtom.Text = "Enable Tool";
            this.EnableButtom.UseVisualStyleBackColor = true;
            this.EnableButtom.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // listBox_GameNames
            // 
            this.listBox_GameNames.FormattingEnabled = true;
            this.listBox_GameNames.Location = new System.Drawing.Point(12, 38);
            this.listBox_GameNames.Name = "listBox_GameNames";
            this.listBox_GameNames.Size = new System.Drawing.Size(206, 238);
            this.listBox_GameNames.TabIndex = 14;
            this.listBox_GameNames.SelectedIndexChanged += new System.EventHandler(this.listBox_GameNames_SelectedIndexChanged);
            // 
            // listBox_GameVersions
            // 
            this.listBox_GameVersions.FormattingEnabled = true;
            this.listBox_GameVersions.Location = new System.Drawing.Point(224, 39);
            this.listBox_GameVersions.Name = "listBox_GameVersions";
            this.listBox_GameVersions.Size = new System.Drawing.Size(230, 238);
            this.listBox_GameVersions.TabIndex = 15;
            this.listBox_GameVersions.SelectedIndexChanged += new System.EventHandler(this.listBox_GameVersions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Game";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Game Version";
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(12, 12);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(68, 23);
            this.button_reload.TabIndex = 18;
            this.button_reload.Text = "Load Files";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // button_Test
            // 
            this.button_Test.Enabled = false;
            this.button_Test.Location = new System.Drawing.Point(473, 212);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(101, 23);
            this.button_Test.TabIndex = 19;
            this.button_Test.Text = "Test Memory";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // CreatorLink
            // 
            this.CreatorLink.AutoSize = true;
            this.CreatorLink.Location = new System.Drawing.Point(474, 286);
            this.CreatorLink.Name = "CreatorLink";
            this.CreatorLink.Size = new System.Drawing.Size(100, 13);
            this.CreatorLink.TabIndex = 20;
            this.CreatorLink.TabStop = true;
            this.CreatorLink.Text = "Made by GordoLeal";
            this.CreatorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreatorLink_LinkClicked);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 308);
            this.Controls.Add(this.CreatorLink);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_GameVersions);
            this.Controls.Add(this.listBox_GameNames);
            this.Controls.Add(this.EnableButtom);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPS_LAG);
            this.Controls.Add(this.FPS_NORMAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPSLAG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.Text = "Gordo Lag Tool v2.0";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FPS_NORMAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_LAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FPSLAG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FPS_NORMAL;
        private System.Windows.Forms.NumericUpDown FPS_LAG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ButtonCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button EnableButtom;
        private System.Windows.Forms.ListBox listBox_GameNames;
        private System.Windows.Forms.ListBox listBox_GameVersions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.LinkLabel CreatorLink;
    }
}