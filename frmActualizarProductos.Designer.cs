namespace ExamenADONET
{
    partial class frmActualizarProductos
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
            txtIdProducto = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(141, 21);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(161, 27);
            txtIdProducto.TabIndex = 0;
            txtIdProducto.TextChanged += txtIdProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "IdProducto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 207);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del producto";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(151, 156);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(120, 107);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(120, 70);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 27);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 114);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "Precio";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 77);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 0;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 42);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(332, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmActualizarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 315);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtIdProducto);
            Name = "frmActualizarProductos";
            Text = "Actualización de producto";
            Load += frmActualizarProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducto;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private Button btnActualizar;
    }
}