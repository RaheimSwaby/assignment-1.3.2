namespace assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Declaration and Initialization Examples:");

            
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("1. Array initialized with values: ");
            PrintArray(numbers);

           
            string[] fruits = new string[3];
            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Cherry";
            Console.WriteLine("2. Array with fixed size and assigned values: ");
            PrintArray(fruits);

            
            Array cars = Array.CreateInstance(typeof(string), 3);
            cars.SetValue("Toyota", 0);
            cars.SetValue("Honda", 1);
            cars.SetValue("Ford", 2);
            Console.WriteLine("3. Array created using Array.CreateInstance: ");
            PrintArray(cars);

            
            Console.WriteLine("\nArray Properties:");
            Console.WriteLine($"Length of numbers array: {numbers.Length}");
            Console.WriteLine($"Rank (dimensions) of numbers array: {numbers.Rank}");
            Console.WriteLine($"IsFixedSize for numbers array: {numbers.IsFixedSize}");
            Console.WriteLine($"IsReadOnly for numbers array: {numbers.IsReadOnly}");

            
            Console.WriteLine("\nArray Methods:");

            
            Console.WriteLine("Sorting the 'numbers' array:");
            Array.Sort(numbers);
            PrintArray(numbers);

           
            Console.WriteLine("Reversing the 'numbers' array:");
            Array.Reverse(numbers);
            PrintArray(numbers);

            
            Console.WriteLine("Finding index of element '3' in 'numbers' array:");
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine($"Index of 3: {index}");

            
            Console.WriteLine("Clearing the first two elements of 'numbers' array:");
            Array.Clear(numbers, 0, 2);
            PrintArray(numbers);


            Console.WriteLine("Copying elements of 'fruits' array to a new array:");
            string[] copiedFruits = new string[fruits.Length];
            Array.Copy(fruits, copiedFruits, fruits.Length);
            PrintArray(copiedFruits);

            Console.ReadLine();
        }

        
        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
