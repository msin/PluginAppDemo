using System;
using System.Collections.Generic;
using SimpleInjector;

namespace CIL
{
    public class IoC
    {
        public static Container Instance { get; private set; }
        public static IList<Type> PluginTypes { get; private set; }

        static IoC()
        {
            Instance = new Container();
            PluginTypes = new List<Type>();
        }
    }
}
