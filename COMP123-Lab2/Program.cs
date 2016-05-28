using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person james = new Person();
            james.Name = "James";
            james.Age = 28;
            james.SaysHello();
            james.ShowAge();

            Console.WriteLine();

            Person alex = new Person("Alex");
            alex.Age = 47;
            alex.SaysHello();
            alex.ShowAge();

            Console.WriteLine();

            Person sarah = new Person(30);
            sarah.Name = "Sarah";
            sarah.SaysHello();
            sarah.ShowAge();

            Console.WriteLine();

            Person victoria = new Person("Victoria", 23);
            victoria.SaysHello();
            victoria.ShowAge();


        }
    }

}
