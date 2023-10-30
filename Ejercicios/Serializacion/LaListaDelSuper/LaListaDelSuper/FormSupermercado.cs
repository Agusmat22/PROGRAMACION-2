using System.Text.Json;

namespace LaListaDelSuper
{
    public partial class FormSupermercado : Form
    {
        private List<string> listaSupermercado;
        private string rutaAbsolutaDeApp;

        public FormSupermercado()
        {
            InitializeComponent();
            this.listaSupermercado = new List<string>();
        }

        private void FormSupermercado_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar objeto");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar objeto");
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar/Alta de objeto");

            //--------------------ACA BUSCAMOS SI EXISTE UN ARCHIVO QUE CONTENGA PRODUCTOS -----------
            //obtengo la ruta de mi app
            try
            {
                rutaAbsolutaDeApp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string carpeta = "Lista supermercado";
                string nombreArchivo = "lista_productos.json";

                rutaAbsolutaDeApp = Path.Combine(rutaAbsolutaDeApp, carpeta);

                if (Directory.Exists(rutaAbsolutaDeApp))
                {
                    rutaAbsolutaDeApp = Path.Combine(rutaAbsolutaDeApp, nombreArchivo);
                    using (StreamReader streamReader = new StreamReader(rutaAbsolutaDeApp))
                    {
                        //el readToEnd lee todo el archivo de principio a fin
                        string leerTodoElArchivo = streamReader.ReadToEnd();
                        //le paso el archivo leido y automaticamente lo deserializa y lo guardo en la lista
                        this.lstObjetos.DataSource = JsonSerializer.Deserialize<List<string>>(leerTodoElArchivo);
                    }
                }
                else
                {
                    Directory.CreateDirectory(rutaAbsolutaDeApp);
                    rutaAbsolutaDeApp = Path.Combine(rutaAbsolutaDeApp, nombreArchivo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltModificacion formAltModificacion = new FormAltModificacion("Agregar", "Agregar objeto", "");
            DialogResult resultado = formAltModificacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.listaSupermercado.Add(formAltModificacion.Objeto);
                this.lstObjetos.DataSource = null;
                this.lstObjetos.DataSource = this.listaSupermercado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //retorna siempre -1 si es que no se selecciono ningun item
            if (this.lstObjetos.SelectedIndex != -1)
            {
                //elimina el objeto seleccionado por indice
                this.listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
                this.lstObjetos.DataSource = null;
                this.lstObjetos.DataSource = this.listaSupermercado;

            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedIndex != -1)
            {
                FormAltModificacion formAltModificacion = new FormAltModificacion("Modificar", "Modificar objeto", this.lstObjetos.SelectedItem.ToString());
                DialogResult resultado = formAltModificacion.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.listaSupermercado[this.lstObjetos.SelectedIndex] = formAltModificacion.Objeto;
                    this.lstObjetos.DataSource = null;
                    this.lstObjetos.DataSource = this.listaSupermercado;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista para modificar");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                //indico que este identado al momento de guardar osea prolijo
                jsonSerializerOptions.WriteIndented = true;


                using (StreamWriter streamWriter = new StreamWriter(this.rutaAbsolutaDeApp))
                {
                    //serializo la lista
                    string listaSerializada = JsonSerializer.Serialize(this.listaSupermercado);

                    //guardo la lista serializada
                    streamWriter.Write(listaSerializada);
                }

                MessageBox.Show("Guardado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

    
}