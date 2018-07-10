using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml.Linq;

namespace LeerXML
{
    public partial class LeerXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEnXML(txtId.Text);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void bt_crear_XML_Click(object sender, EventArgs e)
        {
            //crear_XML();
        }


        private void buscarEnXML(string idempleado)
        {
            XDocument miXML = XDocument.Load(@"D:\\Documentos\\Visual Studio 2010\\Projects\\LeerXML\\Sob_219999830019_20150423_1.xml"); //Cargar el documento

            XNamespace nsy = "http://cfe.dgi.gub.uy";
            XNamespace ns0 = "http://cfe.dgi.gub.uy";

            var nombreusu = from xml in miXML.Elements(nsy + "EnvioCFE_entreEmpresas").Elements(nsy + "CFE_Adenda").Elements(ns0 + "CFE")
                            select xml.Elements(ns0 + "eFact").Select(a => a.Value).ToList(); //Seleccionamos el nombre

            foreach (var minom in nombreusu)
            {
                Message.Text = minom.Count.ToString(); //Mostramos un mensaje con el nombre del empleado que corresponde
            }
        }
    }
}