namespace integra_1
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProductos = new Button();
            btnProveedores = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            btnCerrar_Sesion = new Button();
            label1 = new Label();
            panelContenido = new Panel();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(10, 102);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(131, 34);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(10, 181);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(131, 35);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(10, 275);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(131, 34);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(12, 381);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(131, 34);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(12, 472);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(131, 72);
            btnCerrar_Sesion.TabIndex = 4;
            btnCerrar_Sesion.Text = "Cerrar sesion";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Menu principal";
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(172, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(984, 584);
            panelContenido.TabIndex = 6;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 584);
            Controls.Add(panelContenido);
            Controls.Add(label1);
            Controls.Add(btnCerrar_Sesion);
            Controls.Add(btnVentas);
            Controls.Add(btnInventario);
            Controls.Add(btnProveedores);
            Controls.Add(btnProductos);
            Name = "FrmDashboard";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnCerrar_Sesion;
        private Label label1;
        private Panel panelContenido;
    }
}