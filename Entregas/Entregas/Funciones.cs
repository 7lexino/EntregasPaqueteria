using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Entregas
{
    class Conexion
    {
        static DataSet ds;

        public static DataSet Ejecutar(string SQL)
        {
            //string ruta = Directory.GetCurrentDirectory(); //Traemos el directorio actual del proyecto
            string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Configuracion.Default.rutaDB + Configuracion.Default.nombreDB + ";";

            try
            {
                OleDbConnection conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();
                ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(SQL, conexion);
                da.Fill(ds);
                conexion.Close();
                conexion.Dispose();
                da.Dispose();
                return ds;
            }
            catch (InvalidOperationException err)
            {
                Mensajes.Excepcion(err.Message);
                return new DataSet();
            }catch (OleDbException err)
            {
                Mensajes.Excepcion(err.Message);
                return new DataSet();
            }catch (Exception err)
            {
                Mensajes.Excepcion(err.Message);
                return new DataSet();
            }
        }
        ~Conexion()
        {
            ds.Dispose();
        }
    }

    class Mensajes
    {
        public static DialogResult Excepcion(string mensaje)
        {
            return MessageBox.Show("Se ha producido un error: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult NoExito(string mensaje)
        {
            return MessageBox.Show(mensaje, "Operación no exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Confirmar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult Exito(string mensaje)
        {
            return MessageBox.Show(mensaje, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class Funciones
    {
        public static int TraerCantidadGuias(string paqueteria, string tipoGuia)
        {
            DataSet ds;
            int cantidad;
            string sql = string.Format("SELECT CantGuias FROM Inv_guias WHERE Paqueteria='{0}' AND TipoGuia='{1}';", paqueteria,tipoGuia);
            ds = Conexion.Ejecutar(sql);
            cantidad = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            ds.Clear();
            return cantidad;
        }

        //Consigue instancia de ventana de frmInventarioBotones
        public static T TraerVentana<T>()
        {
            Form frmResultado = null;
            foreach (Form actual in Application.OpenForms)
            {
                frmResultado = actual.GetType() == typeof(T) ? actual : frmResultado;
            }
            if (frmResultado == null)
            {
                //Si no está la ventana abierta lanzamos una excepción
                throw new IndexOutOfRangeException("La ventana " + typeof(T).Name + " no está abierta.");
            }
            return (T)Convert.ChangeType(frmResultado, typeof(T));
        }
    }
}
