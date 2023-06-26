using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlBoxWCF.Models.Entities
{
    public class giro
    {
        private int gir_giro_id;
        public int _gir_giro_id { get { return gir_giro_id; } set { gir_giro_id = value; } }

        private int gir_recibo;
        public int _gir_recibo { get { return gir_recibo; } set { gir_recibo = value; } }

        private int gir_oficina_id;
        public int _gir_oficina_id { get { return gir_oficina_id; } set { gir_oficina_id = value; } }

        private string oficinas;
        public string _oficinas { get { return oficinas; } set { oficinas = value; } }

        private int suma_giro_id;
        public int _suma_giro_id { get { return suma_giro_id; } set { suma_giro_id = value; } }

        public int SumaGiroId(int giroId)
        {
            int acum = 0;
            if (giroId > 9)
            {
                while (giroId != 0)
                {
                    acum += giroId % 10;
                    giroId /= 10;
                }
                return acum;
            }
            else
            {
                return giroId;
            }
        }
    }
}