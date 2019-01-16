using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Infrastructures
{
   public static class Session
    {
        private static Dictionary<string,object> dictionary { get; set; }

        public static void SetValue(string key,object obj)
        {
            if (dictionary[key] != null)
            {
                throw new Exception("There is object in Session");//Exception must create in future.
            }
            else
            {
                dictionary.Add(key, obj);
            }

        }
        public static object GetValue(string key)
        {
            return  dictionary.TryGetValue(key,out object obj);
            

        }
    }
}
