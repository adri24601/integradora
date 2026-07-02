namespace integra_1
{
    partial class FrmCerrar_Sesión
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
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            btnMenu_Inicio = new Button();
            btnAyuda = new Button();
            btnProducto = new Button();
            btnReportes = new Button();
            btnInventario = new Button();
            btnProveedores = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 446);
            panel1.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(25, 341);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(114, 66);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(23, 56);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(127, 42);
            btnMenu_Inicio.TabIndex = 2;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += btnMenu_Inicio_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(25, 294);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(114, 41);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(38, 113);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(112, 34);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(25, 245);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(133, 43);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(25, 153);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(125, 41);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(23, 200);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(126, 39);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(191, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 96);
            panel2.TabIndex = 2;
            // 
            // FrmCerrar_Sesión
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmCerrar_Sesión";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnCerrarSesion;
        private Button btnAyuda;
        private Button btnReportes;
        private Button btnProveedores;
        private Button btnInventario;
        private Button btnProducto;
        private Button btnMenu_Inicio;
        private Panel panel2;
    }
}