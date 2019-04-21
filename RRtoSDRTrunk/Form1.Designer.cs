namespace RRtoSDRTrunk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.playListPathTxt = new System.Windows.Forms.TextBox();
            this.playlistFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listNum = new System.Windows.Forms.NumericUpDown();
            this.systemTypeCmb = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNum)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(792, 496);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copied RadioReference Table Data";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(357, 588);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(122, 23);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import to SDRTrunk";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectFolderBtn);
            this.groupBox2.Controls.Add(this.playListPathTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SDRTrunk location of playlist folder";
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(714, 16);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(84, 23);
            this.selectFolderBtn.TabIndex = 1;
            this.selectFolderBtn.Text = "Select Folder";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // playListPathTxt
            // 
            this.playListPathTxt.Location = new System.Drawing.Point(6, 19);
            this.playListPathTxt.Name = "playListPathTxt";
            this.playListPathTxt.Size = new System.Drawing.Size(702, 20);
            this.playListPathTxt.TabIndex = 0;
            this.playListPathTxt.TextChanged += new System.EventHandler(this.playListPathTxt_TextChanged);
            // 
            // playlistFolder
            // 
            this.playlistFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.playlistFolder.ShowNewFolderButton = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupNum);
            this.groupBox3.Location = new System.Drawing.Point(258, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(91, 40);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group Number";
            // 
            // groupNum
            // 
            this.groupNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupNum.Location = new System.Drawing.Point(24, 14);
            this.groupNum.Name = "groupNum";
            this.groupNum.Size = new System.Drawing.Size(50, 20);
            this.groupNum.TabIndex = 0;
            this.groupNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listNum);
            this.groupBox4.Location = new System.Drawing.Point(364, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 40);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Number";
            // 
            // listNum
            // 
            this.listNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listNum.Location = new System.Drawing.Point(23, 14);
            this.listNum.Name = "listNum";
            this.listNum.Size = new System.Drawing.Size(50, 20);
            this.listNum.TabIndex = 1;
            this.listNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // systemTypeCmb
            // 
            this.systemTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemTypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemTypeCmb.FormattingEnabled = true;
            this.systemTypeCmb.Items.AddRange(new object[] {
            "APCO25",
            "FLEETSYNC",
            "LTRNET",
            "LTRSTANDARD",
            "MDC1200",
            "MPT1327",
            "PASSPORT"});
            this.systemTypeCmb.Location = new System.Drawing.Point(6, 14);
            this.systemTypeCmb.Name = "systemTypeCmb";
            this.systemTypeCmb.Size = new System.Drawing.Size(121, 21);
            this.systemTypeCmb.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.systemTypeCmb);
            this.groupBox5.Location = new System.Drawing.Point(470, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 40);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "System Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 621);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RRtoSDRTrunk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupNum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listNum)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.TextBox playListPathTxt;
        private System.Windows.Forms.FolderBrowserDialog playlistFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown groupNum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown listNum;
        private System.Windows.Forms.ComboBox systemTypeCmb;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

