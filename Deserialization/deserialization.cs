using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Deserialization
{
    class Programm
    {
        static void Main(string[] args)
        {
           var Izhevsk = new Address();
            using (var streamReader = new StreamReader(new FileStream("out.txt", FileMode.OpenOrCreate)))
            {
                var serializ = streamReader.ReadLine();
                var deserialization = JsonConvert.DeserializeObject<Address>(serializ);
                Console.WriteLine(deserialization);
                Console.ReadKey();
            }
        }
        private class Address
        {
            public string Street { get; set; }
            public string City { get; set; }  
            public string State { get; set; } 
            public string Zip { get; set; }                 
        }
    }
}