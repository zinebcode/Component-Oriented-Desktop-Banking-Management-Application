using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Compte
    {
        private int id;
        private string name;
        private double solde;
        public Compte()
        {
        }
        public Compte(int id, string name, double solde)
        {
            this.id = id;
            this.name = name;
            this.solde = solde;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public double getSolde()
        {
            return solde;
        }
        public void setSolde(double solde)
        {
            this.solde = solde;
        }
    }
}
