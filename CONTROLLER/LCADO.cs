using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MODEL;
namespace CONTROLLER
{
    public class LCADO
    {
        Connection cnx = new Connection();

        public void insert (Ligne_cmd lc)
        {

            SqlCommand cmd = new SqlCommand("insert into ligne_cmd (qte , id_cmd,id_article) values ('" + lc.Qte + "' , '" + lc.Id_cmd.Id + "' , '" + lc.Id_article.Id + "')");
            cnx.executeCommand(cmd);
        }


        public List<Ligne_cmd> get(int id)
        {

            String cmd = "select * from ligne_cmd where id_cmd=" + id + ";";
            SqlDataReader reader = cnx.SDD(cmd);

             List<Ligne_cmd> lcmd = new List<Ligne_cmd>();
            while (reader.Read())
            {
                Ligne_cmd cmde= new Ligne_cmd();
                cmde.Id_arte = (int)reader.GetValue(3);
                cmde.Id_cmde = (int)reader.GetValue(2); 
                cmde.Qte = (int)reader.GetValue(1);


                lcmd.Add(cmde);

            }

            return lcmd;
         }
    }
}
