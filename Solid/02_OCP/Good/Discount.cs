namespace Solid._02_OCP.Good
{
    public abstract class Discount
    {
        public abstract decimal Calculate(decimal price);
    }

    public class ElectronicsDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.05m;
    }

    public class HealthDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.06m;
    }

    public class BeautyDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.07m;
    }

    public class FashionDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.08m;
    }
}