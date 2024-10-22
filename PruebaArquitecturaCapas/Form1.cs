using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaArquitecturaCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Modelo_de_negocios.People.Get();

            // aqui llamamos a la capa servicio, despues a la clase service y al metodo get post
            textBox1.Text = Servicios.Service.GetPost();
        }
    }
}
