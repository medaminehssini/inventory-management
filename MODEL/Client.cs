using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Client
    {
        private int code_postal;
        private String telephone;
        private string nom;
        private string prenom;
        private string adresse;
        private int id;
        public int Code_postal { get => code_postal; set => code_postal = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id { get => id; set => id = value; }
    }
}
