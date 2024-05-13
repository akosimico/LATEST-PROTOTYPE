namespace ThesisPrototype
{
    partial class InventoryManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionIDDisplay = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.P1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.qtyCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "  Price";
            // 
            // sessionIDDisplay
            // 
            this.sessionIDDisplay.AutoSize = true;
            this.sessionIDDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionIDDisplay.Location = new System.Drawing.Point(15, 63);
            this.sessionIDDisplay.Name = "sessionIDDisplay";
            this.sessionIDDisplay.Size = new System.Drawing.Size(97, 23);
            this.sessionIDDisplay.TabIndex = 5;
            this.sessionIDDisplay.Text = "Session ID: ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Lime;
            this.guna2Button1.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(247)))), ((int)(((byte)(18)))));
            this.guna2Button1.Location = new System.Drawing.Point(897, 706);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(173, 48);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "CONFIRM";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // P1
            // 
            this.P1.AutoRoundedCorners = true;
            this.P1.BorderRadius = 17;
            this.P1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.P1.DefaultText = "";
            this.P1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.P1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.P1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.P1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.P1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.P1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.ForeColor = System.Drawing.Color.Black;
            this.P1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.P1.Location = new System.Drawing.Point(842, 249);
            this.P1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.P1.Name = "P1";
            this.P1.PasswordChar = '\0';
            this.P1.PlaceholderText = "";
            this.P1.SelectedText = "";
            this.P1.Size = new System.Drawing.Size(126, 36);
            this.P1.TabIndex = 23;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1127, 59);
            this.guna2Panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "Inventory Management";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductIDCB
            // 
            this.ProductIDCB.AutoRoundedCorners = true;
            this.ProductIDCB.BackColor = System.Drawing.Color.Transparent;
            this.ProductIDCB.BorderRadius = 17;
            this.ProductIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProductIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductIDCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIDCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIDCB.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDCB.ForeColor = System.Drawing.Color.Black;
            this.ProductIDCB.ItemHeight = 30;
            this.ProductIDCB.Items.AddRange(new object[] {
            "Food 1",
            "Food 2",
            "Food 3",
            "Food 4",
            "Food 5"});
            this.ProductIDCB.Location = new System.Drawing.Point(90, 249);
            this.ProductIDCB.Name = "ProductIDCB";
            this.ProductIDCB.Size = new System.Drawing.Size(181, 36);
            this.ProductIDCB.TabIndex = 33;
            this.ProductIDCB.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // qtyCB
            // 
            this.qtyCB.AutoRoundedCorners = true;
            this.qtyCB.BackColor = System.Drawing.Color.Transparent;
            this.qtyCB.BorderRadius = 17;
            this.qtyCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qtyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qtyCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtyCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtyCB.Font = new System.Drawing.Font("Impact", 12F);
            this.qtyCB.ForeColor = System.Drawing.Color.Black;
            this.qtyCB.ItemHeight = 30;
            this.qtyCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.qtyCB.Location = new System.Drawing.Point(470, 249);
            this.qtyCB.Name = "qtyCB";
            this.qtyCB.Size = new System.Drawing.Size(181, 36);
            this.qtyCB.TabIndex = 34;
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1127, 857);
            this.Controls.Add(this.qtyCB);
            this.Controls.Add(this.ProductIDCB);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.sessionIDDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sessionIDDisplay;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox P1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox ProductIDCB;
        private Guna.UI2.WinForms.Guna2ComboBox qtyCB;
    }
}