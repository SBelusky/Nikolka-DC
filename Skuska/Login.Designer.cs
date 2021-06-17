namespace Skuska
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txMeno = new System.Windows.Forms.TextBox();
            this.txHeslo = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbHeslo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txMeno
            // 
            this.txMeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.txMeno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMeno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txMeno.ForeColor = System.Drawing.Color.White;
            this.txMeno.Location = new System.Drawing.Point(111, 117);
            this.txMeno.Name = "txMeno";
            this.txMeno.Size = new System.Drawing.Size(185, 18);
            this.txMeno.TabIndex = 0;
            this.txMeno.Text = "sbelusky";
            this.txMeno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txMeno_KeyDown);
            // 
            // txHeslo
            // 
            this.txHeslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.txHeslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txHeslo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txHeslo.ForeColor = System.Drawing.Color.White;
            this.txHeslo.Location = new System.Drawing.Point(111, 157);
            this.txHeslo.Name = "txHeslo";
            this.txHeslo.PasswordChar = '•';
            this.txHeslo.Size = new System.Drawing.Size(185, 18);
            this.txHeslo.TabIndex = 1;
            this.txHeslo.Text = "sbelusky";
            this.txHeslo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txHeslo_KeyDown);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(49, 117);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(52, 18);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Meno:";
            // 
            // lbHeslo
            // 
            this.lbHeslo.AutoSize = true;
            this.lbHeslo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHeslo.ForeColor = System.Drawing.Color.White;
            this.lbHeslo.Location = new System.Drawing.Point(48, 157);
            this.lbHeslo.Name = "lbHeslo";
            this.lbHeslo.Size = new System.Drawing.Size(53, 18);
            this.lbHeslo.TabIndex = 3;
            this.lbHeslo.Text = "Heslo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 59);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.White;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btLogin.Location = new System.Drawing.Point(118, 215);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(114, 43);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = " Prihlásiť";
            this.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(111, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(111, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 1);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(351, 286);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbHeslo);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txHeslo);
            this.Controls.Add(this.txMeno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Prihlasovanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMeno;
        private System.Windows.Forms.TextBox txHeslo;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbHeslo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}