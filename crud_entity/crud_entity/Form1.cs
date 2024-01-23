using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrincEmpresa form = new FormPrincEmpresa();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincEmpleado form = new FormPrincEmpleado();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPrincCargo form = new FormPrincCargo();
            form.ShowDialog();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPrincCargoEmpleado form = new FrmPrincCargoEmpleado();
            form.ShowDialog();  
        }
    }
}
