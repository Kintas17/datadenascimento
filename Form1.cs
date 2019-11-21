using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datadenascimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.recebe = textBox1.Text;
            label2.Text = cunha.envia2;
            cunha.recebe = textBox1.Text;
            label1.Text = cunha.envia;
            cunha.recebe = textBox1.Text;
            label3.Text = cunha.envia3;
        }
        Class1 cunha = new Class1();
        private void Label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
