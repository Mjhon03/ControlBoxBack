using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlBoxWCF.Models.Entities
{
    public class oficina
    {
        private int ofi_oficina_id;
        public int _ofi_oficina_id { get { return ofi_oficina_id; } set { ofi_oficina_id = value; } }

        private string ofi_nombre;
        public string _ofi_nombre { get { return ofi_nombre; } set { ofi_nombre = value; } }

        private int ofi_corresponsal_id;
        public int _ofi_corresponsal_id { get { return ofi_corresponsal_id; } set { ofi_corresponsal_id = value; } }

        private string cor_nombre;
        public string _cor_nombre { get { return cor_nombre; } set { cor_nombre = value; } }

        private int gir_giros;
        public int _gir_giros { get { return gir_giros; } set { gir_giros = value; } }
    }
}
