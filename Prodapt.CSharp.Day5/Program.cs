namespace Prodapt.CSharp.Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Jaya Brindha ";
            string str1 = "   ";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Substring(5,7));
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.Contains("Brindha"));
            Console.WriteLine(String.IsNullOrEmpty(str1));
            Console.WriteLine(String.IsNullOrWhiteSpace(str1));
        }
    }
}
