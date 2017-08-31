using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avatar.Models.Monuments;

namespace Avatar.Models.Factories
{
    public class MonumentFactory
    {
        public static Monument GetMonument(List<string> monumentArgs)
        {
            Type monumentType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == monumentArgs[0] + "Monument");
            ConstructorInfo ctorInfo = monumentType?.GetConstructors().FirstOrDefault();
            ParameterInfo[] args = ctorInfo?.GetParameters();
            List<object> argList = new List<object>();
            for (int i = 1; i < monumentArgs.Count; i++)
            {
                if (args.Length > i - 1)
                {
                    object castedParam = Convert.ChangeType(monumentArgs[i], args[i - 1].ParameterType);
                    argList.Add(castedParam);
                }
            }

            Monument monument = (Monument)Activator.CreateInstance(monumentType, argList.ToArray());
            return monument;
            //var monumentType = monumentArgs[0];
            //switch (monumentType)
            //{
            //    case "Air":
            //    {
            //        var name = monumentArgs[1];
            //        var airAffinity = int.Parse(monumentArgs[2]);
            //        return new AirMonument(name, airAffinity);
            //    }

            //    case "Water":
            //    {
            //        var name = monumentArgs[1];
            //        var waterAffinity = int.Parse(monumentArgs[2]);
            //        return new WaterMonument(name, waterAffinity);
            //    }

            //    case "Fire":
            //    {
            //        var name = monumentArgs[1];
            //        var fireAffinity = int.Parse(monumentArgs[2]);
            //        return new FireMonument(name, fireAffinity);
            //    }

            //    case "Earth":
            //    {
            //        var name = monumentArgs[1];
            //        var earthAffinity = int.Parse(monumentArgs[2]);
            //        return new EarthMonument(name, earthAffinity);
            //    }
            //}
            //return null;
        }
    }
}