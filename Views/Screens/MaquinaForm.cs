using Applicacion.DTO;
using Applicacion.Interfaces.IServices;
using Views.Utilities;

namespace Views
{
    public partial class MaquinaForm : Form
    {
        private readonly IMaquinaService _service;
        public Home HomeForm;
        public MaquinaForm(IMaquinaService service, Home homeForm)
        {
            InitializeComponent();
            FormUtility.setBasicStyles(this);
            _service = service;
            HomeForm = homeForm;
        }

        private async void clickCrearMaquina(object sender, EventArgs e)
        {
            var nombreMaquina = this.name.Text;
            var descripcionMaquina = this.descripcion.Text;
            var numMaquina = this.model.Text;

            if (nombreMaquina.Length < 3 || numMaquina.Length < 1)
            {
                MessageBox.Show("revisa bien los datos ingresados..");
                return;
            }

            var maquinaDTO = new MaquinaDTO
            {
                Nombre = nombreMaquina,
                Descripcion = descripcionMaquina,
                NumMaquina = numMaquina
            };

            try
            {
                var maquina = await _service.CrearNuevaMaquina(maquinaDTO);
                MessageBox.Show("se agrego una maquina nueva: la M-" + maquina.NumMaquina);

                TextBoxUtility.LimpiarTextBox(this.name, this.descripcion, this.model);

            }
            catch (InvalidOperationException exce)
            {
                MessageBox.Show("esta maquina ya existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un problema" + ex);
            }

        }

        private void btnVolverInicio(object sender, EventArgs e)
        {
            this.Hide();
            if (HomeForm != null && !HomeForm.IsDisposed)
            {
                HomeForm.Show();
            }
        }
    }
}
