namespace MaturitaChecker
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bookDataSet = new MaturitaChecker.db_bookDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_bookDataSet1 = new MaturitaChecker.db_bookDataSet1();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_bookDataSet2 = new MaturitaChecker.db_bookDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new MaturitaChecker.db_bookDataSetTableAdapters.booksTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_bookDataSet3 = new MaturitaChecker.db_bookDataSet3();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.db_bookDataSet4 = new MaturitaChecker.db_bookDataSet4();
            this.booksTableAdapter1 = new MaturitaChecker.db_bookDataSet1TableAdapters.booksTableAdapter();
            this.booksTableAdapter2 = new MaturitaChecker.db_bookDataSet2TableAdapters.booksTableAdapter();
            this.booksTableAdapter3 = new MaturitaChecker.db_bookDataSet3TableAdapters.booksTableAdapter();
            this.booksTableAdapter4 = new MaturitaChecker.db_bookDataSet4TableAdapters.booksTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonKontrola = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label18stol = new System.Windows.Forms.Label();
            this.label19stol = new System.Windows.Forms.Label();
            this.labelSvet = new System.Windows.Forms.Label();
            this.labelCesko = new System.Windows.Forms.Label();
            this.dataSetComplete = new MaturitaChecker.dataSetComplete();
            this.booksBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter5 = new MaturitaChecker.dataSetCompleteTableAdapters.booksTableAdapter();
            this.labelDrama = new System.Windows.Forms.Label();
            this.labelProza = new System.Windows.Forms.Label();
            this.labelPoezie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.booksBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.db_bookDataSet;
            // 
            // db_bookDataSet
            // 
            this.db_bookDataSet.DataSetName = "db_bookDataSet";
            this.db_bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataSource = this.booksBindingSource1;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "books";
            this.booksBindingSource1.DataSource = this.db_bookDataSet1;
            // 
            // db_bookDataSet1
            // 
            this.db_bookDataSet1.DataSetName = "db_bookDataSet1";
            this.db_bookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DataSource = this.booksBindingSource2;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(53, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(182, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "books";
            this.booksBindingSource2.DataSource = this.db_bookDataSet2;
            // 
            // db_bookDataSet2
            // 
            this.db_bookDataSet2.DataSetName = "db_bookDataSet2";
            this.db_bookDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "10";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DataSource = this.booksBindingSource3;
            this.comboBox4.DisplayMember = "Name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(53, 87);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(182, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "books";
            this.booksBindingSource3.DataSource = this.db_bookDataSet3;
            // 
            // db_bookDataSet3
            // 
            this.db_bookDataSet3.DataSetName = "db_bookDataSet3";
            this.db_bookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox5.DataSource = this.booksBindingSource4;
            this.comboBox5.DisplayMember = "Name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(53, 114);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(182, 21);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // booksBindingSource4
            // 
            this.booksBindingSource4.DataMember = "books";
            this.booksBindingSource4.DataSource = this.db_bookDataSet4;
            // 
            // db_bookDataSet4
            // 
            this.db_bookDataSet4.DataSetName = "db_bookDataSet4";
            this.db_bookDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // booksTableAdapter2
            // 
            this.booksTableAdapter2.ClearBeforeFill = true;
            // 
            // booksTableAdapter3
            // 
            this.booksTableAdapter3.ClearBeforeFill = true;
            // 
            // booksTableAdapter4
            // 
            this.booksTableAdapter4.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(422, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(422, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(422, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(422, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "20";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonKontrola
            // 
            this.buttonKontrola.Location = new System.Drawing.Point(214, 314);
            this.buttonKontrola.Name = "buttonKontrola";
            this.buttonKontrola.Size = new System.Drawing.Size(75, 23);
            this.buttonKontrola.TabIndex = 3;
            this.buttonKontrola.Text = "Zkontroluj";
            this.buttonKontrola.UseVisualStyleBackColor = true;
            this.buttonKontrola.Click += new System.EventHandler(this.buttonKontrola_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(214, 392);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Poezie";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(214, 366);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Světová 20. – 21. století";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(214, 379);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Česká 20. – 21. století";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(214, 405);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Próza";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(214, 344);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(214, 340);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Do konce 18. století";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(214, 353);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "19. století";
            this.label27.Click += new System.EventHandler(this.label26_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(214, 418);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "Drama";
            this.label28.Click += new System.EventHandler(this.label24_Click);
            // 
            // label18stol
            // 
            this.label18stol.AutoSize = true;
            this.label18stol.Location = new System.Drawing.Point(384, 340);
            this.label18stol.Name = "label18stol";
            this.label18stol.Size = new System.Drawing.Size(57, 13);
            this.label18stol.TabIndex = 9;
            this.label18stol.Text = "label18stol";
            // 
            // label19stol
            // 
            this.label19stol.AutoSize = true;
            this.label19stol.Location = new System.Drawing.Point(384, 353);
            this.label19stol.Name = "label19stol";
            this.label19stol.Size = new System.Drawing.Size(57, 13);
            this.label19stol.TabIndex = 10;
            this.label19stol.Text = "label19stol";
            // 
            // labelSvet
            // 
            this.labelSvet.AutoSize = true;
            this.labelSvet.Location = new System.Drawing.Point(384, 366);
            this.labelSvet.Name = "labelSvet";
            this.labelSvet.Size = new System.Drawing.Size(51, 13);
            this.labelSvet.TabIndex = 11;
            this.labelSvet.Text = "labelSvet";
            // 
            // labelCesko
            // 
            this.labelCesko.AutoSize = true;
            this.labelCesko.Location = new System.Drawing.Point(384, 379);
            this.labelCesko.Name = "labelCesko";
            this.labelCesko.Size = new System.Drawing.Size(59, 13);
            this.labelCesko.TabIndex = 11;
            this.labelCesko.Text = "labelCesko";
            // 
            // dataSetComplete
            // 
            this.dataSetComplete.DataSetName = "dataSetComplete";
            this.dataSetComplete.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource5
            // 
            this.booksBindingSource5.DataMember = "books";
            this.booksBindingSource5.DataSource = this.dataSetComplete;
            // 
            // booksTableAdapter5
            // 
            this.booksTableAdapter5.ClearBeforeFill = true;
            // 
            // labelDrama
            // 
            this.labelDrama.AutoSize = true;
            this.labelDrama.Location = new System.Drawing.Point(384, 417);
            this.labelDrama.Name = "labelDrama";
            this.labelDrama.Size = new System.Drawing.Size(60, 13);
            this.labelDrama.TabIndex = 12;
            this.labelDrama.Text = "labelDrama";
            // 
            // labelProza
            // 
            this.labelProza.AutoSize = true;
            this.labelProza.Location = new System.Drawing.Point(384, 404);
            this.labelProza.Name = "labelProza";
            this.labelProza.Size = new System.Drawing.Size(56, 13);
            this.labelProza.TabIndex = 13;
            this.labelProza.Text = "labelProza";
            // 
            // labelPoezie
            // 
            this.labelPoezie.AutoSize = true;
            this.labelPoezie.Location = new System.Drawing.Point(384, 391);
            this.labelPoezie.Name = "labelPoezie";
            this.labelPoezie.Size = new System.Drawing.Size(61, 13);
            this.labelPoezie.TabIndex = 14;
            this.labelPoezie.Text = "labelPoezie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPoezie);
            this.Controls.Add(this.labelProza);
            this.Controls.Add(this.labelDrama);
            this.Controls.Add(this.labelCesko);
            this.Controls.Add(this.labelSvet);
            this.Controls.Add(this.label19stol);
            this.Controls.Add(this.label18stol);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonKontrola);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Maturita Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bookDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private db_bookDataSet db_bookDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private db_bookDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private db_bookDataSet1 db_bookDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private db_bookDataSet1TableAdapters.booksTableAdapter booksTableAdapter1;
        private db_bookDataSet2 db_bookDataSet2;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private db_bookDataSet2TableAdapters.booksTableAdapter booksTableAdapter2;
        private db_bookDataSet3 db_bookDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private db_bookDataSet3TableAdapters.booksTableAdapter booksTableAdapter3;
        private db_bookDataSet4 db_bookDataSet4;
        private System.Windows.Forms.BindingSource booksBindingSource4;
        private db_bookDataSet4TableAdapters.booksTableAdapter booksTableAdapter4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonKontrola;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label18stol;
        private System.Windows.Forms.Label label19stol;
        private System.Windows.Forms.Label labelSvet;
        private System.Windows.Forms.Label labelCesko;
        private dataSetComplete dataSetComplete;
        private System.Windows.Forms.BindingSource booksBindingSource5;
        private dataSetCompleteTableAdapters.booksTableAdapter booksTableAdapter5;
        private System.Windows.Forms.Label labelDrama;
        private System.Windows.Forms.Label labelProza;
        private System.Windows.Forms.Label labelPoezie;
    }
}

