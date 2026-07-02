using System;  // Contiene funciones basicas de C#
using System.Collections.Generic;   // Permite usar colecciones como List y Dictionary
using System.ComponentModel;     // Proporciona clases para componentes y propiedades
using System.Data;  // Permite trabajar con datos y bases de datos
using System.Drawing;  // Permite usar colores, imágenes y fuentes
using System.Text;   // Contiene clases para manipular texto
using System.Windows.Forms;  // Biblioteca para crear aplicaciones Windows Forms
             
namespace integra_1
{
    // namespace - sirve para organizar el código
    // integra_1 - nombre del proyecto donde se encuentra la clase

    public partial class FrmDashboard : Form  // Constructor del formulario
    {
        public FrmDashboard()
        {
            InitializeComponent();   // Inicializa todos los controles del formulario
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.Show();
            this.Hide();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // duda 
            // boton no visible 
            // formulario creado
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.Show();
            this.Hide();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            FrmCerrar_Sesión frm = new FrmCerrar_Sesión();
            frm.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
