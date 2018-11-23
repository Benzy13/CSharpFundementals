using System;
using CSharpFundementals.Math;

namespace CSharpFundementals
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 5));

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "John", "Jack", "Mary"};
            Console.WriteLine(names[0]);

            var firstName = "Jean";
            var lastName = "du Toit";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var formattedNames = string.Join("-", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\nfolder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}\nb: {1}",a,b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = new int[3] {4, 5, 6};
            // var array2 = array1;
            //array2[0] = 0;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);
            array2 = array1;
            array2[0] = 7;
            array1[1] = 8;
            array2[2] = 9;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array1[2]);

            Console.WriteLine("Testing Git"); 
        }
    }
}
