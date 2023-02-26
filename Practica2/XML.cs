using Practica2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLCREACION
{
    public partial class XML : Form
    {
        public XML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("AsientoContable");
            doc.AppendChild(raiz);

            XmlElement asientocontable = doc.CreateElement("AsientoContable");
            raiz.AppendChild(asientocontable);

            XmlElement descripcionasiento = doc.CreateElement("DescripcionDelAsiento");
            descripcionasiento.AppendChild(doc.CreateTextNode("Facturas por pagar"));
            asientocontable.AppendChild(descripcionasiento);

            XmlElement fechaasiento = doc.CreateElement("FechaDelAsiento");
            fechaasiento.AppendChild(doc.CreateTextNode("25/02/2023"));
            asientocontable.AppendChild(fechaasiento);

            XmlElement detalleasiento = doc.CreateElement("Detalle");
            detalleasiento.AppendChild(doc.CreateTextNode("XXXXXXX"));
            asientocontable.AppendChild(detalleasiento);

            XmlElement noasiento = doc.CreateElement("NumeroDeAsiento");
            noasiento.AppendChild(doc.CreateTextNode("20"));
            asientocontable.AppendChild(noasiento);

            XmlElement cuentacontable = doc.CreateElement("CuentaContable");
            cuentacontable.AppendChild(doc.CreateTextNode("25/02/2023 Cuenta Personal"));
            asientocontable.AppendChild(cuentacontable);

            XmlElement montomovimiento = doc.CreateElement("Monto");
            montomovimiento.AppendChild(doc.CreateTextNode("RD1,000"));
            asientocontable.AppendChild(montomovimiento);

            XmlElement tipomovimiento = doc.CreateElement("TipoDeMovimiento");
            tipomovimiento.AppendChild(doc.CreateTextNode("DB, CR"));
            asientocontable.AppendChild(tipomovimiento);

            XmlElement tipo = doc.CreateElement("Tipo");
            tipo.AppendChild(doc.CreateTextNode("DB o CR"));
            asientocontable.AppendChild(tipo);

            //nuevo asientocontable
            asientocontable = doc.CreateElement("AsientoContable");
            raiz.AppendChild(asientocontable);

             asientocontable = doc.CreateElement("AsientoContable");
            raiz.AppendChild(asientocontable);

            descripcionasiento = doc.CreateElement("DescripcionDelAsiento");
            descripcionasiento.AppendChild(doc.CreateTextNode("Efectivos Ventas"));
            asientocontable.AppendChild(descripcionasiento);

             fechaasiento = doc.CreateElement("FechaDelAsiento");
            fechaasiento.AppendChild(doc.CreateTextNode("26-02-2023"));
            asientocontable.AppendChild(fechaasiento);

            detalleasiento = doc.CreateElement("Detalle");
            detalleasiento.AppendChild(doc.CreateTextNode("Para registrar ventas al contado"));
            asientocontable.AppendChild(detalleasiento);

            noasiento = doc.CreateElement("NumeroDeAsiento");
            noasiento.AppendChild(doc.CreateTextNode("4"));
            asientocontable.AppendChild(noasiento);

             cuentacontable = doc.CreateElement("CuentaContable");
            cuentacontable.AppendChild(doc.CreateTextNode("26-02-2023 Cuenta Personal"));
            asientocontable.AppendChild(cuentacontable);

             montomovimiento = doc.CreateElement("Monto");
            montomovimiento.AppendChild(doc.CreateTextNode("RD500"));
            asientocontable.AppendChild(montomovimiento);

            tipomovimiento = doc.CreateElement("TipoDeMovimiento");
            tipomovimiento.AppendChild(doc.CreateTextNode("DB, CR"));
            asientocontable.AppendChild(tipomovimiento);

             tipo = doc.CreateElement("Tipo");
            tipo.AppendChild(doc.CreateTextNode("DB o CR"));
            asientocontable.AppendChild(tipo);

            doc.Save("C:\\Users\\luisf\\OneDrive\\Escritorio\\UNI\\XML\\archivo.xml");
            MessageBox.Show("Se a agregado un nuevo archivo XML... ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TSS tSS = new TSS();
            tSS.Show();
            this.Close();
        }
    }
}
