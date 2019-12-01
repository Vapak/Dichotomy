using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace Dichotomy
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            graph.Enabled = false;
        }

        private void Cout()
        {
            Class1 clas = new Class1();
            try
            {
                Data.formula = fx_TB.Text;
                clas.CalculateIter(a_TB.Text, b_TB.Text, e_TB.Text, Data.formula);
                MessageBox.Show(Data.ans.ToString());
            }
            catch
            {
                MessageBox.Show("Данные заданы неверно!");
            }
            
        }

        private void go_Click(object sender, EventArgs e)
        {
            graph.Enabled = true;
            Cout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void graph_Click(object sender, EventArgs e)
        {
            Graphic graph = new Graphic();
            graph.Show();
        }

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start(@"README.txt");
        }
    }
}
