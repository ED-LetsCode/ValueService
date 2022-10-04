using ValueServiceLibrary;

namespace ValueServiceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ValueService valueService = new ValueService();

            try
            {
                var test = valueService.GetDecimal("10.2k");
                Console.WriteLine(test);
                var newtest = valueService.GetDisplayValue(test, 15);
                Console.WriteLine(newtest);
 
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}