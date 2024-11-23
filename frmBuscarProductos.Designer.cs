namespace ExamenADONET
{
    partial class frmBuscarProductos
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
            btnBuscar = new Button();
            dgvListadoProductos = new DataGridView();
            txtNombreProducto = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(500, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvListadoProductos
            // 
            dgvListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProductos.Location = new Point(38, 72);
            dgvListadoProductos.Name = "dgvListadoProductos";
            dgvListadoProductos.RowHeadersWidth = 51;
            dgvListadoProductos.Size = new Size(726, 366);
            dgvListadoProductos.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(108, 21);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(364, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // frmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNombreProducto);
            Controls.Add(dgvListadoProductos);
            Controls.Add(btnBuscar);
            Name = "frmBuscarProductos";
            Text = "Buscar Productos";
            Load += frmBuscarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private DataGridView dgvListadoProductos;
        private TextBox txtNombreProducto;
        private Label label1;
    }
}