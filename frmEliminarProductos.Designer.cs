namespace ExamenADONET
{
    partial class frmEliminarProductos
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
            txtIdProducto = new TextBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 37);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Id Producto";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(145, 30);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(111, 84);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEliminarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 146);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdProducto);
            Controls.Add(label1);
            Name = "frmEliminarProductos";
            Text = "Eliminar producto";
            Load += frmEliminarProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdProducto;
        private Button btnEliminar;
    }
}