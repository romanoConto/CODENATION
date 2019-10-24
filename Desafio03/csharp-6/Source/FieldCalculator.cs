namespace Codenation.Challenge
{
    public class FieldCalculator : ICalculateField
    {
        [Add]
        private decimal salary;

        [Add]
        private decimal dsr;

        [Subtract]
        private decimal shop;

        [Subtract]
        private decimal study;

        public decimal Addition(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            foreach(var prop in type.GetProperties())
            {
                var atribute = prop.GetCustomAttributes().First();
                if(prop.Value.type() != decimal.type() && atribute != null && atribute = AddAttribute)
                {
                    value += prop.GetValue();
                }
            }

            return value;
        }

        public decimal Subtraction(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var atribute = prop.GetCustomAttributes().First();
                if (prop.Value.type() != decimal.type() && atribute != null && atribute = SubtractAttribute)
                {
                    value -= prop.GetValue();
                }
            }

            return value;
        }

        public decimal Total(object obj)
        {
            decimal value = new decimal(0);

            value += (Addition(obj) - Subtraction(obj));

            return value;
        }
    }
}
