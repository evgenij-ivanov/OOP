using System;

namespace Sem2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var individual = new Individual();
            var legalEntity = new LegalEntity();
            var individualCredit = new Credit(individual);
            individualCredit.AcceptApplication();
            var legalEntityCredit = new Credit(legalEntity);
            legalEntityCredit.AcceptApplication();
            var individualDeposit = new Deposit(individual);
            individualDeposit.AcceptApplication();
            var legalEntityDeposit = new Deposit(legalEntity);
            legalEntityDeposit.AcceptApplication();
        }
    }
}
