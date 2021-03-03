using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transaccionesBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexionDB conectandose = new ConexionDB();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.Transferir(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
