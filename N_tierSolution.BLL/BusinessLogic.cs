using Microsoft.VisualBasic;
using N_tierSolution.DLL;

namespace N_tierSolution.BLL
{
    public class BusinessLogic
    {
        public string ConcatanateString(string name, int age) => $"My name is {name} and I am {age} old";

        //if lest then 18, validation fails 
        public string ValidateAge(int age)
        {
            var dataLogicObject = new DataLogic();
            
            return dataLogicObject.GetDataFromDb(age) ? "Is valid" : "Not valid";
        }

        public string AreYouHumanOrNot(string obj)
        {
            var dataLogicObject = new DataLogic();
            return 
                dataLogicObject.AreYouHumanOrNot(obj) 
                    ? "I am human" 
                    : "I am not human";

        }
    }
}