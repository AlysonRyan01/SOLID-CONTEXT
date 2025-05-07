namespace Solid._04_ISP.Good
{
    public interface ISalaryCalculator
    {
        void CalculateSalary();
    }

    public interface IBenefitsCalculator
    {
        void CalculateBenefits();
    }

    public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
    {
        public void CalculateBenefits()
        {
            Console.WriteLine("Contract benefits");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }
    }

    public class ContractEmployee : ISalaryCalculator
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }
    }
}