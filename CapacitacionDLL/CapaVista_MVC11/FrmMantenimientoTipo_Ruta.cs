using CapaControlador_MVC1.Modelos_de_controladores;
using CapaControlador_MVC1.Objetos_de_valor.EstadoEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MVC11
{
    public partial class FrmMantenimientoTipo_Ruta : Form
    {
        private ModeloTipo_Ruta tipoRuta = new ModeloTipo_Ruta();

        public FrmMantenimientoTipo_Ruta()
        {
            InitializeComponent();
            PnlDatos.Enabled = false;
            CargarDatos();
        }

        private void FrmTipoRuta_Load(object sender, EventArgs e)
        {
            ListaTipo_Ruta();
            
        }
        private void ListaTipo_Ruta()
        {
            try
            {
                DgvListaTipo_Ruta.DataSource = tipoRuta.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            PnlDatos.Enabled = true;
            tipoRuta.Estado = EstadoEntidad.Added;
        }

        private void Reinicio()
        {
            TxtNombreTipo_Ruta.Clear();
            TxtDescripcionTipo_Ruta.Clear();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                tipoRuta.NombreTipoRuta = TxtNombreTipo_Ruta.Text;
                tipoRuta.DescripcionTipoRuta = TxtDescripcionTipo_Ruta.Text;
                tipoRuta.Estado = EstadoEntidad.Added;

                bool valido = new Ayudas.ValidacionDatos(tipoRuta).Validar();
                if (valido == true)
                {
                    string resultado = tipoRuta.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaTipo_Ruta();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvListaTipo_Ruta.SelectedRows.Count > 0)
            {
                tipoRuta.Estado = EstadoEntidad.Modified;
                tipoRuta.IdTipoRuta = Convert.ToInt32(DgvListaTipo_Ruta.CurrentRow.Cells[0].Value);
                tipoRuta.NombreTipoRuta = TxtNombreTipo_Ruta.Text;
                tipoRuta.DescripcionTipoRuta = TxtDescripcionTipo_Ruta.Text;

                bool valido = new Ayudas.ValidacionDatos(tipoRuta).Validar();
                if (valido == true)
                {
                    string resultado = tipoRuta.GrabarCambios();
                    MessageBox.Show(resultado);
                    ListaTipo_Ruta();
                    Reinicio();
                }
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListaTipo_Ruta.SelectedRows.Count > 0)
            {
                tipoRuta.Estado = EstadoEntidad.Deleted;
                tipoRuta.IdTipoRuta = Convert.ToInt32(DgvListaTipo_Ruta.CurrentRow.Cells[0].Value);

                string resultado = tipoRuta.GrabarCambios();
                MessageBox.Show(resultado);
                ListaTipo_Ruta();
                Reinicio();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void DgvListaTipo_Ruta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvListaTipo_Ruta.SelectedRows.Count > 0)
            {
                tipoRuta.Estado = EstadoEntidad.Modified;
                TxtNombreTipo_Ruta.Text = DgvListaTipo_Ruta.CurrentRow.Cells[1].Value.ToString();
                TxtDescripcionTipo_Ruta.Text = DgvListaTipo_Ruta.CurrentRow.Cells[2].Value.ToString();
            }
        }

        void CargarDatos()
        {
            comboI1.llenarCombo("tbl_id_tipo_ruta", "id_tipo_ruta", "nombre_tipo_ruta");

        }
    }
}
