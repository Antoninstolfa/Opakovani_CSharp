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

        void Vypis(List<int> List1, ListBox listboxik) // budto vypis nebo cyklus je spatne, o jedno mene
        {
            for(int i = 1; i < List1.Count(); i++)
            {
                listboxik.Items.Add(List1[i]);
            }
        }
        int DruheMax(int cislo, int N, int Max) // dodelat na druhe
        {
            while(N != 0)
            {
                if(cislo > Max)
                {
                    Max = cislo;
                }
                N--;
            }
            return Max;
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
        void VymazDokonale() // dodelat
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int N = Convert.ToInt32(textBox1.Text);
            List<int> list = new List<int>();
            int Max = int.MinValue;
            int cislo;
            int i = 0;
            Random rng = new Random();
            while(N != 0)
            {
                cislo = rng.Next(-5, 99);
                list.Add(cislo);
                MaxOdpoved.Text = DruheMax(cislo, N, Max).ToString();
                N--;
                i++;
            }
            Vypis(list, listBox1);
        }
    }
}
