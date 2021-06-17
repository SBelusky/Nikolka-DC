namespace Skuska
{
    partial class Faktury
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faktury));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCvicenie = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbZakaznik = new System.Windows.Forms.ComboBox();
            this.cbTyp = new System.Windows.Forms.ComboBox();
            this.cbSablona = new System.Windows.Forms.ComboBox();
            this.cbSposobUhrady = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txSuma = new System.Windows.Forms.TextBox();
            this.chbCvicenie = new System.Windows.Forms.CheckBox();
            this.dtpDatumVystavenia = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txPriezvisko = new System.Windows.Forms.TextBox();
            this.txMeno = new System.Windows.Forms.TextBox();
            this.txCisloFaktury = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgFaktury = new System.Windows.Forms.DataGridView();
            this.cislo_faktury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_vystavenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btZrusit = new System.Windows.Forms.Button();
            this.btUlozit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktury)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCvicenie);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbZakaznik);
            this.groupBox1.Controls.Add(this.cbTyp);
            this.groupBox1.Controls.Add(this.cbSablona);
            this.groupBox1.Controls.Add(this.cbSposobUhrady);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txSuma);
            this.groupBox1.Controls.Add(this.chbCvicenie);
            this.groupBox1.Controls.Add(this.dtpDatumVystavenia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txPriezvisko);
            this.groupBox1.Controls.Add(this.txMeno);
            this.groupBox1.Controls.Add(this.txCisloFaktury);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(599, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 288);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obsah faktúry";
            // 
            // cbCvicenie
            // 
            this.cbCvicenie.FormattingEnabled = true;
            this.cbCvicenie.Location = new System.Drawing.Point(129, 149);
            this.cbCvicenie.Name = "cbCvicenie";
            this.cbCvicenie.Size = new System.Drawing.Size(214, 21);
            this.cbCvicenie.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Zákazník:";
            // 
            // cbZakaznik
            // 
            this.cbZakaznik.FormattingEnabled = true;
            this.cbZakaznik.Location = new System.Drawing.Point(108, 65);
            this.cbZakaznik.Name = "cbZakaznik";
            this.cbZakaznik.Size = new System.Drawing.Size(128, 21);
            this.cbZakaznik.TabIndex = 37;
            this.cbZakaznik.SelectedValueChanged += new System.EventHandler(this.cbZakaznik_SelectedValueChanged);
            // 
            // cbTyp
            // 
            this.cbTyp.FormattingEnabled = true;
            this.cbTyp.Location = new System.Drawing.Point(108, 38);
            this.cbTyp.Name = "cbTyp";
            this.cbTyp.Size = new System.Drawing.Size(128, 21);
            this.cbTyp.TabIndex = 36;
            // 
            // cbSablona
            // 
            this.cbSablona.FormattingEnabled = true;
            this.cbSablona.Location = new System.Drawing.Point(108, 257);
            this.cbSablona.Name = "cbSablona";
            this.cbSablona.Size = new System.Drawing.Size(128, 21);
            this.cbSablona.TabIndex = 35;
            // 
            // cbSposobUhrady
            // 
            this.cbSposobUhrady.FormattingEnabled = true;
            this.cbSposobUhrady.Location = new System.Drawing.Point(108, 230);
            this.cbSposobUhrady.Name = "cbSposobUhrady";
            this.cbSposobUhrady.Size = new System.Drawing.Size(128, 21);
            this.cbSposobUhrady.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Šablóna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Spôsob:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Suma:";
            // 
            // txSuma
            // 
            this.txSuma.Location = new System.Drawing.Point(108, 204);
            this.txSuma.Name = "txSuma";
            this.txSuma.Size = new System.Drawing.Size(128, 20);
            this.txSuma.TabIndex = 28;
            // 
            // chbCvicenie
            // 
            this.chbCvicenie.AutoSize = true;
            this.chbCvicenie.Location = new System.Drawing.Point(108, 157);
            this.chbCvicenie.Name = "chbCvicenie";
            this.chbCvicenie.Size = new System.Drawing.Size(15, 14);
            this.chbCvicenie.TabIndex = 27;
            this.chbCvicenie.UseVisualStyleBackColor = true;
            this.chbCvicenie.CheckStateChanged += new System.EventHandler(this.chbCvicenie_CheckStateChanged);
            // 
            // dtpDatumVystavenia
            // 
            this.dtpDatumVystavenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumVystavenia.Location = new System.Drawing.Point(108, 178);
            this.dtpDatumVystavenia.Name = "dtpDatumVystavenia";
            this.dtpDatumVystavenia.Size = new System.Drawing.Size(128, 20);
            this.dtpDatumVystavenia.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Priezvisko:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Meno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dátum vystavenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cvičenie:";
            // 
            // txPriezvisko
            // 
            this.txPriezvisko.Location = new System.Drawing.Point(129, 118);
            this.txPriezvisko.Name = "txPriezvisko";
            this.txPriezvisko.Size = new System.Drawing.Size(128, 20);
            this.txPriezvisko.TabIndex = 18;
            // 
            // txMeno
            // 
            this.txMeno.Location = new System.Drawing.Point(129, 92);
            this.txMeno.Name = "txMeno";
            this.txMeno.Size = new System.Drawing.Size(128, 20);
            this.txMeno.TabIndex = 17;
            // 
            // txCisloFaktury
            // 
            this.txCisloFaktury.Location = new System.Drawing.Point(108, 13);
            this.txCisloFaktury.Name = "txCisloFaktury";
            this.txCisloFaktury.Size = new System.Drawing.Size(128, 20);
            this.txCisloFaktury.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Typ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Č. faktúry:";
            // 
            // dgFaktury
            // 
            this.dgFaktury.AllowUserToAddRows = false;
            this.dgFaktury.AllowUserToDeleteRows = false;
            this.dgFaktury.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaktury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cislo_faktury,
            this.typ,
            this.meno,
            this.priezvisko,
            this.datum_vystavenia});
            this.dgFaktury.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgFaktury.Location = new System.Drawing.Point(12, 73);
            this.dgFaktury.MultiSelect = false;
            this.dgFaktury.Name = "dgFaktury";
            this.dgFaktury.Size = new System.Drawing.Size(580, 288);
            this.dgFaktury.TabIndex = 39;
            this.dgFaktury.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFaktury_CellClick);
            // 
            // cislo_faktury
            // 
            this.cislo_faktury.DataPropertyName = "cislo_faktury";
            this.cislo_faktury.HeaderText = "Č. faktúry";
            this.cislo_faktury.MaxInputLength = 100;
            this.cislo_faktury.Name = "cislo_faktury";
            this.cislo_faktury.ReadOnly = true;
            this.cislo_faktury.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typ
            // 
            this.typ.DataPropertyName = "typ";
            this.typ.HeaderText = "Typ";
            this.typ.Name = "typ";
            this.typ.ReadOnly = true;
            // 
            // meno
            // 
            this.meno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.meno.DataPropertyName = "meno";
            this.meno.HeaderText = "Meno";
            this.meno.Name = "meno";
            // 
            // priezvisko
            // 
            this.priezvisko.DataPropertyName = "priezvisko";
            this.priezvisko.HeaderText = "Priezvisko";
            this.priezvisko.Name = "priezvisko";
            // 
            // datum_vystavenia
            // 
            this.datum_vystavenia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datum_vystavenia.DataPropertyName = "datum_vystavenia";
            this.datum_vystavenia.HeaderText = "Dátum vystavenia";
            this.datum_vystavenia.Name = "datum_vystavenia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 35);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
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
            this.btPridat.TabIndex = 41;
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
            this.btZmazat.TabIndex = 43;
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
            this.btEditovat.TabIndex = 42;
            this.btEditovat.Text = " Editovať";
            this.btEditovat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditovat.UseVisualStyleBackColor = false;
            this.btEditovat.Click += new System.EventHandler(this.btEditovat_Click);
            // 
            // btZrusit
            // 
            this.btZrusit.BackColor = System.Drawing.Color.White;
            this.btZrusit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btZrusit.Image")));
            this.btZrusit.Location = new System.Drawing.Point(599, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 46;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.Color.White;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(680, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 45;
            this.btUlozit.Text = " Uložiť";
            this.btUlozit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUlozit.UseVisualStyleBackColor = false;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
            // 
            // Faktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 374);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgFaktury);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Faktury";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faktury";
            this.Load += new System.EventHandler(this.Faktury_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktury)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPriezvisko;
        private System.Windows.Forms.TextBox txMeno;
        private System.Windows.Forms.TextBox txCisloFaktury;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.DataGridView dgFaktury;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chbCvicenie;
        private System.Windows.Forms.DateTimePicker dtpDatumVystavenia;
        private System.Windows.Forms.ComboBox cbSablona;
        private System.Windows.Forms.ComboBox cbSposobUhrady;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSuma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbZakaznik;
        private System.Windows.Forms.ComboBox cbTyp;
        private System.Windows.Forms.ComboBox cbCvicenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cislo_faktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_vystavenia;
    }
}