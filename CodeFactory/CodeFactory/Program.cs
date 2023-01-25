using CodeFactory.Aggregates;

namespace CodeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] list1 = new string[20];
            string[] list2 = new string[15];
            int i = 0;

            while(i < list2.Length)
            {
                list1[i] = i.ToString();
                list2[i] = i++.ToString();
            }
            while(i < list1.Length) { list1[i] = i++.ToString(); }

            R3GEN_List<string> list = new R3GEN_List<string>();//(list1, list2);

            string newNumber = 255.ToString();

            list.Add(newNumber);

            Console.WriteLine("Program didn't crash!");


        }

    }
}