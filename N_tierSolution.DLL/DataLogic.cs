namespace N_tierSolution.DLL
{
    public class DataLogic
    {
        public bool GetDataFromDb(int age)
        {
            //fake data from db
            return age >= 18;
        }

        public bool AreYouHumanOrNot(string obj)
        {
            return obj == "human";
        }
    }
}