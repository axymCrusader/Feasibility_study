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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outak = new System.Windows.Forms.TextBox();
            this.outJetana = new System.Windows.Forms.TextBox();
            this.outJetpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calc_KTC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label64 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calc_Data = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTITOGORUK = new System.Windows.Forms.TextBox();
            this.TXTITOGOPROG = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(474, 189);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(92, 56);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Перейти к калькулятору";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_spravka
            // 
            this.btn_spravka.Location = new System.Drawing.Point(474, 266);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(92, 56);
            this.btn_spravka.TabIndex = 1;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(474, 346);
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
            this.label1.Location = new System.Drawing.Point(400, 58);
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
            this.tabControl1.Size = new System.Drawing.Size(1032, 603);
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
            this.tabPage1.Size = new System.Drawing.Size(1024, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчет КТС";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // outak
            // 
            this.outak.Location = new System.Drawing.Point(756, 503);
            this.outak.Name = "outak";
            this.outak.ReadOnly = true;
            this.outak.Size = new System.Drawing.Size(100, 20);
            this.outak.TabIndex = 6;
            // 
            // outJetana
            // 
            this.outJetana.Location = new System.Drawing.Point(561, 503);
            this.outJetana.Name = "outJetana";
            this.outJetana.ReadOnly = true;
            this.outJetana.Size = new System.Drawing.Size(100, 20);
            this.outJetana.TabIndex = 5;
            // 
            // outJetpro
            // 
            this.outJetpro.Location = new System.Drawing.Point(317, 503);
            this.outJetpro.Name = "outJetpro";
            this.outJetpro.ReadOnly = true;
            this.outJetpro.Size = new System.Drawing.Size(100, 20);
            this.outJetpro.TabIndex = 4;
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
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.TXTITOGOPROG);
            this.tabPage2.Controls.Add(this.TXTITOGORUK);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Calc_Data);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label64);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "План-график работ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 9);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label64.Location = new System.Drawing.Point(359, 12);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(98, 17);
            this.label64.TabIndex = 37;
            this.label64.Text = "Дата начала:";
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView3.Location = new System.Drawing.Point(6, 44);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1012, 468);
            this.dataGridView3.TabIndex = 38;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Содержание работы";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 400;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Исполнители";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Длительность, дни";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "График работ. Начало";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "График работ. Конец";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Calc_Data
            // 
            this.Calc_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calc_Data.Location = new System.Drawing.Point(6, 530);
            this.Calc_Data.Name = "Calc_Data";
            this.Calc_Data.Size = new System.Drawing.Size(137, 36);
            this.Calc_Data.TabIndex = 39;
            this.Calc_Data.Text = "РАССЧИТАТЬ";
            this.Calc_Data.UseVisualStyleBackColor = true;
            this.Calc_Data.Click += new System.EventHandler(this.Calc_Data_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(605, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Количество дней, работать программисту ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(161, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Количество дней, работать руководителю";
            // 
            // TXTITOGORUK
            // 
            this.TXTITOGORUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTITOGORUK.Location = new System.Drawing.Point(454, 537);
            this.TXTITOGORUK.Name = "TXTITOGORUK";
            this.TXTITOGORUK.ReadOnly = true;
            this.TXTITOGORUK.Size = new System.Drawing.Size(100, 22);
            this.TXTITOGORUK.TabIndex = 42;
            // 
            // TXTITOGOPROG
            // 
            this.TXTITOGOPROG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXTITOGOPROG.Location = new System.Drawing.Point(898, 540);
            this.TXTITOGOPROG.Name = "TXTITOGOPROG";
            this.TXTITOGOPROG.ReadOnly = true;
            this.TXTITOGOPROG.Size = new System.Drawing.Size(100, 22);
            this.TXTITOGOPROG.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label64;
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button Calc_Data;
        private System.Windows.Forms.TextBox TXTITOGOPROG;
        private System.Windows.Forms.TextBox TXTITOGORUK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

