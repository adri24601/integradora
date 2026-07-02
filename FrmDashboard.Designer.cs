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
            btnCerrar_Sesion = new Button();
            btnMenu_Inicio = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lbBienvenido = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnAyuda = new Button();
            label2 = new Label();
            panel3 = new Panel();
            lbProductos = new Label();
            panel4 = new Panel();
            lbStock = new Label();
            panel5 = new Panel();
            lbVentas = new Label();
            panel6 = new Panel();
            lbEntradas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.Window;
            btnProductos.BackgroundImageLayout = ImageLayout.Center;
            btnProductos.Location = new Point(33, 196);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(114, 32);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(33, 271);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(129, 35);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnCerrar_Sesion
            // 
            btnCerrar_Sesion.Location = new Point(27, 519);
            btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            btnCerrar_Sesion.Size = new Size(135, 53);
            btnCerrar_Sesion.TabIndex = 4;
            btnCerrar_Sesion.Text = "Cerrar Sesión";
            btnCerrar_Sesion.UseVisualStyleBackColor = true;
            btnCerrar_Sesion.Click += btnCerrar_Sesion_Click;
            // 
            // btnMenu_Inicio
            // 
            btnMenu_Inicio.Location = new Point(33, 156);
            btnMenu_Inicio.Name = "btnMenu_Inicio";
            btnMenu_Inicio.Size = new Size(112, 34);
            btnMenu_Inicio.TabIndex = 0;
            btnMenu_Inicio.Text = "Inicio";
            btnMenu_Inicio.UseVisualStyleBackColor = true;
            btnMenu_Inicio.Click += button1_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(35, 234);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(112, 31);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(33, 432);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(112, 34);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_20260609_WA0004__1_;
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 6, 158);
            panel1.Controls.Add(lbBienvenido);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(222, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 110);
            panel1.TabIndex = 0;
            // 
            // lbBienvenido
            // 
            lbBienvenido.AutoSize = true;
            lbBienvenido.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbBienvenido.ForeColor = SystemColors.ButtonHighlight;
            lbBienvenido.Location = new Point(131, 29);
            lbBienvenido.Name = "lbBienvenido";
            lbBienvenido.Size = new Size(314, 45);
            lbBienvenido.TabIndex = 11;
            lbBienvenido.Text = "¡Bienvenido, Admin!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1APARTADOS;
            pictureBox2.Location = new Point(33, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 71, 161);
            panel2.Controls.Add(btnAyuda);
            panel2.Controls.Add(btnCerrar_Sesion);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnMenu_Inicio);
            panel2.Controls.Add(btnProveedores);
            panel2.Location = new Point(12, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 585);
            panel2.TabIndex = 8;
            // 
            // btnAyuda
            // 
            btnAyuda.Location = new Point(27, 472);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(135, 41);
            btnAyuda.TabIndex = 13;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 127);
            label2.Name = "label2";
            label2.Size = new Size(147, 29);
            label2.TabIndex = 9;
            label2.Text = "CAF Inventory";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbProductos);
            panel3.Location = new Point(222, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 112);
            panel3.TabIndex = 9;
            // 
            // lbProductos
            // 
            lbProductos.AutoSize = true;
            lbProductos.Location = new Point(30, 34);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(135, 25);
            lbProductos.TabIndex = 16;
            lbProductos.Text = "Total Productos";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbStock);
            panel4.Location = new Point(459, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 112);
            panel4.TabIndex = 10;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(51, 15);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(94, 25);
            lbStock.TabIndex = 15;
            lbStock.Text = "Stock Bajo";
            lbStock.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbVentas);
            panel5.Location = new Point(922, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(202, 116);
            panel5.TabIndex = 11;
            // 
            // lbVentas
            // 
            lbVentas.AutoSize = true;
            lbVentas.Location = new Point(58, 34);
            lbVentas.Name = "lbVentas";
            lbVentas.Size = new Size(102, 25);
            lbVentas.TabIndex = 14;
            lbVentas.Text = "Ventas Hoy";
            // 
            // panel6
            // 
            panel6.Controls.Add(lbEntradas);
            panel6.Location = new Point(695, 141);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 116);
            panel6.TabIndex = 12;
            // 
            // lbEntradas
            // 
            lbEntradas.AutoSize = true;
            lbEntradas.Location = new Point(18, 34);
            lbEntradas.Name = "lbEntradas";
            lbEntradas.Size = new Size(118, 25);
            lbEntradas.TabIndex = 13;
            lbEntradas.Text = "Entradas Hoy";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 584);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnProveedores;
        private Button btnCerrar_Sesion;
        private Button btnMenu_Inicio;
        private Button btnInventario;
        private Button btnReportes;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Label lbBienvenido;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lbEntradas;
        private Label lbVentas;
        private Label lbStock;
        private Label lbProductos;
        private Button btnAyuda;
    }
}