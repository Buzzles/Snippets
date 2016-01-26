using System;
using LotteryNumberPicker;
using System.Linq;

namespace CSharpNumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var numPick = new NumberPicker(40, 6);
            var output = numPick.GetNumbers;
            
            Console.WriteLine("C# Calling F# Namespace'd Lottery Number Picker");
            Console.WriteLine(string.Join(",", output));
            Console.ReadKey();

            var staticNumPick = new ModuleLotteryNumberPicker.NumberPickerStatic(40, 6);
            var staticOutput = numPick.GetNumbers;

            Console.WriteLine("C# Calling F# Namespace'd Lottery Number Picker");
            Console.WriteLine(string.Join(",", staticOutput));
            Console.ReadKey();

        }
    }
}
