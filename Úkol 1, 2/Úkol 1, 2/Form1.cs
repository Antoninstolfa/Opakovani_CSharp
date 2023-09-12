using System;
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
            while (delitel != cislo)
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
            foreach(int cislo in List1)
            {
                if(Dokonale(cislo) == true)
                {
                    List1.Remove(cislo);
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();
            int N = Convert.ToInt32(textBox1.Text);
            int cislo;
            int i = 0;
            Random rng = new Random();
            while(N != 0)
            {
                cislo = rng.Next(-5, 99);
                list.Add(cislo);
                N--;
                i++;
            }
            Vypis(list, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            VymazDokonale(list);
            Vypis(list, listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Sort();
            Vypis(list, listBox3);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            MaxOdpoved.Text = DruheMax(list).ToString();
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
            MessageBox.Show("Pardón, více jsem toho bohužel nestihl :(", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
