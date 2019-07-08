using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConvertidorPDFToWord
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog CarpetaSalida;
        bool Convertir = false;
        string RutaArchivoOrigen;
        string NombreArchivoOrigen;
        string RutaArchivoDestino;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArchivoOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDiagolo=new OpenFileDialog();
           // CajaDiagolo.Filter = "Archivo PDF(.pdf)|*.pdf!";

                DialogResult Resultado= CajaDiagolo.ShowDialog();
            if (Resultado==DialogResult.OK){
                RutaArchivoOrigen = CajaDiagolo.FileName;
                NombreArchivoOrigen = Path.GetFileNameWithoutExtension(RutaArchivoOrigen);
                RutaArchivoDestino = Path.GetDirectoryName(RutaArchivoOrigen);
                txtCarpetaDestino.Text = RutaArchivoDestino;
                txtArchivoOrigen.Text = RutaArchivoOrigen.ToString();
                Convertir = true;
            }
        }

        private void btnCarpetaDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();
            if (CarpetaSalida.ShowDialog() == DialogResult.OK) {

                txtCarpetaDestino.Text = CarpetaSalida.SelectedPath;
                RutaArchivoDestino = txtCarpetaDestino.Text;
                Convertir = true;

                

            }
        }

        private void btnConvertirWord_Click(object sender, EventArgs e)
        {

            this.progressBar1.Increment(1);
            if (Convertir) {
               // this.progressBar1.Increment(20);
                SautinSoft.PdfFocus ArchivoPDF = new SautinSoft.PdfFocus();
               // this.progressBar1.Increment(30);
                ArchivoPDF.OpenPdf(@RutaArchivoOrigen);
               // this.progressBar1.Increment(25);
                ArchivoPDF.ToWord(@RutaArchivoDestino + "\\" + NombreArchivoOrigen + ".docx");
              //  this.progressBar1.Increment(25);
                System.Diagnostics.Process.Start(@RutaArchivoDestino);
              //Proceso Terminado
                MessageBox.Show("Archivo Convertido x Sebithaxx");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Esto ya no se usa!
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
