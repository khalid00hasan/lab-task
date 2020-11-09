using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask_6
{
    class Account
    {
        string accName;
        string acId;
        int balance;
        public string getAccName()
        { return accName; }

        public void setAccName(string AccName)
        { accName = AccName; }

        public string getAcid()
        { return acId; }

        public void setAcid(string Acid)
        { acId = Acid; }

        public int getBalance()
        { return balance; }

        public void setBalance(int Balance)
        { balance = Balance; }

        public void Deposite(int ammount)
        { balance = balance + ammount; }
        public void withdrow(int ammount)
        { balance = balance - ammount; }


        public void Transfer(int amount, int amountReceiver)
        {
            balance += amount;
            TransferTransaction newTransaction = new TransferTransaction(transferAmount, transferToId, owner);
            transactions.Add(newTransaction);
        }
    }

    }

