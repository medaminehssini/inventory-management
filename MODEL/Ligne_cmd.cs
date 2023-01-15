using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Ligne_cmd
    {
        private int id_cmde, id_arte;
        private int qte;
        private Commande id_cmd;
        Article id_article;

        public int Qte { get => qte; set => qte = value; }
        public int Id_cmde { get => id_cmde; set => id_cmde = value; }
        public int Id_arte { get => id_arte; set => id_arte = value; }

        public Commande Id_cmd { get => id_cmd; set => id_cmd = value; }
        public Article Id_article { get => id_article; set => id_article = value; }

        public String designation { get => id_article.Designation;}

        public int id_art { get => id_article.Id; }
        public decimal prix { get => id_article.Prix_u; }
        public decimal prixT { get => prix*Qte; }


    }
}
