using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03.csharp_4.Source
{
    class Player
    {
        public void AddProperty(Player player, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = player as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
            {
                expandoDict[propertyName] = propertyValue;
            }
            else
            {
                expandoDict.Add(propertyName, propertyValue);
            }
        }
    }
}
