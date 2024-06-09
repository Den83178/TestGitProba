namespace _001_GitProba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine ($"{a} * {a} = {Logic.PowerOf2(a)}");
        }
    }
}
