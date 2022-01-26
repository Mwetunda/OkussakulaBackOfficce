
namespace Okussakula.UI.User
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnLogar);
            this.panel1.Location = new System.Drawing.Point(213, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 334);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(60, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 2);
            this.panel3.TabIndex = 5;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.Location = new System.Drawing.Point(61, 131);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '.';
            this.TxtPassword.PlaceholderText = "Senha";
            this.TxtPassword.Size = new System.Drawing.Size(266, 26);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(61, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 2);
            this.panel2.TabIndex = 3;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhone.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPhone.ForeColor = System.Drawing.Color.White;
            this.TxtPhone.Location = new System.Drawing.Point(62, 69);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PlaceholderText = "Telefone";
            this.TxtPhone.Size = new System.Drawing.Size(266, 26);
            this.TxtPhone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esqueceu a sua senha?";
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogar.Font = new System.Drawing.Font("Candara Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogar.ForeColor = System.Drawing.Color.White;
            this.BtnLogar.Location = new System.Drawing.Point(62, 193);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(266, 48);
            this.BtnLogar.TabIndex = 0;
            this.BtnLogar.Text = "Entrar";
            this.BtnLogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(206, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 82);
            this.label3.TabIndex = 6;
            this.label3.Text = "OkUsSaKuLa";
            // 
            // FormLogin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(811, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}