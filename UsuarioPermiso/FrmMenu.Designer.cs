namespace UsuarioPermiso
{
    partial class FrmMenu
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
            this.txtUsuarios = new System.Windows.Forms.Button();
            this.txtProductos = new System.Windows.Forms.Button();
            this.txtHerramientas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.Location = new System.Drawing.Point(37, 69);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(93, 32);
            this.txtUsuarios.TabIndex = 0;
            this.txtUsuarios.Text = "USUARIOS";
            this.txtUsuarios.UseVisualStyleBackColor = true;
            this.txtUsuarios.Click += new System.EventHandler(this.txtUsuarios_Click);
            // 
            // txtProductos
            // 
            this.txtProductos.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos.Location = new System.Drawing.Point(204, 69);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(91, 32);
            this.txtProductos.TabIndex = 1;
            this.txtProductos.Text = "PRODUCTOS";
            this.txtProductos.UseVisualStyleBackColor = true;
            this.txtProductos.Click += new System.EventHandler(this.txtProductos_Click);
            // 
            // txtHerramientas
            // 
            this.txtHerramientas.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerramientas.Location = new System.Drawing.Point(111, 117);
            this.txtHerramientas.Name = "txtHerramientas";
            this.txtHerramientas.Size = new System.Drawing.Size(109, 32);
            this.txtHerramientas.TabIndex = 2;
            this.txtHerramientas.Text = "HERRAMIENTAS";
            this.txtHerramientas.UseVisualStyleBackColor = true;
            this.txtHerramientas.Click += new System.EventHandler(this.txtHerramientas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 39);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENÚ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(329, 174);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHerramientas);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.txtUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtUsuarios;
        private System.Windows.Forms.Button txtProductos;
        private System.Windows.Forms.Button txtHerramientas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}