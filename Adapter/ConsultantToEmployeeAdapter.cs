namespace DotNetDesignPatterns.Adapter
{
    public class ConsultantToEmployeeAdapter : Consultant, IEmployee
    {
        public ConsultantToEmployeeAdapter(string name) : base(name)
        {
        }

        public void ShowHappiness()
        {
            //call the parent Consultant class
            ShowSmile();
        }
    }
}