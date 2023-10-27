namespace SiempreQuiseTenerUnNotepad
{
    public partial class Form1 : Form
    {
        private string rutaAbsolutaGuardada;
        private int cantidadCaracteres;
        public Form1()
        {
            InitializeComponent();

            //Esto agrega un atajo presionando Ctrl + A se va abrir
            this.abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            //inicializo el atributo
            this.cantidadCaracteres = 0;
        }



        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esta clase abre un seleccionador de archivos
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //showDialog mostrara para abrir dicho archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                string contenidoGuardado = streamReader.ReadToEnd();

                richTextBox1.Text = contenidoGuardado;
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //pregunto si el directorio existe
                if (!Directory.Exists(this.rutaAbsolutaGuardada))
                {
                    //Obtengo la ruta del escritorio de la pc
                    string rutaAbsolutaDelDirectorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    //Le agrego una carpeta y combino la ruta
                    this.rutaAbsolutaGuardada = Path.Combine(rutaAbsolutaDelDirectorio, $"Blocs de notas");
                    //creo el directorio
                    Directory.CreateDirectory(this.rutaAbsolutaGuardada);
                }

                //indico el tipo de archivo
                string archivoTxt = "caracteres.txt";
                //combino con la ruta
                this.rutaAbsolutaGuardada = Path.Combine(rutaAbsolutaGuardada, archivoTxt);
                //instancio la clase y le paso la ruta donde esta ubicado el directorio y con el nombre del archivo y su tipo
                using (StreamWriter streamWriter = new StreamWriter(this.rutaAbsolutaGuardada))
                {
                    streamWriter.Write(this.richTextBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = $"{this.tsslCantidadCaracteres.Name}.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.rutaAbsolutaGuardada = saveFileDialog1.FileName;

                    using (StreamWriter streamWriter = new StreamWriter(this.rutaAbsolutaGuardada))
                    {
                        streamWriter.Write(this.richTextBox1.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 49 && e.KeyValue < 256)
            {
                this.cantidadCaracteres += 1;
            }
            else if (e.KeyCode == Keys.Back && this.cantidadCaracteres > 0)
            {
                this.cantidadCaracteres -= 1;
            }

            this.tsslCantidadCaracteres.Text = $"{this.cantidadCaracteres} caracteres";
        }

        private void tsslCantidadCaracteres_Click(object sender, EventArgs e)
        {

        }
    }
}