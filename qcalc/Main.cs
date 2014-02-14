using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qcalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Quaternion quatA = new Quaternion(1,2,1,2);
            Quaternion quatB = new Quaternion(1,-1,0,2);
            Quaternion result = new Quaternion(0,0,0,0);

            // test inverse
            Console.WriteLine("inverse");
            Console.WriteLine(quatA + "^-1");
            result = quatA.inverse();
            Console.WriteLine(result + "\n");

            quatA = new Quaternion(3, 2, 1, 0);

            // test addition
            Console.WriteLine("add");
            Console.WriteLine(quatA + " + " + quatB);
            result = quatA.add(quatB);
            Console.WriteLine(result + "\n");

            // test subtraction
            Console.WriteLine("subtract");
            Console.WriteLine(quatA + " - " + quatB);
            result = quatA.subtract(quatB);
            Console.WriteLine(result + "\n");

            quatB = new Quaternion(0,1,-2,0);

            // test multiplication
            Console.WriteLine("multiply");
            Console.WriteLine(quatA + " * " + quatB);
            result = quatA.multiply(quatB);
            Console.WriteLine(result + "\n");

            // test division
            // #ADDME 
            Console.WriteLine("divide");
            Console.WriteLine(quatA + " / " + quatB);
            result = quatA.divide(quatB);
            Console.WriteLine("inverse of quatB: " + quatB.inverse());
            Console.WriteLine(result + "\n");

            quatA = new Quaternion(1,2,1,2);

            // test magnitude
            Console.WriteLine("magnitude");
            Console.WriteLine(quatA);
            Console.WriteLine(quatA.magnitude() + "\n");

            // test rotation
            Quaternion axis = new Quaternion(0, 0, 0, 1);
            Quaternion point = new Quaternion(0, 5, 0, 0);

            Console.WriteLine("quaternion rotation");
            result = Quaternion.rotatePointByAngleAboutAxisVector(point, Math.PI/2, axis);
            Console.WriteLine(result + "\n");

            // verify rotation manually
            Console.WriteLine("quaternion rotation manual check");
            quatA = new Quaternion(Math.Sqrt(2) / 2, 0, 0, Math.Sqrt(2) / 2);
            Quaternion quatP = new Quaternion(0, 5, 0, 0);

            Console.WriteLine("-- inverse");
            Console.WriteLine(quatA + "^-1");
            result = quatA.inverse();
            Console.WriteLine(result + "\n");

            Console.WriteLine("-- multiply");
            Console.WriteLine(quatA + " * " + quatP);
            result = quatA.multiply(quatP);
            result = result.multiply(quatA.inverse());
            Console.WriteLine(result + "\n");
        }
    }
}
