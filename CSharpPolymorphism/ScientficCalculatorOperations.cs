namespace CSharpPolymorphism
{
    class ScientficCalculatorOperations : CalculatorOperations
    {
        public override int Addition(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber)*10;
        }
    }
}
