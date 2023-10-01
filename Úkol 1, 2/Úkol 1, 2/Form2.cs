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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void PoslPrvocislo(int[] pole, out int prvocislo, out int index)
        {
            prvocislo = 0;
            index = 0;
            bool konec = false;
            for (int i = 0; i < pole.Count(); i++)
            {
                konec = false;
                int cislo = pole[i];
                if (cislo != 1)
                {
                    if (cislo != 2)
                    {


                        for (int delitel = 2; delitel <= (int)Math.Sqrt(cislo); ++delitel)
                        {
                            if (cislo % delitel == 0)
                            {
                                konec = false;
                                break;
                            }
                            else konec = true;
                        }
                    }
                    else if (cislo == 2) konec = true;
                }
                if (konec)
                {
                    prvocislo = cislo;
                    index = i;
                }
            }
        }

        void Vymen(int[] pole)
        {
            int indexposledni = pole.Count();
            int prvni = pole[0];
            int posledni = pole[indexposledni-1];
            pole[0] = posledni;
            pole[indexposledni-1] = prvni;
        }

        void Vypis(int[] pole, ListBox listboxik)
        {
            foreach(int cislo in pole)
            {
                listboxik.Items.Add(cislo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                int N = Convert.ToInt32(numericUpDown1.Value);
                int index, prvocislo;
                Random rng = new Random();
                int[] pole = new int[N];
                for (int i = 0; i < N; i++)
                {
                    pole[i] = rng.Next(1, 25);
                }
                Vypis(pole, listBox1);
                PoslPrvocislo(pole, out prvocislo, out index);
                label5.Text = Convert.ToString(prvocislo) + " o indexu: " + Convert.ToString(index);
                Vymen(pole);
                Vypis(pole, listBox2);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Violet;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }

      
    }
}
