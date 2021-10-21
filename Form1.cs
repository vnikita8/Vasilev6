using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasilev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isIntDays = int.TryParse(textBox1.Text, out int number); //Проверка на то что введено число в "Дни"
            if (isIntDays)
            {
                bool visok = false;
                bool isIntYear = int.TryParse(textBox2.Text, out int year); //Проверка на то что введено число в "Год"
                if (isIntYear)
                {
                    if (year % 4 == 0) //Проверка на високосный год
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                                visok = true;
                        }
                        else
                            visok = true;
                    }
                        
                    if (visok) //Если високосный
                    {
                        if (number > 0 & number <= 366) //Проверка на числа для високосного
                        {
                            if (number <= 31)
                            {
                                lMounth.Text = "Январь";
                                lDay.Text = number.ToString();
                            }

                            else if (number <= (31+29))
                            {
                                lMounth.Text = "Февраль";
                                lDay.Text = (number - 31).ToString();
                            }

                            else if (number <= (31 + 29+31))
                            {
                                lMounth.Text = "Март";
                                lDay.Text = (number - (31+29)).ToString();
                            }

                            else if (number <= (31 + 29+31+30))
                            {
                                lMounth.Text = "Апрель";
                                lDay.Text = (number - (31+29+31)).ToString();
                            }

                            else if (number <= (31+29+31+30+31))
                            {
                                lMounth.Text = "Май";
                                lDay.Text = (number - (31 + 29 + 31+30)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31+30))
                            {
                                lMounth.Text = "Июнь";
                                lDay.Text = (number - (31+ 29 + 31 + 30 + 31)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31 + 30+31))
                            {
                                lMounth.Text = "Июль";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31+30)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31 + 30 + 31+31))
                            {
                                lMounth.Text = "Август";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31 + 30 + 31)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31+30))
                            {
                                lMounth.Text = "Сентябрь";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30+31))
                            {
                                lMounth.Text = "Октябрь";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30)).ToString();
                            }

                            else if (number <= (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31+30))
                            {
                                lMounth.Text = "Ноябрь";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31)).ToString();
                            }

                            else
                            {
                                lMounth.Text = "Декабрь";
                                lDay.Text = (number - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31+30)).ToString();
                            }
                            lYear.Text = "Високосный";
                        }
                        else
                        {
                            lError.Text = "Число несоответствует";
                        }
                    }
                    else
                    {
                        if (number > 0 & number <= 365) //Проверка на числа для високосного
                        {
                            if (number <= 31)
                            {
                                lMounth.Text = "Январь";
                                lDay.Text = number.ToString();
                            }

                            else if (number <= (31 + 28))
                            {
                                lMounth.Text = "Февраль";
                                lDay.Text = (number - 31).ToString();
                            }

                            else if (number <= (31 + 28 + 31))
                            {
                                lMounth.Text = "Март";
                                lDay.Text = (number - (31 + 28)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30))
                            {
                                lMounth.Text = "Апрель";
                                lDay.Text = (number - (31 + 28 + 31)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31))
                            {
                                lMounth.Text = "Май";
                                lDay.Text = (number - (31 + 28 + 31 + 30)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30))
                            {
                                lMounth.Text = "Июнь";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30 + 31))
                            {
                                lMounth.Text = "Июль";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31))
                            {
                                lMounth.Text = "Август";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30 + 31)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30))
                            {
                                lMounth.Text = "Сентябрь";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31))
                            {
                                lMounth.Text = "Октябрь";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30)).ToString();
                            }

                            else if (number <= (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30))
                            {
                                lMounth.Text = "Ноябрь";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31)).ToString();
                            }

                            else
                            {
                                lMounth.Text = "Декабрь";
                                lDay.Text = (number - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30)).ToString();
                            }
                            lYear.Text = "Не високосный";
                        }
                        else
                        {
                            lError.Text = "Число несоответствует";
                        }
                    }
                }
                else
                {
                    lError.Text = "Неправильно введен год";
                }
            }
            else
            {
                lError.Text = "Вы ввели не число";
            }
        }
    }
}
