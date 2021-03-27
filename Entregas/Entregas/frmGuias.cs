using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregas
{
    public partial class frmGuias : Form
    {
        DataSet ds;

        public frmGuias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string paqueteria = this.cbPaqueteria.Text;
            string tipoGuia = this.cbTipoGuia.Text;
            if(string.IsNullOrEmpty(paqueteria) || string.IsNullOrEmpty(tipoGuia))
            {
                Mensajes.NoExito("Selecciona una paquetería y el tipo de guía para añadir al inventario.");
                return;
            }
            int cantidad = Funciones.TraerCantidadGuias(paqueteria,tipoGuia);
            cantidad += (int)nCantidad.Value;
            string sql = string.Format("UPDATE Inv_guias SET CantGuias={0} WHERE Paqueteria='{1}' AND TipoGuia='{2}';", cantidad, paqueteria, tipoGuia);
            ds = Conexion.Ejecutar(sql);
            ds.Clear();
            this.lblCantidad.Text = Funciones.TraerCantidadGuias(paqueteria,tipoGuia).ToString();
            
        }

        private void frmGuias_Load(object sender, EventArgs e)
        {
            ds = Conexion.Ejecutar("SELECT NombrePaqueteria FROM Paqueterias ORDER BY NombrePaqueteria ASC;");
            foreach (DataRow paqueteria in ds.Tables[0].Rows)
            {
                cbPaqueteria.Items.Add(paqueteria[0].ToString());
            }
            ds.Clear();
        }

        private void cbPaqueteria_SelectedValueChanged(object sender, EventArgs e)
        {
            cbTipoGuia.Enabled = true;
            lblCantidad.Visible = false;
            cbTipoGuia.Items.Clear();
            string sql = string.Format("SELECT TipoGuia FROM Inv_guias WHERE Paqueteria='{0}' ORDER BY TipoGuia ASC;",this.cbPaqueteria.Text);
            ds = Conexion.Ejecutar(sql);
            foreach (DataRow paqueteria in ds.Tables[0].Rows)
            {
                cbTipoGuia.Items.Add(paqueteria[0].ToString());
            }
            ds.Clear();
        }

        private void cbTipoGuia_SelectedValueChanged(object sender, EventArgs e)
        {
            lblCantidad.Text = Funciones.TraerCantidadGuias(this.cbPaqueteria.Text, this.cbTipoGuia.Text).ToString();
            this.lblCantidad.Visible = true;
        }
    }
}
