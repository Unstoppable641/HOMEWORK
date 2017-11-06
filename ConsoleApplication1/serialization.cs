using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var Izhevsk = new Address();
            var serialized = JsonConvert.SerializeObject(Izhevsk);
            using (var streamWriter = new StreamWriter(new FileStream("out.txt", FileMode.OpenOrCreate)))
            {
                streamWriter.WriteLine(Izhevsk);
            }
        }
        private class Address
        {
            public string Street { get; set; } = "79 Barishnikova St";
            public string City { get; set; } = "Izhevsk";
            public string State { get; set; } = "RF";
            public string Zip { get; set; } = "426000";
        }
    }
}