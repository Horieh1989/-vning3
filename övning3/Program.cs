using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3
{
    internal class program
    {
        static void main(string[] array)
        {

            Person person = new();

            person.Age = 43;
            person.Fname = "hale";
            person.Height = 175;
            person.weight = 63;
            person.LName = "Ghiasidalalian";

            Console.WriteLine($"age:{person.Age}");

            Console.WriteLine($"age:{person.Fname }");

            Console.WriteLine($"age:{person.Height }");

            Console.WriteLine($"age:{person.weight }");

            Console.WriteLine($"age:{person.LName }");

        }



        static void main()
        {
         List<UserError> errorlist =new List<UserError> 

         List<UserError> errorlist=new NumericalInputError

         List<UserError> errorlist = new TextInputError


        }


        foreach(UserError error in errorlist)
        {
          Console.WriteLine(error.UEMessage)

        





    }
}
