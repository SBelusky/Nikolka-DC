namespace Skuska
{
    partial class Zakaznici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakaznici));
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPermanentka = new System.Windows.Forms.TextBox();
            this.txZdravotnyStav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMesto = new System.Windows.Forms.TextBox();
            this.txUlica = new System.Windows.Forms.TextBox();
            this.txPriezviskoDietata = new System.Windows.Forms.TextBox();
            this.txMenoDietata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btZrusit = new System.Windows.Forms.Button();
            this.dgZakaznici = new System.Windows.Forms.DataGridView();
            this.btUlozit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txTelefon = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txPriezviskoRodica = new System.Windows.Forms.TextBox();
            this.txMenoRodica = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.meno_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezvisko_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucastna_permanentka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZakaznici)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.btPridat.TabIndex = 31;
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
            this.btZmazat.TabIndex = 33;
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
            this.btEditovat.TabIndex = 32;
            this.btEditovat.Text = " Editovať";
            this.btEditovat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditovat.UseVisualStyleBackColor = false;
            this.btEditovat.Click += new System.EventHandler(this.btEditovat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txPermanentka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txMesto);
            this.groupBox1.Controls.Add(this.txUlica);
            this.groupBox1.Controls.Add(this.txPriezviskoDietata);
            this.groupBox1.Controls.Add(this.txMenoDietata);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(565, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 159);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zákazník";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Permanentka:";
            // 
            // txPermanentka
            // 
            this.txPermanentka.Enabled = false;
            this.txPermanentka.Location = new System.Drawing.Point(94, 124);
            this.txPermanentka.Name = "txPermanentka";
            this.txPermanentka.Size = new System.Drawing.Size(128, 20);
            this.txPermanentka.TabIndex = 23;
            // 
            // txZdravotnyStav
            // 
            this.txZdravotnyStav.Location = new System.Drawing.Point(6, 19);
            this.txZdravotnyStav.Multiline = true;
            this.txZdravotnyStav.Name = "txZdravotnyStav";
            this.txZdravotnyStav.Size = new System.Drawing.Size(440, 140);
            this.txZdravotnyStav.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulica:";
            // 
            // txMesto
            // 
            this.txMesto.BackColor = System.Drawing.SystemColors.Window;
            this.txMesto.Location = new System.Drawing.Point(94, 98);
            this.txMesto.Name = "txMesto";
            this.txMesto.Size = new System.Drawing.Size(128, 20);
            this.txMesto.TabIndex = 18;
            // 
            // txUlica
            // 
            this.txUlica.Location = new System.Drawing.Point(94, 72);
            this.txUlica.Name = "txUlica";
            this.txUlica.Size = new System.Drawing.Size(128, 20);
            this.txUlica.TabIndex = 17;
            // 
            // txPriezviskoDietata
            // 
            this.txPriezviskoDietata.Location = new System.Drawing.Point(94, 46);
            this.txPriezviskoDietata.Name = "txPriezviskoDietata";
            this.txPriezviskoDietata.Size = new System.Drawing.Size(128, 20);
            this.txPriezviskoDietata.TabIndex = 16;
            // 
            // txMenoDietata
            // 
            this.txMenoDietata.Location = new System.Drawing.Point(94, 19);
            this.txMenoDietata.Name = "txMenoDietata";
            this.txMenoDietata.Size = new System.Drawing.Size(128, 20);
            this.txMenoDietata.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Priezvisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
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
            this.btZrusit.Location = new System.Drawing.Point(565, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 36;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // dgZakaznici
            // 
            this.dgZakaznici.AllowUserToAddRows = false;
            this.dgZakaznici.AllowUserToDeleteRows = false;
            this.dgZakaznici.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgZakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZakaznici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meno_dietata,
            this.priezvisko_dietata,
            this.email,
            this.telefon,
            this.sucastna_permanentka});
            this.dgZakaznici.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgZakaznici.Location = new System.Drawing.Point(18, 74);
            this.dgZakaznici.MultiSelect = false;
            this.dgZakaznici.Name = "dgZakaznici";
            this.dgZakaznici.Size = new System.Drawing.Size(541, 339);
            this.dgZakaznici.TabIndex = 29;
            this.dgZakaznici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZakaznici_CellClick);
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.Color.White;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(646, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 35;
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
            this.menuStrip1.Size = new System.Drawing.Size(1052, 35);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txTelefon);
            this.groupBox2.Controls.Add(this.txEmail);
            this.groupBox2.Controls.Add(this.txPriezviskoRodica);
            this.groupBox2.Controls.Add(this.txMenoRodica);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(814, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 159);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rodič";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telefón:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            // 
            // txTelefon
            // 
            this.txTelefon.Location = new System.Drawing.Point(69, 95);
            this.txTelefon.Name = "txTelefon";
            this.txTelefon.Size = new System.Drawing.Size(128, 20);
            this.txTelefon.TabIndex = 18;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(69, 69);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(128, 20);
            this.txEmail.TabIndex = 17;
            // 
            // txPriezviskoRodica
            // 
            this.txPriezviskoRodica.Location = new System.Drawing.Point(69, 43);
            this.txPriezviskoRodica.Name = "txPriezviskoRodica";
            this.txPriezviskoRodica.Size = new System.Drawing.Size(128, 20);
            this.txPriezviskoRodica.TabIndex = 16;
            // 
            // txMenoRodica
            // 
            this.txMenoRodica.Location = new System.Drawing.Point(69, 16);
            this.txMenoRodica.Name = "txMenoRodica";
            this.txMenoRodica.Size = new System.Drawing.Size(128, 20);
            this.txMenoRodica.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Priezvisko:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Meno:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txZdravotnyStav);
            this.groupBox3.Location = new System.Drawing.Point(565, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 174);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zdravotný stav";
            // 
            // meno_dietata
            // 
            this.meno_dietata.DataPropertyName = "meno_dietata";
            this.meno_dietata.HeaderText = "Meno";
            this.meno_dietata.MaxInputLength = 100;
            this.meno_dietata.Name = "meno_dietata";
            this.meno_dietata.ReadOnly = true;
            this.meno_dietata.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // priezvisko_dietata
            // 
            this.priezvisko_dietata.DataPropertyName = "priezvisko_dietata";
            this.priezvisko_dietata.HeaderText = "Priezvisko";
            this.priezvisko_dietata.Name = "priezvisko_dietata";
            this.priezvisko_dietata.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // sucastna_permanentka
            // 
            this.sucastna_permanentka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sucastna_permanentka.DataPropertyName = "sucastna_permanentka";
            this.sucastna_permanentka.HeaderText = "Permanentka";
            this.sucastna_permanentka.MaxInputLength = 25;
            this.sucastna_permanentka.Name = "sucastna_permanentka";
            this.sucastna_permanentka.ReadOnly = true;
            // 
            // Zakaznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 427);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgZakaznici);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zakaznici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakaznici";
            this.Load += new System.EventHandler(this.Zakaznici_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZakaznici)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox txPriezviskoDietata;
        private System.Windows.Forms.TextBox txMenoDietata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.DataGridView dgZakaznici;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txZdravotnyStav;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txTelefon;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txPriezviskoRodica;
        private System.Windows.Forms.TextBox txMenoRodica;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPermanentka;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezvisko_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucastna_permanentka;
    }
}