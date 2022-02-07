
using N_tierSolution.BLL;

namespace N_tierSolution.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
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