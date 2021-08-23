using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Term_Project
{
    // inMemory db
    public class Database
    { 
        public static ConcurrentDictionary<int, string> TABLE_ACCOUNTS = new ConcurrentDictionary<int, string>(
           new Dictionary<int, string>()
           {
              {148218183, "Ali Umar"},
              {000000000, "Wayne Bryan"},
              {111111111, "Zeyu Li"}
           }
        );

        public static ConcurrentDictionary<string, int> TABLE_PRODUCTS = new ConcurrentDictionary<string, int>();

        public static ConcurrentDictionary<int, List<ValueTuple<string, string, int>>> TABLE_ORDERS = new ConcurrentDictionary<int, List<ValueTuple<string, string, int>>>();

        public static void InitDatabase()
        {
            string[] teaArray = { "green tea", "black tea", "peppermint tea", "ginseng tea", "oolong tea" };
            Random rand = new Random();

            for(int i = 0; i < 5; ++i)
            {
                TABLE_PRODUCTS[teaArray[i]] = rand.Next(1, 4);
            }
        }
    }
}
