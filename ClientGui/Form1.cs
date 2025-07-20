using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRemote;

namespace ClientGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refrechList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankInterface bn = (BankInterface)Activator.GetObject(typeof(BankInterface), "tcp://localhost:2048/bank");
            int id = 11;
            string name = "fghjk";
            double solde = 1000.0;
            bn.creeCompte(id, name, solde);
        }

        private void refrechList()
        {
            BankInterface bn = (BankInterface)Activator.GetObject(typeof(BankInterface), "tcp://localhost:2048/bank");
            ArrayList accounts = bn.accountsList();
            foreach (var account in accounts)
            {
                clientList.Items.Add(((Compte)account).getId());
            }
            

        }

    }
}
