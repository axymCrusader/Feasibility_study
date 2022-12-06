using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Feasibility_study
{
    public partial class Form1 : Form
    {
        int ITOGO_day1, ITOGO_day2;
        //double Wd;// = 0.4;
        //double Wh; // = 0.22 + 0.029 + 0.051 + 0.002; // ПФ + ФСС + ФФОМС + Стра.взносы
        //double Wc;// = 0.6; //накладные расходы  

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
            
            dataGridView3.Rows[0].Cells[2].ReadOnly = true; //запрещаем ввод определенной ячейки
            dataGridView3.Rows[17].Cells[2].ReadOnly = true;
            dataGridView3.Rows[22].Cells[2].ReadOnly = true;
            dataGridView3.Rows[31].Cells[2].ReadOnly = true;
            Calc_Data_Click(sender,e);
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
        }
    }
}
