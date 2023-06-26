using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlBoxWCF.Models.Entities
{
    public class corresponsal
    {
        private int cor_corresponsal_id;
        public int _cor_corresponsal_id { get { return cor_corresponsal_id; } set { cor_corresponsal_id = value; } }

        private string cor_nombre;
        public string _cor_nombre { get { return cor_nombre; } set { cor_nombre = value; } }


    }
}