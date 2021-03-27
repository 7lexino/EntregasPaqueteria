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
    public partial class frmPrincipal : Form
    {
        DataSet ds;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbrirRegistrarCodigo_Click(object sender, EventArgs e)
        {
            frmRegistrarCodigo wRegistrarCodigo = new frmRegistrarCodigo();
            wRegistrarCodigo.ShowDialog();
        }

        private void txtCodigoPostal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Validamos que sea un numero lo que se ingresó en el textbox
                bool isNumeric = int.TryParse(this.txtCodigoPostal.Text.Trim(), out int codigoPostal);

                if (isNumeric == false)
                {
                    this.txtCodigoPostal.SelectAll();
                    this.label2.Visible = false;
                    this.lblMejorOpcion.Visible = false;
                    this.btnUtilizarGuia.Visible = false;
                    this.lblEstado.Visible = false;
                    this.lblMunicipio.Visible = false;
                    this.lblNoEncontrado.Visible = false;
                    Mensajes.NoExito("Inserte un código postal válido");
                    return;
                }

                //Hacemos una consulta a la DB para traer la mejor opción de paquetería dependiendo de su nivel de prioridad
                string sql = string.Format("SELECT TOP 1 Paqueterias.NombrePaqueteria FROM Paqueterias_codigos INNER JOIN Paqueterias ON Paqueterias_codigos.Paqueteria=Paqueterias.NombrePaqueteria WHERE Paqueterias_codigos.CodigoPostal={0} ORDER BY Paqueterias.Prioridad ASC;",this.txtCodigoPostal.Text.Trim());
                ds = Conexion.Ejecutar(sql);//Ejecutamos la consulta
                sql = string.Format("SELECT Estado, Municipio FROM Codigos_postales WHERE CodigoPostal={0}", this.txtCodigoPostal.Text.Trim());
                DataSet ds2 = Conexion.Ejecutar(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.label2.Visible = true;
                    this.lblMejorOpcion.Visible = true;
                    this.btnUtilizarGuia.Visible = true;
                    this.lblMejorOpcion.Text = ds.Tables[0].Rows[0]["NombrePaqueteria"].ToString();
                    this.lblEstado.Text = "Estado: " + ds2.Tables[0].Rows[0]["Estado"].ToString();
                    this.lblMunicipio.Text = "Municipio: " + ds2.Tables[0].Rows[0]["Municipio"].ToString();
                    this.lblMejorOpcion.Left = (int)((this.Size.Width / 2) - (this.lblMejorOpcion.Size.Width / 2));
                    this.lblEstado.Left = (int)((this.Size.Width / 2) - (this.lblEstado.Size.Width / 2));
                    this.lblMunicipio.Left = (int)((this.Size.Width / 2) - (this.lblMunicipio.Size.Width / 2));
                    this.lblNoEncontrado.Visible = false;
                    this.lblEstado.Visible = true;
                    this.lblMunicipio.Visible = true;
                    this.btnUtilizarGuia.Focus();
                }
                else
                {
                    this.label2.Visible = false;
                    this.lblMejorOpcion.Visible = false;
                    this.lblNoEncontrado.Visible = true;
                    this.btnUtilizarGuia.Visible = false;
                    this.lblEstado.Visible = false;
                    this.lblMunicipio.Visible = false;
                }
                ds.Clear();
            }
        }

        private void btnGuias_Click(object sender, EventArgs e)
        {
            frmGuias wGuias = new frmGuias();
            wGuias.ShowDialog();
        }

        private void btnUtilizarGuia_Click(object sender, EventArgs e)
        {
            frmUtilizarGuia wUtilizarGuia = new frmUtilizarGuia();
            wUtilizarGuia.ShowDialog();
        }
    }
}
