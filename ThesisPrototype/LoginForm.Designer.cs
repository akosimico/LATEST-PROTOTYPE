namespace ThesisPrototype
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.msgExit = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgNull = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgWrong = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(323, 210);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(42, 47);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(225, 162);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AutoRoundedCorners = true;
            this.UsernameTxt.BorderRadius = 19;
            this.UsernameTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxt.DefaultText = "";
            this.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.UsernameTxt.Location = new System.Drawing.Point(58, 249);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.PlaceholderText = "";
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.Size = new System.Drawing.Size(209, 41);
            this.UsernameTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoRoundedCorners = true;
            this.PasswordTxt.BorderRadius = 19;
            this.PasswordTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTxt.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.PasswordTxt.Location = new System.Drawing.Point(58, 318);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '●';
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.Size = new System.Drawing.Size(209, 41);
            this.PasswordTxt.TabIndex = 4;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoRoundedCorners = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 12;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.Red;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(58, 388);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(80, 26);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoRoundedCorners = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderRadius = 12;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Silver;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(187, 388);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 26);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // msgExit
            // 
            this.msgExit.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgExit.Caption = null;
            this.msgExit.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgExit.Parent = this;
            this.msgExit.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgExit.Text = null;
            // 
            // msgNull
            // 
            this.msgNull.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgNull.Caption = null;
            this.msgNull.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgNull.Parent = this;
            this.msgNull.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgNull.Text = null;
            // 
            // msgWrong
            // 
            this.msgWrong.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgWrong.Caption = null;
            this.msgWrong.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgWrong.Parent = this;
            this.msgWrong.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgWrong.Text = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(323, 448);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef Joy Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2MessageDialog msgExit;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNull;
        private Guna.UI2.WinForms.Guna2MessageDialog msgWrong;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

