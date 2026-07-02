namespace integra_1
{
    partial class FrmAyuda
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
            panel2 = new Panel();
            btnMenu_Inicio = new Button();
            btnProducto = new Button();
            btnInventario = new Button();
            btnProveedores = new Button();
            btnAyuda = new Button();
            btnReportes = new Button();
            btnCerrar_Sesión = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnMenu_Inicio);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnAyuda);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCerrar_Sesión);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 444);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(224, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 77);
            panel2.TabIndex = 1;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(44, 121);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(107, 32);
            btnMenu_Inicio.TabIndex = 2;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(44, 159);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(110, 35);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(44, 200);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(105, 32);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(31, 238);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(104, 33);
            btnProveedores.TabIndex = 5;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(30, 333);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(97, 32);
            btnAyuda.TabIndex = 6;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(30, 293);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(99, 34);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCerrar_Sesión
            // 
            btnCerrar_Sesión.Location = new Point(30, 366);
            btnCerrar_Sesión.Name = "btnCerrar_Sesión";
            btnCerrar_Sesión.Size = new Size(105, 36);
            btnCerrar_Sesión.TabIndex = 8;
            btnCerrar_Sesión.Text = "Cerrar Sesión";
            btnCerrar_Sesión.UseVisualStyleBackColor = true;
            // 
            // FrmAyuda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAyuda";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnMenu_Inicio;
        private Button btnProducto;
        private Button btnInventario;
        private Button btnProveedores;
        private Button btnAyuda;
        private Button btnReportes;
        private Button btnCerrar_Sesión;
    }
}