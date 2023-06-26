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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Corresponsal" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Corresponsal.svc or Corresponsal.svc.cs at the Solution Explorer and start debugging.
    public class Corresponsal : ICorresponsal
    {
        BaseData db = new BaseData();
        
        public DataSet GetDataCorresponsal()
        {
            DataSet ds = new DataSet();
            try
            {
                string sqlQuery = "Select * from corresponsales";
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, db.connection);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {

                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        string ICorresponsal.AddDataCorresponsal(corresponsales cor)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"INSERT INTO corresponsales (cor_corresponsal_id, cor_nombre)  
                                               Values(@cor_corresponsal_id, @cor_nombre)";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@cor_corresponsal_id", cor._cor_corresponsal_id);
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

        string ICorresponsal.DeleteCorresponsal(corresponsales cor)
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

        string ICorresponsal.UpdateDataCorresponsal(corresponsales cor)
        {
            string result = " ";
            try
            {
                SqlCommand cmd = new SqlCommand();
                string Query = @"UPDATE corresponsales SET cor_nombre=@cor_nombre Where cor_corresponsal_id=@cor_corresponsal_id ";
                cmd = new SqlCommand(Query, db.connection);
                cmd.Parameters.AddWithValue("@cor_corresponsal_id", cor._cor_corresponsal_id);
                cmd.Parameters.AddWithValue("@cor_nombre", cor._cor_nombre);

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
