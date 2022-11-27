namespace Feasibility_study
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_spravka = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calc_KTC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outJetpro = new System.Windows.Forms.TextBox();
            this.outJetana = new System.Windows.Forms.TextBox();
            this.outak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(337, 155);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(92, 56);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Перейти к калькулятору";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_spravka
            // 
            this.btn_spravka.Location = new System.Drawing.Point(337, 232);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(92, 56);
            this.btn_spravka.TabIndex = 1;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(337, 312);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(92, 56);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "Об авторе";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = "ТЭО";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 576);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.outak);
            this.tabPage1.Controls.Add(this.outJetana);
            this.tabPage1.Controls.Add(this.outJetpro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Calc_KTC);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчет КТС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.textBox34);
            this.tabPage2.Controls.Add(this.textBox32);
            this.tabPage2.Controls.Add(this.textBox36);
            this.tabPage2.Controls.Add(this.textBox35);
            this.tabPage2.Controls.Add(this.textBox31);
            this.tabPage2.Controls.Add(this.textBox37);
            this.tabPage2.Controls.Add(this.textBox33);
            this.tabPage2.Controls.Add(this.textBox38);
            this.tabPage2.Controls.Add(this.textBox39);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.textBox30);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.textBox29);
            this.tabPage2.Controls.Add(this.textBox28);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label64);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "План-график работ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1021, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчет затрат на разработку проекта и внедрение аналога";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1021, 550);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Расчет эксплуатационных затрат";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1021, 550);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Расчет показателей экономической эффективности";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(225, 22);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 18);
            this.label21.TabIndex = 2;
            this.label21.Text = "Испольнители";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(18, 22);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 18);
            this.label20.TabIndex = 3;
            this.label20.Text = "Содержание работы";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(384, 4);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.MaximumSize = new System.Drawing.Size(135, 244);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 36);
            this.label22.TabIndex = 4;
            this.label22.Text = "Длительность, дни";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(621, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 18);
            this.label23.TabIndex = 5;
            this.label23.Text = "График работы";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(581, 22);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 18);
            this.label24.TabIndex = 6;
            this.label24.Text = "Начало";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(718, 22);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 18);
            this.label25.TabIndex = 7;
            this.label25.Text = "Конец";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label64.Location = new System.Drawing.Point(554, 76);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(98, 17);
            this.label64.TabIndex = 37;
            this.label64.Text = "Дата начала:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(673, 72);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(18, 77);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(441, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "1. Подготовка процесса разработки и анализ требований";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(701, 198);
            this.textBox34.Margin = new System.Windows.Forms.Padding(2);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(86, 20);
            this.textBox34.TabIndex = 14;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(557, 202);
            this.textBox35.Margin = new System.Windows.Forms.Padding(2);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(85, 20);
            this.textBox35.TabIndex = 13;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(701, 174);
            this.textBox36.Margin = new System.Windows.Forms.Padding(2);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(86, 20);
            this.textBox36.TabIndex = 12;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(557, 178);
            this.textBox37.Margin = new System.Windows.Forms.Padding(2);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(85, 20);
            this.textBox37.TabIndex = 11;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(377, 202);
            this.textBox38.Margin = new System.Windows.Forms.Padding(2);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(114, 20);
            this.textBox38.TabIndex = 10;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(376, 178);
            this.textBox39.Margin = new System.Windows.Forms.Padding(2);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(114, 20);
            this.textBox39.TabIndex = 9;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(224, 183);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.MaximumSize = new System.Drawing.Size(150, 406);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(104, 34);
            this.label29.TabIndex = 8;
            this.label29.Text = "Руководитель Программист";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(18, 183);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.MaximumSize = new System.Drawing.Size(150, 406);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(134, 34);
            this.label30.TabIndex = 7;
            this.label30.Text = "1.2 Сбор исходных данных";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(701, 137);
            this.textBox32.Margin = new System.Windows.Forms.Padding(2);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(86, 20);
            this.textBox32.TabIndex = 14;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(557, 137);
            this.textBox33.Margin = new System.Windows.Forms.Padding(2);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(85, 20);
            this.textBox33.TabIndex = 13;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(701, 113);
            this.textBox31.Margin = new System.Windows.Forms.Padding(2);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(86, 20);
            this.textBox31.TabIndex = 12;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(557, 113);
            this.textBox30.Margin = new System.Windows.Forms.Padding(2);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(85, 20);
            this.textBox30.TabIndex = 11;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(376, 137);
            this.textBox29.Margin = new System.Windows.Forms.Padding(2);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(114, 20);
            this.textBox29.TabIndex = 10;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(376, 113);
            this.textBox28.Margin = new System.Windows.Forms.Padding(2);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(114, 20);
            this.textBox28.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(225, 118);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.MaximumSize = new System.Drawing.Size(150, 406);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 34);
            this.label28.TabIndex = 8;
            this.label28.Text = "Руководитель Программист";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(18, 118);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.MaximumSize = new System.Drawing.Size(150, 406);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 36);
            this.label27.TabIndex = 7;
            this.label27.Text = "1.1 Постановка задачи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column6,
            this.Column4});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 462);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Показатели качества";
            this.Column1.MaxInputLength = 100;
            this.Column1.Name = "Column1";
            this.Column1.Width = 400;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Коэффициент весомости, Вj";
            this.Column2.MaxInputLength = 4;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Проект. Xj";
            this.Column5.MaxInputLength = 1;
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Проект. Xj*Bj";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Аналог. Xj";
            this.Column6.MaxInputLength = 1;
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Аналог. Xj*Bj";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Calc_KTC
            // 
            this.Calc_KTC.Location = new System.Drawing.Point(8, 499);
            this.Calc_KTC.Name = "Calc_KTC";
            this.Calc_KTC.Size = new System.Drawing.Size(175, 33);
            this.Calc_KTC.TabIndex = 2;
            this.Calc_KTC.Text = "РАССЧИТАТЬ";
            this.Calc_KTC.UseVisualStyleBackColor = true;
            this.Calc_KTC.Click += new System.EventHandler(this.Calc_KTC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jэту Проект ";
            // 
            // outJetpro
            // 
            this.outJetpro.Location = new System.Drawing.Point(317, 503);
            this.outJetpro.Name = "outJetpro";
            this.outJetpro.ReadOnly = true;
            this.outJetpro.Size = new System.Drawing.Size(100, 20);
            this.outJetpro.TabIndex = 4;
            // 
            // outJetana
            // 
            this.outJetana.Location = new System.Drawing.Point(561, 503);
            this.outJetana.Name = "outJetana";
            this.outJetana.ReadOnly = true;
            this.outJetana.Size = new System.Drawing.Size(100, 20);
            this.outJetana.TabIndex = 5;
            // 
            // outak
            // 
            this.outak.Location = new System.Drawing.Point(756, 503);
            this.outak.Name = "outak";
            this.outak.ReadOnly = true;
            this.outak.Size = new System.Drawing.Size(100, 20);
            this.outak.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jэту Аналог";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(718, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_spravka);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ТЭО";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_spravka;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outak;
        private System.Windows.Forms.TextBox outJetana;
        private System.Windows.Forms.TextBox outJetpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calc_KTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

