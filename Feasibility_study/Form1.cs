﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Feasibility_study
{
    public partial class Form1 : Form
    {
        int ITOGO_day1, ITOGO_day2;
        double Wd;// = 0.4;
        double Wh; // = 0.22 + 0.029 + 0.051 + 0.002; // ПФ + ФСС + ФФОМС + Стра.взносы
        double Wc;// = 0.6; //накладные расходы  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;

            string[] row1 = new string[] { "Подготовка процесса разработки и анализ требований" };
            string[] row1_1 = new string[] { "Постановка задачи", "Руководитель","1" };
            string[] row1_2 = new string[] { "", "Программист","3" };
            string[] row1_3 = new string[] { "Сбор исходных данных", "Руководитель","5" };
            string[] row1_4 = new string[] { "", "Программист","14" };
            string[] row1_5 = new string[] { "Анализ существующих методов решения задачи и программных средств", "Руководитель","0"};
            string[] row1_6 = new string[] { "", "Программист","6"};
            string[] row1_7 = new string[] { "Обоснование принципиальной необходимости разработки", "Руководитель", "1"};
            string[] row1_8 = new string[] { "", "Программист","2" };
            string[] row1_9 = new string[] { "Определение и анализ требований к программе", "Руководитель","1" };
            string[] row1_10 = new string[] { "", "Программист","3" };
            string[] row1_11 = new string[] { "Определение структуры входных и выходных данных", "Руководитель","1" };
            string[] row1_12 = new string[] { "", "Программист","5" };
            string[] row1_13 = new string[] { "Выбор технических средств и программных средств реализации", "Руководитель","1" };
            string[] row1_14 = new string[] { "", "Программист","3"};
            string[] row1_15 = new string[] { "Согласование и утверждение технического задания", "Руководитель","1" };
            string[] row1_16 = new string[] { "", "Программист","3" };

            string[] row2 = new string[] { "Проектирование" };
            string[] row2_1 = new string[] { "Проектирование программной архитектуры", "Руководитель","0"};
            string[] row2_2 = new string[] { "", "Программист","3" };
            string[] row2_3 = new string[] { "Техническое проектирование компонентов программы", "Руководитель","0" };
            string[] row2_4 = new string[] { "", "Программист","7" };

            string[] row3 = new string[] { "Программирование и тестирование программных модулей" };
            string[] row3_1 = new string[] { "Программирование модулей в выбранной среде программирования", "Руководитель","0" };
            string[] row3_2 = new string[] { "", "Программист","13" };
            string[] row3_3 = new string[] { "Тестирование программных модулей", "Руководитель","0" };
            string[] row3_4 = new string[] { "", "Программист","21" };
            string[] row3_5 = new string[] { "Сборка и испытание программы", "Руководитель","2" };
            string[] row3_6 = new string[] { "", "Программист","5" };
            string[] row3_7 = new string[] { "Анализ результатов испытаний", "Руководитель","1" };
            string[] row3_8 = new string[] { "", "Программист","5" };

            string[] row4 = new string[] { "Оформление рабочей документации" };
            string[] row4_1 = new string[] { "Проведение расчетов показателей безопасности жизнедеятельности", "Руководитель","0" };
            string[] row4_2 = new string[] { "", "Программист","3" };
            string[] row4_3 = new string[] { "Проведение экономических расчетов", "Руководитель","0" };
            string[] row4_4 = new string[] { "", "Программист","4" };
            string[] row4_5 = new string[] { "Оформление пояснительной записки", "Руководитель","5" };
            string[] row4_6 = new string[] { "", "Программист","15" };

            object[] rows = new object[]
            {
                row1, row1_1, row1_2, row1_3, row1_4, row1_5, row1_6, row1_7, row1_8, row1_9, row1_10, row1_11, row1_12, row1_13, row1_14, row1_15, row1_16,
                row2, row2_1, row2_2, row2_3, row2_4,
                row3, row3_1, row3_2, row3_3, row3_4, row3_5, row3_6, row3_7, row3_8,
                row4, row4_1, row4_2, row4_3, row4_4, row4_5, row4_6
            };

            foreach (string[] rowArray in rows)
            {
                dataGridView3.Rows.Add(rowArray);
            }
            
            dataGridView3.Rows[1].Cells[3].Style.BackColor = Color.Gold;
            
            for (int i = 0; i < 5; i++) //Красим заголовки графика работ по строкам
            {
                dataGridView3.Rows[0].Cells[i].Style.BackColor = Color.DarkGray;
                dataGridView3.Rows[17].Cells[i].Style.BackColor = Color.DarkGray;
                dataGridView3.Rows[22].Cells[i].Style.BackColor = Color.DarkGray;
                dataGridView3.Rows[31].Cells[i].Style.BackColor = Color.DarkGray;

            }
            dataGridView4.Rows.Add(5);
            dataGridView5.Rows.Add(5);

            dataGridView3.Rows[0].Cells[2].ReadOnly = true; //запрещаем ввод определенной ячейки
            dataGridView3.Rows[17].Cells[2].ReadOnly = true;
            dataGridView3.Rows[22].Cells[2].ReadOnly = true;
            dataGridView3.Rows[31].Cells[2].ReadOnly = true;

            dataGridView2.Rows.Add(2);
            dataGridView2.Rows[0].Cells[0].Value = "Руководитель";
            dataGridView2.Rows[1].Cells[0].Value = "Программист";

            dataGridView2.Rows[0].Cells[2].Value = "1";
            dataGridView2.Rows[1].Cells[2].Value = "1";

            dataGridView13.Rows.Add(7);
            dataGridView13.Rows[0].Cells[0].Value = "Основная заработная плата";
            dataGridView13.Rows[1].Cells[0].Value = "Дополнительная зарплата";
            dataGridView13.Rows[2].Cells[0].Value = "Отчисления на социальные нужды";
            dataGridView13.Rows[3].Cells[0].Value = "Затраты на материалы ";
            dataGridView13.Rows[4].Cells[0].Value = "Затраты на машинное время";
            dataGridView13.Rows[5].Cells[0].Value = "Накладные расходы организации";
            dataGridView13.Rows[6].Cells[0].Value = "Итого";

            dataGridView8.Rows.Add(7);
            dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Авто высота строк
            dataGridView8.Rows[0].Cells[0].Value = "Основная и дополнительная зарплата с отчислениями во внебюджетные фонды";
            dataGridView8.Rows[1].Cells[0].Value = "Амортизационные отчисления";
            dataGridView8.Rows[2].Cells[0].Value = "Затраты на электроэнергию";
            dataGridView8.Rows[3].Cells[0].Value = "Затраты на текущий ремонт";
            dataGridView8.Rows[4].Cells[0].Value = "Затраты на материалы";
            dataGridView8.Rows[5].Cells[0].Value = "Накладные расходы";
            dataGridView8.Rows[6].Cells[0].Value = "Итого";

            dataGridView9.Rows.Add(4);
            dataGridView9.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Авто высота строк
            dataGridView9.Rows[0].Cells[0].Value = "Себестоимость (текущие эксплуатационные затраты), руб.";
            dataGridView9.Rows[1].Cells[0].Value = "Суммарные затраты, связанные с внедрением проекта, руб.";
            dataGridView9.Rows[2].Cells[0].Value = "Приведенные затраты на единицу работ, руб.";
            dataGridView9.Rows[3].Cells[0].Value = "Экономический эффект от использования разрабатываемой системы, руб.";

            dataGridView11.Rows.Add(5);
            dataGridView11.Rows[0].Cells[0].Value = "Затраты на разработку и внедрение проекта, руб.";
            dataGridView11.Rows[1].Cells[0].Value = "Общие эксплуатационные затраты, руб.";
            dataGridView11.Rows[2].Cells[0].Value = "Экономический эффект, руб.";
            dataGridView11.Rows[3].Cells[0].Value = "Коэффициент экономической эффективности";
            dataGridView11.Rows[4].Cells[0].Value = "Срок окупаемости, лет";

            //Calc_Data_Click(sender,e);
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_about.Visible = false;
            btn_start.Visible = false;
            btn_spravka.Visible = false;

            tabControl1.Visible = true;
        }
        private void btn_spravka_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ТЭО справка.pdf");
        }

        private void Calc_KTC_Click(object sender, EventArgs e)
        {
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom1, incom2, incom3;
                double.TryParse((row.Cells[3].Value ?? "0").ToString().Replace(".", ","), out incom1);
                double.TryParse((row.Cells[5].Value ?? "0").ToString().Replace(".", ","), out incom2);
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom3);
                sum1 += incom1;
                sum2 += incom2;
                sum3 += incom3;
            }
            if (sum3 != 1)
            {
                MessageBox.Show("Коэффициент весомости не равен 1" + ", Он равен: " + sum3 );
            }
            else
            {
                outJetpro.Text = sum1.ToString();
                outJetana.Text = sum2.ToString();
                sum1 = sum1 / sum2;
                sum1 = Math.Round(sum1, 2);
                outak.Text = sum1.ToString();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double incom1, incom2, incom3;
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom2);
                double.TryParse((row.Cells[4].Value ?? "0").ToString().Replace(".", ","), out incom3);
                row.Cells[3].Value = incom1 * incom2;
                row.Cells[5].Value = incom1 * incom3;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].IsInEditMode ||
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].IsInEditMode)
            {
                if ((e.KeyChar <= 48 || e.KeyChar >= 54) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }

            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void CALC_DEVELOP_Click(object sender, EventArgs e)
        {
            double dn = 21;
            double incom1;
            int incom2;
            double ITOGO_OZP = 0, Sum_Mat = 0;
            int Tm = 0;
            double Kp, Kr, Sm = 0, Km = 0;
            double Sum_Ob = 0;
            int Uk = 0; 
            int Dk = 21 * 12;
            int H = 0;
            double tx = 0;
            double sum = 0;
            double ITOGO_Zatr = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);

                incom1 = incom1 / dn;
                incom1 = Math.Round(incom1, 2);
                row.Cells[2].Value = incom1; //Средняя дневная ставка 

                dataGridView2.Rows[0].Cells[3].Value = ITOGO_day1;
                dataGridView2.Rows[1].Cells[3].Value = ITOGO_day2;

                incom2 = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[4].Value = incom1 * incom2;
            }
            if (textBox10.Text != "")
                Wc = double.Parse(textBox10.Text); //накладные расходы  

            if ((textBox6.Text != "") || (textBox7.Text != "") || (textBox8.Text != "") || (textBox9.Text != ""))
                Wh = double.Parse(textBox6.Text) + double.Parse(textBox7.Text) + double.Parse(textBox8.Text) + double.Parse(textBox9.Text); // ПФ + ФСС + ФФОМС + Стра.взносы

            if ((textBox4.Text != "") || (textBox5.Text != ""))
                Wd = double.Parse(textBox4.Text) + double.Parse(textBox5.Text);  //коэффициент, учитывающий дополнительную заработную плату в долях к основной заработной плате 

            if (textBox1.Text != "")
                Tm = Convert.ToInt32(textBox1.Text) * ITOGO_day2; //машинное время компьютера

            if (textBox2.Text != "")
                Sm = double.Parse(textBox2.Text); //стоимость 1 часа машинного времени, 

            if (textBox3.Text != "")
                Km = double.Parse(textBox3.Text); //коэффициент мультипрограммности

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                ITOGO_OZP += Convert.ToDouble(row.Cells[4].Value);
            }

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                Sum_Mat += Convert.ToDouble(row.Cells[4].Value);
            }

            Kp = ITOGO_OZP * ((1 + Wd) * (1 + Wh) + Wc) + Tm * Sm * Km + Sum_Mat; //Капитальнное вложение
            Kp = Math.Round(Kp, 2); //Округлил до десятых
            textBox11.Text = Kp.ToString();

            if (textBox35.Text != "")
                Uk = Convert.ToInt32(textBox35.Text);

            if (textBox20.Text != "")
                H = Convert.ToInt32(textBox20.Text); //норматив среднесуточной загрузки, час./день    

            if (textBox29.Text != "")
                tx = double.Parse(textBox29.Text);

            foreach (DataGridViewRow row in dataGridView5.Rows) //Сумма оборудования
            {
                Sum_Ob += Convert.ToDouble(row.Cells[3].Value);
            }

            Kr = Math.Round(Sum_Ob * tx * Uk / (Dk * H), 2);
            textBox12.Text = Kr.ToString();

            //------------           
            textBox13.Text = Math.Round(Kr + Kp, 2).ToString();

            dataGridView13.Rows[0].Cells[1].Value = Math.Round(ITOGO_OZP, 2); //ОЗП
            dataGridView13.Rows[1].Cells[1].Value = Math.Round(ITOGO_OZP * Wd, 2); //Дополнительная зарплата
            dataGridView13.Rows[2].Cells[1].Value = Math.Round((ITOGO_OZP + (ITOGO_OZP * Wd)) * Wh, 2);// Отчисления на социальные нужды 
            dataGridView13.Rows[3].Cells[1].Value = Math.Round(Sum_Mat, 2); //Затраты на материалы 
            dataGridView13.Rows[4].Cells[1].Value = Math.Round(Tm * Sm, 2);
            dataGridView13.Rows[5].Cells[1].Value = Math.Round(ITOGO_OZP * Wc, 2); //Накладные расходы организации 

            for (int i = 0; i <= 5; i++)
            {
                sum += Convert.ToDouble(dataGridView13.Rows[i].Cells[1].Value);
            }
            dataGridView13.Rows[6].Cells[1].Value = sum; //ИТОГО 

            foreach (DataGridViewRow row in dataGridView12.Rows)
            {
                ITOGO_Zatr += Convert.ToDouble(row.Cells[1].Value);
            }
            textBox31.Text = ITOGO_Zatr.ToString();
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double incom1, incom2;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                incom1 = Convert.ToDouble(row.Cells[2].Value);
                double.TryParse((row.Cells[3].Value ?? "0").ToString().Replace(".", ","), out incom2);
                row.Cells[4].Value = incom1 * incom2;
            }
        }

        private void dataGridView4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb2 = (TextBox)e.Control;
            tb2.KeyPress += new KeyPressEventHandler(tb2_KeyPress);
        }
        void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[3].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
            if (dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[2].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double incom1, incom2;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                incom2 = Convert.ToDouble(row.Cells[2].Value);
                row.Cells[3].Value = incom1 * incom2;
            }
        }

        private void dataGridView5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb3 = (TextBox)e.Control;
            tb3.KeyPress += new KeyPressEventHandler(tb3_KeyPress);
        }
        void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
            if (dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[2].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void CALC_ZATRATI_Click(object sender, EventArgs e)
        {
            double R = 0; //Районный коэф
            if (textBox26.Text != "")
                R = double.Parse(textBox26.Text);


            double incom1;
            int incom2;
            int notnul = 0;
            double incom3;
            int incom4;

            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                notnul = 21;
                incom1 = incom1 / notnul;
                row.Cells[2].Value = Math.Round(incom1, 2); //Средняя дневная ставка                 
                incom2 = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[4].Value = Math.Round(incom1 * incom2 * (1 + Wh) * (1 + R), 2);
            }

            //-----            
            foreach (DataGridViewRow row in dataGridView7.Rows)
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom3);
                incom3 = incom3 / notnul;
                notnul = 21;
                row.Cells[2].Value = Math.Round(incom3, 2); //Средняя дневная ставка                 
                incom4 = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[4].Value = Math.Round(incom3 * incom4 * (1 + Wh) * (1 + R), 2);
            }
            //----

            int D = 21, H = 0;
            if (textBox22.Text != "")
                H = Convert.ToInt32(textBox22.Text); // Час/день

            int Fe = H * D; //эффективный фонд времени работы оборудования в год, час            
            double t1 = 0; // время работы j - гo вида оборудования, час (для проекта)
            double t2 = 0; // время работы j - гo вида оборудования, час (для аналога)
            double sum1 = 0, sum2 = 0; //Основная и дополнительная зарплата с отчислениями во внебюджетные фонды
            double SumOb = 0; // Сумма (стоимость оборудования * шт)
            double Ca1, Ca2; //Сумма амортизационных отчислений

            double g = 0;//количество единиц оборудования j-гo вида.
            foreach (DataGridViewRow row in dataGridView10.Rows)
            { g += Convert.ToDouble(row.Cells[1].Value); }


            double aj = 0; //норма годовых амортизационных отчислений для j-гo вида оборудования
            if (textBox23.Text != "")
                aj = double.Parse(textBox23.Text);

            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                sum1 += Convert.ToDouble(row.Cells[4].Value);
                t1 += Convert.ToDouble(row.Cells[3].Value);
            }
            foreach (DataGridViewRow row in dataGridView7.Rows)
            {
                sum2 += Convert.ToDouble(row.Cells[4].Value);
                t2 += Convert.ToDouble(row.Cells[3].Value);
            }

            t1 = t1 * H; //Время работы оборудования
            t2 = t2 * H;

            foreach (DataGridViewRow row in dataGridView10.Rows)// Сумма (стоимость оборудования * шт)
            { SumOb += Convert.ToDouble(row.Cells[3].Value); }

            Ca1 = Math.Round((SumOb * aj * g * t1) / Fe, 2);
            Ca2 = Math.Round((SumOb * aj * g * t2) / Fe, 2);

            //--------Затраты на электроэнергию-----------------
            double Ze1, Ze2; //Затраты на силовую энергию
            double Ni = 0; //установленная мощность j-го вида технических средств, кВт;
            if (textBox21.Text != "")
                Ni = double.Parse(textBox21.Text);

            double Te = 0; // тариф на электроэнергию, руб./ кВт ч.            
            if (textBox14.Text != "")
                Te = double.Parse(textBox14.Text);

            double gi = 0; //коэффициент использования установленной мощности оборудования;
            if (textBox24.Text != "")
                gi = double.Parse(textBox24.Text);

            Ze1 = Math.Round(Ni * gi * t1 * Te, 2);
            Ze2 = Math.Round(Ni * gi * t2 * Te, 2);

            //--------Затраты на текущий ремонт оборудования--------------------
            double Cp = 0; //норматив затрат на ремонт
            if (textBox25.Text != "")
                Cp = double.Parse(textBox25.Text);

            double ZrOb1, ZrOb2; //Затраты на текущий ремонт оборудования
            ZrOb1 = Math.Round((Cp * SumOb * t1) / Fe, 2);
            ZrOb2 = Math.Round((Cp * SumOb * t2) / Fe, 2);

            //--------Затраты на материалы  ------------------
            double Zm = 0; // Затраты на материалы, потребляемые в течение года          
            if (textBox27.Text != "")
                Zm = double.Parse(textBox27.Text);
            double ZrM; //Затраты на материалы           
            ZrM = Math.Round(SumOb * Zm, 2);

            //--------Накладные расходы----------------------
            double Proz = 0; //Норматив накладных расходов
            if (textBox28.Text != "")
                Proz = double.Parse(textBox28.Text);
            double Zn1, Zn2; //Накладные расходы           
            Zn1 = Math.Round((sum1 + Ca1 + Ze1 + ZrM + ZrOb1) * Proz, 2);
            Zn2 = Math.Round((sum2 + Ca2 + Ze2 + ZrM + ZrOb2) * Proz, 2);

            //--------ИТОГО
            double Itog1 = sum1 + Ca1 + Ze1 + ZrOb1 + ZrM + Zn1;
            double Itog2 = sum2 + Ca2 + Ze2 + ZrOb2 + ZrM + Zn2;

            //--------
            dataGridView8.Rows[0].Cells[1].Value = sum1;
            dataGridView8.Rows[0].Cells[2].Value = sum2;
            dataGridView8.Rows[1].Cells[1].Value = Ca1;
            dataGridView8.Rows[1].Cells[2].Value = Ca2;
            dataGridView8.Rows[2].Cells[1].Value = Ze1;
            dataGridView8.Rows[2].Cells[2].Value = Ze2;
            dataGridView8.Rows[3].Cells[1].Value = ZrOb1;
            dataGridView8.Rows[3].Cells[2].Value = ZrOb2;
            dataGridView8.Rows[4].Cells[1].Value = ZrM;
            dataGridView8.Rows[4].Cells[2].Value = ZrM;
            dataGridView8.Rows[5].Cells[1].Value = Zn1;
            dataGridView8.Rows[5].Cells[2].Value = Zn2;
            dataGridView8.Rows[6].Cells[1].Value = Itog1;
            dataGridView8.Rows[6].Cells[2].Value = Itog2;
        }

        private void dataGridView10_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double incom1, incom2;
            foreach (DataGridViewRow row in dataGridView10.Rows)
            {
                double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom1);// Сумма оборудования
                incom2 = Convert.ToDouble(row.Cells[1].Value);// Кол оборудования
                row.Cells[3].Value = incom1 * incom2;// Сумма
            }
        }

        private void dataGridView10_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb100 = (TextBox)e.Control;
            tb100.KeyPress += new KeyPressEventHandler(tb100_KeyPress);
        }
        void tb100_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (dataGridView10.Rows[dataGridView10.CurrentRow.Index].Cells[2].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
            if (dataGridView10.Rows[dataGridView10.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void dataGridView6_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           double R = 0; //Районный коэф
            if (textBox26.Text != "")
            R = double.Parse(textBox26.Text); 
            double incom1;
            int incom2;
            foreach (DataGridViewRow row in dataGridView6.Rows) 
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                incom1 = incom1 / 21;               
                row.Cells[2].Value = Math.Round(incom1, 2); //Средняя дневная ставка                 
                incom2 = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[4].Value = Math.Round(incom1*incom2*(1+Wh)*(1+R), 2); 
            }
        }

        private void dataGridView6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb4 = (TextBox)e.Control;
            tb4.KeyPress += new KeyPressEventHandler(tb4_KeyPress);
        }
        void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
            if (dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[3].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void dataGridView7_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double R = 0; //Районный коэф
            if (textBox26.Text != "")
            R = double.Parse(textBox26.Text);
            double incom1;
            int incom2;
            foreach (DataGridViewRow row in dataGridView7.Rows)
            {
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                incom1 = incom1 / 21;
                row.Cells[2].Value = Math.Round(incom1, 2); //Средняя дневная ставка                 
                incom2 = Convert.ToInt32(row.Cells[3].Value);
                row.Cells[4].Value = Math.Round(incom1 * incom2 * (1 + Wh) * (1 + R), 2);
            }
        }

        private void dataGridView7_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb5 = (TextBox)e.Control;
            tb5.KeyPress += new KeyPressEventHandler(tb5_KeyPress);
        }
        void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (dataGridView7.Rows[dataGridView7.CurrentRow.Index].Cells[1].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
            if (dataGridView7.Rows[dataGridView7.CurrentRow.Index].Cells[3].IsInEditMode)
            {
                if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) { e.Handled = true; }
            }
        }

        private void CALC_FINAL_Click(object sender, EventArgs e)
        {
            double Z1, Z2; //приведенные затраты на единицу работ, выполняемых с помощью базового и проектируемого вариантов процесса обработки информации, руб.;
            double En = 0;  //нормативный коэффициент экономической эффективности
            if (textBox8.Text != "")
            { En = double.Parse(textBox8.Text); }
            double Ki1 = 0, Ki2 = 0; //суммарные затраты, связанные с внедрением нового проекта. 
            double Ci1 = 0, Ci2 = 0; //себестоимость (текущие эксплуатационные затраты единицы работ), руб.;

            Ci1 = Convert.ToDouble(dataGridView8.Rows[6].Cells[2].Value);
            Ci2 = Convert.ToDouble(dataGridView8.Rows[6].Cells[1].Value);

            foreach (DataGridViewRow row in dataGridView12.Rows)
            {
                double incom1;
                double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom1);
                Ki1 += incom1;
            }
            if (textBox6.Text != "")
            { Ki2 = double.Parse(textBox6.Text); }

            Z1 = Math.Round(Ci1 + En * Ki1, 2);
            Z2 = Math.Round(Ci2 + En * Ki2, 2);

            double E;
            double Ak = 0;
            if (textBox3.Text != "")
            { Ak = double.Parse(textBox3.Text); }

            E = Math.Round(Z1 * Ak - Z2, 2);

            dataGridView9.Rows[0].Cells[1].Value = Ci1;
            dataGridView9.Rows[0].Cells[2].Value = Ci2;
            dataGridView9.Rows[1].Cells[1].Value = Ki1;
            dataGridView9.Rows[1].Cells[2].Value = Ki2;
            dataGridView9.Rows[2].Cells[1].Value = Z1;
            dataGridView9.Rows[2].Cells[2].Value = Z2;
            dataGridView9.Rows[3].Cells[1].Value = E;
            dataGridView9.Rows[3].Cells[2].Value = E;

            //------------------------------------

            double Tok = 0;
            Tok = Math.Round(Ki2 / E, 2); //срок окупаемости затрат на разработку
            double Ef = 0;
            Ef = Math.Round(1 / Tok, 2); //фактический коэффициент экономической эффективности разработки

            dataGridView11.Rows[0].Cells[1].Value = Ki2;
            dataGridView11.Rows[1].Cells[1].Value = Ci2;
            dataGridView11.Rows[2].Cells[1].Value = E;
            dataGridView11.Rows[3].Cells[1].Value = Ef;
            dataGridView11.Rows[4].Cells[1].Value = Tok;
            //------------------------------------

            if (En < Ef)
                label37.Text = "Проект эффективен";
            else label37.Text = "Проект не эффективен";

        }

        private void Calc_Data_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            DateTime dateB, dateM; // Даты для сравнения (руководителя и программиста на конец предыдущих)

            bool dobro = false;
            for (int i = 1; i <= 1; i++) //Сообщение о не заполненых ячейках
            {
                if (i == 17 || i == 22 || i == 31)
                { i++; }
                else if (dataGridView3.Rows[i].Cells[2].Value == null)
                {
                    dobro = false;
                    MessageBox.Show("Введите длительность дней");
                    break;
                }
                else { dobro = true; };
            }

            if (dobro == true)
            {
                dataGridView3.Rows[1].Cells[3].Value = dateTimePicker1.Value.ToString("dd.MM.yyyy"); //Заносим дату пользователя в начало руководителя
                dataGridView3.Rows[2].Cells[3].Value = dataGridView3.Rows[1].Cells[3].Value; // Дата руководителя совподает с датой программиста

                date1 = Convert.ToDateTime(dataGridView3.Rows[1].Cells[3].Value); // Заносим в переменную дату руководителя 
                date1 = date1.AddDays(Convert.ToInt32(dataGridView3.Rows[1].Cells[2].Value) - 1); //Прибавляем дни руководителя
                dataGridView3.Rows[1].Cells[4].Value = date1.ToShortDateString(); // заносим дату в конец руководителя

                date1 = Convert.ToDateTime(dataGridView3.Rows[2].Cells[3].Value); // Заносим в переменную дату программиста
                date1 = date1.AddDays(Convert.ToInt32(dataGridView3.Rows[2].Cells[2].Value) - 1); //Прибавляем дни программиста
                dataGridView3.Rows[2].Cells[4].Value = date1.ToShortDateString(); // заносим дату в конец программиста


                for (int i = 3; i <= 37; i = i + 2)
                {
                    if (i == 17 || i == 22 || i == 31) // Заголовки строк исключаем
                    {
                        i++;
                        dateM = Convert.ToDateTime(dataGridView3.Rows[i - 3].Cells[4].Value); //Руководитель
                        dateB = Convert.ToDateTime(dataGridView3.Rows[i - 2].Cells[4].Value); //Программист

                        if (dateB > dateM)
                            date1 = Convert.ToDateTime(dataGridView3.Rows[i - 2].Cells[4].Value); // Предыдущая дата программиста                         
                        else date1 = Convert.ToDateTime(dataGridView3.Rows[i - 3].Cells[4].Value);
                    }
                    else
                    {
                        dateM = Convert.ToDateTime(dataGridView3.Rows[i - 2].Cells[4].Value); //Руководитель
                        dateB = Convert.ToDateTime(dataGridView3.Rows[i - 1].Cells[4].Value); //Программист
                        if (dateB > dateM)
                            date1 = Convert.ToDateTime(dataGridView3.Rows[i - 1].Cells[4].Value); // Предыдущая дата программиста                         
                        else date1 = Convert.ToDateTime(dataGridView3.Rows[i - 2].Cells[4].Value);
                    }

                    date1 = date1.AddDays(1); // Прибавляем день с новой работы
                    dataGridView3.Rows[i].Cells[3].Value = date1.ToShortDateString();
                    date1 = date1.AddDays(Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value) - 1);
                    dataGridView3.Rows[i].Cells[4].Value = date1.ToShortDateString();

                    dataGridView3.Rows[i + 1].Cells[3].Value = dataGridView3.Rows[i].Cells[3].Value; // Дата руководителя совподает с датой программиста

                    date1 = Convert.ToDateTime(dataGridView3.Rows[i + 1].Cells[3].Value);
                    date1 = date1.AddDays(Convert.ToInt32(dataGridView3.Rows[i + 1].Cells[2].Value) - 1);
                    dataGridView3.Rows[i + 1].Cells[4].Value = date1.ToShortDateString();
                }

                for (int i = 1; i <= 37; i++)
                {
                    if (i == 17 || i == 22 || i == 31) // Заголовки строк исключаем
                    {
                        i++;
                    }

                    if (Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value) == 0)
                    {
                        dataGridView3.Rows[i].Cells[3].Value = "-------";
                        dataGridView3.Rows[i].Cells[4].Value = "-------";
                    }
                }
            }

            //--Суммирование дней руководителей и программистов 
            int day1 = 0;
            int day2 = 0;
            for (int i = 1; i <= 37; i = i + 2)
            {
                if (i == 17 || i == 22 || i == 31) // Заголовки строк исключаем
                {
                    i--;
                }
                else
                {
                    day1 += Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value);
                    day2 += Convert.ToInt32(dataGridView3.Rows[i + 1].Cells[2].Value);
                }
            }
            ITOGO_day1 = day1;
            ITOGO_day2 = day2;

            TXTITOGORUK.Text = Convert.ToString(ITOGO_day1);
            TXTITOGOPROG.Text = Convert.ToString(ITOGO_day2);

            dataGridView2.Rows[0].Cells[3].Value = ITOGO_day1;
            dataGridView2.Rows[1].Cells[3].Value = ITOGO_day2;

        }
    }
}
