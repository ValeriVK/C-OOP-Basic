using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avatar.Models.Benders;

namespace Avatar.Models.Factories
{
    public class BenderFactory
    {
        public static Bender GetBender(List<string> benderArgs)
        {
            Type benderType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == benderArgs[0] + "Bender");
            ConstructorInfo ctorInfo = benderType.GetConstructors().FirstOrDefault();
            ParameterInfo[] args = ctorInfo.GetParameters();
            List<object> argList = new List<object>();
            for (int i = 1; i < benderArgs.Count; i++)
            {
                object casted = Convert.ChangeType(benderArgs[i], args[i - 1].ParameterType);
                argList.Add(casted);
            }

            Bender bender = (Bender)Activator.CreateInstance(benderType, argList.ToArray());
            return bender;
            //var benderType = benderArgs[0];
            //switch (benderType)
            //{
            //    case "Air":
            //        {
            //            var name = benderArgs[1];
            //            var power = int.Parse(benderArgs[2]);
            //            var aerialIntegrity = double.Parse(benderArgs[3]);
            //            return new AirBender(name, power, aerialIntegrity);
            //        }

            //    case "Water":
            //        {
            //            var name = benderArgs[1];
            //            var power = int.Parse(benderArgs[2]);
            //            var aerialIntegrity = double.Parse(benderArgs[3]);
            //            return new WaterBender(name, power, aerialIntegrity);
            //        }

            //    case "Fire":
            //    {
            //        var name = benderArgs[1];
            //        var power = int.Parse(benderArgs[2]);
            //        var aerialIntegrity = double.Parse(benderArgs[3]);
            //        return new FireBender(name, power, aerialIntegrity);
            //    }

            //    case "Earth":
            //    {
            //        var name = benderArgs[1];
            //        var power = int.Parse(benderArgs[2]);
            //        var aerialIntegrity = double.Parse(benderArgs[3]);
            //        return new EarthBender(name, power, aerialIntegrity);
            //    }
            //}
            //return null;
        }
    }
}