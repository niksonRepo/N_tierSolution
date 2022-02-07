
using N_tierSolution.BLL;

namespace N_tierSolution.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dateTime = DateTime.Today.ToString();
            var date = $"{DateTime.Today.Day}" +
                       $"/{DateTime.Today.Month}" +
                       $"'/{DateTime.Today.Year}";

            var cretedDate = new DateTime(2022, 09, 12);

            var businessLogicObject = new BusinessLogic();
            var getConcatResult = businessLogicObject.ConcatanateString("John", 18);
            var validationResult = businessLogicObject.ValidateAge(11);
            var isHumanOrNot = businessLogicObject.AreYouHumanOrNot("human");

            Console.WriteLine(getConcatResult);
            Console.WriteLine(validationResult);
            Console.WriteLine(isHumanOrNot);
            Console.ReadLine();
        }
    }
}