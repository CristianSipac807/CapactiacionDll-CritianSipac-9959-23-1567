using Capa_Controlado_Comboi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Comboi
{
    public partial class ComboI : UserControl
    {
        public ComboI()
        {
            InitializeComponent();
        }
        ModeloComboI controlador = new ModeloComboI();

        public void llenarCombo(string _tabla, string _campo1, string _campo2)
        {

            var dtTabla = controlador.enviarDatos(_tabla, _campo1, _campo2);

            cboPrueba.DataSource = dtTabla;
            cboPrueba.ValueMember = "id_tipo_ruta";
            cboPrueba.DisplayMember = "nombre_tipo_ruta";

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dtTabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["id_tipo_ruta"]) + "-" + Convert.ToString(row["nombre_tipo_ruta"]));
                coleccion.Add(Convert.ToString(row["nombre_tipo_ruta"]) + "-" + Convert.ToString(row["id_tipo_ruta"]));
            }
            cboPrueba.AutoCompleteCustomSource = coleccion;
            cboPrueba.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPrueba.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
