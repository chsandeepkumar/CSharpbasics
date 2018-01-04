namespace CSharpAbstractClass
{
    public class UCMUniversityClass : StudentAbstractClass
    {
        public override bool IsStudentElgibile()
        {
            return true;
        }
        public void GetMarks()
        {
          
        }
    }

    public class UCMLibrary : UCMUniversityClass
    {
        public void GetListOfBooks()
        {

        }
    }
}
