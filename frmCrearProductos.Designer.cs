namespace ExamenADONET
{
    partial class frmCrearProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            btnAgregarProducto = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 84);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 123);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 0;
            label3.Text = "Stock";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 168);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(110, 116);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(104, 27);
            txtStock.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(110, 77);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(104, 27);
            txtPrecio.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 27);
            txtNombre.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(223, 214);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // frmCrearProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 270);
            Controls.Add(btnAgregarProducto);
            Controls.Add(groupBox1);
            Name = "frmCrearProductos";
            Text = "Agregar Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Button btnAgregarProducto;
    }
}