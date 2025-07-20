using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public interface BankInterface
    {
        bool creeCompte(int id, string name, double soldeIni);

        string debiter(int id, double montant);

        string crediter(int id, double montant);

        string consulter(int id);

        ArrayList accountsList();
    }
}
