using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchiHack
{


    public partial class FormGame : Form
    {

        public void GenerateMap(int red_points, int blue_points, int green_points, int rose_points)
        {
            int start_x = 0;
            int end_x = 0;
            int start_y = 0;
            int end_y = 0;

            //высота и ширина квадрата в пикселях
            int rect_width = 20;
            int rect_height = 20;

            Bitmap bmp1 = new Bitmap(picGame.Width, picGame.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp1);
            g.Clear(Color.Black);
            // Создаем объекты-кисти для закрашивания фигур
            SolidBrush sbRed = new SolidBrush(Color.Red);
            SolidBrush sbGreen = new SolidBrush(Color.Green); //парамагнетик
            SolidBrush sbBlue = new SolidBrush(Color.Blue); //ферромагнетик
            SolidBrush sbRose = new SolidBrush(Color.Purple); //полупроводник




            int x_n = picGame.Width / rect_width;
            int y_n = picGame.Height / rect_height;
            int n_count = x_n * y_n; //количество квадратов

            //красные
            int r_n = 0; //уже закрашено красным
            g.FillRectangle(sbRed, 0, 0, rect_width, rect_height);
            for (int i = 1; i < x_n; i++) //номер квадрата по горизонтали
            {
                for (int j = 0; j <= i; j++) // количество квадратов по диагонали
                {
                    if (r_n < red_points)
                    {
                        start_x = (i - j) * rect_width;
                        end_x = start_x + rect_width;
                        start_y = j * rect_height;
                        end_y = start_y + rect_height;

                        g.FillRectangle(sbRed, start_x, start_y, rect_width, rect_height);
                        r_n++;

                    }
                }
            }


            //синие
            int b_n = 0; //уже закрашено
            g.FillRectangle(sbBlue, picGame.Width - rect_width, 0, rect_width, rect_height);
            for (int i = 1; i < x_n; i++) //номер квадрата по горизонтали
            {
                for (int j = 0; j <= i; j++) // количество квадратов по диагонали
                {
                    if (b_n < blue_points)
                    {
                        start_x = ((x_n-1) - (i - j)) * rect_width;
                        end_x = start_x + rect_width;
                        start_y = j * rect_height;
                        end_y = start_y + rect_height;

                        g.FillRectangle(sbBlue, start_x, start_y, rect_width, rect_height);
                        b_n++;
                    }
                }
            }


            //зеленые
            int g_n = 0; //уже закрашено
            g.FillRectangle(sbGreen, picGame.Width - rect_width, picGame.Height - rect_height, rect_width, rect_height);
            for (int i = 1; i < x_n; i++) //номер квадрата по горизонтали
            {
                for (int j = 0; j <= i; j++) // количество квадратов по диагонали
                {
                    if (g_n < green_points)
                    {
                        start_x = ((x_n - 1) - (i - j)) * rect_width;
                        end_x = start_x + rect_width;
                        start_y = ((y_n - 1) - j) * rect_height;
                        end_y = start_y + rect_height;

                        g.FillRectangle(sbGreen, start_x, start_y, rect_width, rect_height);
                        g_n++;
                    }
                }
            }


            //розовые
            int p_n = 0; //уже закрашено
            g.FillRectangle(sbRose, 0, picGame.Height - rect_height, rect_width, rect_height);
            for (int i = 1; i < x_n; i++) //номер квадрата по горизонтали
            {
                for (int j = 0; j <= i; j++) // количество квадратов по диагонали
                {
                    if (p_n < rose_points)
                    {
                        start_x = (i - j) * rect_width;
                        end_x = start_x + rect_width;
                        start_y = ((y_n - 1) - j) * rect_height;
                        end_y = start_y + rect_height;

                        g.FillRectangle(sbRose, start_x, start_y, rect_width, rect_height);
                        p_n++;
                    }
                }
            }


            picGame.Image = bmp1;
        }

        public HashSet<FormMain.QuestAnswers> quests = new HashSet<FormMain.QuestAnswers>();
        public int step = 0;

        //текущий этап игры: показ вопроса / показ правильного ответа
        public string gameAction = "answer";

        public int red_points = 0;
        public int blue_points = 0;
        public int green_points = 0;
        public int rose_points = 0;

        public FormGame(HashSet<FormMain.QuestAnswers> questsFrom)
        {
            InitializeComponent();
            quests = questsFrom;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //Следующий вопрос
            FormMain.QuestAnswers item = quests.Skip(step).First();

            lblResult.Text = item.quest;

            rbBlue1.Text = item.answ1.Replace("+", string.Empty);
            rbBlue1.Checked = false;
            rbBlue2.Text = item.answ2.Replace("+", string.Empty);
            rbBlue2.Checked = false;
            rbBlue3.Text = item.answ3.Replace("+", string.Empty);
            rbBlue3.Checked = false;
            rbBlue4.Text = item.answ4.Replace("+", string.Empty);
            rbBlue4.Checked = false;

            rbRed1.Text = item.answ1.Replace("+", string.Empty);
            rbRed1.Checked = false;
            rbRed2.Text = item.answ2.Replace("+", string.Empty);
            rbRed2.Checked = false;
            rbRed3.Text = item.answ3.Replace("+", string.Empty);
            rbRed3.Checked = false;
            rbRed4.Text = item.answ4.Replace("+", string.Empty);
            rbRed4.Checked = false;

            rbGreen1.Text = item.answ1.Replace("+", string.Empty);
            rbGreen1.Checked = false;
            rbGreen2.Text = item.answ2.Replace("+", string.Empty);
            rbGreen2.Checked = false;
            rbGreen3.Text = item.answ3.Replace("+", string.Empty);
            rbGreen3.Checked = false;
            rbGreen4.Text = item.answ4.Replace("+", string.Empty);
            rbGreen4.Checked = false;

            rbRose1.Text = item.answ1.Replace("+", string.Empty);
            rbRose1.Checked = false;
            rbRose2.Text = item.answ2.Replace("+", string.Empty);
            rbRose2.Checked = false;
            rbRose3.Text = item.answ3.Replace("+", string.Empty);
            rbRose3.Checked = false;
            rbRose4.Text = item.answ4.Replace("+", string.Empty);
            rbRose4.Checked = false;

            gameAction = "answer";
            GenerateMap(red_points, blue_points, green_points, rose_points);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (step >= quests.Count)
            {
                string best_command = "";
                if ((red_points>blue_points) && (red_points > green_points) && (red_points > rose_points)) {
                    best_command = "Красные!";
                }
                if ((blue_points > red_points) && (blue_points > green_points) && (blue_points > rose_points))
                {
                    best_command = "Синие!";
                }
                if ((green_points > blue_points) && (green_points > red_points) && (green_points > rose_points))
                {
                    best_command = "Зеленые!";
                }
                if ((rose_points > blue_points) && (rose_points > green_points) && (rose_points > red_points))
                {
                    best_command = "Пурпурные";
                }

                FormPrize frmPrize = new FormPrize(best_command);
                frmPrize.Show();
                this.Hide();

            }


            else if (gameAction == "answer")
            {
                FormMain.QuestAnswers item = quests.Skip(step).First();

                string true_answ = "";
                if (item.answ1.IndexOf("+") != -1)
                {
                    true_answ = item.answ1;
                }
                if (item.answ2.IndexOf("+") != -1)
                {
                    true_answ = item.answ2;
                }
                if (item.answ3.IndexOf("+") != -1)
                {
                    true_answ = item.answ3;
                }
                if (item.answ4.IndexOf("+") != -1)
                {
                    true_answ = item.answ4;
                }
                string true_answ_text = true_answ.Replace("+", string.Empty);


                lblResult.Text = "Правильный ответ: " + true_answ_text;

                int is_blue = 0;
                //подсвечиваем правильные ответы
                if ((rbBlue1.Checked) && (rbBlue1.Text == true_answ_text))
                {
                    is_blue = 1;
                    rbBlue1.BackColor = Color.Green;
                }
                if ((rbBlue2.Checked) && (rbBlue2.Text == true_answ_text))
                {
                    is_blue = 1;
                    rbBlue2.BackColor = Color.Green;
                }
                if ((rbBlue3.Checked) && (rbBlue3.Text == true_answ_text))
                {
                    is_blue = 1;
                    rbBlue3.BackColor = Color.Green;
                }
                if ((rbBlue4.Checked) && (rbBlue4.Text == true_answ_text))
                {
                    is_blue = 1;
                    rbBlue4.BackColor = Color.Green;
                }

                //подсвечиваем неправильные ответы
                if ((rbBlue1.Checked) && (rbBlue1.Text != true_answ_text))
                {
                    rbBlue1.BackColor = Color.Red;
                }
                if ((rbBlue2.Checked) && (rbBlue2.Text != true_answ_text))
                {
                    rbBlue2.BackColor = Color.Red;
                }
                if ((rbBlue3.Checked) && (rbBlue3.Text != true_answ_text))
                {
                    rbBlue3.BackColor = Color.Red;
                }
                if ((rbBlue4.Checked) && (rbBlue4.Text != true_answ_text))
                {
                    rbBlue4.BackColor = Color.Red;
                }


                int is_red = 0;
                //подсвечиваем правильные ответы
                if ((rbRed1.Checked) && (rbRed1.Text == true_answ_text))
                {
                    is_red = 1;
                    rbRed1.BackColor = Color.Green;
                }
                if ((rbRed2.Checked) && (rbRed2.Text == true_answ_text))
                {
                    is_red = 1;
                    rbRed2.BackColor = Color.Green;
                }
                if ((rbRed3.Checked) && (rbRed3.Text == true_answ_text))
                {
                    is_red = 1;
                    rbRed3.BackColor = Color.Green;
                }
                if ((rbRed4.Checked) && (rbRed4.Text == true_answ_text))
                {
                    is_red = 1;
                    rbRed4.BackColor = Color.Green;
                }

                //подсвечиваем неправильные ответы
                if ((rbRed1.Checked) && (rbRed1.Text != true_answ_text))
                {
                    rbRed1.BackColor = Color.Red;
                }
                if ((rbRed2.Checked) && (rbRed2.Text != true_answ_text))
                {
                    rbRed2.BackColor = Color.Red;
                }
                if ((rbRed3.Checked) && (rbRed3.Text != true_answ_text))
                {
                    rbRed3.BackColor = Color.Red;
                }
                if ((rbRed4.Checked) && (rbRed4.Text != true_answ_text))
                {
                    rbRed4.BackColor = Color.Red;
                }


                int is_green = 0;
                //подсвечиваем правильные ответы
                if ((rbGreen1.Checked) && (rbGreen1.Text == true_answ_text))
                {
                    is_green = 1;
                    rbGreen1.BackColor = Color.Green;
                }
                if ((rbGreen2.Checked) && (rbGreen2.Text == true_answ_text))
                {
                    is_green = 1;
                    rbGreen2.BackColor = Color.Green;
                }
                if ((rbGreen3.Checked) && (rbGreen3.Text == true_answ_text))
                {
                    is_green = 1;
                    rbGreen3.BackColor = Color.Green;
                }
                if ((rbGreen4.Checked) && (rbGreen4.Text == true_answ_text))
                {
                    is_green = 1;
                    rbGreen4.BackColor = Color.Green;
                }

                //подсвечиваем неправильные ответы
                if ((rbGreen1.Checked) && (rbGreen1.Text != true_answ_text))
                {
                    rbGreen1.BackColor = Color.Red;
                }
                if ((rbGreen2.Checked) && (rbGreen2.Text != true_answ_text))
                {
                    rbGreen2.BackColor = Color.Red;
                }
                if ((rbGreen3.Checked) && (rbGreen3.Text != true_answ_text))
                {
                    rbGreen3.BackColor = Color.Red;
                }
                if ((rbGreen4.Checked) && (rbGreen4.Text != true_answ_text))
                {
                    rbGreen4.BackColor = Color.Red;
                }



                int is_rose = 0;
                //подсвечиваем правильные ответы
                if ((rbRose1.Checked) && (rbRose1.Text == true_answ_text))
                {
                    is_rose = 1;
                    rbRose1.BackColor = Color.Green;
                }
                if ((rbRose2.Checked) && (rbRose2.Text == true_answ_text))
                {
                    is_rose = 1;
                    rbRose2.BackColor = Color.Green;
                }
                if ((rbRose3.Checked) && (rbRose3.Text == true_answ_text))
                {
                    is_rose = 1;
                    rbRose3.BackColor = Color.Green;
                }
                if ((rbRose4.Checked) && (rbRose4.Text == true_answ_text))
                {
                    is_rose = 1;
                    rbRose4.BackColor = Color.Green;
                }

                //подсвечиваем неправильные ответы
                if ((rbRose1.Checked) && (rbRose1.Text != true_answ_text))
                {
                    rbRose1.BackColor = Color.Red;
                }
                if ((rbRose2.Checked) && (rbRose2.Text != true_answ_text))
                {
                    rbRose2.BackColor = Color.Red;
                }
                if ((rbRose3.Checked) && (rbRose3.Text != true_answ_text))
                {
                    rbRose3.BackColor = Color.Red;
                }
                if ((rbRose4.Checked) && (rbRose4.Text != true_answ_text))
                {
                    rbRose4.BackColor = Color.Red;
                }


                //количество правильных ответов
                int true_count = is_blue + is_green + is_red + is_rose;
                int summary_points = 5 - true_count;

                if (is_blue == 1)
                {
                    blue_points = blue_points + summary_points;
                }

                if (is_red == 1)
                {
                    red_points = red_points + summary_points;
                }

                if (is_green == 1)
                {
                    green_points = green_points + summary_points;
                }

                if (is_rose == 1)
                {
                    rose_points = rose_points + summary_points;
                }

                groupBox2.Text = "Красные: " + red_points.ToString();
                groupBox3.Text = "Синие: " + blue_points.ToString();
                groupBox4.Text = "Зеленые: " + green_points.ToString();
                groupBox5.Text = "Пурпурные: " + rose_points.ToString();

                GenerateMap(red_points, blue_points, green_points, rose_points);

                gameAction = "quest";

                step++;
                if (step >= quests.Count)
                {
                    btnCheck.Text = "Результаты";
                }
                else
                {
                    btnCheck.Text = "Следующий вопрос";
                }


            }





            else if (gameAction == "quest")
            {
                FormMain.QuestAnswers item = quests.Skip(step).First();

                lblResult.Text = item.quest;

                rbBlue1.Checked = false;
                rbBlue2.Checked = false;
                rbBlue3.Checked = false;
                rbBlue4.Checked = false;

                rbRed1.Checked = false;
                rbRed2.Checked = false;
                rbRed3.Checked = false;
                rbRed4.Checked = false;

                rbGreen1.Checked = false;
                rbGreen2.Checked = false;
                rbGreen3.Checked = false;
                rbGreen4.Checked = false;

                rbRose1.Checked = false;
                rbRose2.Checked = false;
                rbRose3.Checked = false;
                rbRose4.Checked = false;

                rbBlue1.Text = item.answ1.Replace("+", string.Empty);
                rbBlue1.BackColor = Color.Transparent;
                rbBlue2.Text = item.answ2.Replace("+", string.Empty);
                rbBlue2.BackColor = Color.Transparent;
                rbBlue3.Text = item.answ3.Replace("+", string.Empty);
                rbBlue3.BackColor = Color.Transparent;
                rbBlue4.Text = item.answ4.Replace("+", string.Empty);
                rbBlue4.BackColor = Color.Transparent;

                rbRed1.Text = item.answ1.Replace("+", string.Empty);
                rbRed1.BackColor = Color.Transparent;
                rbRed2.Text = item.answ2.Replace("+", string.Empty);
                rbRed2.BackColor = Color.Transparent;
                rbRed3.Text = item.answ3.Replace("+", string.Empty);
                rbRed3.BackColor = Color.Transparent;
                rbRed4.Text = item.answ4.Replace("+", string.Empty);
                rbRed4.BackColor = Color.Transparent;

                rbGreen1.Text = item.answ1.Replace("+", string.Empty);
                rbGreen1.BackColor = Color.Transparent;
                rbGreen2.Text = item.answ2.Replace("+", string.Empty);
                rbGreen2.BackColor = Color.Transparent;
                rbGreen3.Text = item.answ3.Replace("+", string.Empty);
                rbGreen3.BackColor = Color.Transparent;
                rbGreen4.Text = item.answ4.Replace("+", string.Empty);
                rbGreen4.BackColor = Color.Transparent;

                rbRose1.Text = item.answ1.Replace("+", string.Empty);
                rbRose1.BackColor = Color.Transparent;
                rbRose2.Text = item.answ2.Replace("+", string.Empty);
                rbRose2.BackColor = Color.Transparent;
                rbRose3.Text = item.answ3.Replace("+", string.Empty);
                rbRose3.BackColor = Color.Transparent;
                rbRose4.Text = item.answ4.Replace("+", string.Empty);
                rbRose4.BackColor = Color.Transparent;

                btnCheck.Text = "Проверить";
                gameAction = "answer";


            }





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
