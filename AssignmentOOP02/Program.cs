using System.Security.Cryptography.X509Certificates;

namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region Q1
            //a
            /*
            1- the fields are public which is not preferred because it can be accessed and modified from outside the class which can allow invalid data
            2-the class doesn't have properties which can provide better control over the access and modification of the fields using getters and setters
            3-no validation on withdrawal amount which can lead to negative balance
             */

            //c
            /*
             becuase encapsulation enforces the principle of data hiding so when fields are public they can be accessed and modified from outside the class
             */

            #endregion


            #endregion
        }

        #region Part 1
        #region Q1
        //b
        //public class BankAccount { 
        //    private string _owner;
        //    private double _balance;


        //    public string Owner { get; private set; }
        //    public double Balance { get; private set; }


        //}

        #endregion
        #endregion
    }
}
