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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Giros" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Giros.svc or Giros.svc.cs at the Solution Explorer and start debugging.
    public class Giros : IGiros
    {
        BaseData db = new BaseData();
        string IGiros.AddDataGiros(giro gir)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"INSERT INTO giros (gir_recibo, gir_oficina_id)  
                                               Values(@gir_recibo, @gir_oficina_id)";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@gir_recibo",gir._gir_recibo );
                cmd.Parameters.AddWithValue("@gir_oficina_id",gir._gir_oficina_id);

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

        string IGiros.DeleteGiros(giro gir)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"DELETE FROM giros Where gir_giro_id=@gir_giro_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@gir_giro_id",gir._gir_giro_id);

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

        public IEnumerable<giro> GetDataGiros(giro gir)
        {
            DataTable dt = new DataTable();
            List<giro> giros = new List<giro>();
            List<oficina> oficinas = new List<oficina>();
            try
            {
                db.connection.Open();
                string sqlQuery = @"select o.ofi_nombre as 'Oficina', g.gir_giro_id, g.gir_recibo from oficinas as o inner join giros as g on o.ofi_oficina_id=g.gir_oficina_id where o.ofi_oficina_id = @ofi_oficina_id ;";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.connection);
                cmd.Parameters.AddWithValue("@ofi_oficina_id", gir._gir_oficina_id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                db.connection.Close();
                adapter.Dispose();

                giros = (from DataRow dr in dt.Rows
                         select new giro()
                         {
                             _gir_giro_id = Convert.ToInt32(dr["gir_giro_id"]),
                             _gir_recibo = Convert.ToInt32(dr["gir_recibo"]),
                             _suma_giro_id = gir.SumaGiroId(Convert.ToInt32(dr["gir_giro_id"])),
                             _oficinas = dr["Oficina"].ToString(),

                         }).ToList();
            }
            catch (FaultException fex)
            {
                oficinas = null;
                throw new FaultException<string>("Error: " + fex);
            }
            return giros;
        }

        string IGiros.UpdateDataGiros(giro gir)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"UPDATE giros SET gir_recibo=@gir_recibo, gir_oficina_id=@gir_oficina_id  Where gir_giro_id=@gir_giro_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@gir_giro_id", gir._gir_giro_id );
                cmd.Parameters.AddWithValue("@gir_recibo", gir._gir_recibo);
                cmd.Parameters.AddWithValue("@gir_oficina_id", gir._gir_oficina_id );

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
    }
}
