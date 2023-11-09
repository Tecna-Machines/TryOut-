using Applicacion.DTO;
using Applicacion.Interfaces.IServices;
using Views.Utilities;

namespace Views.Screens
{
    public partial class PruebaForm : Form
    {
        private readonly IMaquinaService _service;
        public Home HomeForm;
        public PruebaForm(IMaquinaService service, Home homeForm)
        {
            InitializeComponent();
            FormUtility.setBasicStyles(this);
            ButtonUtility.ConfigurationButtons(this.btnListo, this.btnVolver);
            _service = service;

            this.addOptionListBox();
            HomeForm = homeForm;
        }

        private async void addOptionListBox()
        {
            IEnumerable<MaquinaDTO> maquinas = await _service.ConseguirTodasLasMaquinas();

            foreach (var maquina in maquinas)
            {
                if (maquina.NumMaquina != null)
                {
                    this.optionsMachineSelect.Items.Add(maquina.NumMaquina + " -" + maquina.Nombre);
                }
            }

        }

        private void volverInicio(object sender, EventArgs e)
        {
            this.Hide();
            if (HomeForm != null && !HomeForm.IsDisposed)
            {
                HomeForm.Show();
            }
        }
    }
}
