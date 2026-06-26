using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;

namespace integra_1
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //ruta 
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            //consulta a SQL para traer los "productos"
            // En lugar de usar el asterisco (*), escribe las columnas de texto y números separadas por comas
            string consulta = "SELECT * FROM Productos";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    //adaptador sirve como puente , hace la consulta y se enarga de abrir/cerrar la conexion solo
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    //creamos tabla en memoria para guardar lo que traiga Access
                    System.Data.DataTable tablaProductos = new System.Data.DataTable();

                    // Llenamos la tabla en memoria con los datos
                    adaptador.Fill(tablaProductos);

                    //decir a DataGridView que su fuente de datos es la tabla de acces
                    dgvProductos.DataSource = tablaProductos;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:  " + ex.Message);
            }

        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Esto le dice al DataGridView: "Si encuentras una imagen extraña, no lances nigun cartel de error"
            e.ThrowException = false;
        }
    }
}
