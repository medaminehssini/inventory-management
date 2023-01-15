using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Article
    {
        private String ss_rayon;
        private string code;
        private string designation;
        private decimal prix_u;
        private string rayon;
        int id;
        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
        public decimal Prix_u { get => prix_u; set => prix_u = value; }
        public string Rayon { get => rayon; set => rayon = value; }
        public string Ss_rayon { get => ss_rayon; set => ss_rayon = value; }
        public int Id { get => id; set => id = value; }
    }
}
