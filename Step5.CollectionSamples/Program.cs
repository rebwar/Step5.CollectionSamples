using System;
using System.Collections;
using System.Collections.Generic;

namespace Step5.CollectionSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 7, 8 };
            
            //CarListwithForeach();
            //CarListWithFor();
            //RemoveOddItems();
            //MyListClass();
            //QueueSampl();
            usingDictionary();

            // ArrayListSample();
        }

        private static void ArrayListSample()
        {
            ArrayList words = new ArrayList { "Book", "Car", "Love", "Photography", "Code",12,true };
            
            
           // List<object> list = new List<object> { "sjd", true, 1 };
            
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        private static void QueueSampl()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            Console.WriteLine(numbers.Count);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********Remove an Item*********");
            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine(numbers.Peek());
            Console.WriteLine("*******************");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************");

            var queueCopy =new Queue<string>(numbers.ToArray());
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            var array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);
            Console.WriteLine("*******************");
            var queueCopy2 = new Queue<string>(array2);
            foreach (var item in queueCopy2)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine($"queueCopy.Contains(two)= {queueCopy.Contains("two")}");
            queueCopy.Clear();
            Console.WriteLine($"There is {queueCopy.Count} item in the queue");
        }

        private static void usingDictionary()
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>() {
                ["cs"]="Visual Studio",
                ["mp4"]="Media Player"
            };
            openWith.Add("txt", "Notepad");
            openWith.Add("psd", "Photoshop");
            openWith.Add("docx", "WinWord");

            if (!openWith.ContainsKey("txt"))
            {
                openWith.Add("txt", "Notepad");
            }
            else
            {
                Console.WriteLine($"Key {openWith["txt"]} Contains in Dictionary! ");
            }
            foreach (KeyValuePair<string,string> item in openWith)
            {
                Console.Write($"Key:{item.Key}  Value:{item.Value}");
                Console.WriteLine();
            }
            openWith["txt"] = "Notepad++";
            openWith["xls"] = "Excel";
            try
            {
                Console.WriteLine(openWith["tif"]);

            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine($"Key tif is not found!");                
            }
            //openWith["tif"] = "MsPaint";
            string value = "";
            if(openWith.TryGetValue("tif",out value))
            {
                Console.WriteLine($"For key=tif value={value}");
            }
            else
            {
                openWith["tif"] = "MsPaint";
                Console.WriteLine("key tif is not found");
            }
            Console.WriteLine("************ Using var *************");
            //Miracle of using var ;-)
            //Happy Coding!
            foreach (var item in openWith)
            {
                Console.Write($"Key:{item.Key}  Value:{item.Value}");
                Console.WriteLine();
            }
            var valueColl = openWith.Values;
            Console.WriteLine("***********Values***********");
            foreach (var item in valueColl)
            {
                Console.WriteLine(item);
            }
            var keyColl = openWith.Keys;
            Console.WriteLine("***********Keys***********");
            foreach (var item in keyColl)
            {
                Console.WriteLine(item);
            }
        }

        private static void MyListClass()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1,Name="Ali"},
                new Student{Id=2,Name="Rebwar"},
                new Student{Id=3,Name="Maryam"}
            };
            students.Add(new Student { Id = 4, Name = "Sara" });

            foreach (var student in students)
            {
                Console.WriteLine($"Student Id:{student.Id} , Name={student.Name}");
            }
        }

        private static void RemoveOddItems()
        {
            List<int> numbers = new List<int> { 20, 14, 13, 17, 18, 54, 65, 35, 98, 14,18 };
            for (int index = numbers.Count-1; index >= 0; index--)
            {
                if (numbers[index]%2==1)
                {
                    numbers.RemoveAt(index);

                }
            }
            Console.Write("Even Numbers: ");
            foreach (var number in numbers)
            {
                Console.Write(number + "  ");
            }
        }

        private static void CarListWithFor()
        {
            var carList = new List<string>
            {
                "BMW",
                "Mercedes",
                "Bogatti",
                "Lamborghini"
            };
            carList.Add("Peykan");
            for (int index = 0; index < carList.Count; index++)
            {
                Console.Write(carList[index] + "  ");

            }
            
        }

        private static void CarListwithForeach()
        {
            var carList = new List<string>
            {
                "BMW",
                "Mercedes",
                "Bogatti",
                "Lamborghini"
            };
            carList.Add("Peykan");
            carList.Insert(2, "Pride!");
            carList.RemoveAt(0);
            carList.RemoveRange(4, 1);
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
            Console.Write("Enter car name:");
            string tempCar = Console.ReadLine();
            if (carList.Remove(tempCar))
            {
                Console.WriteLine($"{tempCar} deleted!");
            }
            else
            {
                Console.WriteLine("Car Not Found");
            }
        }
    }
}
