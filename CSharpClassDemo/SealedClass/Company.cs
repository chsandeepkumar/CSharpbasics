namespace CSharpClassDemo.SealedClass
{
    sealed class Company
    {
        public string AssignWork(int Empoyees)
        {
            if (Empoyees > 0)
                return "work assigned to Employees";
            else
                return "No Employee";
        }
        public string GiveSalary()
        {
            return "Giving Salary";
        }
    }
}
