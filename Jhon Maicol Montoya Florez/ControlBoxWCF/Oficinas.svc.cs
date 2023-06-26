using ControlBoxWCF.Models;
using ControlBoxWCF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlBoxWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Oficinas" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Oficinas.svc or Oficinas.svc.cs at the Solution Explorer and start debugging.
    public class Oficinas : IOficinas
    {
        BaseData db = new BaseData();

        string IOficinas.AddDataOficinas(oficina ofi)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"INSERT INTO oficinas (ofi_nombre, ofi_corresponsal_id)  
                                               Values(@ofi_nombre, @ofi_corresponsal_id)";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@ofi_nombre", ofi._ofi_nombre );
                cmd.Parameters.AddWithValue("@ofi_corresponsal_id", ofi._ofi_corresponsal_id );

                db.connection.Open();
                cmd.ExecuteNonQuery();
                db.connection.Close();
                result = "Se añadio correctamente !";
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return result;
        }

        string IOficinas.DeleteOficinas(oficina ofi)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"DELETE FROM oficinas Where ofi_oficina_id=@ofi_oficina_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@ofi_oficina_id", ofi._ofi_oficina_id);

                db.connection.Open();
                cmd.ExecuteNonQuery();
                db.connection.Close();
                result = "Se elimino correctamente !";
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return result;
        }

        public IEnumerable<oficina> GetDataOficinas()
        {
            DataTable dt = new DataTable();
            List<oficina> oficinas = new List<oficina>();
                
            try
            {
                db.connection.Open();
                string sqlQuery = "SELECT o.ofi_oficina_id, o.ofi_nombre as 'Nombre de la oficina', c.cor_nombre as 'Nombre del corresponsal', count(g.gir_recibo) as 'Numero de giros' from oficinas as o inner join giros as g on o.ofi_oficina_id=g.gir_oficina_id  inner join corresponsales as c on o.ofi_corresponsal_id=c.cor_corresponsal_id group by gir_oficina_id, o.ofi_nombre, c.cor_nombre, o.ofi_oficina_id order by count(g.gir_recibo) desc;";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                db.connection.Close();
                adapter.Dispose();

                oficinas = (from DataRow dr in dt.Rows
                                 select new oficina()
                                 {
                                     _ofi_oficina_id = Convert.ToInt32(dr["ofi_oficina_id"]),
                                     _ofi_nombre = dr["Nombre de la oficina"].ToString(),
                                     _cor_nombre = dr["Nombre del corresponsal"].ToString(),
                                     _gir_giros = Convert.ToInt32(dr["Numero de giros"]),

                                 }).ToList();
            }
            catch (FaultException fex)
            {
                oficinas = null ;
                throw new FaultException<string>("Error: " + fex);
            }
            return oficinas;
        }

        string IOficinas.UpdateDataOficinas(oficina ofi)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"UPDATE oficinas SET ofi_nombre=@ofi_nombre, ofi_corresponsal_id=@ofi_corresponsal_id  Where ofi_oficina_id=@ofi_oficina_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@ofi_nombre", ofi._ofi_nombre );
                cmd.Parameters.AddWithValue("@ofi_corresponsal_id", ofi._ofi_corresponsal_id);
                cmd.Parameters.AddWithValue("@ofi_oficina_id", ofi._ofi_oficina_id);

                db.connection.Open();
                cmd.ExecuteNonQuery();
                db.connection.Close();
                result = "Se actualizo correctamente !";
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return result;
        }

        public IEnumerable<oficina> GetAllOficinas()
        {
            DataTable dt = new DataTable();
            List<oficina> oficinas = new List<oficina>();

            try
            {
                db.connection.Open();
                string sqlQuery = "SELECT * from oficinas";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                db.connection.Close();
                adapter.Dispose();

                oficinas = (from DataRow dr in dt.Rows
                            select new oficina()
                            {
                                _ofi_oficina_id = Convert.ToInt32(dr["ofi_oficina_id"]),
                                _ofi_nombre = dr["ofi_nombre"].ToString(),
                                _ofi_corresponsal_id = Convert.ToInt32(dr["ofi_corresponsal_id"]),

                            }).ToList();
            }
            catch (FaultException fex)
            {
                oficinas = null;
                throw new FaultException<string>("Error: " + fex);
            }
            return oficinas;
        }
    }
}
