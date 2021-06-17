namespace Skuska
{
    partial class MesacnyVykaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesacnyVykaz));
            this.dgMesacnyVykaz = new System.Windows.Forms.DataGridView();
            this.mesiac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.najom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odvody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviceni_celkovo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbOdvodyZaplatene = new System.Windows.Forms.CheckBox();
            this.chbNajomZaplatene = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txVyzbieranePeniaze = new System.Windows.Forms.TextBox();
            this.txCelkovoCviceni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.polozka = new System.Windows.Forms.GroupBox();
            this.txOdvody = new System.Windows.Forms.TextBox();
            this.txNajom = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btUlozit = new System.Windows.Forms.Button();
            this.btPridat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btZrusit = new System.Windows.Forms.Button();
            this.dtpMesiac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgMesacnyVykaz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.polozka.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMesacnyVykaz
            // 
            this.dgMesacnyVykaz.AllowUserToAddRows = false;
            this.dgMesacnyVykaz.AllowUserToDeleteRows = false;
            this.dgMesacnyVykaz.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgMesacnyVykaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMesacnyVykaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesiac,
            this.najom,
            this.odvody,
            this.cviceni_celkovo});
            this.dgMesacnyVykaz.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgMesacnyVykaz.Location = new System.Drawing.Point(12, 74);
            this.dgMesacnyVykaz.MultiSelect = false;
            this.dgMesacnyVykaz.Name = "dgMesacnyVykaz";
            this.dgMesacnyVykaz.Size = new System.Drawing.Size(404, 241);
            this.dgMesacnyVykaz.TabIndex = 34;
            this.dgMesacnyVykaz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMesacnyVykaz_CellClick);
            // 
            // mesiac
            // 
            this.mesiac.DataPropertyName = "mesiac";
            this.mesiac.HeaderText = "Mesiac";
            this.mesiac.Name = "mesiac";
            this.mesiac.Width = 60;
            // 
            // najom
            // 
            this.najom.DataPropertyName = "najom";
            this.najom.HeaderText = "Nájom";
            this.najom.MaxInputLength = 100;
            this.najom.Name = "najom";
            this.najom.ReadOnly = true;
            this.najom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // odvody
            // 
            this.odvody.DataPropertyName = "odvody";
            this.odvody.HeaderText = "Odvody";
            this.odvody.Name = "odvody";
            this.odvody.ReadOnly = true;
            // 
            // cviceni_celkovo
            // 
            this.cviceni_celkovo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cviceni_celkovo.DataPropertyName = "cviceni_celkovo";
            this.cviceni_celkovo.HeaderText = "Počet cvičení";
            this.cviceni_celkovo.MaxInputLength = 25;
            this.cviceni_celkovo.Name = "cviceni_celkovo";
            this.cviceni_celkovo.ReadOnly = true;
            // 
            // chbOdvodyZaplatene
            // 
            this.chbOdvodyZaplatene.AutoSize = true;
            this.chbOdvodyZaplatene.Location = new System.Drawing.Point(292, 79);
            this.chbOdvodyZaplatene.Name = "chbOdvodyZaplatene";
            this.chbOdvodyZaplatene.Size = new System.Drawing.Size(15, 14);
            this.chbOdvodyZaplatene.TabIndex = 30;
            this.chbOdvodyZaplatene.UseVisualStyleBackColor = true;
            // 
            // chbNajomZaplatene
            // 
            this.chbNajomZaplatene.AutoSize = true;
            this.chbNajomZaplatene.Location = new System.Drawing.Point(292, 49);
            this.chbNajomZaplatene.Name = "chbNajomZaplatene";
            this.chbNajomZaplatene.Size = new System.Drawing.Size(15, 14);
            this.chbNajomZaplatene.TabIndex = 29;
            this.chbNajomZaplatene.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Zaplatené:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mesiac:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txVyzbieranePeniaze);
            this.groupBox1.Controls.Add(this.txCelkovoCviceni);
            this.groupBox1.Location = new System.Drawing.Point(422, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 120);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zisky / zbierky";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.White;
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Location = new System.Drawing.Point(180, 82);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 25);
            this.btUpdate.TabIndex = 42;
            this.btUpdate.Text = "Update";
            this.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdate.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vyzbierané peniaze:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Celkovo cvičení:";
            // 
            // txVyzbieranePeniaze
            // 
            this.txVyzbieranePeniaze.Location = new System.Drawing.Point(111, 44);
            this.txVyzbieranePeniaze.Name = "txVyzbieranePeniaze";
            this.txVyzbieranePeniaze.Size = new System.Drawing.Size(144, 20);
            this.txVyzbieranePeniaze.TabIndex = 1;
            // 
            // txCelkovoCviceni
            // 
            this.txCelkovoCviceni.Location = new System.Drawing.Point(111, 18);
            this.txCelkovoCviceni.Name = "txCelkovoCviceni";
            this.txCelkovoCviceni.Size = new System.Drawing.Size(144, 20);
            this.txCelkovoCviceni.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Odvody:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Zaplatené:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nájom:";
            // 
            // polozka
            // 
            this.polozka.Controls.Add(this.dtpMesiac);
            this.polozka.Controls.Add(this.txOdvody);
            this.polozka.Controls.Add(this.txNajom);
            this.polozka.Controls.Add(this.chbOdvodyZaplatene);
            this.polozka.Controls.Add(this.chbNajomZaplatene);
            this.polozka.Controls.Add(this.label2);
            this.polozka.Controls.Add(this.label5);
            this.polozka.Controls.Add(this.label3);
            this.polozka.Controls.Add(this.label6);
            this.polozka.Controls.Add(this.label1);
            this.polozka.Location = new System.Drawing.Point(422, 75);
            this.polozka.Name = "polozka";
            this.polozka.Size = new System.Drawing.Size(330, 114);
            this.polozka.TabIndex = 35;
            this.polozka.TabStop = false;
            this.polozka.Text = "Základné informácie";
            // 
            // txOdvody
            // 
            this.txOdvody.Location = new System.Drawing.Point(81, 76);
            this.txOdvody.Name = "txOdvody";
            this.txOdvody.Size = new System.Drawing.Size(144, 20);
            this.txOdvody.TabIndex = 32;
            // 
            // txNajom
            // 
            this.txNajom.Location = new System.Drawing.Point(81, 49);
            this.txNajom.Name = "txNajom";
            this.txNajom.Size = new System.Drawing.Size(145, 20);
            this.txNajom.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 35);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.Image = ((System.Drawing.Image)(resources.GetObject("btUlozit.Image")));
            this.btUlozit.Location = new System.Drawing.Point(503, 5);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(75, 25);
            this.btUlozit.TabIndex = 40;
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
            this.btPridat.TabIndex = 36;
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
            this.btZmazat.TabIndex = 38;
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
            this.btEditovat.TabIndex = 37;
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
            this.btZrusit.Location = new System.Drawing.Point(422, 5);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(75, 25);
            this.btZrusit.TabIndex = 41;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // dtpMesiac
            // 
            this.dtpMesiac.CustomFormat = "yyyyMM";
            this.dtpMesiac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesiac.Location = new System.Drawing.Point(81, 19);
            this.dtpMesiac.Name = "dtpMesiac";
            this.dtpMesiac.Size = new System.Drawing.Size(145, 20);
            this.dtpMesiac.TabIndex = 33;
            // 
            // MesacnyVykaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 337);
            this.Controls.Add(this.dgMesacnyVykaz);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.polozka);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MesacnyVykaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesacnyVykaz";
            this.Load += new System.EventHandler(this.MesacnyVykaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMesacnyVykaz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.polozka.ResumeLayout(false);
            this.polozka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMesacnyVykaz;
        private System.Windows.Forms.CheckBox chbOdvodyZaplatene;
        private System.Windows.Forms.CheckBox chbNajomZaplatene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.GroupBox polozka;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesiac;
        private System.Windows.Forms.DataGridViewTextBoxColumn najom;
        private System.Windows.Forms.DataGridViewTextBoxColumn odvody;
        private System.Windows.Forms.DataGridViewTextBoxColumn cviceni_celkovo;
        private System.Windows.Forms.TextBox txNajom;
        private System.Windows.Forms.TextBox txOdvody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txVyzbieranePeniaze;
        private System.Windows.Forms.TextBox txCelkovoCviceni;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DateTimePicker dtpMesiac;
    }
}