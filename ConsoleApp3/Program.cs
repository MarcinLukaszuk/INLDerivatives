using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            var rnd = new Random();
            var derivates = repo.GetDerivatesResult().OrderBy(x=> rnd.Next()).ToList() ;

            StreamWriter writer = new StreamWriter("derywaty.txt");
            foreach (var item in derivates)
            {
                writer.WriteLine(item.Female+"\t"+ item.Male);
                 
            }
            writer.Close(); 
        }
    }
}
