using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Classwork01042022
{
    public partial class Support_Form : Form
    {
        Main_Form main_form = new Main_Form();
        public Support_Form()
        {
            InitializeComponent();
        }

        private void button_Ready_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                main_form.Show();
                Data.Name = textBox1.Text;
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Вы не ввели имя");
            }
        }
    }
}
