using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            List<RutasBE> listaP = new List<RutasBE>();
           RutasController rutacontrola = new RutasController();
           listaP = rutacontrola.VER_RUTA();

            BindingSource rutasourse  = new BindingSource();
           rutasourse.DataSource = listaP;
           cmbruta.DataSource = rutasourse;
           cmbruta.DisplayMember = "RUTA";
           
           

        }

        public void calculo() {
            int num1;
            int num2;
            int resultado;

            num1 = Int32.Parse(txtmonto.Text);
            num2 = Int32.Parse(txtpagacliente.Text);
            resultado = (num2- num1);
            txtvuelto.Text = resultado.ToString();
            
        
        
        }

        public void calculodolares() {
            double num1;
            double num2;
            double resultado;

            num1 = double.Parse(txtmonto.Text);
            num2 = double.Parse(txtpagacliente.Text);
            num1 = (num1 / 540);
            //num2 = (num2 * 540);
            resultado = (num2 - num1);
            txtvuelto.Text = resultado.ToString();
            
        
        }

        public void calcular() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from RUTAS where RUTA='" + cmbruta.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
               
            {
                txtmonto.Text = leer["MONTO"].ToString();
                double monto;
                double monto2;
                
                monto = double.Parse(txtmonto.Text);
                monto2 = (monto / 540);
                txtdolares.Text = monto2.ToString();


               
            }
            else
            {
                MessageBox.Show("No se encontro al conductor");

                
            }
            conexion.Close();
            
        
        
        }
        public void verconductor() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from Conductor where DNI='" + txtcedula.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {

                txtnombre.Text = leer["NOMBRES"].ToString();
                txtcolor.Text = leer["COLOR"].ToString();
                txtplaca.Text = leer["PLACA"].ToString();
                tapellidos.Text = leer["APELLIDOS"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro al conductor");

                txtnombre.Text = "";
                txtcolor.Text = "";
                txtplaca.Text = "";
                tapellidos.Text = "";
            }
            conexion.Close();
            
        
        
        }

        private void vercliente() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from CLIENTE where DNI='" + txtcedulacliente.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {

                txtname.Text = leer["NOMBRES"].ToString();
                txtapellido.Text = leer["APELLIDOS"].ToString();
              

            }
            else
            {
                MessageBox.Show("No se encontro al cliente");

                txtnombre.Text = "";
                txtcolor.Text = "";
                txtplaca.Text = "";
            }
            conexion.Close();
            
        
        }
        private void btnasignachofer_Click(object sender, EventArgs e){
            verconductor();
        
            }

        private void btnasignacliente_Click(object sender, EventArgs e)
        {
            vercliente();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            calcular();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculodolares();
        }
    }
}
