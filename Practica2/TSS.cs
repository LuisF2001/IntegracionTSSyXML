
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLCREACION;

namespace Practica2
{
    public partial class TSS : Form
    {
        
        string fileName = "C:\\Users\\luisf\\source\\repos\\ejemplo.xml";
        public TSS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdLeerRutaFija_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                    {
                    String line = sr.ReadToEnd();
                    TxtContenidoArchivo.Text = line; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            openFileDialog1.ShowDialog();

            string archivo = openFileDialog1.FileName;

            if (archivo.Trim().Length > 0)
                // Open the selected file to read.

                using (StreamReader sr = new StreamReader(archivo))
                {

                    TxtContenidoArchivo.Text = sr.ReadToEnd();
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdLlenarGrid_Click(object sender, EventArgs e)
        {
            string line;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Campo");
            dt.Columns.Add("Tipo Dato");
            dt.Columns.Add("Posicion Inicial");
            dt.Columns.Add("Posicion Final");
            dt.Columns.Add("Longitud");
            dt.Columns.Add("Descripcion");

            // lee linea a linea 
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\luisf\\source\\repos\\TSS.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] registro = line.Split(',');
                DataRow fila = dt.NewRow();
                fila["Campo"] = registro[0];
                fila["Tipo Dato"] = registro[1];
                fila["Posicion Inicial"] = registro[2];
                fila["Posicion Final"] = registro[3];
                fila["Longitud"] = registro[4];
                fila["Descripcion"] = registro[5];


                dt.Rows.Add(fila);
            }

            file.Close();
            DgvResultados.DataSource = dt;
            DgvResultados.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            writeFileLine("Id,int,1,1,1,Numero identificador");
            writeFileLine("Nombre,Varchar,2,10,50,Nombres y apellidos del empleado");
            writeFileLine("DNI/Pasaporte, numeric,5,20,20,numero de pasaporte o DNI");
            MessageBox.Show("Archivo generado con exito");
        }
        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(fileName))
            {
                w.WriteLine(pLine);
            }
        }

        private void cmdGenFile_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ocon = Conexion.getConnection();
                SqlDataReader reader;
                string sSQL = "select Id, Nombre, DNIoPasaporte, Fecha_de_Nacimiento ";
                sSQL += "from TSSdb ";
                sSQL += "order by Nombre ";
                SqlCommand ocmd = new SqlCommand(sSQL, ocon);

                reader = ocmd.ExecuteReader();
                while (reader.Read())
                {
                    writeFileLine(reader.GetValue(0) + "," + reader.GetValue(1) + "," + reader.GetValue(2) + "," + reader.GetValue(3));
                }
                reader.Close();
                ocmd.Dispose();
                ocon.Close();
                MessageBox.Show("Archivo generado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos... " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           XML xML = new XML();
            xML.Show();
            this.Hide();
        }
    }
    }
