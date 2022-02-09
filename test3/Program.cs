using System;
using System.Collections.Generic;

namespace test3
{
    class MainClass
    {

        
        static bool Hit(int circleX, int circleY, int rad, int x, int y)
        {
            
            if ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= rad * rad)
            {
                return true;

            }

            else
            {
                return false;
            }

        }


        

        public static void Main(string[] args)
        {
            


            List<double> shapeScoreh = new List<double>();
            List<double> shapeScorem = new List<double>();

            Console.WriteLine("Ange en längd");
            int inputL = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange poäng för objektet");
            int inputPoints = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange att det är en cirkel = 2");
            int inputShapeType = Convert.ToInt32(Console.ReadLine());
        
            int shapeType = inputShapeType; 
            int instancePoints = inputPoints; 
            int Area = 10; 
            int x = 51;
            int y = 1;
            int length = inputL;
            int circleX = 0;
            int circleY = 1;
            int rad = (int)(length / (2 * Math.PI));

            if (Hit(circleX, circleY, rad, x, y))
            {
                Console.WriteLine("Inuti");
                var eq1 = ((shapeType * instancePoints) / Area);
                shapeScoreh.Add(eq1);
            }
            else
            {
                Console.WriteLine("Utanför");
                var eq2 = ((shapeType * instancePoints) / Area);
                shapeScorem.Add(eq2);
                
            }


            Console.WriteLine(String.Join(", ", shapeScoreh));
            Console.WriteLine(String.Join(", ", shapeScorem));
        }


    }

}



