namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] firstNames = new string[10];

            //firstNames[0] = "tim";
            //firstNames[1] = "Sue";
            //firstNames[2] = "bob";
            //firstNames[4] = "jane";

            //Console.WriteLine($"The firstNames is {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

            // single quote identifies a char
            // double quote identifies a string
            string data = "Tim,Sue,Bob,Jane,Frank";
            string[] firstNames = data.Split(',');

            Console.WriteLine(firstNames[1]);
            Console.WriteLine(firstNames[firstNames.Length-1]);

            string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

            int[] ages = new int[] { 2, 3, 4 };
        }
    }
}
