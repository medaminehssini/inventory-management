using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MODEL;
namespace CONTROLLER
{
    public class CommandeADO
    {

        public List<Commande> commandeADOList = new List<Commande>();
        Connection cnx = new Connection();

        public void insert(Commande commande  )
        {


            SqlCommand cmd = new SqlCommand("insert into commande values ( '" + commande.Idcl + "' , '" + commande.Num + "' , CONVERT(date,'" + commande.Date + "',105) , '" + commande.Adresse_livraise + "')");
            cnx.executeCommand(cmd);

            SqlDataReader sqlDataReader = cnx.SDD("SELECT MAX(ID) FROM commande");
            sqlDataReader.Read();
            commande.Id = sqlDataReader.GetInt32(0);

            LCADO lc = new LCADO();
            foreach (Ligne_cmd ligne in commande.Ligne)
            {
                Console.WriteLine(ligne.Id_article.Id);
                ligne.Id_cmd = commande;
               lc.insert(ligne) ;
               
            }

        }
        public void update(Commande commande)
        {


            SqlCommand cmd = new SqlCommand("update  commande set id_client ='" + commande.Idcl + "' ,  num =  '" + commande.Num + "' , date =  '" + commande.Date + "' , adresse_livraison =  '" + commande.Adresse_livraise + "'  where id = " + commande.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Commande commande)
        {

            SqlCommand cmd = new SqlCommand("delete from  commande  where id = " + commande.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void load()
        {
            LCADO lcado = new LCADO();
            commandeADOList = new List<Commande>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM Commande");
            while (reader.Read())
            {
                Commande commande = new Commande();
                commande.Id = (int)reader.GetValue(0);
                commande.Idcl = (int)reader.GetValue(1);
                commande.Num = (int)reader.GetValue(2);
                commande.Date = (DateTime)reader.GetValue(3);
                commande.Adresse_livraise = (String)reader.GetValue(4);
                
                commande.Ligne = lcado.get(commande.Id);

                commandeADOList.Add(commande);


            }
            reader.Close();
        }
    }
}
