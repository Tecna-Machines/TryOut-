using Applicacion.Interfaces.IServices;
using Views.Screens;
using Views.Utilities;

namespace Views
{
    public partial class Home : Form
    {
        private readonly IMaquinaService _service;
        public Home(IMaquinaService service)
        {
            InitializeComponent();
            FormUtility.setBasicStyles(this);
            _service = service;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void clickBtnCrearMaquina(object sender, EventArgs e)
        {
            Form maquinaForm = new MaquinaForm(_service,this);
            maquinaForm.Show();

            this.Hide();
        }

        private void clickBtnIniciarPrueba(object sender, EventArgs e)
        {
            Form pruebaForm = new PruebaForm();
            pruebaForm.Show();
            this.Hide();
        }

        private void imgRobot_Click(object sender, EventArgs e)
        {

        }
    }
}