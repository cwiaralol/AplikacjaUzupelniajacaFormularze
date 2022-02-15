using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaUzupelniajacaFormularze
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

    

    }


        private void button1_Click(object sender, EventArgs e)
        {
            Program.imie = textBox1.Text;
            Program.nazwisko = textBox2.Text;
            Program.datax = textBox3.Text;
            Program.miejscowosc = textBox4.Text;

            if (Dokument1.CheckState == CheckState.Checked)
            {
                Program.d1 = true;
            }
            else Program.d1 = false;


            if (Dokument2.CheckState == CheckState.Checked)
            {
                Program.d2 = true;
            }
            else Program.d2 = false;

            if (Dokument3.CheckState == CheckState.Checked)
            {
                Program.d3 = true;
            }
            else Program.d3 = false;





            MessageBox.Show("Dokumenty uzupełnione !");
            Application.Restart();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
