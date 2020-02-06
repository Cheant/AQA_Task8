using System;
using System.Text;

namespace Task8Library
{
    public class EnumHelper
    {
        public static string PrintEnumDefinition<TEnum>() where TEnum : struct
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Do you want to see Shipments with Orders:");

            for (int index = 1; index < Enum.GetValues(typeof(TEnum)).Length + 1; index++)
            {
                sb.AppendLine($"{index}. {Enum.GetName(typeof(TEnum), index)}");
            }
            return sb.ToString();
        }

        public static TEnum RequestForEnumValue<TEnum>() where TEnum : struct
        {
            TEnum result;
            bool parseResult;
            do
            {
                Console.WriteLine(PrintEnumDefinition<TEnum>());

                string _pr = Console.ReadLine();
                parseResult = Enum.TryParse(_pr, ignoreCase: true, result: out result)
                    & Enum.IsDefined(typeof(TEnum), result);

                if (!parseResult)
                {
                    Console.WriteLine($"{Environment.NewLine}Entered value is invalid.");
                }
            } while (!parseResult);
            return result;
        }
    }
}