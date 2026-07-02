namespace integra_1
{
    partial class FrmReportes
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
            btnMenu_Inicio = new Button();
            btnProducto = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnInventario = new Button();
            btnProveedores = new Button();
            btnReportes = new Button();
            btnCerrar_Sesión = new Button();
            btnAyuda = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(38, 51);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(112, 34);
            btnMenu_Inicio.TabIndex = 0;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(38, 91);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(112, 34);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCerrar_Sesión);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 450);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(188, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 85);
            panel2.TabIndex = 3;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(38, 131);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(112, 34);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(38, 171);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(132, 44);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(38, 221);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(124, 38);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCerrar_Sesión
            // 
            btnCerrar_Sesión.Location = new Point(39, 312);
            btnCerrar_Sesión.Name = "btnCerrar_Sesión";
            btnCerrar_Sesión.Size = new Size(114, 75);
            btnCerrar_Sesión.TabIndex = 7;
            btnCerrar_Sesión.Text = "Cerrar Sesión";
            btnCerrar_Sesión.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(38, 265);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(132, 41);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmReportes";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu_Inicio;
        private Button btnProducto;
        private Panel panel1;
        private Panel panel2;
        private Button btnInventario;
        private Button btnProveedores;
        private Button btnReportes;
        private Button btnCerrar_Sesión;
        private Button btnAyuda;
    }
}