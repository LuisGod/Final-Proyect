using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Solicitud_servicio : Form
    {
        public Solicitud_servicio()
        {
            InitializeComponent();
        }

        private void Solicitud_servicio_Load(object sender, EventArgs e)
        {
             SolicitudController sc= new SolicitudController();
            List<ConductorBE> listaP = new List<ConductorBE>();
            SolicitudController Conductorcontrola = new SolicitudController();
            listaP = Conductorcontrola.VERCHOFER();

            BindingSource  chofersourse = new BindingSource();
            chofersourse.DataSource = listaP;
            cmbconductor.DataSource =  chofersourse;
            cmbconductor.DisplayMember = "NOMBRES";
         
                  
           
           

          cmbconductor.ValueMember = "ID";
        }
    }
}
