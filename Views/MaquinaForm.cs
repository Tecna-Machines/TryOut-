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

namespace Views
{
    public partial class MaquinaForm : Form
    {
        private readonly IMaquinaService _service;
        public MaquinaForm(IMaquinaService service)
        {
            InitializeComponent();
            FormUtility.setBasicStyles(this);
            _service = service;
        }

        private void clickCrearMaquina(object sender, EventArgs e)
        {
            var maquinaDTO = new MaquinaDTO
            {
                Nombre = this.name.Text,
                Descripcion = this.descripcion.Text,
                NumMaquina = this.model.Text,
                FechaCreacion = DateTime.Now
            };

            try
            {
                var maquina =_service.CrearNuevaMaquina(maquinaDTO);
                MessageBox.Show("se agrego una maquina nueva: la M-"+maquina.NumMaquina);

                this.name.Text = "";
                this.descripcion.Text = "";
                this.model.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un problema"+ex);
            }
            
        }
    }
}
