using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < 100000; i++)
            {
                var tmp = Faker.Internet.Email();
                if (!names.Contains(tmp))
                {
                    names.Add(tmp);
                    //if (names.Count == 3000) break;
                }
            }

            using (StreamWriter w = File.AppendText(@"D:\Resources by Faker\Email.txt"))
            {
                foreach(var name in names)
                {
                    w.WriteLine(name);
                }
                w.WriteLine("Count {0}", names.Count);
            }
        }
    }
}
