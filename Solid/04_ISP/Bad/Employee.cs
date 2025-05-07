namespace Solid._04_ISP.Bad
{
    public interface IEmployee
    {
        string Name { get; set; }
        void CalculateSalary();
        void CalculateBenefits();
    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBenefits()
        {
            Console.WriteLine("Contract benefits");
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBenefits()
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }
    }
}