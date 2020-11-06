namespace CajeroAutomático
{
    partial class Admin
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCostoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarcaProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbXProducto = new System.Windows.Forms.TextBox();
            this.tbYProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(240, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 66);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(52, 83);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(159, 22);
            this.tbIdProducto.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(49, 63);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 17);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Ingresar ID:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(237, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Ingresar Nombre:";
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(240, 83);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(159, 22);
            this.tbNombreProducto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar Costo:";
            // 
            // tbCostoProducto
            // 
            this.tbCostoProducto.Location = new System.Drawing.Point(52, 143);
            this.tbCostoProducto.Name = "tbCostoProducto";
            this.tbCostoProducto.Size = new System.Drawing.Size(159, 22);
            this.tbCostoProducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresar Marca:";
            // 
            // tbMarcaProducto
            // 
            this.tbMarcaProducto.Location = new System.Drawing.Point(240, 143);
            this.tbMarcaProducto.Name = "tbMarcaProducto";
            this.tbMarcaProducto.Size = new System.Drawing.Size(159, 22);
            this.tbMarcaProducto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingresar Coordenadas:";
            // 
            // tbXProducto
            // 
            this.tbXProducto.Location = new System.Drawing.Point(95, 210);
            this.tbXProducto.Name = "tbXProducto";
            this.tbXProducto.Size = new System.Drawing.Size(116, 22);
            this.tbXProducto.TabIndex = 9;
            // 
            // tbYProducto
            // 
            this.tbYProducto.Location = new System.Drawing.Point(95, 249);
            this.tbYProducto.Name = "tbYProducto";
            this.tbYProducto.Size = new System.Drawing.Size(116, 22);
            this.tbYProducto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "X: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y:";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(52, 305);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(459, 196);
            this.lbProductos.TabIndex = 17;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbXProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarcaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCostoProducto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombreProducto);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCostoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMarcaProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbXProducto;
        private System.Windows.Forms.TextBox tbYProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbProductos;
    }
}