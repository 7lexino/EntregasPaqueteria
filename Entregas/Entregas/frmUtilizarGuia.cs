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
    public partial class frmUtilizarGuia : Form
    {
        DataSet ds;
        string sql;
        frmPrincipal wPrincipal = Funciones.TraerVentana<frmPrincipal>();

        public frmUtilizarGuia()
        {
            InitializeComponent();
        }

        private void frmUtilizarGuia_Load(object sender, EventArgs e)
        {
            

            sql = string.Format("SELECT TipoGuia FROM Inv_guias WHERE Paqueteria='{0}';",wPrincipal.lblMejorOpcion.Text);
            ds = Conexion.Ejecutar(sql);
            foreach(DataRow tipoguia in ds.Tables[0].Rows)
            {
                this.cbTipoGuias.Items.Add(tipoguia[0].ToString());
            }
            ds.Clear();
            sql = string.Format("SELECT GuiaDefault FROM Paqueterias_codigos WHERE CodigoPostal={0} AND Paqueteria='{1}';", wPrincipal.txtCodigoPostal.Text,wPrincipal.lblMejorOpcion.Text);
            ds = Conexion.Ejecutar(sql);
            this.cbTipoGuias.SelectedIndex = this.cbTipoGuias.FindStringExact(ds.Tables[0].Rows[0][0].ToString());
            ds.Clear();
        }

        private void cbTipoGuias_SelectedValueChanged(object sender, EventArgs e)
        {
            sql = string.Format("UPDATE Paqueterias_codigos SET GuiaDefault='{0}' WHERE Paqueteria='{1}' AND CodigoPostal={2}", this.cbTipoGuias.Text, wPrincipal.lblMejorOpcion.Text,wPrincipal.txtCodigoPostal.Text);
            ds = Conexion.Ejecutar(sql);
            ds.Clear();
            this.lblCantGuias.Text = Funciones.TraerCantidadGuias(wPrincipal.lblMejorOpcion.Text, this.cbTipoGuias.Text).ToString();
            this.lblCantGuias.Visible = true;
        }

        private void btnUtilizarGuias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbTipoGuias.Text))
            {
                Mensajes.NoExito("Selecciona un tipo de guía a utilizar.");
                return;
            }

            if(this.numCantGuias.Value != 0)
            {
                int cantGuias = Funciones.TraerCantidadGuias(wPrincipal.lblMejorOpcion.Text, this.cbTipoGuias.Text);
                cantGuias -= (int)this.numCantGuias.Value;
                sql = string.Format("UPDATE Inv_guias SET CantGuias={0} WHERE Paqueteria='{1}' AND TipoGuia='{2}';", cantGuias, wPrincipal.lblMejorOpcion.Text, this.cbTipoGuias.Text);
                ds = Conexion.Ejecutar(sql);
                this.Close();
                Mensajes.Exito("Se han descontado las guías del inventario");                    
            }
        }
    }
}
