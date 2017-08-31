using System;
using System.Linq;
using System.Reflection;

namespace ClassBox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var boxParams = new double[3];
            for (int i = 0; i < boxParams.Length; i++)
            {
                boxParams[i] = double.Parse(Console.ReadLine());
            }
            try
            {
                var box = new Box(boxParams[0], boxParams[1], boxParams[2]);
                Console.WriteLine($"Surface Area - {box.GetSuurficeArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSuurficeArea():f2}");
                Console.WriteLine($"Volume - {box.GetVolume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
