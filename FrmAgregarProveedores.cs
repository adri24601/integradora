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
    public partial class FrmAgregarProveedores : Form
    {
        public FrmAgregarProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            // 1. Validar que no dejen ningún campo vacío
            if (string.IsNullOrEmpty(txtId_Proveedor.Text) || string.IsNullOrEmpty(txtProveedor_Nombre.Text) ||
                string.IsNullOrEmpty(txtProveedor_Empresa.Text) || string.IsNullOrEmpty(txtProveedor_Telefono.Text) ||
                string.IsNullOrEmpty(txtProveedor_Correo.Text) || string.IsNullOrEmpty(txtProveedor_Direccion.Text) ||
                string.IsNullOrEmpty(txtId_Producto2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos necesarios.");
                return;
            }

            // 2. Tu ruta absoluta que ya está probada
            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";

            // 3. Consulta SQL completa con los 4 campos (los signos '?' se sustituyen en orden exacto abajo)
            string consulta = "INSERT INTO Proveedores (Id_Proveedor, Proveedor_Nombre, Proveedor_Empresa, Proveedor_Telefono, Proveedor_Correo, Id_Producto2) VALUES (?, ?, ?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        // Pasamos los parámetros en el mismo orden que aparecen en el INSERT
                        comando.Parameters.AddWithValue("@idproveedor", Convert.ToInt32(txtId_Proveedor.Text));
                        comando.Parameters.AddWithValue("@nombre", txtProveedor_Nombre.Text);
                        comando.Parameters.AddWithValue("@empresa", txtProveedor_Empresa.Text);
                        comando.Parameters.AddWithValue("@telefono", txtProveedor_Telefono.Text);
                        comando.Parameters.AddWithValue("@correo", txtProveedor_Correo.Text);
                        comando.Parameters.AddWithValue("@direccion", txtProveedor_Direccion.Text);
                        comando.Parameters.AddWithValue("@idproducto2", Convert.ToInt32(txtId_Producto2.Text));







                        conexion.Open();
                        comando.ExecuteNonQuery(); // Guarda la fila completa en Access

                        MessageBox.Show("¡Producto agregado con éxito con toda su información!");

                        this.Close(); // Cierra la ventana de captura al terminar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar toda la información: " + ex.Message);
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar este producto de la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.No) return;

            string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adria\Desktop\integradora00\integradora avanzada media\integradora boceto.accdb;";
            string consulta = "DELETE FROM Proveedor WHERE Id_Proveedor = ?";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idproveedor", Convert.ToInt32(txtId_Proveedor.Text));

                        conexion.Open();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado con éxito.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
