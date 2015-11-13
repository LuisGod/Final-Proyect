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

        public static ConductorBE ObtenerConductor(int pPlaca)
        {
            ConductorBE pConductor = new ConductorBE();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = new SqlCommand(String.Format("SELECT PLACA, AñO, COLOR, NOMBRES,APELLIDOS, DNI, EDAD, DIRECCION, PROVINCIA FROM CONDUCTOR where PLACA ='{0}'", pPlaca), conexion);
            SqlDataReader cconductor;

            conexion.Open();

            cconductor = comando.ExecuteReader();
            while (cconductor.Read())
            {

                pConductor.Placa = cconductor.GetString(0);
                pConductor.Año = cconductor.GetString(1);
                pConductor.Color = cconductor.GetString(2);
                pConductor.Nombres = cconductor.GetString(3);
                pConductor.Apellidos = cconductor.GetString(4);
                pConductor.DNI = cconductor.GetString(5);
                pConductor.Edad = cconductor.GetString(6);
                pConductor.Direccion = cconductor.GetString(7);
                pConductor.Provincia = cconductor.GetString(8);


            }

            conexion.Close();
            return pConductor;

        }
    }
}
