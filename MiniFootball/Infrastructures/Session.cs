using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.Infrastructures
{
   public static class Session
    {
        static Session()
        {
            dictionary = new Dictionary<string, object>();
        }
        private static Dictionary<string,object> dictionary { get; set; }

        public static void SetValue(string key,object obj)
        {
            bool findedObj = dictionary.TryGetValue(key, out object ob);
            if ( findedObj)
            {
                dictionary[key] = obj;
            }
            else
            {
                dictionary.Add(key, obj);
            }

        }
        public static object GetValue(string key)
        {
            if (dictionary.TryGetValue(key, out object obj))
            {
                return dictionary[key];
            }
            else
                return null;
            

        }
    }
}
