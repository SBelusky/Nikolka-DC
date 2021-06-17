namespace Skuska
{
    partial class Podujatia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podujatia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbCasZacatia = new System.Windows.Forms.CheckBox();
            this.chbDatumPodujatia = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txDobaTrvania = new System.Windows.Forms.TextBox();
            this.dtpCasZacatia = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatumPodujatia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMesto = new System.Windows.Forms.TextBox();
            this.txUlica = new System.Windows.Forms.TextBox();
            this.txNazov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txPoznamka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txPocetOsob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txVyzbieranePeniaze = new System.Windows.Forms.TextBox();
            this.txVyhradenePeniaze = new System.Windows.Forms.TextBox();
            this.dgPodujatia = new System.Windows.Forms.DataGridView();
            this.Nazov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_podujatia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cas_zacatia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btZrusit = new System.Windows.Forms.Button();
            this.btUlozit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodujatia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCasZacatia);
            this.groupBox1.Controls.Add(this.chbDatumPodujatia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txDobaTrvania);
            this.groupBox1.Controls.Add(this.dtpCasZacatia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDatumPodujatia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txMesto);
            this.groupBox1.Controls.Add(this.txUlica);
            this.groupBox1.Controls.Add(this.txNazov);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(361, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 184);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Základné informácie";
            // 
            // chbCasZacatia
            // 
            this.chbCasZacatia.AutoSize = true;
            this.chbCasZacatia.Location = new System.Drawing.Point(73, 75);
            this.chbCasZacatia.Name = "chbCasZacatia";
            this.chbCasZacatia.Size = new System.Drawing.Size(15, 14);
            this.chbCasZacatia.TabIndex = 31;
            this.chbCasZacatia.UseVisualStyleBackColor = true;
            this.chbCasZacatia.CheckStateChanged += new System.EventHandler(this.chbCasZacatia_CheckStateChanged);
            // 
            // chbDatumPodujatia
            // 
            this.chbDatumPodujatia.AutoSize = true;
            this.chbDatumPodujatia.Location = new System.Drawing.Point(73, 51);
            this.chbDatumPodujatia.Name = "chbDatumPodujatia";
            this.chbDatumPodujatia.Size = new System.Drawing.Size(15, 14);
            this.chbDatumPodujatia.TabIndex = 30;
            this.chbDatumPodujatia.UseVisualStyleBackColor = true;
            this.chbDatumPodujatia.CheckStateChanged += new System.EventHandler(this.chbDatumPodujatia_CheckStateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dĺžka:";
            // 
            // txDobaTrvania
            // 
            this.txDobaTrvania.Location = new System.Drawing.Point(73, 98);
            this.txDobaTrvania.Name = "txDobaTrvania";
            this.txDobaTrvania.Size = new System.Drawing.Size(128, 20);
            this.txDobaTrvania.TabIndex = 24;
            // 
            // dtpCasZacatia
            // 
            this.dtpCasZacatia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCasZacatia.Location = new System.Drawing.Point(94, 71);
            this.dtpCasZacatia.Name = "dtpCasZacatia";
            this.dtpCasZacatia.ShowUpDown = true;
            this.dtpCasZacatia.Size = new System.Drawing.Size(128, 20);
            this.dtpCasZacatia.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Čas:";
            // 
            // dtpDatumPodujatia
            // 
            this.dtpDatumPodujatia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPodujatia.Location = new System.Drawing.Point(94, 45);
            this.dtpDatumPodujatia.Name = "dtpDatumPodujatia";
            this.dtpDatumPodujatia.Size = new System.Drawing.Size(128, 20);
            this.dtpDatumPodujatia.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mesto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulica:";
            // 
            // txMesto
            // 
            this.txMesto.Location = new System.Drawing.Point(73, 149);
            this.txMesto.Name = "txMesto";
            this.txMesto.Size = new System.Drawing.Size(128, 20);
            this.txMesto.TabIndex = 18;
            // 
            // txUlica
            // 
            this.txUlica.Location = new System.Drawing.Point(73, 123);
            this.txUlica.Name = "txUlica";
            this.txUlica.Size = new System.Drawing.Size(128, 20);
            this.txUlica.TabIndex = 17;
            // 
            // txNazov
            // 
            this.txNazov.Location = new System.Drawing.Point(73, 19);
            this.txNazov.Name = "txNazov";
            this.txNazov.Size = new System.Drawing.Size(128, 20);
            this.txNazov.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dátum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Názov:";
            // 
            // txPoznamka
            // 
            this.txPoznamka.Location = new System.Drawing.Point(6, 19);
            this.txPoznamka.Multiline = true;
            this.txPoznamka.Name = "txPoznamka";
            this.txPoznamka.Size = new System.Drawing.Size(496, 90);
            this.txPoznamka.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Počet osôb:";
            // 
            // txPocetOsob
            // 
            this.txPocetOsob.Location = new System.Drawing.Point(78, 45);
            this.txPocetOsob.Name = "txPocetOsob";
            this.txPocetOsob.Size = new System.Drawing.Size(128, 20);
            this.txPocetOsob.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zbierka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Financie:";
            // 
            // txVyzbieranePeniaze
            // 
            this.txVyzbieranePeniaze.Location = new System.Drawing.Point(78, 71);
            this.txVyzbieranePeniaze.Name = "txVyzbieranePeniaze";
            this.txVyzbieranePeniaze.Size = new System.Drawing.Size(128, 20);
            this.txVyzbieranePeniaze.TabIndex = 6;
            // 
            // txVyhradenePeniaze
            // 
            this.txVyhradenePeniaze.Location = new System.Drawing.Point(78, 19);
            this.txVyhradenePeniaze.Name = "txVyhradenePeniaze";
            this.txVyhradenePeniaze.Size = new System.Drawing.Size(128, 20);
            this.txVyhradenePeniaze.TabIndex = 5;
            // 
            // dgPodujatia
            // 
            this.dgPodujatia.AllowUserToAddRows = false;
            this.dgPodujatia.AllowUserToDeleteRows = false;
            this.dgPodujatia.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPodujatia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodujatia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazov,
            this.Datum_podujatia,
            this.Cas_zacatia});
            this.dgPodujatia.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPodujatia.Location = new System.Drawing.Point(12, 74);
            this.dgPodujatia.MultiSelect = false;
            this.dgPodujatia.Name = "dgPodujatia";
            this.dgPodujatia.Size = new System.Drawing.Size(343, 319);
            this.dgPodujatia.TabIndex = 29;
            this.dgPodujatia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPodujatia_CellClick);
            // 
            // Nazov
            // 
            this.Nazov.DataPropertyName = "Nazov";
            this.Nazov.HeaderText = "Nazov";
            this.Nazov.MaxInputLength = 100;
            this.Nazov.Name = "Nazov";
            this.Nazov.ReadOnly = true;
            this.Nazov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Datum_podujatia
            // 
            this.Datum_podujatia.DataPropertyName = "Datum_podujatia";
            this.Datum_podujatia.HeaderText = "Dátum";
            this.Datum_podujatia.Name = "Datum_podujatia";
            this.Datum_podujatia.ReadOnly = true;
            // 
            // Cas_zacatia
            // 
            this.Cas_zacatia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cas_zacatia.DataPropertyName = "Cas_zacatia";
            this.Cas_zacatia.HeaderText = "Čas začiatku";
            this.Cas_zacatia.Name = "Cas_zacatia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 35);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txPocetOsob);
            this.groupBox2.Controls.Add(this.txVyhradenePeniaze);
            this.groupBox2.Controls.Add(this.txVyzbieranePeniaze);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(643, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 106);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podrobnosti";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txPoznamka);
            this.groupBox3.Location = new System.Drawing.Point(362, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 129);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poznámka";
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
            // btZrusit
            // 
            this.btZrusit.BackColor = System.Drawing.Color.White;
            this.btZrusit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btZrusit.Image")));
            this.btZrusit.Location = new System.Drawing.Point(361, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 36;
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
            this.btUlozit.Location = new System.Drawing.Point(442, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 35;
            this.btUlozit.Text = " Uložiť";
            this.btUlozit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUlozit.UseVisualStyleBackColor = false;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
            // 
            // Podujatia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgPodujatia);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Podujatia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podujatia";
            this.Load += new System.EventHandler(this.Podujatia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodujatia)).EndInit();
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
        private System.Windows.Forms.TextBox txNazov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txVyzbieranePeniaze;
        private System.Windows.Forms.TextBox txVyhradenePeniaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.DataGridView dgPodujatia;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txDobaTrvania;
        private System.Windows.Forms.DateTimePicker dtpCasZacatia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatumPodujatia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txPocetOsob;
        private System.Windows.Forms.TextBox txPoznamka;
        private System.Windows.Forms.CheckBox chbCasZacatia;
        private System.Windows.Forms.CheckBox chbDatumPodujatia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_podujatia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cas_zacatia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}