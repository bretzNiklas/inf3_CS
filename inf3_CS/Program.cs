using System;

namespace inf3_CS
{
    class test
    {

        static void Main(string[] args)
        {

            Car car = new Car();
            Car car2 = new Car();

            Buffer b = new Buffer();
            
            Console.WriteLine(b.empty());
            b.push(car);
            b.push(car2);
            

            
        }
    }
}