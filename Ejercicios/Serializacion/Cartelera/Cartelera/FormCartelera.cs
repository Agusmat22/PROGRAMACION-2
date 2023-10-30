using Entidades;
using System.Text.Json;
using System.Xml.Serialization;

namespace Cartelera
{
    public partial class FormCartelera : Form
    {
        private static string rutaConfiguracion;

        public FormCartelera()
        {
            InitializeComponent();
        }

        static FormCartelera()
        {
            rutaConfiguracion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(rutaConfiguracion))
            {
                Directory.CreateDirectory(rutaConfiguracion);
            }

            rutaConfiguracion = Path.Combine(rutaConfiguracion, "configuacion.json");
        }


        private void btnColorFondoPanel_Click(object sender, EventArgs e)
        {
            this.colorDialog1 = new ColorDialog();

            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pnlCartelera.BackColor = colorDialog1.Color;

            }

        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            this.colorDialog1 = new ColorDialog();

            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lblTitulo.ForeColor = colorDialog1.Color;

            }
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            this.colorDialog1 = new ColorDialog();

            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lblMensaje.ForeColor = colorDialog1.Color;
            }

        }

        private void txtTitulo_TextChanged_1(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void FormCartelera_Load(object sender, EventArgs e)
        {
            if (File.Exists(rutaConfiguracion))
            {
                try
                {
                    using (StreamReader streamWriter = new StreamReader(rutaConfiguracion))
                    {
                        string archivoLeido = streamWriter.ReadToEnd();

                        Cartel cartel = JsonSerializer.Deserialize<Cartel>(archivoLeido);

                        pnlCartelera.BackColor = Color.FromArgb(cartel.ColorARGB);

                        txtTitulo.Text = cartel.Titulo.Contenido;
                        lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                        rtxtMensaje.Text = cartel.Mensaje.Contenido;
                        lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartelera.BackColor.ToArgb(), titulo, mensaje);

            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                using (StreamWriter streamWriter = new StreamWriter(rutaConfiguracion))
                {
                    string archivoLeido = JsonSerializer.Serialize(cartel, opciones);
                    streamWriter.Write(archivoLeido);

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            this.ImportarConfiguracion();
        }


        private void ImportarConfiguracion()
        {
            OpenFileDialog seleccionadorDeArchivo = new OpenFileDialog();

            if (seleccionadorDeArchivo.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(seleccionadorDeArchivo.FileName))
                {
                    rutaConfiguracion = seleccionadorDeArchivo.FileName;
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(seleccionadorDeArchivo.FileName))
                        {
                            string archivoLeido = streamReader.ReadToEnd();

                            Cartel cartel = JsonSerializer.Deserialize<Cartel>(archivoLeido);

                            pnlCartelera.BackColor = Color.FromArgb(cartel.ColorARGB);

                            txtTitulo.Text = cartel.Titulo.Contenido;
                            lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                            rtxtMensaje.Text = cartel.Mensaje.Contenido;
                            lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                        }
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                if (File.Exists(rutaConfiguracion))
                {
                    File.Delete(rutaConfiguracion);

                    txtTitulo.Text = "Título";
                    lblTitulo.ForeColor = Control.DefaultForeColor;

                    rtxtMensaje.Text = "Mensaje";
                    lblMensaje.ForeColor = Control.DefaultForeColor;

                    pnlCartelera.BackColor = Control.DefaultBackColor;
                }
            }
        }
    }
}