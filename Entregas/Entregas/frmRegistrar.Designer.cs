namespace Entregas
{
    partial class frmRegistrarCodigo
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
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPaqueterias = new System.Windows.Forms.DataGridView();
            this.btnGuardarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarPaqueteria = new System.Windows.Forms.Button();
            this.btnAgregarPaqueteria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaqueterias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(12, 22);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPostal.TabIndex = 0;
            this.txtCodigoPostal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPostal_KeyDown);
            // 
            // cbEstado
            // 
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(12, 61);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(149, 21);
            this.cbEstado.TabIndex = 1;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Enabled = false;
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(173, 61);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(149, 21);
            this.cbMunicipio.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPaqueterias);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paqueterías";
            // 
            // dgvPaqueterias
            // 
            this.dgvPaqueterias.AllowUserToAddRows = false;
            this.dgvPaqueterias.AllowUserToDeleteRows = false;
            this.dgvPaqueterias.AllowUserToResizeColumns = false;
            this.dgvPaqueterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaqueterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaqueterias.Location = new System.Drawing.Point(6, 23);
            this.dgvPaqueterias.Name = "dgvPaqueterias";
            this.dgvPaqueterias.Size = new System.Drawing.Size(298, 141);
            this.dgvPaqueterias.TabIndex = 5;
            // 
            // btnGuardarCodigo
            // 
            this.btnGuardarCodigo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCodigo.Location = new System.Drawing.Point(12, 284);
            this.btnGuardarCodigo.Name = "btnGuardarCodigo";
            this.btnGuardarCodigo.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarCodigo.TabIndex = 4;
            this.btnGuardarCodigo.Text = "Guardar";
            this.btnGuardarCodigo.UseVisualStyleBackColor = false;
            this.btnGuardarCodigo.Click += new System.EventHandler(this.btnGuardarCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Municipio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código postal";
            // 
            // btnEliminarPaqueteria
            // 
            this.btnEliminarPaqueteria.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPaqueteria.BackgroundImage = global::Entregas.Properties.Resources.delete_40623;
            this.btnEliminarPaqueteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPaqueteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPaqueteria.FlatAppearance.BorderSize = 0;
            this.btnEliminarPaqueteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPaqueteria.Location = new System.Drawing.Point(260, 283);
            this.btnEliminarPaqueteria.Name = "btnEliminarPaqueteria";
            this.btnEliminarPaqueteria.Size = new System.Drawing.Size(25, 25);
            this.btnEliminarPaqueteria.TabIndex = 6;
            this.btnEliminarPaqueteria.UseVisualStyleBackColor = false;
            this.btnEliminarPaqueteria.Click += new System.EventHandler(this.btnEliminarPaqueteria_Click);
            // 
            // btnAgregarPaqueteria
            // 
            this.btnAgregarPaqueteria.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPaqueteria.BackgroundImage = global::Entregas.Properties.Resources.text_plus_icon;
            this.btnAgregarPaqueteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPaqueteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPaqueteria.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaqueteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaqueteria.Location = new System.Drawing.Point(291, 283);
            this.btnAgregarPaqueteria.Name = "btnAgregarPaqueteria";
            this.btnAgregarPaqueteria.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarPaqueteria.TabIndex = 4;
            this.btnAgregarPaqueteria.UseVisualStyleBackColor = false;
            this.btnAgregarPaqueteria.Click += new System.EventHandler(this.btnAgregarPaqueteria_Click);
            // 
            // frmRegistrarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 318);
            this.Controls.Add(this.btnEliminarPaqueteria);
            this.Controls.Add(this.btnAgregarPaqueteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMunicipio);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtCodigoPostal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar/Editar código postal";
            this.Load += new System.EventHandler(this.frmRegistrarCodigo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaqueterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarPaqueteria;
        private System.Windows.Forms.Button btnGuardarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPaqueterias;
        private System.Windows.Forms.Button btnEliminarPaqueteria;
    }
}