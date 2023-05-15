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
using System.IO.Compression;
using System.Linq.Expressions;

namespace ambiente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //const string RouteActualizadorSource = "\\Actualizador\\Source";

            if (LabelDirectory.Text.Length > 0)
            {
                Directory.CreateDirectory(@LabelDirectory.Text);
            }

            Directorios();
            //compression(LabelDirectory.Text + RouteActualizadorSource, textBoxActualicer.Text);            
        }

        /* Directorio principal del ambiente */
        private void MenuDirectory_Click(object sender, EventArgs e)
        {
            string Ruta = string.Empty;

            FolderBrowserDialog fldr = new FolderBrowserDialog();

            fldr.Description = "Seleccione la ruta donde creara el ambiente.";
            fldr.RootFolder = Environment.SpecialFolder.Desktop;

            if(fldr.ShowDialog() == DialogResult.OK )
            {
               Ruta = fldr.SelectedPath;
               LabelDirectory.Text = Ruta;
                Ruta = LabelDirectory.Text + "\\Worldsys\\PROYECTOS\\BT4";
                LabelDirectory.Text = Ruta;
            }

        }

        /* Directorio de los Archivos (Seccion File) */
        private void buttonActualizador_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxActualicer.Text = openFileDialog.FileName;
            }

        }
        private void buttonPackage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPackage.Text = openFileDialog.FileName;
            }
        }

        private void buttonEncripter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEncripter.Text = openFileDialog.FileName;
            }
        }

        /* Recracion de los directorios */

        private void Directorios()
        {
            string[] DirectoryAmbient = { "\\Actualizador", "\\AGENTE", "\\Credenciales", "\\Encriptador", "\\Listas", "\\Logs", "\\WEB", "\\WEBAPI"};
            string source = "\\Source";

            for(int i=0; i<DirectoryAmbient.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Directory.CreateDirectory(@LabelDirectory.Text + @DirectoryAmbient[i] + @source);
                        compression(LabelDirectory.Text + @DirectoryAmbient[i], textBoxActualicer.Text);
                        compression(LabelDirectory.Text + @DirectoryAmbient[i] + @source, textBoxPackage.Text);
                        break;

                    case 1:
                        Agent(@LabelDirectory.Text + @DirectoryAmbient[i]);
                        break;
                    case 3:
                        Directory.CreateDirectory(@LabelDirectory.Text + @DirectoryAmbient[i]);
                        compression(LabelDirectory.Text + @DirectoryAmbient[i], textBoxEncripter.Text);
                        break;
                    case 5:
                        Agent(@LabelDirectory.Text + @DirectoryAmbient[i]);
                        break;
                    default:
                        Directory.CreateDirectory(@LabelDirectory.Text + @DirectoryAmbient[i]);
                        break;
                }
            }
            
        }

        /* Descompresion de los archivos */
        private void compression(string path, string pathZip)
        {
            ZipFile.ExtractToDirectory(@pathZip, path);
        }

        private void Agent(string path)
        {
            string[] Agentes = { "\\Agente600", "\\Agente800", "\\Agente880", "\\Agente920" };
            string[] Paralelo = { "\\Console", "\\Service", "\\Actualizador" };

            if (checkBoxAgente600.Checked == true)
            {
                if (Path.GetFileName(path) == "AGENTE")
                {
                    Directory.CreateDirectory(@path + Agentes[0] + Paralelo[0]);
                    Directory.CreateDirectory(@path + Agentes[0] + Paralelo[1]);
                } else if (Path.GetFileName(path) == "Logs")
                {
                    Directory.CreateDirectory(@path + Agentes[0]);
                    Directory.CreateDirectory(@path + Paralelo[2]);
                } else { Directory.CreateDirectory(@path + Agentes[0]); }
            }
            if (checkBoxAgente800.Checked == true)
            {
                if (Path.GetFileName(path) == "AGENTE")
                {
                    Directory.CreateDirectory(@path + Agentes[1] + Paralelo[0]);
                    Directory.CreateDirectory(@path + Agentes[1] + Paralelo[1]);
                }
                else if (Path.GetFileName(path) == "Logs")
                {
                    Directory.CreateDirectory(@path + Agentes[1]);
                    Directory.CreateDirectory(@path + Paralelo[2]);
                }
                else { Directory.CreateDirectory(@path + Agentes[1]); }
            }
            if (checkBoxAgente880.Checked == true)
            {
                if (Path.GetFileName(path) == "AGENTE")
                {
                    Directory.CreateDirectory(@path + Agentes[2] + Paralelo[0]);
                    Directory.CreateDirectory(@path + Agentes[2] + Paralelo[1]);
                }
                else if (Path.GetFileName(path) == "Logs")
                {
                    Directory.CreateDirectory(@path + Agentes[2]);
                    Directory.CreateDirectory(@path + Paralelo[2]);
                }
                else { Directory.CreateDirectory(@path + Agentes[2]); }
            }
            if (checkBoxAgente920.Checked == true)
            {
                if (Path.GetFileName(path) == "AGENTE")
                {
                    Directory.CreateDirectory(@path + Agentes[3] + Paralelo[0]);
                    Directory.CreateDirectory(@path + Agentes[3] + Paralelo[1]);
                }
                else if (Path.GetFileName(path) == "Logs")
                {
                    Directory.CreateDirectory(@path + Agentes[3]);
                    Directory.CreateDirectory(@path + Paralelo[2]);
                }
                else { Directory.CreateDirectory(@path + Agentes[3]); }
            }
        }
    }
}
