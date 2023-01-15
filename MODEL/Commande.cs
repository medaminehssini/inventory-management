using System;
using System.Collections.Generic;

namespace MODEL
{
    public class Commande
    {
        String adresse_livraise;
        DateTime date;

    
        int num, idcl;
        int id;
        List<Ligne_cmd> ligne = new List<Ligne_cmd>();
        public string Adresse_livraise { get => adresse_livraise; set => adresse_livraise = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Num { get => num; set => num = value; }
        public int Idcl { get => idcl; set => idcl = value; }
        public int Id { get => id; set => id = value; }
        public List<Ligne_cmd> Ligne { get => ligne; set => ligne = value; }

    }
}
