namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedGradientButton1 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton2 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton3 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl11 = new Steam.UserControl1();
            this.userControl21 = new Steam.UserControl2();
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl3 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(616, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Visible = false;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(571, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            this.siticoneControlBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BackColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(961, 276);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(193, 46);
            this.siticoneRoundedButton1.TabIndex = 28;
            this.siticoneRoundedButton1.Text = "Download";
            this.siticoneRoundedButton1.Visible = false;
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(961, 226);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(193, 44);
            this.siticoneRoundedButton2.TabIndex = 29;
            this.siticoneRoundedButton2.Text = "Execute";
            this.siticoneRoundedButton2.Visible = false;
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.BorderThickness = 1;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(948, 352);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(193, 45);
            this.siticoneRoundedButton3.TabIndex = 30;
            this.siticoneRoundedButton3.Text = "Clean";
            this.siticoneRoundedButton3.Visible = false;
            this.siticoneRoundedButton3.Click += new System.EventHandler(this.siticoneRoundedButton3_Click);
            // 
            // siticoneRoundedGradientButton1
            // 
            this.siticoneRoundedGradientButton1.CheckedState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.CustomImages.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneRoundedGradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.siticoneRoundedGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton1.HoveredState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Location = new System.Drawing.Point(236, 100);
            this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
            this.siticoneRoundedGradientButton1.ShadowDecoration.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Size = new System.Drawing.Size(167, 49);
            this.siticoneRoundedGradientButton1.TabIndex = 38;
            this.siticoneRoundedGradientButton1.Text = "Eulen";
            this.siticoneRoundedGradientButton1.Click += new System.EventHandler(this.siticoneRoundedGradientButton1_Click);
            // 
            // siticoneRoundedGradientButton2
            // 
            this.siticoneRoundedGradientButton2.CheckedState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.CustomImages.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneRoundedGradientButton2.FillColor2 = System.Drawing.Color.Black;
            this.siticoneRoundedGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton2.HoveredState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Location = new System.Drawing.Point(236, 164);
            this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
            this.siticoneRoundedGradientButton2.ShadowDecoration.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Size = new System.Drawing.Size(167, 49);
            this.siticoneRoundedGradientButton2.TabIndex = 39;
            this.siticoneRoundedGradientButton2.Text = "Skript";
            this.siticoneRoundedGradientButton2.Click += new System.EventHandler(this.siticoneRoundedGradientButton2_Click);
            // 
            // siticoneRoundedGradientButton3
            // 
            this.siticoneRoundedGradientButton3.CheckedState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.CustomImages.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.FillColor = System.Drawing.Color.Red;
            this.siticoneRoundedGradientButton3.FillColor2 = System.Drawing.Color.Black;
            this.siticoneRoundedGradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedGradientButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton3.HoveredState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Location = new System.Drawing.Point(86, 277);
            this.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
            this.siticoneRoundedGradientButton3.ShadowDecoration.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Size = new System.Drawing.Size(112, 30);
            this.siticoneRoundedGradientButton3.TabIndex = 40;
            this.siticoneRoundedGradientButton3.Text = "<<< Back";
            this.siticoneRoundedGradientButton3.Visible = false;
            this.siticoneRoundedGradientButton3.Click += new System.EventHandler(this.siticoneRoundedGradientButton3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Microsoft.Properties.Resources.Untitleasdadasd_2;
            this.pictureBox3.Location = new System.Drawing.Point(288, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Microsoft.Properties.Resources.Unasdasdtitled_2;
            this.pictureBox2.Location = new System.Drawing.Point(194, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Microsoft.Properties.Resources.Untitled_22;
            this.pictureBox1.Location = new System.Drawing.Point(-44, -110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Black;
            this.userControl11.Location = new System.Drawing.Point(61, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(572, 343);
            this.userControl11.TabIndex = 35;
            this.userControl11.Visible = false;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Black;
            this.userControl21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userControl21.Location = new System.Drawing.Point(61, 4);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(537, 397);
            this.userControl21.TabIndex = 36;
            this.userControl21.Visible = false;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.userControl11;
            // 
            // siticoneDragControl3
            // 
            this.siticoneDragControl3.TargetControl = this.userControl21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 381);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.siticoneRoundedGradientButton3);
            this.Controls.Add(this.siticoneRoundedGradientButton2);
            this.Controls.Add(this.siticoneRoundedGradientButton1);
            this.Controls.Add(this.siticoneRoundedButton3);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mylon";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
        private Steam.UserControl1 userControl11;
        private Steam.UserControl2 userControl21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton1;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton2;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl3;
    }
}
