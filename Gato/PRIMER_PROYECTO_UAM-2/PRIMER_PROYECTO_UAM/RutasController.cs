using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRIMER_PROYECTO_UAM
{
    class RutasController
    {

        public bool REGISTRARUTAS(RutasBE ruta)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);

                comando.CommandText = "REGISTRA_RUTAS";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RUTA", ruta.RUTA);
                comando.Parameters.AddWithValue("@DISTANCIAKM", ruta.DISTANCIAKM);


                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                result = true;
            }
            catch (SqlException e)
            {
                //insert error in a log
                result = false;
            }
            return result;
        }


        public List<RutasBE> VER_RUTA()
        {
            List<RutasBE> listResult = new List<RutasBE>();
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);
                SqlDataReader inforutaReader;

                comando.CommandText = "VER_RUTA";
                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                inforutaReader = comando.ExecuteReader();

                while (inforutaReader.Read())
                {
                    RutasBE RUTA = new RutasBE();

                    RUTA.RUTA = inforutaReader["RUTA"].ToString();
                    RUTA.DISTANCIAKM = Convert.ToInt32(inforutaReader["DISTANCIAKM"]);


                    listResult.Add(RUTA);
                }

                conexion.Close();
            }
            catch (SqlException e)
            {

            }
            return listResult;
        }


    }
}
