using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudiantDataDevoir
{
    public class Etudiant
    {
        private String Id;
        private String Nom;
        private String Niveau;

        public String getId() { 
            return this.Id;
        }

        public String getNom()
        {
            return this.Nom;
        }

        public String getNiveau()
        {
            return this.Niveau;
        }

        public void setId(String _Id)
        {
            this.Id = _Id;
        }

        public void setNom(String _Name)
        {
            this.Nom = _Name;
        }
        public void setNiveau(String _Niveau)
        {
            this.Niveau = _Niveau;      
        }

    }
}
