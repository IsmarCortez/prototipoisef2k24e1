using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_RRHH
{
    public partial class MantenimientoExamen : Form
    {
        public MantenimientoExamen()
        {
            InitializeComponent();


            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "Codigo Facu.", "Nombre", "estatus", "estado"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("facultades");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Facultades");
            /**********************************************/

            ///********Valores foraneos en Combobox************************/

            //navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
            //navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);
            ///**************************************************/

        }
    }
}
