namespace CSharpClassDemo.SealedClass
{
    class Employee 
    {
        public int Work(string Requirements)
        {
            if (Requirements == "Good")
                return 100;
            else
                return 0;
        }
    }
}
