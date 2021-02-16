using Domain;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Importarfrm : Form, ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Importarfrm _instance = null;
        DataTable dt = new DataTable();
        public Importarfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Importarfrm GetInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new Importarfrm(serviciosAplicacion);
            return _instance;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = ".csv|*.csv";
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();

            Cursor.Current = Cursors.WaitCursor;
            csvdg.DataSource = "";

            if (Path.GetExtension(openFileDialog.FileName) == ".csv")
            {
                try
                {
                    using (TextReader tr = File.OpenText(openFileDialog.FileName))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string line;
                        while ((line = tr.ReadLine()) != null)
                        {
                            string[] items = line.Split(';');
                            if (dt.Columns.Count == 0)
                            {
                                for (int i = 0; i < items.Length; i++)
                                    dt.Columns.Add(new DataColumn(items[i], typeof(string)));
                            }
                            else
                            {
                                dt.Rows.Add(items);
                            }
                        }
                        csvdg.DataSource = dt;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "");
                }
                
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dt = (DataTable)(csvdg.DataSource);
            remito_stockBLL _StockBLL = new remito_stockBLL();
            try
            {
                if (!_StockBLL.validaDatos(dt))
                {
                    MessageBox.Show("No se puede guardar porque contiene errores, verifique el log.", "strings.Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Proceso correcto.", "strings.Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }

        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            impbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Importar);
            savebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Guardar);
            openFileDialog.Title = _traductorUsuario.Traducir(ConstantesTexto.Importar);
        }
    }
}