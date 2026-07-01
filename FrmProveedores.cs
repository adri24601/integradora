using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace integra_1
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            //ruta 
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            //consulta a SQL para traer los "productos"
            // En lugar de usar el asterisco (*), escribe las columnas de texto y números separadas por comas
            string consulta = "SELECT * FROM Proveedores";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    //adaptador sirve como puente , hace la consulta y se enarga de abrir/cerrar la conexion solo
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);

                    //creamos tabla en memoria para guardar lo que traiga Access
                    System.Data.DataTable tablaProvedores = new System.Data.DataTable();

                    // Llenamos la tabla en memoria con los datos
                    adaptador.Fill(tablaProvedores);

                    //decir a DataGridView que su fuente de datos es la tabla de acces
                    dgvProveedores.DataSource = tablaProvedores;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:  " + ex.Message);
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya una fila seleccionada en tu tabla
            if (dgvProveedores.CurrentRow != null)
            {
                // 2. Creamos la instancia usando el nombre real de tu ventana
                FrmAgregarProveedores ventanaEdicion = new FrmAgregarProveedores();

                // 3. Rellenamos los campos de la ventana emergente con lo seleccionado en la tabla
                // (Revisa que los nombres de las celdas ["Id_Producto"], etc., sean exactamente los de tu Access)
                ventanaEdicion.txtId_Proveedor.Text = dgvProveedores.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
                ventanaEdicion.txtProveedor_Nombre.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Nombre"].Value.ToString();
                ventanaEdicion.txtProveedor_Empresa.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Empresa"].Value.ToString();
                ventanaEdicion.txtProveedor_Telefono.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Telefono"].Value.ToString();
                ventanaEdicion.txtProveedor_Correo.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Correo"].Value.ToString();
                ventanaEdicion.txtProveedor_Direccion.Text = dgvProveedores.CurrentRow.Cells["Proveedor_Direccion"].Value.ToString();
                ventanaEdicion.txtId_Producto2.Text = dgvProveedores.CurrentRow.Cells["Id_Producto2"].Value.ToString();


                // 4. Mostramos la ventana llena con los datos
                ventanaEdicion.ShowDialog();

                // 5. Al cerrarse, refresca la tabla automáticamente para ver los cambios

            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero un producto de la tabla gris.");
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Asegúrate de que el nombre coincida letra por letra con tu nuevo Form
            FrmAgregarProveedores ventanaAgregar = new FrmAgregarProveedores();
            ventanaAgregar.ShowDialog();

            // Si ya tienes el método para actualizar la tabla, llámalo aquí abajo:

        }

        
    }
}
