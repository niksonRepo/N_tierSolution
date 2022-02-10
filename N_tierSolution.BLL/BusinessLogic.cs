using Microsoft.VisualBasic;
using N_tierSolution.DLL;
using N_tierSolution.Entity;

namespace N_tierSolution.BLL
{
    public class BusinessLogic
    {
        private readonly DataLogic _dataLogic;

        public BusinessLogic()
        {
            _dataLogic = new DataLogic();
        }

        public string ConcatanateString(string name, int age) => $"My name is {name} and I am {age} old";

        //if lest then 18, validation fails 
        public string ValidateAge(int age)
        {
            return _dataLogic.GetDataFromDb(age) ? "Is valid" : "Not valid";
        }

        public string AreYouHumanOrNot(string obj)
        {
            return 
                _dataLogic.AreYouHumanOrNot(obj) 
                    ? "I am human" 
                    : "I am not human";

        }

        public List<Students> GetStudentsList()
        {
            return _dataLogic.GetStudents();
        }

        public void AddStudents(Students student)
        {
            _dataLogic.AddStudent(student);
        }
    }
}