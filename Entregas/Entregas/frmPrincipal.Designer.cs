namespace Entregas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirRegistrarCodigo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMejorOpcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuias = new System.Windows.Forms.Button();
            this.btnUtilizarGuia = new System.Windows.Forms.Button();
            this.lblNoEncontrado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(205, 70);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(189, 38);
            this.txtCodigoPostal.TabIndex = 0;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoPostal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPostal_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código postal";
            // 
            // btnAbrirRegistrarCodigo
            // 
            this.btnAbrirRegistrarCodigo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbrirRegistrarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirRegistrarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirRegistrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirRegistrarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnAbrirRegistrarCodigo.Location = new System.Drawing.Point(12, 289);
            this.btnAbrirRegistrarCodigo.Name = "btnAbrirRegistrarCodigo";
            this.btnAbrirRegistrarCodigo.Size = new System.Drawing.Size(134, 30);
            this.btnAbrirRegistrarCodigo.TabIndex = 2;
            this.btnAbrirRegistrarCodigo.Text = "Códigos postales";
            this.btnAbrirRegistrarCodigo.UseVisualStyleBackColor = false;
            this.btnAbrirRegistrarCodigo.Click += new System.EventHandler(this.btnAbrirRegistrarCodigo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(497, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMejorOpcion
            // 
            this.lblMejorOpcion.AutoSize = true;
            this.lblMejorOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejorOpcion.Location = new System.Drawing.Point(261, 141);
            this.lblMejorOpcion.Name = "lblMejorOpcion";
            this.lblMejorOpcion.Size = new System.Drawing.Size(78, 24);
            this.lblMejorOpcion.TabIndex = 3;
            this.lblMejorOpcion.Text = "Opción";
            this.lblMejorOpcion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMejorOpcion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mejor opción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // btnGuias
            // 
            this.btnGuias.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuias.ForeColor = System.Drawing.Color.White;
            this.btnGuias.Location = new System.Drawing.Point(152, 289);
            this.btnGuias.Name = "btnGuias";
            this.btnGuias.Size = new System.Drawing.Size(84, 30);
            this.btnGuias.TabIndex = 3;
            this.btnGuias.Text = "Guías";
            this.btnGuias.UseVisualStyleBackColor = false;
            this.btnGuias.Click += new System.EventHandler(this.btnGuias_Click);
            // 
            // btnUtilizarGuia
            // 
            this.btnUtilizarGuia.BackColor = System.Drawing.Color.SlateGray;
            this.btnUtilizarGuia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtilizarGuia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUtilizarGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizarGuia.ForeColor = System.Drawing.Color.White;
            this.btnUtilizarGuia.Location = new System.Drawing.Point(397, 77);
            this.btnUtilizarGuia.Name = "btnUtilizarGuia";
            this.btnUtilizarGuia.Size = new System.Drawing.Size(64, 24);
            this.btnUtilizarGuia.TabIndex = 1;
            this.btnUtilizarGuia.Text = "Utilizar";
            this.btnUtilizarGuia.UseVisualStyleBackColor = false;
            this.btnUtilizarGuia.Visible = false;
            this.btnUtilizarGuia.Click += new System.EventHandler(this.btnUtilizarGuia_Click);
            // 
            // lblNoEncontrado
            // 
            this.lblNoEncontrado.AutoSize = true;
            this.lblNoEncontrado.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoEncontrado.Location = new System.Drawing.Point(231, 118);
            this.lblNoEncontrado.Name = "lblNoEncontrado";
            this.lblNoEncontrado.Size = new System.Drawing.Size(135, 13);
            this.lblNoEncontrado.TabIndex = 6;
            this.lblNoEncontrado.Text = "Código postal no registrado";
            this.lblNoEncontrado.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(202, 176);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEstado.Visible = false;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(202, 197);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(71, 18);
            this.lblMunicipio.TabIndex = 8;
            this.lblMunicipio.Text = "Municipio";
            this.lblMunicipio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMunicipio.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNoEncontrado);
            this.Controls.Add(this.btnUtilizarGuia);
            this.Controls.Add(this.btnGuias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMejorOpcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.btnAbrirRegistrarCodigo);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 370);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas :: Juguel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirRegistrarCodigo;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblMejorOpcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuias;
        private System.Windows.Forms.Button btnUtilizarGuia;
        private System.Windows.Forms.Label lblNoEncontrado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMunicipio;
    }
}