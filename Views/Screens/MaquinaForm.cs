using Applicacion.DTO;
using Applicacion.Interfaces.IRepositories;
using Applicacion.Interfaces.IServices;
using Applicacion.UseCase.Maquinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            var foundMachine = await _service.ConsultarMaquinaById(numMaquina);

            if (foundMachine != null)
            {
                MessageBox.Show("esa maquina ya existe");
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
