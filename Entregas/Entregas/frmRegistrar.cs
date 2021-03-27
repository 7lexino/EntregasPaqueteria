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
    public partial class frmRegistrarCodigo : Form
    {
        DataSet ds;

        public frmRegistrarCodigo()
        {
            InitializeComponent();
        }

        private void frmRegistrarCodigo_Load(object sender, EventArgs e)
        {
            ds = Conexion.Ejecutar("SELECT Estado FROM Estados ORDER BY Estado ASC;");
            //Vamos llenando el combobox trayendo los estados
            foreach (DataRow estado in ds.Tables[0].Rows)
            {
                this.cbEstado.Items.Add(estado[0].ToString());
            }
            ds.Clear(); //Liberamos el dataset

            //Ahora creamos la tabla para el datagrid

            DataGridViewComboBoxColumn dgvComboBox = new DataGridViewComboBoxColumn();
            dgvComboBox.ValueType = typeof(string);
            dgvComboBox.Name = "Paqueteria";
            dgvComboBox.HeaderText = "Paquetería";

            //Hacemos la consulta para traer las paqueterías disponibles
            ds = Conexion.Ejecutar("SELECT NombrePaqueteria FROM Paqueterias ORDER BY NombrePaqueteria ASC;");
            foreach (DataRow paqueteria in ds.Tables[0].Rows)
            {
                dgvComboBox.Items.Add(paqueteria[0].ToString());
            }
            ds.Clear();
            dgvPaqueterias.Columns.Add(dgvComboBox);

            DataGridViewCheckBoxColumn dgvCheckBox = new DataGridViewCheckBoxColumn();
            dgvCheckBox.ValueType = typeof(bool);
            dgvCheckBox.Name = "Ocurre";
            dgvCheckBox.HeaderText = "Ocurre";
            dgvPaqueterias.Columns.Add(dgvCheckBox);

        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbMunicipio.Enabled = true; //Lo habilitamos
            this.cbMunicipio.Items.Clear(); //Limpiamos el combo

            //Preparamos la consulta
            string sql = string.Format("SELECT Ciudades.Ciudad FROM Ciudades INNER JOIN Estados ON Estados.Estado=Ciudades.Estado WHERE Estados.Estado='{0}' ORDER BY Ciudades.Ciudad ASC;", this.cbEstado.Text);
            ds = Conexion.Ejecutar(sql);
            foreach (DataRow ciudad in ds.Tables[0].Rows)
            {
                this.cbMunicipio.Items.Add(ciudad[0].ToString());
            }
            ds.Clear(); //Liberamos el dataset
        }

        private void btnAgregarPaqueteria_Click(object sender, EventArgs e)
        {
            dgvPaqueterias.Rows.Add();
        }

        private void btnEliminarPaqueteria_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvPaqueterias.SelectedRows)
            {
                dgvPaqueterias.Rows.RemoveAt(fila.Index);
            }
        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            string sql;
            //Validamos que el código postal sea válido
            bool isNumeric = int.TryParse(this.txtCodigoPostal.Text.Trim(), out int codigoPostal);
            if (isNumeric == false)
            {
                Mensajes.NoExito("Inserte un código postal válido");
                return;
            }
            //Validamos que haya seleccionado un estado
            if (string.IsNullOrEmpty(this.cbEstado.Text))
            {
                Mensajes.NoExito("Seleccione un estado");
                return;
            }
            //Validamos que haya seleccionado o escrito una ciudad
            if (string.IsNullOrWhiteSpace(this.cbMunicipio.Text))
            {
                Mensajes.NoExito("Seleccione o escriba una ciudad");
                return;
            }


            //Validamos que tenga al menos 1 paquetería
            if (dgvPaqueterias.Rows.Count == 0)
            {
                Mensajes.NoExito("El código postal al menos debe de tener una paquetería");
                return;
            }

            //Recorremos el datagridview para validar que no haya datos vacíos
            foreach (DataGridViewRow fila in dgvPaqueterias.Rows)
            {
                if (fila.Cells["Paqueteria"].Value == null)
                {
                    Mensajes.NoExito("No puede haber datos vacíos");
                    return;
                }
                if (fila.Cells["Ocurre"].Value == null)
                {
                    fila.Cells["Ocurre"].Value = false;
                }

            }

            string estado = this.cbEstado.Text;
            string municipio = this.cbMunicipio.Text.Trim().ToUpper();


            DialogResult respuesta=DialogResult.None;
            //Validamos que no haya sido registrado ya el código postal
            sql = string.Format("SELECT Id FROM Codigos_postales WHERE CodigoPostal={0};", codigoPostal);
            ds = Conexion.Ejecutar(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Clear();
                respuesta = Mensajes.Confirmar("¿Deseas actualizar los datos?");
                if (respuesta == DialogResult.No) return;
            }

            sql = string.Format("SELECT Id FROM Ciudades WHERE Ciudad='{0}'", municipio);
            ds = Conexion.Ejecutar(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Clear();
                sql = string.Format("INSERT INTO Ciudades (Estado, Ciudad) VALUES('{0}', '{1}')", estado, municipio);
                ds = Conexion.Ejecutar(sql);
            }
            ds.Clear();

            if (respuesta == DialogResult.Yes)
            {
                //Actualizamos el estado y municipio
                sql = string.Format("UPDATE Codigos_postales SET Estado='{0}', Municipio='{1}' WHERE CodigoPostal={2};",estado,municipio,codigoPostal);
                ds = Conexion.Ejecutar(sql);
                ds.Clear();
                
                //Borramos la información primero
                sql = string.Format("DELETE FROM Paqueterias_codigos WHERE CodigoPostal={0}",codigoPostal);
                ds = Conexion.Ejecutar(sql);
                ds.Clear();

                //Recorremos el datagridview para actualizar los datos de los métodos de envío
                foreach (DataGridViewRow fila in dgvPaqueterias.Rows)
                {
                    string paqueteria = fila.Cells["Paqueteria"].Value.ToString();
                    bool ocurre = bool.Parse(fila.Cells["Ocurre"].Value.ToString());

                    //Insertamos las paqueterias que tiene ese codigo postal
                    sql = string.Format("INSERT INTO Paqueterias_codigos (CodigoPostal, Paqueteria, Ocurre) VALUES ({0}, '{1}', {2});", codigoPostal, paqueteria, ocurre);
                    ds = Conexion.Ejecutar(sql);
                    ds.Clear();
                }

                Mensajes.Exito("El código postal se ha actualizado correctamente");
                this.txtCodigoPostal.Clear();
                this.LimpiarFormulario();

                return; //Salimos del proceso
            }

            //Insertamos los datos del codigo postal
            sql = string.Format("INSERT INTO Codigos_postales (CodigoPostal, Estado, Municipio) VALUES({0}, '{1}', '{2}')", codigoPostal, estado, municipio);
            ds = Conexion.Ejecutar(sql);
            ds.Clear();

            //Recorremos el datagridview para insertar la información en la DB
            foreach (DataGridViewRow fila in dgvPaqueterias.Rows)
            {
                string paqueteria = fila.Cells["Paqueteria"].Value.ToString();
                bool ocurre = bool.Parse(fila.Cells["Ocurre"].Value.ToString());

                //Insertamos las paqueterias que tiene ese codigo postal
                sql = string.Format("INSERT INTO Paqueterias_codigos (CodigoPostal, Paqueteria, Ocurre) VALUES ({0}, '{1}', {2});", codigoPostal, paqueteria, ocurre);
                ds = Conexion.Ejecutar(sql);
                ds.Clear();
            }
            Mensajes.Exito("El código postal se ha registrado correctamente");
            this.txtCodigoPostal.Clear();
            this.LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            this.cbEstado.SelectedIndex = -1;
            this.cbMunicipio.ResetText();
            this.dgvPaqueterias.Rows.Clear();
            this.txtCodigoPostal.Focus();
        }

        private void txtCodigoPostal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;

                //Limpiamos los datos
                this.LimpiarFormulario();

                bool isNumeric = int.TryParse(this.txtCodigoPostal.Text.Trim(), out int codigoPostal);
                if (isNumeric == false)
                {
                    Mensajes.NoExito("Inserte un código postal válido");
                    return;
                }

                this.cbMunicipio.Enabled = true;
                sql = string.Format("SELECT Estado, Municipio FROM Codigos_postales WHERE CodigoPostal={0}",codigoPostal);
                ds = Conexion.Ejecutar(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    ds.Clear();
                    Mensajes.NoExito("No existe el código postal");
                    return;
                }

                this.cbMunicipio.Text = ds.Tables[0].Rows[0]["Municipio"].ToString();
                this.cbEstado.Text = ds.Tables[0].Rows[0]["Estado"].ToString();
                ds.Clear();

                sql= string.Format("SELECT Paqueteria, Ocurre FROM Paqueterias_codigos WHERE CodigoPostal={0}", codigoPostal);
                ds = Conexion.Ejecutar(sql);
                foreach(DataRow paqueteria in ds.Tables[0].Rows)
                {
                    int nuevaFila = dgvPaqueterias.Rows.Add();
                    DataGridViewRow fila = dgvPaqueterias.Rows[nuevaFila];
                    fila.Cells["Paqueteria"].Value = paqueteria["Paqueteria"].ToString();
                    fila.Cells["Ocurre"].Value = paqueteria["Ocurre"].ToString();
                }
                ds.Clear();
            }
        }
    }
}
