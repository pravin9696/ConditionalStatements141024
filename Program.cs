namespace ConditionalStatements141024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// print   " number 1 = 123 and number 2 = 456

            //int no1 = 123;
            //int no2 = 456;
            //Console.WriteLine("number 1 ="+no1+" and number 2= "+no2);
            //Console.WriteLine(no1+""+no2);//1


            //Console.WriteLine("number 1={0} and number2 = {1}",no1,no2);
            //Console.WriteLine("{0}{1}",no1,no2);//2

            ////string interpolation
            //Console.WriteLine($"number1= {no1} and number2= {no2}");
            //Console.WriteLine($"{no1}{no2}");
            //string ss;  //ref type variable

            int n; // value type variable
            Console.WriteLine("enter number");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("no is even");
            }
            else
            {
                Console.WriteLine("no is odd");
            }
            var nn = 3.4f;

            float result = 4 * 3.5f;

            String s1;
            string s2;
        }
    }
}
//Data types in C#
