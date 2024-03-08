using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinaria
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio regresar = new Inicio();
            this.Hide();//Nos ocultara la pestaña AdminMenu para mostrar otra pestaña.
            regresar.Show();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creacion crear = new Creacion();
            //No utilizaremos el this.hide para ocultar la pestaña.
            //Pero si utilizare el ShowDialog para darle prioridad a esa pestaña.
            crear.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminBuscar buscador = new adminBuscar();
            buscador.ShowDialog();
        }
    }
}
