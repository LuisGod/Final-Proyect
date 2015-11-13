using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM
{
  public   class SolicitudBE
    {
        private string dNI;

        public string DNI
        {
            get { return dNI; }
            set { dNI = value; }
        }

        private string nOMBRES;

        public string NOMBRES
        {
            get { return nOMBRES; }
            set { nOMBRES = value; }
        }
        private string aPELLIDOS;

        public string APELLIDOS
        {
            get { return aPELLIDOS; }
            set { aPELLIDOS = value; }
        }
    }
}
