using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MODEL;
namespace CONTROLLER
{
    public  class ClientADO
    {
        public List<Client> clientADOList = new List<Client>();
        Connection cnx = new Connection();
        
        public void insert(Client client)
        {

        
            SqlCommand cmd = new SqlCommand("insert into client values ('"+client.Nom+"' , '"+client.Prenom+"' , '"+client.Adresse+"' , '"+client.Telephone+"', '"+client.Code_postal+"')");
            cnx.executeCommand(cmd);
           
        }
        public void update(Client client)
        {

      
            SqlCommand cmd = new SqlCommand("update  client set nom ='" + client.Nom + "' ,  prenom =  '" + client.Prenom + "' , adresse =  '" + client.Adresse + "' , tel =  '" + client.Telephone + "' , code_postale =  '" + client.Code_postal + "' where id = "+client.Id+"; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Client client)
        {

            SqlCommand cmd = new SqlCommand("delete from  client  where id = " + client.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void load( )
        {
            clientADOList = new List<Client>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM CLIENT");
            while (reader.Read())
            {
                Client client = new Client();
                client.Id = (int)reader.GetValue(0);
                client.Nom = (String)reader.GetValue(1);
                client.Prenom = (String)reader.GetValue(2);
                client.Adresse = (String)reader.GetValue(3);
                client.Telephone = (String)reader.GetValue(4);
                client.Code_postal = (int)reader.GetValue(5);
                clientADOList.Add(client);


            }
            reader.Close();
        }

    }
}
