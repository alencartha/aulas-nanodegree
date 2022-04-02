using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            int tabuada = Convert.ToInt32(numerotextBox1.Text);

            for (int i = 1; i <= 10; i++)

            {
                string linha = string.Format("{0} x {1} = {2}", tabuada, i, (tabuada * i)); 
                resultadoListBox.Items.Add(linha);
            }

        }
    }
}
