namespace Skuska
{
    partial class Pouzivatelia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pouzivatelia));
            this.dgPouzivatelia = new System.Windows.Forms.DataGridView();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_heslo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPriezvisko = new System.Windows.Forms.TextBox();
            this.txMeno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbZamestnanec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txHeslo = new System.Windows.Forms.TextBox();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.btZrusit = new System.Windows.Forms.Button();
            this.btUlozit = new System.Windows.Forms.Button();
            this.btPridat = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btZmazat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbAktivyUzivatel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPouzivatelia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPouzivatelia
            // 
            this.dgPouzivatelia.AllowUserToAddRows = false;
            this.dgPouzivatelia.AllowUserToDeleteRows = false;
            this.dgPouzivatelia.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPouzivatelia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPouzivatelia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPouzivatelia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meno,
            this.Priezvisko,
            this.Login_meno,
            this.Login_heslo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPouzivatelia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgPouzivatelia.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgPouzivatelia.Location = new System.Drawing.Point(9, 62);
            this.dgPouzivatelia.MultiSelect = false;
            this.dgPouzivatelia.Name = "dgPouzivatelia";
            this.dgPouzivatelia.Size = new System.Drawing.Size(456, 229);
            this.dgPouzivatelia.TabIndex = 0;
            this.dgPouzivatelia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPouzivatelia_CellClick);
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
            // Login_meno
            // 
            this.Login_meno.DataPropertyName = "Login_meno";
            this.Login_meno.HeaderText = "Login";
            this.Login_meno.MaxInputLength = 25;
            this.Login_meno.Name = "Login_meno";
            this.Login_meno.ReadOnly = true;
            // 
            // Login_heslo
            // 
            this.Login_heslo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Login_heslo.DataPropertyName = "Login_heslo";
            this.Login_heslo.HeaderText = "Heslo";
            this.Login_heslo.MaxInputLength = 25;
            this.Login_heslo.Name = "Login_heslo";
            this.Login_heslo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Priezvisko:";
            // 
            // txPriezvisko
            // 
            this.txPriezvisko.BackColor = System.Drawing.Color.White;
            this.txPriezvisko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPriezvisko.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txPriezvisko.Location = new System.Drawing.Point(106, 87);
            this.txPriezvisko.Name = "txPriezvisko";
            this.txPriezvisko.Size = new System.Drawing.Size(185, 15);
            this.txPriezvisko.TabIndex = 16;
            // 
            // txMeno
            // 
            this.txMeno.BackColor = System.Drawing.Color.White;
            this.txMeno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMeno.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txMeno.Location = new System.Drawing.Point(106, 55);
            this.txMeno.Name = "txMeno";
            this.txMeno.Size = new System.Drawing.Size(185, 15);
            this.txMeno.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zamestnanec:";
            // 
            // cbZamestnanec
            // 
            this.cbZamestnanec.BackColor = System.Drawing.Color.White;
            this.cbZamestnanec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamestnanec.FormattingEnabled = true;
            this.cbZamestnanec.Location = new System.Drawing.Point(106, 25);
            this.cbZamestnanec.Name = "cbZamestnanec";
            this.cbZamestnanec.Size = new System.Drawing.Size(185, 24);
            this.cbZamestnanec.TabIndex = 13;
            this.cbZamestnanec.SelectedValueChanged += new System.EventHandler(this.cbZamestnanec_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Heslo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login:";
            // 
            // txHeslo
            // 
            this.txHeslo.BackColor = System.Drawing.Color.White;
            this.txHeslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txHeslo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txHeslo.Location = new System.Drawing.Point(106, 149);
            this.txHeslo.Name = "txHeslo";
            this.txHeslo.Size = new System.Drawing.Size(185, 15);
            this.txHeslo.TabIndex = 6;
            // 
            // txLogin
            // 
            this.txLogin.BackColor = System.Drawing.Color.White;
            this.txLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txLogin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txLogin.Location = new System.Drawing.Point(106, 118);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(185, 15);
            this.txLogin.TabIndex = 5;
            // 
            // btZrusit
            // 
            this.btZrusit.BackColor = System.Drawing.Color.White;
            this.btZrusit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZrusit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZrusit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btZrusit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btZrusit.Image = ((System.Drawing.Image)(resources.GetObject("btZrusit.Image")));
            this.btZrusit.Location = new System.Drawing.Point(491, 6);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(91, 30);
            this.btZrusit.TabIndex = 12;
            this.btZrusit.Text = " Zrušiť";
            this.btZrusit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZrusit.UseVisualStyleBackColor = false;
            this.btZrusit.Click += new System.EventHandler(this.btZrusit_Click);
            // 
            // btUlozit
            // 
            this.btUlozit.BackColor = System.Drawing.Color.White;
            this.btUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUlozit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btUlozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btUlozit.Image = global::Skuska.Properties.Resources.if_Check_27837_1_;
            this.btUlozit.Location = new System.Drawing.Point(588, 6);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(91, 30);
            this.btUlozit.TabIndex = 11;
            this.btUlozit.Text = " Uložiť";
            this.btUlozit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUlozit.UseVisualStyleBackColor = false;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
            // 
            // btPridat
            // 
            this.btPridat.BackColor = System.Drawing.Color.White;
            this.btPridat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPridat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPridat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPridat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btPridat.Image = ((System.Drawing.Image)(resources.GetObject("btPridat.Image")));
            this.btPridat.Location = new System.Drawing.Point(9, 6);
            this.btPridat.Margin = new System.Windows.Forms.Padding(0);
            this.btPridat.Name = "btPridat";
            this.btPridat.Size = new System.Drawing.Size(91, 30);
            this.btPridat.TabIndex = 6;
            this.btPridat.Text = " Pridať";
            this.btPridat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPridat.UseVisualStyleBackColor = false;
            this.btPridat.Click += new System.EventHandler(this.btPridat_Click);
            // 
            // btEditovat
            // 
            this.btEditovat.BackColor = System.Drawing.Color.White;
            this.btEditovat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditovat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btEditovat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btEditovat.Image = ((System.Drawing.Image)(resources.GetObject("btEditovat.Image")));
            this.btEditovat.Location = new System.Drawing.Point(107, 6);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(91, 30);
            this.btEditovat.TabIndex = 7;
            this.btEditovat.Text = " Editovať";
            this.btEditovat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditovat.UseVisualStyleBackColor = false;
            this.btEditovat.Click += new System.EventHandler(this.btEditovat_Click);
            // 
            // btZmazat
            // 
            this.btZmazat.BackColor = System.Drawing.Color.White;
            this.btZmazat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZmazat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZmazat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btZmazat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.btZmazat.Image = ((System.Drawing.Image)(resources.GetObject("btZmazat.Image")));
            this.btZmazat.Location = new System.Drawing.Point(204, 6);
            this.btZmazat.Name = "btZmazat";
            this.btZmazat.Size = new System.Drawing.Size(91, 30);
            this.btZmazat.TabIndex = 8;
            this.btZmazat.Text = " Zmazať";
            this.btZmazat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btZmazat.UseVisualStyleBackColor = false;
            this.btZmazat.Click += new System.EventHandler(this.btZmazat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 46);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(106, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(106, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel3.Location = new System.Drawing.Point(106, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 1);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel4.Location = new System.Drawing.Point(106, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 1);
            this.panel4.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(485, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Používateľ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(488, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 1);
            this.panel5.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.txLogin);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txHeslo);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbZamestnanec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txMeno);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txPriezvisko);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(488, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 201);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informácie";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.lbAktivyUzivatel);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 349);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(871, 25);
            this.panel6.TabIndex = 24;
            // 
            // lbAktivyUzivatel
            // 
            this.lbAktivyUzivatel.AutoSize = true;
            this.lbAktivyUzivatel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbAktivyUzivatel.ForeColor = System.Drawing.Color.White;
            this.lbAktivyUzivatel.Location = new System.Drawing.Point(73, 3);
            this.lbAktivyUzivatel.Name = "lbAktivyUzivatel";
            this.lbAktivyUzivatel.Size = new System.Drawing.Size(0, 16);
            this.lbAktivyUzivatel.TabIndex = 1;
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
            // Pouzivatelia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 374);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btZmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.dgPouzivatelia);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pouzivatelia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Používatelia";
            this.Load += new System.EventHandler(this.Pouzivatelia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPouzivatelia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPouzivatelia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.Button btZmazat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txHeslo;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.TextBox txPriezvisko;
        private System.Windows.Forms.TextBox txMeno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbZamestnanec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_heslo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbAktivyUzivatel;
        private System.Windows.Forms.Label label7;
    }
}