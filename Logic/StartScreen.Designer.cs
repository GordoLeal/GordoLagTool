
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
            this.DataInfo = new System.Windows.Forms.ListBox();
            this.FPSLAG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FPS_NORMAL = new System.Windows.Forms.NumericUpDown();
            this.FPS_LAG = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GameRevisionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_NORMAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_LAG)).BeginInit();
            this.SuspendLayout();
            // 
            // DataInfo
            // 
            this.DataInfo.FormattingEnabled = true;
            this.DataInfo.Location = new System.Drawing.Point(12, 12);
            this.DataInfo.Name = "DataInfo";
            this.DataInfo.Size = new System.Drawing.Size(464, 264);
            this.DataInfo.TabIndex = 0;
            // 
            // FPSLAG
            // 
            this.FPSLAG.AutoSize = true;
            this.FPSLAG.Location = new System.Drawing.Point(496, 13);
            this.FPSLAG.Name = "FPSLAG";
            this.FPSLAG.Size = new System.Drawing.Size(106, 13);
            this.FPSLAG.TabIndex = 1;
            this.FPSLAG.Text = "FPS LAG (Default: 2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FPS NORMAL (Default: 60)";
            // 
            // FPS_NORMAL
            // 
            this.FPS_NORMAL.Location = new System.Drawing.Point(511, 72);
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
            this.FPS_LAG.Location = new System.Drawing.Point(511, 29);
            this.FPS_LAG.Name = "FPS_LAG";
            this.FPS_LAG.Size = new System.Drawing.Size(64, 20);
            this.FPS_LAG.TabIndex = 6;
            this.FPS_LAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FPS_LAG.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FPS_LAG.ValueChanged += new System.EventHandler(this.FPS_LAG_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Button (Virtual Code)";
            // 
            // ButtonCode
            // 
            this.ButtonCode.Location = new System.Drawing.Point(511, 124);
            this.ButtonCode.Name = "ButtonCode";
            this.ButtonCode.Size = new System.Drawing.Size(64, 20);
            this.ButtonCode.TabIndex = 8;
            this.ButtonCode.Text = "0xA0";
            this.ButtonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Default: Left Shift ( 0xA0 )";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(485, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Virtual Codes (click here)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(498, 242);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Set Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GameRevisionBox
            // 
            this.GameRevisionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameRevisionBox.FormattingEnabled = true;
            this.GameRevisionBox.Items.AddRange(new object[] {
            "611616",
            "604909",
            "603899",
            "603442",
            "603296",
            "600294"});
            this.GameRevisionBox.Location = new System.Drawing.Point(485, 187);
            this.GameRevisionBox.Name = "GameRevisionBox";
            this.GameRevisionBox.Size = new System.Drawing.Size(121, 21);
            this.GameRevisionBox.TabIndex = 12;
            this.GameRevisionBox.SelectedIndexChanged += new System.EventHandler(this.GameRevisionBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Game Revision";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GameRevisionBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPS_LAG);
            this.Controls.Add(this.FPS_NORMAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPSLAG);
            this.Controls.Add(this.DataInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.Text = "Gordo Lag Tool";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FPS_NORMAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS_LAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DataInfo;
        private System.Windows.Forms.Label FPSLAG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FPS_NORMAL;
        private System.Windows.Forms.NumericUpDown FPS_LAG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ButtonCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox GameRevisionBox;
        private System.Windows.Forms.Label label4;
    }
}