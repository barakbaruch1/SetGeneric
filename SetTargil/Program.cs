using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SetGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] team1 = GetIntegerTeam(5, 10);
            int[] team2 = GetIntegerTeam(5, 10);
            int[] team3 = GetIntegerTeam(5, 10);
            PrintArr<int>(team1);
            PrintArr<int>(team2);
            PrintArr<int>(team3);


            Set<int> set1 = new Set<int>(team1);
            Set<int> set2 = new Set<int>(team2);
            Set<int> set3 = new Set<int>(team3);

            Console.WriteLine("set1:" + set1);
            Console.WriteLine("set2:" + set2);
            Console.WriteLine("set3:" + set3);

            set1.Union(set2);
            Console.WriteLine("Union:" + set1);
            set1.Intersect(set3);
            Console.WriteLine("Intersect:" + set1);
            Set<int> set4 = new Set<int>(GetUserNumbers(2));
            Console.WriteLine(set1.Subset(set4));
            Console.WriteLine("Is Member Enter Number");
            Console.WriteLine(set1.IsMember(int.Parse(Console.ReadLine())));
            Console.WriteLine("Insert Enter Number");
            set1.Insert(int.Parse(Console.ReadLine()));
            Console.WriteLine(set1);
            Console.WriteLine("Delete Enter Number");
            set1.Delete(int.Parse(Console.ReadLine()));
            Console.WriteLine(set1);
            Console.WriteLine(set1.Equals(set2));
            Console.WriteLine(set1.Equals(set1));

            Set<string> setString1 = new Set<string>("God", "God", "god", "Al");
            Set<string> setString2 = new Set<string>("abc", "efg", "hij");
            Set<string> setString3 = new Set<string>("aa", "bb", "cc","efg");
            Console.WriteLine("setString1:" + setString1);
            Console.WriteLine("setString2:" + setString2);
            Console.WriteLine("setString3:" + setString3);
            setString1.Union(setString2);
            Console.WriteLine("Union: " + setString1);
            setString1.Intersect(setString3);
            Console.WriteLine("InterSect: " +setString1);

            Student student1 = new Student("ala", 90);
            Student student2 = new Student("jorden" ,94);
            Student student3 = new Student("su", 99);
            Student student4 = new Student("peterson", 99);
            Student student5 = new Student("Joey", 99);


            Set<Student> setStudent1 = new Set<Student>(student1, student2);
            Set<Student> setStudent2 = new Set<Student>(student2, student3);
            Set<Student> setStudent3 = new Set<Student>(student3, student4, student5);
            Console.WriteLine("set1 student:" + setStudent1);
            Console.WriteLine("set2 student:" + setStudent2);
            Console.WriteLine("set3 student:" + setStudent3);

            setStudent1.Union(setStudent2);
            Console.WriteLine("union:"+setStudent1);
            setStudent1.Intersect(setStudent3);
            Console.WriteLine("intersect:" + setStudent1);
            setStudent1.Insert(student2);
            Console.WriteLine(setStudent1);
            setStudent1.Delete(student2);
            Console.WriteLine(setStudent1);

        }

        public static int[] GetIntegerTeam(int length,int maxNumber)
        {
            Random random = new Random();
            int[] result = new int[length];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(maxNumber);
            }
            return result;
        }

        public static int[] GetUserNumbers(int userInputs)
        {
            int[] result = new int[userInputs];
            Console.WriteLine($"Enter {userInputs} Numbers");
            for(int i = 0; i < result.Length;i++)
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Enter A number");
                }
                result[i] = num;
            }

            return result;
        }

        public static void PrintArr<T>(T[] arr) 
        {
            Console.Write("Array:");
            foreach(var member in arr)
            {
                Console.Write(member.ToString() + ",");
            }
            Console.WriteLine();
        }

    }
}
