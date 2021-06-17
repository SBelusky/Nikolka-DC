namespace Skuska
{
    partial class HlavneMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HlavneMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miOsoby = new System.Windows.Forms.ToolStripMenuItem();
            this.miPouzivatelia = new System.Windows.Forms.ToolStripMenuItem();
            this.miZamestnanci = new System.Windows.Forms.ToolStripMenuItem();
            this.miZkaznici = new System.Windows.Forms.ToolStripMenuItem();
            this.miSponzori = new System.Windows.Forms.ToolStripMenuItem();
            this.miDokumentácia = new System.Windows.Forms.ToolStripMenuItem();
            this.miZmluvy = new System.Windows.Forms.ToolStripMenuItem();
            this.miFaktury = new System.Windows.Forms.ToolStripMenuItem();
            this.miSablony = new System.Windows.Forms.ToolStripMenuItem();
            this.miRozvrh = new System.Windows.Forms.ToolStripMenuItem();
            this.miIne = new System.Windows.Forms.ToolStripMenuItem();
            this.miPodujatia = new System.Windows.Forms.ToolStripMenuItem();
            this.miInventar = new System.Windows.Forms.ToolStripMenuItem();
            this.miPermanentky = new System.Windows.Forms.ToolStripMenuItem();
            this.miMesacnyVykaz = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgRozvrh = new System.Windows.Forms.DataGridView();
            this.meno_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priezvisko_dietata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_cvicenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlzka_cvicenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poznamka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prebehlo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbAktivnyUzivatel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRozvrh)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOsoby,
            this.miDokumentácia,
            this.miRozvrh,
            this.miIne});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1050, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miOsoby
            // 
            this.miOsoby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.miOsoby.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPouzivatelia,
            this.miZamestnanci,
            this.miZkaznici,
            this.miSponzori});
            this.miOsoby.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miOsoby.ForeColor = System.Drawing.Color.White;
            this.miOsoby.Image = ((System.Drawing.Image)(resources.GetObject("miOsoby.Image")));
            this.miOsoby.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miOsoby.Name = "miOsoby";
            this.miOsoby.Size = new System.Drawing.Size(83, 39);
            this.miOsoby.Text = "Osoby";
            this.miOsoby.Click += new System.EventHandler(this.miOsoby_Click);
            // 
            // miPouzivatelia
            // 
            this.miPouzivatelia.BackColor = System.Drawing.Color.White;
            this.miPouzivatelia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miPouzivatelia.ForeColor = System.Drawing.Color.Black;
            this.miPouzivatelia.Name = "miPouzivatelia";
            this.miPouzivatelia.Size = new System.Drawing.Size(185, 22);
            this.miPouzivatelia.Text = "Používatelia";
            this.miPouzivatelia.Click += new System.EventHandler(this.miPouzivatelia_Click);
            // 
            // miZamestnanci
            // 
            this.miZamestnanci.BackColor = System.Drawing.Color.White;
            this.miZamestnanci.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miZamestnanci.ForeColor = System.Drawing.Color.Black;
            this.miZamestnanci.Name = "miZamestnanci";
            this.miZamestnanci.Size = new System.Drawing.Size(185, 22);
            this.miZamestnanci.Text = "Zamestnanci";
            this.miZamestnanci.Click += new System.EventHandler(this.zamestnanciToolStripMenuItem_Click);
            // 
            // miZkaznici
            // 
            this.miZkaznici.BackColor = System.Drawing.Color.White;
            this.miZkaznici.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miZkaznici.ForeColor = System.Drawing.Color.Black;
            this.miZkaznici.Name = "miZkaznici";
            this.miZkaznici.Size = new System.Drawing.Size(185, 22);
            this.miZkaznici.Text = "Zákazníci";
            this.miZkaznici.Click += new System.EventHandler(this.miZkaznici_Click);
            // 
            // miSponzori
            // 
            this.miSponzori.BackColor = System.Drawing.Color.White;
            this.miSponzori.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miSponzori.ForeColor = System.Drawing.Color.Black;
            this.miSponzori.Name = "miSponzori";
            this.miSponzori.Size = new System.Drawing.Size(185, 22);
            this.miSponzori.Text = "Sponzori a partneri";
            this.miSponzori.Click += new System.EventHandler(this.miSponzori_Click);
            // 
            // miDokumentácia
            // 
            this.miDokumentácia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miZmluvy,
            this.miFaktury,
            this.miSablony});
            this.miDokumentácia.Font = new System.Drawing.Font("Arial", 11.25F);
            this.miDokumentácia.ForeColor = System.Drawing.Color.White;
            this.miDokumentácia.Image = ((System.Drawing.Image)(resources.GetObject("miDokumentácia.Image")));
            this.miDokumentácia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDokumentácia.Name = "miDokumentácia";
            this.miDokumentácia.Size = new System.Drawing.Size(134, 39);
            this.miDokumentácia.Text = "Dokumentácia";
            // 
            // miZmluvy
            // 
            this.miZmluvy.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miZmluvy.Name = "miZmluvy";
            this.miZmluvy.Size = new System.Drawing.Size(123, 22);
            this.miZmluvy.Text = "Zmluvy";
            // 
            // miFaktury
            // 
            this.miFaktury.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miFaktury.Name = "miFaktury";
            this.miFaktury.Size = new System.Drawing.Size(123, 22);
            this.miFaktury.Text = "Faktúry";
            this.miFaktury.Click += new System.EventHandler(this.faktúryToolStripMenuItem_Click);
            // 
            // miSablony
            // 
            this.miSablony.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miSablony.Name = "miSablony";
            this.miSablony.Size = new System.Drawing.Size(123, 22);
            this.miSablony.Text = "Šablóny";
            // 
            // miRozvrh
            // 
            this.miRozvrh.Font = new System.Drawing.Font("Arial", 11.25F);
            this.miRozvrh.ForeColor = System.Drawing.Color.White;
            this.miRozvrh.Image = ((System.Drawing.Image)(resources.GetObject("miRozvrh.Image")));
            this.miRozvrh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miRozvrh.Name = "miRozvrh";
            this.miRozvrh.Size = new System.Drawing.Size(87, 39);
            this.miRozvrh.Text = "Rozvrh";
            this.miRozvrh.Click += new System.EventHandler(this.miRozvrh_Click);
            // 
            // miIne
            // 
            this.miIne.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPodujatia,
            this.miInventar,
            this.miPermanentky,
            this.miMesacnyVykaz});
            this.miIne.Font = new System.Drawing.Font("Arial", 11.25F);
            this.miIne.ForeColor = System.Drawing.Color.White;
            this.miIne.Image = ((System.Drawing.Image)(resources.GetObject("miIne.Image")));
            this.miIne.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miIne.Name = "miIne";
            this.miIne.Size = new System.Drawing.Size(59, 39);
            this.miIne.Text = "Iné";
            // 
            // miPodujatia
            // 
            this.miPodujatia.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miPodujatia.Name = "miPodujatia";
            this.miPodujatia.Size = new System.Drawing.Size(166, 22);
            this.miPodujatia.Text = "Podujatia";
            this.miPodujatia.Click += new System.EventHandler(this.podujatiaToolStripMenuItem_Click);
            // 
            // miInventar
            // 
            this.miInventar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miInventar.Name = "miInventar";
            this.miInventar.Size = new System.Drawing.Size(166, 22);
            this.miInventar.Text = "Inventár";
            this.miInventar.Click += new System.EventHandler(this.miInventar_Click);
            // 
            // miPermanentky
            // 
            this.miPermanentky.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miPermanentky.Name = "miPermanentky";
            this.miPermanentky.Size = new System.Drawing.Size(166, 22);
            this.miPermanentky.Text = "Permanentky";
            // 
            // miMesacnyVykaz
            // 
            this.miMesacnyVykaz.Font = new System.Drawing.Font("Arial", 9.75F);
            this.miMesacnyVykaz.Name = "miMesacnyVykaz";
            this.miMesacnyVykaz.Size = new System.Drawing.Size(166, 22);
            this.miMesacnyVykaz.Text = "Mesačný výkaz";
            this.miMesacnyVykaz.Click += new System.EventHandler(this.mesačnýVýkazToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(917, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgRozvrh
            // 
            this.dgRozvrh.AllowUserToAddRows = false;
            this.dgRozvrh.AllowUserToDeleteRows = false;
            this.dgRozvrh.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRozvrh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgRozvrh.ColumnHeadersHeight = 35;
            this.dgRozvrh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRozvrh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meno_dietata,
            this.priezvisko_dietata,
            this.datum_cvicenia,
            this.dlzka_cvicenia,
            this.poznamka,
            this.prebehlo});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRozvrh.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgRozvrh.Location = new System.Drawing.Point(12, 100);
            this.dgRozvrh.Name = "dgRozvrh";
            this.dgRozvrh.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRozvrh.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgRozvrh.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgRozvrh.Size = new System.Drawing.Size(1022, 375);
            this.dgRozvrh.TabIndex = 2;
            this.dgRozvrh.TabStop = false;
            this.dgRozvrh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCvicenia_CellContentClick);
            // 
            // meno_dietata
            // 
            this.meno_dietata.DataPropertyName = "meno_dietata";
            this.meno_dietata.HeaderText = "Meno";
            this.meno_dietata.Name = "meno_dietata";
            this.meno_dietata.ReadOnly = true;
            this.meno_dietata.Width = 150;
            // 
            // priezvisko_dietata
            // 
            this.priezvisko_dietata.DataPropertyName = "priezvisko_dietata";
            this.priezvisko_dietata.HeaderText = "Priezvisko";
            this.priezvisko_dietata.Name = "priezvisko_dietata";
            this.priezvisko_dietata.ReadOnly = true;
            this.priezvisko_dietata.Width = 150;
            // 
            // datum_cvicenia
            // 
            this.datum_cvicenia.DataPropertyName = "datum_cvicenia";
            this.datum_cvicenia.HeaderText = "Datum";
            this.datum_cvicenia.Name = "datum_cvicenia";
            this.datum_cvicenia.ReadOnly = true;
            this.datum_cvicenia.Width = 150;
            // 
            // dlzka_cvicenia
            // 
            this.dlzka_cvicenia.DataPropertyName = "dlzka_cvicenia";
            this.dlzka_cvicenia.HeaderText = "Dĺžka min.";
            this.dlzka_cvicenia.Name = "dlzka_cvicenia";
            this.dlzka_cvicenia.ReadOnly = true;
            // 
            // poznamka
            // 
            this.poznamka.DataPropertyName = "poznamka";
            this.poznamka.HeaderText = "Poznámka";
            this.poznamka.Name = "poznamka";
            this.poznamka.ReadOnly = true;
            this.poznamka.Width = 329;
            // 
            // prebehlo
            // 
            this.prebehlo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prebehlo.DataPropertyName = "prebehlo";
            this.prebehlo.FalseValue = "";
            this.prebehlo.HeaderText = "Prebehlo";
            this.prebehlo.Name = "prebehlo";
            this.prebehlo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dnešné cvičenia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.lbAktivnyUzivatel);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 487);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1050, 25);
            this.panel6.TabIndex = 25;
            // 
            // lbAktivnyUzivatel
            // 
            this.lbAktivnyUzivatel.AutoSize = true;
            this.lbAktivnyUzivatel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAktivnyUzivatel.ForeColor = System.Drawing.Color.White;
            this.lbAktivnyUzivatel.Location = new System.Drawing.Point(82, 3);
            this.lbAktivnyUzivatel.Name = "lbAktivnyUzivatel";
            this.lbAktivnyUzivatel.Size = new System.Drawing.Size(0, 16);
            this.lbAktivnyUzivatel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prihlásený:";
            // 
            // HlavneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 512);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRozvrh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HlavneMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denné centrum Nikolka o.z.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HlavneMenu_FormClosing);
            this.Load += new System.EventHandler(this.HlavneMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRozvrh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem miOsoby;
        private System.Windows.Forms.ToolStripMenuItem miPouzivatelia;
        private System.Windows.Forms.ToolStripMenuItem miSponzori;
        private System.Windows.Forms.ToolStripMenuItem miZkaznici;
        private System.Windows.Forms.ToolStripMenuItem miZamestnanci;
        private System.Windows.Forms.ToolStripMenuItem miDokumentácia;
        private System.Windows.Forms.ToolStripMenuItem miZmluvy;
        private System.Windows.Forms.ToolStripMenuItem miFaktury;
        private System.Windows.Forms.ToolStripMenuItem miSablony;
        private System.Windows.Forms.ToolStripMenuItem miRozvrh;
        private System.Windows.Forms.ToolStripMenuItem miIne;
        private System.Windows.Forms.ToolStripMenuItem miPodujatia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miInventar;
        private System.Windows.Forms.ToolStripMenuItem miPermanentky;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgRozvrh;
        private System.Windows.Forms.ToolStripMenuItem miMesacnyVykaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn priezvisko_dietata;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_cvicenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlzka_cvicenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn poznamka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prebehlo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAktivnyUzivatel;
    }
}

