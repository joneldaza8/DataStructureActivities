using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                                   // y, x
            // int[,] table = new int[10,10];


            // int[] arr = new int[] { 1,2,3,4,5};
            // foreach (int num in arr)
            // {

            // }
            // for (int counter = 0; counter < 10; counter++)
            // {
                
            // }

            // int indexCounter = 0;
            // do
            // {
            //     // do something here
            //     indexCounter++;
            // } while (indexCounter < 10);

            // indexCounter = 0;
            // while (indexCounter<10)
            // {
                 
            // }

            // int i = 0;
            // while (i > 0 || i <10)
            // {
            //     Console.WriteLine($"Count {i}");
            //     i++;
            // }


            Mug anInstanceOfaMug = new Mug
            {
                Length = 10,
                Color = "Blue",
                Volume = 120,
            };

            anInstanceOfaMug.Fill(new Beverage
            {
                Temperature = 20,
                Name = "Coffee",
            });

            Box newBox = new Box
            {
                length = 5,
                breadth = 15,
                height = 10,
            };


            Console.WriteLine($"Box volume {newBox.Volume}");
        }
    }

    class Box {
        public double length;   // Length of a box
        public double breadth;  // Breadth of a box
        public double height;   // Height of a box

        public double Volume 
        {
            get
            {
            return  length * breadth * height;
            }
        }
    }

    public interface IMug
    {
        void Fill(Beverage beverage);

        void Empty();

        double SpillHalf();
    }

    public class Mug : IMug
    {
        public int Length { get; set; } 

        public string Color { get; set; }

        public double Volume { get; set; }
        
        public Beverage Beverage { get; set; }

       
        public void Empty()
        {
            Beverage = null;
        }

        public void Fill(Beverage beverage)
        {
           Beverage = beverage;
        }

        public double SpillHalf()
        {
            return Volume / 2;
        }
    }

    public class Beverage
    {
        public int Temperature { get; set; }

        public string Name { get; set; }
    }




    
}
