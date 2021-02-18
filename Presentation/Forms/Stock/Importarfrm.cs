using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Importarfrm : Form, ISubscriptorCambioIdioma
    {
        #region FormSettings
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Importarfrm _instance = null;
        private string NombreArchivo = null;
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
        #endregion
        #region FormActions
        private void impbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            openFileDialog.Filter = ".csv|*.csv";
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();
            Cursor.Current = Cursors.WaitCursor;
            csvdg.DataSource = "";
            if (Path.GetExtension(openFileDialog.FileName) == ".csv")
            {
                using (TextReader tr = File.OpenText(openFileDialog.FileName))
                {
                    NombreArchivo = openFileDialog.SafeFileName;
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
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                _serviciosAplicacion.RemitoStock.Create(GetRemitos(csvdg));
                this.MostrarDialogoInformacion(_traductorUsuario, ConstantesTexto.ComprobanteGenerado);
                csvdg.DataSource = "";
            }
            catch(Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }       
        }
        #endregion
        #region PrivateFunctions
        private List<RemitoStock> GetRemitos (DataGridView dg)
        {
            List<RemitoStock> remitoStocks = new List<RemitoStock>();
            foreach (DataGridViewRow dr in dg.Rows)
            {
                remitoStocks.Add(new RemitoStock()
                {
                    fecha_remito = Convert.ToDateTime(dr.Cells[0].Value.ToString()),
                    cuit_empresa = dr.Cells[1].Value.ToString(),
                    letra_remito = dr.Cells[2].Value.ToString(),
                    sucursal_remito = dr.Cells[3].Value.ToString(),
                    numero_remito = dr.Cells[4].Value.ToString(),
                    regis_tipo_doc = Convert.ToInt32(dr.Cells[5].Value),
                    numero_doc = Convert.ToInt32(dr.Cells[6].Value.ToString()),
                    nombres_destinatario = dr.Cells[7].Value.ToString(),
                    apellidos_destinatario = dr.Cells[8].Value.ToString(),
                    domicilio_destinatario = dr.Cells[9].Value.ToString(),
                    codigo_postal_destinatario = dr.Cells[10].Value.ToString(),
                    te_linea_destinatario = dr.Cells[11].Value.ToString(),
                    te_celular_destinatario = dr.Cells[12].Value.ToString(),
                    email_dest_destinatario = dr.Cells[13].Value.ToString(),
                    fecha_entrega = Convert.ToDateTime(dr.Cells[14].Value.ToString()),
                    franja_horario_entrega = dr.Cells[15].Value.ToString(),
                    fecha_retiro = Convert.ToDateTime(dr.Cells[16].Value.ToString()),
                    domicilio_retiro_Cliente = dr.Cells[17].Value.ToString(),
                    codigo_postal_retiro_Cliente = dr.Cells[18].Value.ToString(),
                    cantidad_bultos = Convert.ToInt32(dr.Cells[19].Value),
                    codigo_fs = dr.Cells[20].Value.ToString(),
                    peso_kg = Convert.ToInt32(dr.Cells[21].Value),
                    ancho_cm = Convert.ToInt32(dr.Cells[22].Value),
                    largo_cm = Convert.ToInt32(dr.Cells[23].Value.ToString()),
                    alto_cm = Convert.ToInt32(dr.Cells[24].Value.ToString()),
                    nm_archivo = NombreArchivo
                });
            }
            return remitoStocks;
        }
        #endregion
        #region Language
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            impbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Importar);
            savebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Guardar);
            openFileDialog.Title = _traductorUsuario.Traducir(ConstantesTexto.Importar);
        }
        #endregion
    }
}