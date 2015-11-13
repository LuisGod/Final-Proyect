using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class SolicitudController
    {
        public List<ConductorBE> VERCHOFER()
        {

            ConductorBE conductorBE;
            List<ConductorBE> listaResulta = new List<ConductorBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader conductor;

            comando.CommandText = "VERCHOFER";
            comando.CommandType = CommandType.StoredProcedure;


            conexion.Open();

            conductor = comando.ExecuteReader();
            while (conductor.Read())
            {
                conductorBE = new ConductorBE();


                conductorBE.Nombres = conductor["NOMBRES"].ToString();
                conductorBE.Apellidos = conductor["APELLIDOS"].ToString();
                
                //conductorBE.ID= int.Parse(conductor["ID"].ToString());
                //conductorBE.Placa = conductor["PLACA"].ToString();

                listaResulta.Add(conductorBE);

            }

            conexion.Close();

            return listaResulta;

        }

    }
}
