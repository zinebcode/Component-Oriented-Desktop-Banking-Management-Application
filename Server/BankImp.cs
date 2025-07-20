using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Server
{
    internal class BankImp : MarshalByRefObject, BankInterface
    {
        ArrayList comptes = new ArrayList();
        public bool creeCompte(int id, string name, double soldeIni)
        {
            if (chercheCompte(id) == null)
            {
                Compte compte = new Compte(id, name, soldeIni);
                comptes.Add(compte);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string debiter(int id, double montant)
        {
            Compte compte = chercheCompte(id);
            if (compte != null)
            {
                if (compte.getSolde() >= montant)
                {
                    compte.setSolde(compte.getSolde() - montant);
                    return compte.getName() + ": nouveau solde: " + compte.getSolde();
                }
                return compte.getName() + ": solde insuffisant";
            }
            return "compte introuvable.";
        }
        public string crediter(int id, double montant)
        {
            Compte compte = chercheCompte(id);
            if (compte != null)
            {
                compte.setSolde(compte.getSolde() + montant);
                return compte.getName() + ": nouveau solde: " + compte.getSolde();
            }
            return "compte introuvable.";
        }
        public string consulter(int id)
        {
            Compte compte = chercheCompte(id);
            if (compte != null)
            {
                return compte.getName() + ": solde: " + compte.getSolde();
            }
            return "compte introuvable.";
        }
        public ArrayList accountsList()
        {
            return comptes;
        }
        private Compte chercheCompte(int id)
        {
            foreach (Compte compte in comptes)
            {
                if (compte.getId() == id)
                {
                    return compte;
                }
            }
            return null;
        }
    }
}
