using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace Bermes
{
    public partial class Form1 : Form
    {
        public Size _pictOriginalSize;

        public Form1()
        {
            InitializeComponent();
            _pictOriginalSize = picture.Size;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 1000;
            Key = Posledo_vvod.Text;
            c = new byte[count];
        }
        /// <summary>
        /// Алгоритм Берлекемпа-Месси
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rasschit_algor_Click(object sender, EventArgs e)
        {
            //очистка всего содержимого
            Per.Clear();
            Polinom_CD.Clear();
            Kol_L.Clear();
            dataGridView1.Rows.Clear();
            LabelPosl.Text = "";
            k30 = 0;
            plus1 = 0;
            d = 0;
            count = 0;
            T = 0;
            psi = 0;
            per = 0;
            int j = 0;
            int t = 0;
            int numbtd = 0;

            Key = Posledo_vvod.Text;
            try
            {
                //Проверка
                if (Key.Length == 0)
                {
                    Posledo_vvod.Clear();
                    throw new Exception("Введите последовательность");
                }
                if (Key=="01" || Key=="10")
                {
                    throw new Exception("Детские последовательности, введите последовательность побольше");
                }
                for (int i = 0; i < Key.Length; i++)
                {
                    if (Key[i] == 0 && Key[i] == 1)
                    {
                        throw new Exception("Последовательность должна состоять из 0 и 1");
                    }
                }
                //Заполнение начальных сосотояний
                count = Key.Count();
                Sost = new byte[count];
                for (int i = 0; i < Sost.Length; i++)
                {
                    Sost[i] = Convert.ToByte(new string(Key.Substring(i, 1).ToArray()), 2);
                }
                c = new byte[count];
                td = new byte[count];
                bd = new byte[count];
                for (int i = 0; i < count; i++)
                {
                    c[i] = bd[i] = td[i] = 0;
                }
                c[0] = bd[0] = 1;
                N = L = 0;
                m = -1;
                new_sost = new byte[L];
                //Дата грид
                dataGridView1.RowCount = Sost.Length + 2;//сколько строк в таблице
                //SN-1
                dataGridView1.Rows[0].Cells[0].Value = "-";
                //SN-1(со второй строки)
                for (int i = 0; i < Sost.Length; i++)
                {
                    dataGridView1.Rows[i + 1].Cells[0].Value = Sost[i].ToString();
                }
                //delta-1
                dataGridView1.Rows[0].Cells[1].Value = "-";
                //TX-2
                dataGridView1.Rows[t].Cells[2].Value = "-";
                //CX-3
                dataGridView1.Rows[t].Cells[3].Value = 1;
                //L-4
                dataGridView1.Rows[t].Cells[4].Value = 0;
                //m-5
                dataGridView1.Rows[t].Cells[5].Value = -1;
                //BX-6
                dataGridView1.Rows[t].Cells[6].Value = 1;
                //№-7
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[7].Value = i;
                }
                t++;
                //алгоритм
                while (N < Sost.Length)
                {
                    d = 0;
                    psi = 0;
                    l.Add(L);
                    for (int i = 1; i <= L; i++)
                    {
                        psi ^= Sost[N - i] * c[i];
                    }
                    d = Sost[N] ^ psi;
                    del.Add(d);
                    //delta-1
                    dataGridView1.Rows[j + 1].Cells[1].Value = del[j].ToString();
                    j++;
                    if (d != 0)
                    {
                        td = (byte[])c.Clone();
                        for (int i = 0; i <= Sost.Length + m - 1 - N; i++)
                        {
                            c[N - m + i] = (byte)(c[N - m + i] ^ bd[i]);
                        }
                        if (L <= (N / 2))
                        {
                            L = N + 1 - L;
                            m = N;
                            bd = (byte[])td.Clone();
                        }
                    }
                    if (t == dataGridView1.RowCount)
                    {
                        break;
                    }
                    //Проверка
                    if (L == 0 & d == 0)
                    {
                        dataGridView1.Rows[t].Cells[2].Value = 0;
                        goto tx;
                    }
                    for (int i = 0; i < L; i++)
                    {
                        if (td[i] == 1)
                        {
                            numbtd = i;
                        }
                    }

                    //TX-2
                    for (int i = 0; i <= numbtd; i++)
                    {
                        dataGridView1.Rows[t].Cells[2].Value += td[i].ToString();
                    }
                tx:
                    //CX-3
                    if (L == 0 & d == 0)
                    {
                        dataGridView1.Rows[t].Cells[3].Value = 1;
                        goto c;
                    }
                    for (int i = 0; i <= L; i++)
                    {
                        if (c[i] == 1)
                        {
                            numbtd = i;
                        }
                    }
                    for (int i = 0; i <= numbtd; i++)
                    {
                        dataGridView1.Rows[t].Cells[3].Value += c[i].ToString();
                    }
                c:
                    //L-4
                    dataGridView1.Rows[t].Cells[4].Value = L.ToString();
                    //m-5
                    dataGridView1.Rows[t].Cells[5].Value = m.ToString();

                    //BX-6
                    if (L == 0)
                    {
                        dataGridView1.Rows[t].Cells[6].Value = 1;
                        goto bx;
                    }


                    for (int i = 0; i < L; i++)
                    {
                        if (bd[i] == 1)
                        {
                            numbtd = i;
                        }
                    }

                    for (int i = 0; i <= numbtd; i++)
                    {
                        dataGridView1.Rows[t].Cells[6].Value += bd[i].ToString();
                    }
                bx:
                    t++;
                    mas.Add(m);
                    N++;
                }
                //Заполнение поля С(X)
                int numb = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == 1)
                    {
                        numb = i;
                    }
                }
                for (int i = 0; i <= numb; i++)
                {
                    Polinom_CD.Text += c[i];
                }

                //Заполнение исходного состояния
                new_sost = new byte[L];
                int o = L - 1;
                for (int i = 0; i < L; ++i)
                {
                    new_sost[i] = Sost[o];//создание нового массива размером L и перевернутого
                    o--;
                }
                for (int i = L - 1; i >= 0; --i)
                {
                    LabelPosl.Text += Sost[i];
                }
                //Заполнение сложности
                Kol_L.Text += L;

                if (L == 0) throw new Exception("Дружок, это запрещенная комбинация");
                //алгоритм регистра 
                T = 0;
                while (T != Sost.Length)
                {
                    for (int i = 0; i < L; i++)
                    {
                        if (c[i + 1] == 1)
                        {
                            per ^= new_sost[i];//расчет элемента который встанет на 1 место

                        }
                    }
                    for (int i = L - 1; i > 0; --i)
                    {
                        new_sost[i] = new_sost[i - 1];//сдвиг регистра
                    }

                    ++T;
                    new_sost[0] = (byte)per;//присваивание нового элемента на 1 место
                    per = 0;
                }
                //Заполнение периода
                Per.Text += T;

                //Отрисовка
                try
                {
                    if (Posledo_vvod.Text == "" && c.Length == 0)
                    {
                        throw new Exception("Введите последовательность");
                    }
                    picture.Controls.Clear();
                    TextBox[] pan = new TextBox[L];
                    new_sost = new byte[L];
                    int p = L - 1;
                    //создает массив
                    for (int i = 0; i < L; ++i)
                    {
                        new_sost[i] = Sost[p];
                        p--;
                    }
                    //создает элементы 
                    for (int i = 0; i < L; i++)
                    {
                        pan[i] = new TextBox();
                        pan[i].Text = new_sost[i].ToString();
                        pan[i].Width = 50;
                        pan[i].Height = 50;
                        pan[i].Multiline = true;
                        pan[i].ReadOnly = true;
                        pan[i].TextAlign = HorizontalAlignment.Center;
                        pan[i].Location = new Point(60 + k30, 150);
                        k30 += 80;
                        picture.Controls.Add(pan[i]);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Это отрисовочка");
                }
                picture.Paint += picture_Paint;
                picture.Refresh();
                picture.Paint -= picture_Paint;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void picture_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (Key == "")
                {
                    throw new Exception();
                }
                Bitmap bmp = new Bitmap(panel3.Width, panel3.Height);
                gr = e.Graphics;
                Pen pen = new Pen(Color.Red);
                gr.Clear(Color.White);
                //нахождение последней единицы в массиве c[]
                int number1 = 0;
                for (int w = 0; w < c.Length; w++)
                {
                    if (c[w] == 1)
                    {
                        number1 = w;
                    }
                }
                if (Key == "10")
                {
                    gr.DrawLine(pen, 10, 105, 210, 105);
                    gr.DrawLine(pen, 210, 105, 210, 175);
                }
                //прямые линии
                if (c.Length != 0)
                {
                    gr.DrawLine(pen, 110, 175, 110 + L * 30 + (L - 1) * 50, 175);

                    gr.DrawLine(pen, 60, 175, 10, 175);
                    gr.DrawLine(pen, 10, 175, 10, 105);

                    //стрелка перед первым регистром
                    gr.DrawLine(pen, 60, 175, 53, 178);
                    gr.DrawLine(pen, 60, 175, 53, 172);
                    //стрелка в конце
                    gr.DrawLine(pen, 110 + L * 30 + (L - 1) * 50, 175, 110 + L * 30 + (L - 1) * 50 - 6, 178);
                    gr.DrawLine(pen, 110 + L * 30 + (L - 1) * 50, 175, 110 + L * 30 + (L - 1) * 50 - 6, 172);
                }
                for (int i = 1; i < L + 1; i++)
                {
                    if (c[i] == 1)
                    {
                        if (number1 == i)
                        {
                            plus1 = 80 * i;
                            gr.DrawLine(pen, 45 + plus1, 175, 45 + plus1, 105);
                            gr.DrawLine(pen, 45 + plus1, 105, 10, 105);
                            break;
                        }
                        plus1 = 80 * i;
                        gr.DrawEllipse(pen, new Rectangle(40 + plus1, 100, 10, 10));
                        gr.DrawLine(pen, 40 + plus1, 105, 50 + plus1, 105);
                        //стрелки
                        gr.DrawLine(pen, 50 + plus1, 105, 50 + plus1 + 3, 102);
                        gr.DrawLine(pen, 50 + plus1, 105, 50 + plus1 + 3, 108);
                        //
                        gr.DrawLine(pen, 45 + plus1, 100, 45 + plus1, 110);
                        gr.DrawLine(pen, 45 + plus1, 175, 45 + plus1, 110);
                        //линия
                    }
                }
                pen.Dispose();
            }
            catch (Exception) { }
        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Size size = SystemInformation.PrimaryMonitorSize;
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
            }
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
            if (this.Location.X + this.Size.Width > size.Width)
            {
                this.Location = new Point(size.Width - this.Size.Width, this.Location.Y);
            }
            if (this.Location.Y + this.Size.Height > size.Height)
            {
                this.Location = new Point(this.Location.X, size.Height - this.Size.Height);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            const double MaxScale = 50.0;

            double scale = Math.Pow(MaxScale, trackBar1.Value / trackBar1.Maximum);

            Size newSize = new Size((int)(_pictOriginalSize.Width * scale),
                           (int)(_pictOriginalSize.Height * scale));

            picture.Size = newSize;
        }
    }
}

