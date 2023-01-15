using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
namespace CONTROLLER
{
    public class ArticleADO
    {

        public List<Article> articleADOList;
        Connection cnx = new Connection();


        public void load()
        {
            articleADOList = new List<Article>();
            SqlDataReader reader = cnx.SDD("SELECT * FROM ARTICLE");
            while (reader.Read())
            {
                Article article = new Article();
                article.Id = (int)reader.GetValue(0);
                article.Code = (String)reader.GetValue(1);
                article.Designation = (String)reader.GetValue(2);
                article.Prix_u = (Decimal)reader.GetValue(3);
                article.Rayon = (String)reader.GetValue(4);
                article.Ss_rayon = (String)reader.GetValue(5);
                articleADOList.Add(article);


            }
            reader.Close();
        }

        public void insert(Article article)
        {


            SqlCommand cmd = new SqlCommand("insert into article (code, designation ,prix_u ,ss_rayon, rayon) values ('" + article.Code + "' , '" + article.Designation + "' , '" + article.Prix_u + "' , '" + article.Rayon + "', '" + article.Ss_rayon + "')");
            cnx.executeCommand(cmd);

        }
        public void update(Article article)
        {


            SqlCommand cmd = new SqlCommand("update  article set code ='" + article.Code + "' ,  designation =  '" + article.Designation + "' , prix_u =  '" + article.Prix_u + "' , rayon =  '" + article.Rayon + "' , ss_rayon =  '" + article.Ss_rayon + "' where id = " + article.Id + "; ");
            cnx.executeCommand(cmd);
        }
        public void delete(Article article)
        {

            SqlCommand cmd = new SqlCommand("delete from  article  where id = " + article.Id + "; ");
            cnx.executeCommand(cmd);
        }

    }
}
