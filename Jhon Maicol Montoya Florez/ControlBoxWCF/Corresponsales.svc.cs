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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Corresponsales" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Corresponsales.svc or Corresponsales.svc.cs at the Solution Explorer and start debugging.
    public class Corresponsales : ICorresponsales
    {
        BaseData db = new BaseData();
        public string AddDataCorresponsal(corresponsal cor)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"INSERT INTO corresponsales (cor_nombre)  
                                               Values(@cor_nombre)";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@cor_nombre", cor._cor_nombre);
                

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

        public string DeleteCorresponsal(corresponsal cor)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"DELETE FROM corresponsales Where cor_corresponsal_id=@cor_corresponsal_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@cor_corresponsal_id", cor._cor_corresponsal_id);

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

        public IEnumerable<corresponsal> GetDataCorresponsal()
        {
            DataTable dt = new DataTable();
            List<corresponsal> corresponsals = new List<corresponsal>();
            try
            {
                db.connection.Open();
                string sqlQuery = "Select * from corresponsales";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                db.connection.Close();
                adapter.Dispose();
                corresponsals = (from DataRow dr in dt.Rows
                                 select new corresponsal()
                                 {
                                     _cor_corresponsal_id = Convert.ToInt32(dr["cor_corresponsal_id"]),
                                     _cor_nombre = dr["cor_nombre"].ToString()
                                 }).ToList();
                return corresponsals;
            }
            catch
            {
                dt = null;
            }
            return corresponsals;
        }

        public string UpdateDataCorresponsal(corresponsal cor)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"UPDATE corresponsales SET  cor_nombre=@cor_nombre Where cor_corresponsal_id=@cor_corresponsal_id";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@cor_nombre", cor._cor_nombre);
                cmd.Parameters.AddWithValue("@cor_corresponsal_id", cor._cor_corresponsal_id);

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
