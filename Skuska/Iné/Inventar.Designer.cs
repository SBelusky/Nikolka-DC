namespace Skuska
{
    partial class Inventar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventar));
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.polozka = new System.Windows.Forms.GroupBox();
            this.chbServis = new System.Windows.Forms.CheckBox();
            this.chbDatumKupy = new System.Windows.Forms.CheckBox();
            this.chbKPrevadzke = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpServis = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumKupy = new System.Windows.Forms.DateTimePicker();
            this.cbTyp = new System.Windows.Forms.ComboBox();
            this.txNazov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txPoznamka = new System.Windows.Forms.TextBox();
            this.btZrusit = new System.Windows.Forms.Button();
            this.dgInventar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_kupy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_prevadzke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btUlozit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.polozka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventar)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btPridat.TabIndex = 15;
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
            this.btZmazat.TabIndex = 17;
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
            this.btEditovat.TabIndex = 16;
            this.btEditovat.Text = " Editovať";
            this.btEditovat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditovat.UseVisualStyleBackColor = false;
            this.btEditovat.Click += new System.EventHandler(this.btEditovat_Click);
            // 
            // polozka
            // 
            this.polozka.Controls.Add(this.chbServis);
            this.polozka.Controls.Add(this.chbDatumKupy);
            this.polozka.Controls.Add(this.chbKPrevadzke);
            this.polozka.Controls.Add(this.label2);
            this.polozka.Controls.Add(this.dtpServis);
            this.polozka.Controls.Add(this.dtpDatumKupy);
            this.polozka.Controls.Add(this.cbTyp);
            this.polozka.Controls.Add(this.txNazov);
            this.polozka.Controls.Add(this.label5);
            this.polozka.Controls.Add(this.label3);
            this.polozka.Controls.Add(this.label6);
            this.polozka.Controls.Add(this.label1);
            this.polozka.Location = new System.Drawing.Point(591, 74);
            this.polozka.Name = "polozka";
            this.polozka.Size = new System.Drawing.Size(292, 153);
            this.polozka.TabIndex = 14;
            this.polozka.TabStop = false;
            this.polozka.Text = "Základné informácie";
            // 
            // chbServis
            // 
            this.chbServis.AutoSize = true;
            this.chbServis.Location = new System.Drawing.Point(81, 108);
            this.chbServis.Name = "chbServis";
            this.chbServis.Size = new System.Drawing.Size(15, 14);
            this.chbServis.TabIndex = 30;
            this.chbServis.UseVisualStyleBackColor = true;
            this.chbServis.CheckStateChanged += new System.EventHandler(this.chbServis_CheckStateChanged);
            // 
            // chbDatumKupy
            // 
            this.chbDatumKupy.AutoSize = true;
            this.chbDatumKupy.Location = new System.Drawing.Point(81, 83);
            this.chbDatumKupy.Name = "chbDatumKupy";
            this.chbDatumKupy.Size = new System.Drawing.Size(15, 14);
            this.chbDatumKupy.TabIndex = 29;
            this.chbDatumKupy.UseVisualStyleBackColor = true;
            this.chbDatumKupy.CheckStateChanged += new System.EventHandler(this.chbDatumKupy_CheckStateChanged);
            // 
            // chbKPrevadzke
            // 
            this.chbKPrevadzke.AutoSize = true;
            this.chbKPrevadzke.Location = new System.Drawing.Point(81, 131);
            this.chbKPrevadzke.Name = "chbKPrevadzke";
            this.chbKPrevadzke.Size = new System.Drawing.Size(15, 14);
            this.chbKPrevadzke.TabIndex = 28;
            this.chbKPrevadzke.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "K prevádzke:";
            // 
            // dtpServis
            // 
            this.dtpServis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpServis.Location = new System.Drawing.Point(102, 104);
            this.dtpServis.Name = "dtpServis";
            this.dtpServis.Size = new System.Drawing.Size(145, 20);
            this.dtpServis.TabIndex = 26;
            this.dtpServis.Value = new System.DateTime(2018, 10, 30, 0, 0, 0, 0);
            // 
            // dtpDatumKupy
            // 
            this.dtpDatumKupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.dtpDatumKupy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumKupy.Location = new System.Drawing.Point(102, 78);
            this.dtpDatumKupy.Name = "dtpDatumKupy";
            this.dtpDatumKupy.Size = new System.Drawing.Size(145, 20);
            this.dtpDatumKupy.TabIndex = 23;
            this.dtpDatumKupy.Value = new System.DateTime(2018, 10, 30, 0, 0, 0, 0);
            // 
            // cbTyp
            // 
            this.cbTyp.FormattingEnabled = true;
            this.cbTyp.Location = new System.Drawing.Point(81, 51);
            this.cbTyp.Name = "cbTyp";
            this.cbTyp.Size = new System.Drawing.Size(145, 21);
            this.cbTyp.TabIndex = 22;
            // 
            // txNazov
            // 
            this.txNazov.Location = new System.Drawing.Point(81, 24);
            this.txNazov.Name = "txNazov";
            this.txNazov.Size = new System.Drawing.Size(145, 20);
            this.txNazov.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Názov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Servis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dátum kúpy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typ:";
            // 
            // txPoznamka
            // 
            this.txPoznamka.Location = new System.Drawing.Point(9, 19);
            this.txPoznamka.Multiline = true;
            this.txPoznamka.Name = "txPoznamka";
            this.txPoznamka.Size = new System.Drawing.Size(275, 120);
            this.txPoznamka.TabIndex = 31;
            // 
            // btZrusit
            // 
            this.btZrusit.BackColor = System.Drawing.Color.White;
            this.btZrusit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btZrusit.Image")));
            this.btZrusit.Location = new System.Drawing.Point(591, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 20;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // dgInventar
            // 
            this.dgInventar.AllowUserToAddRows = false;
            this.dgInventar.AllowUserToDeleteRows = false;
            this.dgInventar.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgInventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nazov,
            this.Typ,
            this.Datum_kupy,
            this.Servis,
            this.K_prevadzke});
            this.dgInventar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgInventar.Location = new System.Drawing.Point(12, 74);
            this.dgInventar.MultiSelect = false;
            this.dgInventar.Name = "dgInventar";
            this.dgInventar.Size = new System.Drawing.Size(573, 309);
            this.dgInventar.TabIndex = 13;
            this.dgInventar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventar_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // Nazov
            // 
            this.Nazov.DataPropertyName = "Nazov";
            this.Nazov.HeaderText = "Názov";
            this.Nazov.MaxInputLength = 100;
            this.Nazov.Name = "Nazov";
            this.Nazov.ReadOnly = true;
            this.Nazov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Typ
            // 
            this.Typ.DataPropertyName = "Typ";
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            // 
            // Datum_kupy
            // 
            this.Datum_kupy.DataPropertyName = "Datum_kupy";
            this.Datum_kupy.HeaderText = "Dátum kúpy";
            this.Datum_kupy.MaxInputLength = 25;
            this.Datum_kupy.Name = "Datum_kupy";
            this.Datum_kupy.ReadOnly = true;
            // 
            // Servis
            // 
            this.Servis.DataPropertyName = "Servis";
            this.Servis.HeaderText = "Servis";
            this.Servis.MaxInputLength = 25;
            this.Servis.Name = "Servis";
            this.Servis.ReadOnly = true;
            this.Servis.Width = 92;
            // 
            // K_prevadzke
            // 
            this.K_prevadzke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.K_prevadzke.DataPropertyName = "K_prevadzke";
            this.K_prevadzke.HeaderText = "K prevádzke";
            this.K_prevadzke.Name = "K_prevadzke";
            this.K_prevadzke.ReadOnly = true;
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(672, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 19;
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
            this.menuStrip1.Size = new System.Drawing.Size(899, 35);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txPoznamka);
            this.groupBox1.Location = new System.Drawing.Point(592, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 149);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poznámka";
            // 
            // Inventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.polozka);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgInventar);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventár";
            this.Load += new System.EventHandler(this.Inventar_Load);
            this.polozka.ResumeLayout(false);
            this.polozka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.GroupBox polozka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.DataGridView dgInventar;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txNazov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpServis;
        private System.Windows.Forms.DateTimePicker dtpDatumKupy;
        private System.Windows.Forms.ComboBox cbTyp;
        private System.Windows.Forms.CheckBox chbKPrevadzke;
        private System.Windows.Forms.CheckBox chbServis;
        private System.Windows.Forms.CheckBox chbDatumKupy;
        private System.Windows.Forms.TextBox txPoznamka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_kupy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn K_prevadzke;
        public System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}