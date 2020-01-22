using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace limpia
{
    public partial class Form1 : Form
    {

        datos dato = new datos();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Creado por: Marco Antonio Castillo Escorza");
            this.Close();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dato.detener();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dato.limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dato.iniciar();
        }
    }
}
