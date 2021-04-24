namespace DersNotKayıt
{
    partial class FrmOgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenDetay));
            this.btnogrkaydet = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msknumara = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.btnsınavkydt = new System.Windows.Forms.Button();
            this.txts3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblortalama = new System.Windows.Forms.Label();
            this.lblgecen = new System.Windows.Forms.Label();
            this.lblkalan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLOGRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersNotKayıtDataSet = new DersNotKayıt.DersNotKayıtDataSet();
            this.tBLOGRTableAdapter = new DersNotKayıt.DersNotKayıtDataSetTableAdapters.TBLOGRTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsınort = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLOGRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersNotKayıtDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnogrkaydet
            // 
            this.btnogrkaydet.BackColor = System.Drawing.Color.White;
            this.btnogrkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnogrkaydet.ForeColor = System.Drawing.Color.Gray;
            this.btnogrkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnogrkaydet.Image")));
            this.btnogrkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogrkaydet.Location = new System.Drawing.Point(77, 225);
            this.btnogrkaydet.Name = "btnogrkaydet";
            this.btnogrkaydet.Size = new System.Drawing.Size(250, 35);
            this.btnogrkaydet.TabIndex = 4;
            this.btnogrkaydet.Text = "ÖĞRENCİYİ KAYDET";
            this.btnogrkaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnogrkaydet.UseVisualStyleBackColor = false;
            this.btnogrkaydet.Click += new System.EventHandler(this.button1_Click);
            this.btnogrkaydet.MouseLeave += new System.EventHandler(this.btnogrkaydet_MouseLeave);
            this.btnogrkaydet.MouseHover += new System.EventHandler(this.btnogrkaydet_MouseHover);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(188, 161);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(103, 29);
            this.txtsoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(139, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "SOYAD:";
            // 
            // msknumara
            // 
            this.msknumara.Location = new System.Drawing.Point(188, 69);
            this.msknumara.Mask = "0000";
            this.msknumara.Name = "msknumara";
            this.msknumara.Size = new System.Drawing.Size(103, 29);
            this.msknumara.TabIndex = 1;
            this.msknumara.ValidatingType = typeof(int);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(188, 112);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(103, 29);
            this.txtad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(82, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "NUMARA:";
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(193, 67);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(103, 29);
            this.txts1.TabIndex = 5;
            // 
            // btnsınavkydt
            // 
            this.btnsınavkydt.BackColor = System.Drawing.Color.White;
            this.btnsınavkydt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsınavkydt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsınavkydt.ForeColor = System.Drawing.Color.Gray;
            this.btnsınavkydt.Image = ((System.Drawing.Image)(resources.GetObject("btnsınavkydt.Image")));
            this.btnsınavkydt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsınavkydt.Location = new System.Drawing.Point(103, 225);
            this.btnsınavkydt.Name = "btnsınavkydt";
            this.btnsınavkydt.Size = new System.Drawing.Size(227, 35);
            this.btnsınavkydt.TabIndex = 8;
            this.btnsınavkydt.Text = "GÜNCELLE";
            this.btnsınavkydt.UseVisualStyleBackColor = false;
            this.btnsınavkydt.Click += new System.EventHandler(this.btnsınavkydt_Click);
            this.btnsınavkydt.MouseLeave += new System.EventHandler(this.btnsınavkydt_MouseLeave);
            this.btnsınavkydt.MouseHover += new System.EventHandler(this.btnsınavkydt_MouseHover);
            // 
            // txts3
            // 
            this.txts3.Location = new System.Drawing.Point(193, 162);
            this.txts3.Name = "txts3";
            this.txts3.Size = new System.Drawing.Size(103, 29);
            this.txts3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(98, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "SINAV 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(98, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "SINAV 3:";
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(193, 113);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(103, 29);
            this.txts2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(98, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "SINAV 1:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(92, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.ForeColor = System.Drawing.Color.Transparent;
            this.lblortalama.Location = new System.Drawing.Point(275, 73);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(30, 24);
            this.lblortalama.TabIndex = 13;
            this.lblortalama.Text = "00";
            // 
            // lblgecen
            // 
            this.lblgecen.AutoSize = true;
            this.lblgecen.ForeColor = System.Drawing.Color.Transparent;
            this.lblgecen.Location = new System.Drawing.Point(275, 142);
            this.lblgecen.Name = "lblgecen";
            this.lblgecen.Size = new System.Drawing.Size(30, 24);
            this.lblgecen.TabIndex = 12;
            this.lblgecen.Text = "00";
            // 
            // lblkalan
            // 
            this.lblkalan.AutoSize = true;
            this.lblkalan.ForeColor = System.Drawing.Color.Transparent;
            this.lblkalan.Location = new System.Drawing.Point(275, 183);
            this.lblkalan.Name = "lblkalan";
            this.lblkalan.Size = new System.Drawing.Size(30, 24);
            this.lblkalan.TabIndex = 11;
            this.lblkalan.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(125, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "GEÇEN SAYISI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(130, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "KALAN SAYISI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(42, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "ÖĞRENCİ ORTALAMASI:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLOGRBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 237);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tBLOGRBindingSource
            // 
            this.tBLOGRBindingSource.DataMember = "TBLOGR";
            this.tBLOGRBindingSource.DataSource = this.dersNotKayıtDataSet;
            // 
            // dersNotKayıtDataSet
            // 
            this.dersNotKayıtDataSet.DataSetName = "DersNotKayıtDataSet";
            this.dersNotKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLOGRTableAdapter
            // 
            this.tBLOGRTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnogrkaydet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsoyad);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.msknumara);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 323);
            this.panel1.TabIndex = 13;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.ForeColor = System.Drawing.Color.Gray;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.Location = new System.Drawing.Point(143, 266);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(128, 35);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            this.btnsil.MouseLeave += new System.EventHandler(this.btnsil_MouseLeave);
            this.btnsil.MouseHover += new System.EventHandler(this.btnsil_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(71, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 36);
            this.label10.TabIndex = 9;
            this.label10.Text = "ÖĞRENCİ EKLEME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txts1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnsınavkydt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txts3);
            this.panel2.Controls.Add(this.txts2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(454, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 323);
            this.panel2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(97, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 36);
            this.label11.TabIndex = 10;
            this.label11.Text = "SINAV GİRİŞİ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel3.Controls.Add(this.lblsınort);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblortalama);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblgecen);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblkalan);
            this.panel3.Location = new System.Drawing.Point(867, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 323);
            this.panel3.TabIndex = 15;
            // 
            // lblsınort
            // 
            this.lblsınort.AutoSize = true;
            this.lblsınort.ForeColor = System.Drawing.Color.Transparent;
            this.lblsınort.Location = new System.Drawing.Point(275, 108);
            this.lblsınort.Name = "lblsınort";
            this.lblsınort.Size = new System.Drawing.Size(30, 24);
            this.lblsınort.TabIndex = 15;
            this.lblsınort.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(82, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "SINIF ORTALAMASI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(75, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 36);
            this.label12.TabIndex = 11;
            this.label12.Text = "SINIF DURUMU";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1271, 237);
            this.panel4.TabIndex = 16;
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1268, 553);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOgretmenDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ÖĞRETMEN SİSTEMİ";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLOGRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersNotKayıtDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnogrkaydet;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msknumara;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.Button btnsınavkydt;
        private System.Windows.Forms.TextBox txts3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblortalama;
        private System.Windows.Forms.Label lblgecen;
        private System.Windows.Forms.Label lblkalan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DersNotKayıtDataSet dersNotKayıtDataSet;
        private System.Windows.Forms.BindingSource tBLOGRBindingSource;
        private DersNotKayıtDataSetTableAdapters.TBLOGRTableAdapter tBLOGRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblsınort;
    }
}