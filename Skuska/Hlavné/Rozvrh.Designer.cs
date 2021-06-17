namespace Skuska
{
    partial class Rozvrh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rozvrh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txPriezvisko = new System.Windows.Forms.TextBox();
            this.txMeno = new System.Windows.Forms.TextBox();
            this.chbPrebehlo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbZakaznik = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txDlzkaCvicenia = new System.Windows.Forms.TextBox();
            this.dtpDatumCvicenia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txPoznamka = new System.Windows.Forms.TextBox();
            this.dgCvicenie = new System.Windows.Forms.DataGridView();
            this.meno_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezvisko_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_cvicenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlzka_cvicenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prebehlo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btUlozit = new System.Windows.Forms.Button();
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btZrusit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txPokrok = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCvicenie)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txPriezvisko);
            this.groupBox1.Controls.Add(this.txMeno);
            this.groupBox1.Controls.Add(this.chbPrebehlo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbZakaznik);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txDlzkaCvicenia);
            this.groupBox1.Controls.Add(this.dtpDatumCvicenia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(535, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 190);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Základné informácie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Priezvisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Meno:";
            // 
            // txPriezvisko
            // 
            this.txPriezvisko.Location = new System.Drawing.Point(65, 66);
            this.txPriezvisko.Name = "txPriezvisko";
            this.txPriezvisko.Size = new System.Drawing.Size(146, 20);
            this.txPriezvisko.TabIndex = 37;
            // 
            // txMeno
            // 
            this.txMeno.Location = new System.Drawing.Point(65, 40);
            this.txMeno.Name = "txMeno";
            this.txMeno.Size = new System.Drawing.Size(146, 20);
            this.txMeno.TabIndex = 36;
            // 
            // chbPrebehlo
            // 
            this.chbPrebehlo.AutoSize = true;
            this.chbPrebehlo.Location = new System.Drawing.Point(65, 144);
            this.chbPrebehlo.Name = "chbPrebehlo";
            this.chbPrebehlo.Size = new System.Drawing.Size(15, 14);
            this.chbPrebehlo.TabIndex = 35;
            this.chbPrebehlo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Prebehlo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "min.";
            // 
            // cbZakaznik
            // 
            this.cbZakaznik.FormattingEnabled = true;
            this.cbZakaznik.Location = new System.Drawing.Point(65, 13);
            this.cbZakaznik.Name = "cbZakaznik";
            this.cbZakaznik.Size = new System.Drawing.Size(146, 21);
            this.cbZakaznik.TabIndex = 32;
            this.cbZakaznik.SelectedValueChanged += new System.EventHandler(this.cbZakaznik_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dĺžka:";
            // 
            // txDlzkaCvicenia
            // 
            this.txDlzkaCvicenia.Location = new System.Drawing.Point(65, 118);
            this.txDlzkaCvicenia.Name = "txDlzkaCvicenia";
            this.txDlzkaCvicenia.Size = new System.Drawing.Size(58, 20);
            this.txDlzkaCvicenia.TabIndex = 24;
            // 
            // dtpDatumCvicenia
            // 
            this.dtpDatumCvicenia.CustomFormat = "dd. MM. yyyy hh:mm";
            this.dtpDatumCvicenia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumCvicenia.Location = new System.Drawing.Point(65, 92);
            this.dtpDatumCvicenia.Name = "dtpDatumCvicenia";
            this.dtpDatumCvicenia.Size = new System.Drawing.Size(146, 20);
            this.dtpDatumCvicenia.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dátum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zákazník:";
            // 
            // txPoznamka
            // 
            this.txPoznamka.Location = new System.Drawing.Point(6, 19);
            this.txPoznamka.Multiline = true;
            this.txPoznamka.Name = "txPoznamka";
            this.txPoznamka.Size = new System.Drawing.Size(348, 127);
            this.txPoznamka.TabIndex = 28;
            // 
            // dgCvicenie
            // 
            this.dgCvicenie.AllowUserToAddRows = false;
            this.dgCvicenie.AllowUserToDeleteRows = false;
            this.dgCvicenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCvicenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meno_dietata,
            this.priezvisko_dietata,
            this.datum_cvicenia,
            this.dlzka_cvicenia,
            this.prebehlo});
            this.dgCvicenie.Location = new System.Drawing.Point(12, 74);
            this.dgCvicenie.Name = "dgCvicenie";
            this.dgCvicenie.Size = new System.Drawing.Size(517, 487);
            this.dgCvicenie.TabIndex = 45;
            this.dgCvicenie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCvicenie_CellClick);
            // 
            // meno_dietata
            // 
            this.meno_dietata.DataPropertyName = "meno_dietata";
            this.meno_dietata.HeaderText = "Meno";
            this.meno_dietata.Name = "meno_dietata";
            this.meno_dietata.ReadOnly = true;
            // 
            // priezvisko_dietata
            // 
            this.priezvisko_dietata.DataPropertyName = "priezvisko_dietata";
            this.priezvisko_dietata.HeaderText = "Priezvisko";
            this.priezvisko_dietata.Name = "priezvisko_dietata";
            this.priezvisko_dietata.ReadOnly = true;
            // 
            // datum_cvicenia
            // 
            this.datum_cvicenia.DataPropertyName = "datum_cvicenia";
            this.datum_cvicenia.HeaderText = "Datum";
            this.datum_cvicenia.Name = "datum_cvicenia";
            this.datum_cvicenia.ReadOnly = true;
            // 
            // dlzka_cvicenia
            // 
            this.dlzka_cvicenia.DataPropertyName = "dlzka_cvicenia";
            this.dlzka_cvicenia.HeaderText = "Dĺžka";
            this.dlzka_cvicenia.Name = "dlzka_cvicenia";
            this.dlzka_cvicenia.ReadOnly = true;
            // 
            // prebehlo
            // 
            this.prebehlo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prebehlo.DataPropertyName = "prebehlo";
            this.prebehlo.HeaderText = "Prebehlo";
            this.prebehlo.Name = "prebehlo";
            this.prebehlo.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 35);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(616, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 49;
            this.btUlozit.Text = " Uložiť";
            this.btUlozit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUlozit.UseVisualStyleBackColor = false;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
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
            this.btPridat.TabIndex = 46;
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
            this.btZmazat.TabIndex = 48;
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
            this.btEditovat.TabIndex = 47;
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
            this.btZrusit.Location = new System.Drawing.Point(535, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 50;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txPoznamka);
            this.groupBox2.Location = new System.Drawing.Point(535, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 152);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poznámka";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txPokrok);
            this.groupBox3.Location = new System.Drawing.Point(535, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 139);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pokrok";
            // 
            // txPokrok
            // 
            this.txPokrok.Location = new System.Drawing.Point(6, 19);
            this.txPokrok.Multiline = true;
            this.txPokrok.Name = "txPokrok";
            this.txPokrok.Size = new System.Drawing.Size(348, 114);
            this.txPokrok.TabIndex = 0;
            // 
            // Rozvrh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 576);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgCvicenie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rozvrh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozvrh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rozvrh_FormClosing);
            this.Load += new System.EventHandler(this.Rozvrh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCvicenie)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPoznamka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txDlzkaCvicenia;
        private System.Windows.Forms.DateTimePicker dtpDatumCvicenia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCvicenie;
        private System.Windows.Forms.ComboBox cbZakaznik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btUlozit;
        public System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.CheckBox chbPrebehlo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txPokrok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPriezvisko;
        private System.Windows.Forms.TextBox txMeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezvisko_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_cvicenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlzka_cvicenia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prebehlo;
    }
}