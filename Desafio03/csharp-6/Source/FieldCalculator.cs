using System.Reflection;

namespace Codenation.Challenge
{
    public class FieldCalculator : ICalculateField
    {
        public decimal Addition(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            foreach (var field in type.GetTypeInfo().DeclaredFields)
            {
                if (!field.FieldType.Name.Equals("Decimal"))
                    continue;

                var atribute = field.GetCustomAttributes(typeof(AddAttribute), false);

                if (atribute != null && atribute.Length > 0)
                {
                    value += (decimal)field.GetValue(obj);
                }
            }

            return value;
        }

        public decimal Subtraction(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            foreach (var field in type.GetTypeInfo().DeclaredFields)
            {
                if (!field.FieldType.Name.Equals("Decimal"))
                    continue;

                var atribute = field.GetCustomAttributes(typeof(SubtractAttribute), false);

                if (atribute != null && atribute.Length > 0)
                {
                    value += -(decimal)field.GetValue(obj);
                }
            }

            return value;
        }

        public decimal Total(object obj)
        {
            return Addition(obj) + Subtraction(obj);
        }
    }
}
