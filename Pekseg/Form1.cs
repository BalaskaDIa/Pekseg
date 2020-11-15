using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekseg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pekaruk a = (Pekaruk)listBox1.SelectedItem;
            string textbox = a.Nev;
            int textboxar = a.Ar;
            numericUpDown1.Value = textboxar;
            textBox1.Text = textbox;
            
            bool checkbox = a.Laktozmentes;
            if (checkbox)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        private int laktozMentesTermekekSzama(Peksegek a)
        {
            int db = 0;
            foreach (var item in a.GetTermekek())
            {
                if (item.Laktozmentes)
                {
                    db++;
                }
            }
            return db;
        }
        private Pekaruk legdragabb(Peksegek a)
        {
            Pekaruk pekaru = a.GetTermekek()[0];
            foreach (var item in a.GetTermekek())
            {
                if (item.Ar > pekaru.Ar)
                {
                    pekaru = item;
                }
            }
            return pekaru;
        }
        private Pekaruk legolcsobb(Peksegek a)
        {
            Pekaruk pekaruk = a.GetTermekek()[0];
            foreach (var item in a.GetTermekek())
            {
                if (item.Ar < pekaruk.Ar)
                {
                    pekaruk = item;
                }
            }
            return pekaruk;
        }
        private double atlagos(Peksegek a)
        {
            double sum = 0;
            foreach (var item in a.GetTermekek())
            {
                sum += item.Ar;
            }
            double atlagosar = sum / a.GetTermekek().Count;
            return atlagosar;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0 && numericUpDown1.Value > 0 && checkBox1.Checked)
                {
                    string pekaruNev = textBox1.Text;
                    int pekaruAr = Convert.ToInt32(numericUpDown1.Value);
                    bool laktozmentes = true;

                    listBox1.Items.Add(new Pekaruk(pekaruNev, pekaruAr, laktozmentes));
                    textBox1.Clear();
                    numericUpDown1.Value = 0; 
                }
                else if (textBox1.Text.Length > 0 && numericUpDown1.Value > 0 && !checkBox1.Checked)
                {
                    string pekaruNev = textBox1.Text;
                    int pekaruAr = Convert.ToInt32(numericUpDown1.Value);
                    bool laktozmentes = false;

                    listBox1.Items.Add(new Pekaruk(pekaruNev, pekaruAr, laktozmentes));
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0)
                {
                    Peksegek a = new Peksegek(textBox1.Text, DateTime.Now);
                    listBox2.Items.Add(a);
                    listBox4.Items.Add(a);
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Peksegek a = (Peksegek)listBox2.SelectedItem;
            foreach (var item in a.GetTermekek())
            {
                listBox1.Items.Add(item);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                Pekaruk a = (Pekaruk)listBox1.SelectedItem;
                Peksegek peksegek = (Peksegek)listBox2.SelectedItem;
                peksegek.SetTermekek(a);
            }
        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
