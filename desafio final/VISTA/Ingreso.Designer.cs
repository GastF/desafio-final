namespace desafio_final
{
    partial class ingresoVendedor
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
            this.label10 = new System.Windows.Forms.Label();
            this.codigoVendedor = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ingrese sus datos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codigoVendedor
            // 
            this.codigoVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.codigoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.codigoVendedor.ForeColor = System.Drawing.Color.Black;
            this.codigoVendedor.Location = new System.Drawing.Point(63, 124);
            this.codigoVendedor.Name = "codigoVendedor";
            this.codigoVendedor.Size = new System.Drawing.Size(132, 22);
            this.codigoVendedor.TabIndex = 2;
            this.codigoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigoVendedor.TextChanged += new System.EventHandler(this.codigoVendedor_TextChanged);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.Control;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Black;
            this.nombre.Location = new System.Drawing.Point(63, 45);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(132, 22);
            this.nombre.TabIndex = 0;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(47, 152);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(160, 48);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // apellido
            // 
            this.apellido.BackColor = System.Drawing.SystemColors.Control;
            this.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.Color.Black;
            this.apellido.Location = new System.Drawing.Point(63, 83);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(132, 22);
            this.apellido.TabIndex = 1;
            this.apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::desafio_final.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.btnExit.Location = new System.Drawing.Point(233, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingresoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 212);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigoVendedor);
            this.Controls.Add(this.label10);
            this.MaximumSize = new System.Drawing.Size(269, 251);
            this.MinimumSize = new System.Drawing.Size(269, 251);
            this.Name = "ingresoVendedor";
            this.ShowIcon = false;
            this.Text = "Cotizador Express";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codigoVendedor;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}