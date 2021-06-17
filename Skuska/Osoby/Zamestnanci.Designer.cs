namespace Skuska
{
    partial class Zamestnanci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamestnanci));
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMesto = new System.Windows.Forms.TextBox();
            this.txUlica = new System.Windows.Forms.TextBox();
            this.txPriezvisko = new System.Windows.Forms.TextBox();
            this.txMeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txTelefon = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btZrusit = new System.Windows.Forms.Button();
            this.dgZamestnanci = new System.Windows.Forms.DataGridView();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUlozit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZamestnanci)).BeginInit();
            this.SuspendLayout();
            // 
            // btPridat
            // 
            this.btPridat.BackColor = System.Drawing.Color.White;
            this.btPridat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPridat.Image = ((System.Drawing.Image)(resources.GetObject("btPridat.Image")));
            this.btPridat.Location = new System.Drawing.Point(12, 5);
            this.btPridat.Margin = new System.Windows.Forms.Padding(0);
            this.btPridat.Name = "btPridat";
            this.btPridat.Size = new System.Drawing.Size(75, 25);
            this.btPridat.TabIndex = 23;
            this.btPridat.Text = " Pridať";
            this.btPridat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPridat.UseVisualStyleBackColor = false;
            this.btPridat.Click += new System.EventHandler(this.btPridat_Click);
            // 
            // btZmazat
            // 
            this.btZmazat.BackColor = System.Drawing.Color.White;
            this.btZmazat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZmazat.Image = ((System.Drawing.Image)(resources.GetObject("btZmazat.Image")));
            this.btZmazat.Location = new System.Drawing.Point(212, 5);
            this.btZmazat.Name = "btZmazat";
            this.btZmazat.Size = new System.Drawing.Size(75, 25);
            this.btZmazat.TabIndex = 25;
            this.btZmazat.Text = " Zmazať";
            this.btZmazat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZmazat.UseVisualStyleBackColor = false;
            this.btZmazat.Click += new System.EventHandler(this.btZmazat_Click);
            // 
            // btEditovat
            // 
            this.btEditovat.BackColor = System.Drawing.Color.White;
            this.btEditovat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditovat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEditovat.Image = ((System.Drawing.Image)(resources.GetObject("btEditovat.Image")));
            this.btEditovat.Location = new System.Drawing.Point(93, 5);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(75, 25);
            this.btEditovat.TabIndex = 24;
            this.btEditovat.Text = " Editovať";
            this.btEditovat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditovat.UseVisualStyleBackColor = false;
            this.btEditovat.Click += new System.EventHandler(this.btEditovat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txMesto);
            this.groupBox1.Controls.Add(this.txUlica);
            this.groupBox1.Controls.Add(this.txPriezvisko);
            this.groupBox1.Controls.Add(this.txMeno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txTelefon);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(581, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 248);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zamestnanec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulica:";
            // 
            // txMesto
            // 
            this.txMesto.Location = new System.Drawing.Point(70, 171);
            this.txMesto.Name = "txMesto";
            this.txMesto.Size = new System.Drawing.Size(128, 20);
            this.txMesto.TabIndex = 18;
            // 
            // txUlica
            // 
            this.txUlica.Location = new System.Drawing.Point(70, 145);
            this.txUlica.Name = "txUlica";
            this.txUlica.Size = new System.Drawing.Size(128, 20);
            this.txUlica.TabIndex = 17;
            // 
            // txPriezvisko
            // 
            this.txPriezvisko.Location = new System.Drawing.Point(70, 46);
            this.txPriezvisko.Name = "txPriezvisko";
            this.txPriezvisko.Size = new System.Drawing.Size(128, 20);
            this.txPriezvisko.TabIndex = 16;
            // 
            // txMeno
            // 
            this.txMeno.Location = new System.Drawing.Point(70, 19);
            this.txMeno.Name = "txMeno";
            this.txMeno.Size = new System.Drawing.Size(128, 20);
            this.txMeno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefón:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Priezvisko:";
            // 
            // txTelefon
            // 
            this.txTelefon.Location = new System.Drawing.Point(70, 118);
            this.txTelefon.Name = "txTelefon";
            this.txTelefon.Size = new System.Drawing.Size(128, 20);
            this.txTelefon.TabIndex = 6;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(70, 91);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(128, 20);
            this.txEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meno:";
            // 
            // btZrusit
            // 
            this.btZrusit.BackColor = System.Drawing.Color.White;
            this.btZrusit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btZrusit.Image")));
            this.btZrusit.Location = new System.Drawing.Point(581, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 28;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // dgZamestnanci
            // 
            this.dgZamestnanci.AllowUserToAddRows = false;
            this.dgZamestnanci.AllowUserToDeleteRows = false;
            this.dgZamestnanci.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgZamestnanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZamestnanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meno,
            this.Priezvisko,
            this.Email,
            this.Telefon,
            this.Ulica,
            this.Mesto});
            this.dgZamestnanci.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgZamestnanci.Location = new System.Drawing.Point(12, 74);
            this.dgZamestnanci.MultiSelect = false;
            this.dgZamestnanci.Name = "dgZamestnanci";
            this.dgZamestnanci.Size = new System.Drawing.Size(541, 248);
            this.dgZamestnanci.TabIndex = 21;
            this.dgZamestnanci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZamestnanci_CellClick);
            // 
            // Meno
            // 
            this.Meno.DataPropertyName = "Meno";
            this.Meno.HeaderText = "Meno";
            this.Meno.MaxInputLength = 100;
            this.Meno.Name = "Meno";
            this.Meno.ReadOnly = true;
            this.Meno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Priezvisko
            // 
            this.Priezvisko.DataPropertyName = "Priezvisko";
            this.Priezvisko.HeaderText = "Priezvisko";
            this.Priezvisko.Name = "Priezvisko";
            this.Priezvisko.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Ulica
            // 
            this.Ulica.DataPropertyName = "Ulica";
            this.Ulica.HeaderText = "Ulica";
            this.Ulica.MaxInputLength = 25;
            this.Ulica.Name = "Ulica";
            this.Ulica.ReadOnly = true;
            // 
            // Mesto
            // 
            this.Mesto.DataPropertyName = "Mesto";
            this.Mesto.HeaderText = "Mesto";
            this.Mesto.MaxInputLength = 25;
            this.Mesto.Name = "Mesto";
            this.Mesto.ReadOnly = true;
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.Color.White;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(662, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 27;
            this.btUlozit.Text = " Uložiť";
            this.btUlozit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUlozit.UseVisualStyleBackColor = false;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 35);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Zamestnanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 346);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgZamestnanci);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zamestnanci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamestnanci";
            this.Load += new System.EventHandler(this.Zamestnanci_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZamestnanci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMesto;
        private System.Windows.Forms.TextBox txUlica;
        private System.Windows.Forms.TextBox txPriezvisko;
        private System.Windows.Forms.TextBox txMeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txTelefon;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.DataGridView dgZamestnanci;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesto;
    }
}