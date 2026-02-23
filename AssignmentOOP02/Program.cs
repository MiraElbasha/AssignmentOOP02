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

            #region Q2
            //the difference between field and property
            /*
             1-field
                -direct data storage 
                -no validation
                -Break Encapsulation
                -Starts with _


            2-Properties
                -Controlled Access
                -can validate
                -Enforse Encapsulation
                -Starts with capital letter (but same field name)
             */

            #endregion

            #region Q3
            //a
            //An indexer allows an object to be accessed like an array.

            //b
            //So it makes the object behave like a collection

            //c
            /*
              yes class can have more thank one indexer but with

                Different parameter types

                Different number of parameters
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

        #region Q3
        //b
        //public class StudentRegister
        //{
        //    private string[] names = new string[5];
        //    public string this[int index]
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= names.Length)
        //                throw new IndexOutOfRangeException("Invalid index.");

        //            return names[index];
        //        }
        //        set
        //        {
        //            if (index < 0 || index >= names.Length)
        //                throw new IndexOutOfRangeException("Invalid index.");

        //            names[index] = value;
        //        }
        //    }
        //}
        #endregion
        #endregion
    }
}
