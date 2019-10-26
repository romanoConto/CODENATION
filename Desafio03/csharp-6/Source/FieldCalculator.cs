using System.Reflection;
using System.Linq;

namespace Codenation.Challenge
{
    public class FieldCalculator : ICalculateField
    {
        //Implementado com lambda (Linq)
        public decimal Addition(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            var fields = type.GetTypeInfo().DeclaredFields;

            var fielsAdd = fields.Where(f => f.FieldType == typeof(decimal) && f.GetCustomAttributes(typeof(AddAttribute), false).Length > 0);

            foreach (var field in fielsAdd)
            {
                value += (decimal)field.GetValue(obj);
            }

            return value;
        }

        //Implementado com for  
        public decimal Subtraction(object obj)
        {
            decimal value = new decimal(0);

            var type = obj.GetType();

            foreach (var field in type.GetTypeInfo().DeclaredFields)
            {
                if (!(field.FieldType == typeof(decimal)))
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
