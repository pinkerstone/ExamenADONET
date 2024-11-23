namespace ExamenADONET
{
    partial class Menu
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
            btnAgregar = new Button();
            btnConsultar = new Button();
            btnActualizar = new Button();
            bntElminar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(102, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 68);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(102, 115);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(185, 68);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar productos";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(102, 206);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(185, 68);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar productos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // bntElminar
            // 
            bntElminar.Location = new Point(102, 299);
            bntElminar.Name = "bntElminar";
            bntElminar.Size = new Size(185, 68);
            bntElminar.TabIndex = 0;
            bntElminar.Text = "Eliminar producto";
            bntElminar.UseVisualStyleBackColor = true;
            bntElminar.Click += bntElminar_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 395);
            Controls.Add(bntElminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAgregar);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnAgregar;
        private Button btnConsultar;
        private Button btnActualizar;
        private Button bntElminar;
    }
}