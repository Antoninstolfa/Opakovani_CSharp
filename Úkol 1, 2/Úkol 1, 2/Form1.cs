using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_1__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        void Vypis(List<int> List1, ListBox listboxik) // ok
        {
            foreach (int cisla in List1)
            {
                listboxik.Items.Add(cisla);
            }
        }
        int DruheMax(List<int> List1) // ok
        {
            int Max = int.MinValue;
            int druheMax = 0;
            foreach (int cislo in List1)
            {
                if(cislo > Max)
                {
                    druheMax = Max;
                    Max = cislo;
                }
            }
            return druheMax;
        }

        bool Dokonale(int cislo) // dodelat
        {
            int delitel = 1;
            int soucetdelitelu = 0;
            while (delitel < cislo)
            {
                if(cislo % delitel == 0)
                {
                    soucetdelitelu += delitel;
                }
                delitel++;
            }
            if (soucetdelitelu == cislo)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        void VymazDokonale(List<int> List1) // dodelat
        {
            /*foreach(int cislo in List1)
            {
                if(Dokonale(cislo) == true)
                {
                    List1.Remove(cislo);
                }
            }*/
            for (int i = 0; i < List1.Count(); i++)
            {
                if (Dokonale(List1[i]))
                {
                    List1.Remove(List1[i]);
                }
            }
        }
        int CifernySoucet(List<int> List1)
        {
            int Max = int.MinValue;
            foreach(int cislo in List1)
            {
                if(cislo > Max)
                {
                    Max = cislo;
                }
            }
            int soucet = 0;
            while(Max > 1)
            {
                soucet += Convert.ToInt32(Max % 10);
                Max /= 10;
            }
            return soucet;
        }

        List<int> list = new List<int>();
        List<char> znaky = new List<char>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.Clear();
                int N = Convert.ToInt32(textBox1.Text);
                if(N<1)
                {
                    MessageBox.Show("N musí být větší než 0!!!!!!!!");
                }
                else
                {
                    int cislo;
                    int i = 0;
                    Random rng = new Random();
                    while (N != 0)
                    {
                        cislo = rng.Next(-4, 100);
                        list.Add(cislo);
                        N--;
                        i++;
                    }
                    Vypis(list, listBox1);
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            VymazDokonale(list);
            Vypis(list, listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            list.Sort();
            Vypis(list, listBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double soucet = 0;
                double pocet = list.Count();
                double vysledek = 0.0;
                foreach (int cislo in list)
                {
                    soucet += cislo;
                }
                vysledek = soucet / pocet;
                APOdpoved.Text = vysledek.ToString();
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            if(N<2)
            {
                MaxOdpoved.Text = "Není";
            }
            else
            {
                MaxOdpoved.Text = DruheMax(list).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Max = int.MinValue;
            foreach(int cislo in list)
            {
                if(cislo > Max)
                {
                    Max = cislo;
                }
            }
            MaxOdpoved2.Text = Max.ToString();
            CSoucetOdpoved.Text = CifernySoucet(list).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            znaky.Clear();
            listBox4.Items.Clear();
            for (int i = 0; i < list.Count(); i++)
            {
                char znak = Convert.ToChar(list[i]);
                if (znak >= 'A' && znak <= 'Z')
                {
                    znaky.Add(znak);
                }
                else
                {
                    znaky.Add('*');
                } 
                listBox4.Items.Add(znaky[i]);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gold;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LawnGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gold;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.LawnGreen;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Gold;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.LawnGreen;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Gold;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.LawnGreen;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Gold;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.LawnGreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Violet;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.LawnGreen;
        }
    }
}
