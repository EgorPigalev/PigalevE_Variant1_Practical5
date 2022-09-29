using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПрактическаяРабота_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RBEasternHoroscope_Checked(object sender, RoutedEventArgs e)
        {
            SPZodiacSignal.Visibility = Visibility.Collapsed;
            BtnClear_Click(sender, e);
            SPEasternHoroscope.Visibility = Visibility.Visible;
            SPButton.Visibility = Visibility.Visible;
        }

        private void RBZodiac_Checked(object sender, RoutedEventArgs e)
        {
            SPEasternHoroscope.Visibility = Visibility.Collapsed;
            BtnClear_Click(sender, e);
            SPZodiacSignal.Visibility = Visibility.Visible;
            SPButton.Visibility = Visibility.Visible;
        }

        bool GetProverkaDay(int day, string month)
        {
            if(month == "Январь" && day > 31)
            {
                MessageBox.Show("В январе нет " + day +" числа!");
                return true;
            }
            if (month == "Февраль" && day > 29)
            {
                MessageBox.Show("В феврале нет " + day + " числа!");
                return true;
            }
            if (month == "Март" && day > 31)
            {
                MessageBox.Show("В марте нет " + day + " числа!");
                return true;
            }
            if (month == "Апрель" && day > 30)
            {
                MessageBox.Show("В апреле нет " + day + " числа!");
                return true;
            }
            if (month == "Май" && day > 31)
            {
                MessageBox.Show("В мае нет " + day + " числа!");
                return true;
            }
            if (month == "Июнь" && day > 31)
            {
                MessageBox.Show("В июне нет " + day + " числа!");
                return true;
            }
            if (month == "Июль" && day > 31)
            {
                MessageBox.Show("В июле нет " + day + " числа!");
                return true;
            }
            if (month == "Август" && day > 31)
            {
                MessageBox.Show("В августе нет " + day + " числа!");
                return true;
            }
            if (month == "Сентябрь" && day > 31)
            {
                MessageBox.Show("В сентябре нет " + day + " числа!");
                return true;
            }
            if (month == "Август" && day > 31)
            {
                MessageBox.Show("В августе нет " + day + " числа!");
                return true;
            }
            if (month == "Сентябрь" && day > 30)
            {
                MessageBox.Show("В сентябре нет " + day + " числа!");
                return true;
            }
            if (month == "Октябрь" && day > 31)
            {
                MessageBox.Show("В октябре нет " + day + " числа!");
                return true;
            }
            if (month == "Ноябрь" && day > 30)
            {
                MessageBox.Show("В ноябре нет " + day + " числа!");
                return true;
            }
            if (month == "Декабрь" && day > 31)
            {
                MessageBox.Show("В декабре нет " + day + " числа!");
                return true;
            }
            if(day <= 0)
            {
                MessageBox.Show("Число не может быть нулевым!");
                return true;
            }
            return false;
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(RBZodiac.IsChecked == true)
                {
                    if(TBDay.Text == "" || TBMonth.Text == "")
                    {
                        MessageBox.Show("Все поля должны быть заполнены!");
                        return;
                    }
                    if (GetProverkaDay(Convert.ToInt32(TBDay.Text), TBMonth.Text) == true)
                    {
                        return;
                    }
                    string ZodiacSingl = "";
                    if((Convert.ToInt32(TBDay.Text) >=21 && TBMonth.Text == "Март") || (Convert.ToInt32(TBDay.Text) <= 20 && TBMonth.Text == "Апрель"))
                    {
                        ZodiacSingl = "Овен";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 21 && TBMonth.Text == "Апрель") || (Convert.ToInt32(TBDay.Text) <= 20 && TBMonth.Text == "Май"))
                    {
                        ZodiacSingl = "Телец";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 21 && TBMonth.Text == "Май") || (Convert.ToInt32(TBDay.Text) <= 21 && TBMonth.Text == "Июнь"))
                    {
                        ZodiacSingl = "Близнецы";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 22 && TBMonth.Text == "Июнь") || (Convert.ToInt32(TBDay.Text) <= 22 && TBMonth.Text == "Июль"))
                    {
                        ZodiacSingl = "Рак";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 23 && TBMonth.Text == "Июль") || (Convert.ToInt32(TBDay.Text) <= 22 && TBMonth.Text == "Август"))
                    {
                        ZodiacSingl = "Лев";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 23 && TBMonth.Text == "Август") || (Convert.ToInt32(TBDay.Text) <= 23 && TBMonth.Text == "Сентябрь"))
                    {
                        ZodiacSingl = "Дева";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 24 && TBMonth.Text == "Сентябрь") || (Convert.ToInt32(TBDay.Text) <= 23 && TBMonth.Text == "Октябрь"))
                    {
                        ZodiacSingl = "Веса";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 24 && TBMonth.Text == "Октябрь") || (Convert.ToInt32(TBDay.Text) <= 22 && TBMonth.Text == "Ноябрь"))
                    {
                        ZodiacSingl = "Скорпион";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 23 && TBMonth.Text == "Ноябрь") || (Convert.ToInt32(TBDay.Text) <= 21 && TBMonth.Text == "Декабрь"))
                    {
                        ZodiacSingl = "Стрелец";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 22 && TBMonth.Text == "Декабрь") || (Convert.ToInt32(TBDay.Text) <= 20 && TBMonth.Text == "Январь"))
                    {
                        ZodiacSingl = "Козерог";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 21 && TBMonth.Text == "Январь") || (Convert.ToInt32(TBDay.Text) <= 18 && TBMonth.Text == "Февраль"))
                    {
                        ZodiacSingl = "Водолей";
                    }
                    else if ((Convert.ToInt32(TBDay.Text) >= 19 && TBMonth.Text == "Февраль") || (Convert.ToInt32(TBDay.Text) <= 20 && TBMonth.Text == "Март"))
                    {
                        ZodiacSingl = "Рыбы";
                    }
                    TBHeaderResult.Visibility = Visibility.Visible;
                    TBlResult.Text = "Ваш знак зодиака => " + ZodiacSingl;
                }
                else if(RBEasternHoroscope.IsChecked == true)
                {
                    string Horoscope = "";
                    int Year = Convert.ToInt32(TBYear.Text);
                    Year = Year % 12;
                    if (Year == 0)
                    {
                        Horoscope = "Обезьяна";
                    }
                    else if (Year == 1)
                    {
                        Horoscope = "Петух";
                    }
                    else if (Year == 2)
                    {
                        Horoscope = "Собака";
                    }
                    else if (Year == 3)
                    {
                        Horoscope = "Кабан";
                    }
                    else if (Year == 4)
                    {
                        Horoscope = "Крыса";
                    }
                    else if (Year == 5)
                    {
                        Horoscope = "Бык";
                    }
                    else if (Year == 6)
                    {
                        Horoscope = "Тигр";
                    }
                    else if (Year == 7)
                    {
                        Horoscope = "Кролик";
                    }
                    else if (Year == 8)
                    {
                        Horoscope = "Дракон";
                    }
                    else if (Year == 9)
                    {
                        Horoscope = "Змея";
                    }
                    else if (Year == 10)
                    {
                        Horoscope = "Лошадь";
                    }
                    else if (Year == 11)
                    {
                        Horoscope = "Овца";
                    }
                    TBHeaderResult.Visibility = Visibility.Visible;
                    TBlResult.Text = "Знак по восточному гороскопу => " + Horoscope;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RBZodiac.IsChecked == true)
                {
                    TBDay.Text = "";
                    TBMonth.Text = "";
                }
                else
                {
                    TBYear.Text = "";
                }
                TBHeaderResult.Visibility = Visibility.Collapsed;
                TBlResult.Text = "Здесь будет результат";
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }

        private void TBYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
