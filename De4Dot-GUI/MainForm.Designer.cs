namespace De4DotGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picIF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSearchInput = new System.Windows.Forms.Button();
            this.btnSearchOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.rbt32Bit = new System.Windows.Forms.RadioButton();
            this.rbt64Bit = new System.Windows.Forms.RadioButton();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picIF)).BeginInit();
            this.SuspendLayout();
            // 
            // picIF
            // 
            this.picIF.Image = ((System.Drawing.Image)(resources.GetObject("picIF.Image")));
            this.picIF.Location = new System.Drawing.Point(115, 25);
            this.picIF.Name = "picIF";
            this.picIF.Size = new System.Drawing.Size(128, 96);
            this.picIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIF.TabIndex = 0;
            this.picIF.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入文件：";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 130);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(329, 21);
            this.txtInput.TabIndex = 2;
            // 
            // btnSearchInput
            // 
            this.btnSearchInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInput.Location = new System.Drawing.Point(352, 128);
            this.btnSearchInput.Name = "btnSearchInput";
            this.btnSearchInput.Size = new System.Drawing.Size(75, 21);
            this.btnSearchInput.TabIndex = 3;
            this.btnSearchInput.Text = "...";
            this.btnSearchInput.UseVisualStyleBackColor = true;
            this.btnSearchInput.Click += new System.EventHandler(this.btnSearchInput_Click);
            // 
            // btnSearchOutput
            // 
            this.btnSearchOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOutput.Location = new System.Drawing.Point(352, 172);
            this.btnSearchOutput.Name = "btnSearchOutput";
            this.btnSearchOutput.Size = new System.Drawing.Size(75, 21);
            this.btnSearchOutput.TabIndex = 6;
            this.btnSearchOutput.Text = "...";
            this.btnSearchOutput.UseVisualStyleBackColor = true;
            this.btnSearchOutput.Click += new System.EventHandler(this.btnSearchOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 174);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(329, 21);
            this.txtOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输出文件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "附加选项：";
            // 
            // txtAdditional
            // 
            this.txtAdditional.Location = new System.Drawing.Point(12, 244);
            this.txtAdditional.Multiline = true;
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(329, 58);
            this.txtAdditional.TabIndex = 8;
            // 
            // rbt32Bit
            // 
            this.rbt32Bit.AutoSize = true;
            this.rbt32Bit.Checked = true;
            this.rbt32Bit.Location = new System.Drawing.Point(364, 255);
            this.rbt32Bit.Name = "rbt32Bit";
            this.rbt32Bit.Size = new System.Drawing.Size(47, 16);
            this.rbt32Bit.TabIndex = 9;
            this.rbt32Bit.TabStop = true;
            this.rbt32Bit.Text = "32位";
            this.rbt32Bit.UseVisualStyleBackColor = true;
            // 
            // rbt64Bit
            // 
            this.rbt64Bit.AutoSize = true;
            this.rbt64Bit.Location = new System.Drawing.Point(364, 276);
            this.rbt64Bit.Name = "rbt64Bit";
            this.rbt64Bit.Size = new System.Drawing.Size(47, 16);
            this.rbt64Bit.TabIndex = 10;
            this.rbt64Bit.Text = "64位";
            this.rbt64Bit.UseVisualStyleBackColor = true;
            // 
            // btnWork
            // 
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Location = new System.Drawing.Point(12, 333);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(421, 21);
            this.btnWork.TabIndex = 11;
            this.btnWork.Text = "开始执行！";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.Purple;
            this.txtOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOut.ForeColor = System.Drawing.Color.White;
            this.txtOut.Location = new System.Drawing.Point(12, 393);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(421, 147);
            this.txtOut.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "控制台输出：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(286, 84);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 12);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "致中国区用户的一封信";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(445, 551);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.rbt64Bit);
            this.Controls.Add(this.rbt32Bit);
            this.Controls.Add(this.txtAdditional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picIF);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De4Dot图形界面，Tianjiao修改，原作者V0K3";
            ((System.ComponentModel.ISupportInitialize)(this.picIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Button btnWork;
		private System.Windows.Forms.RadioButton rbt64Bit;
		private System.Windows.Forms.RadioButton rbt32Bit;
		private System.Windows.Forms.TextBox txtAdditional;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnSearchOutput;
		private System.Windows.Forms.Button btnSearchInput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picIF;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
