using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    public class Repository
    {
        XDocument xdoc;
        public Repository()
        {
            xdoc = XDocument.Load("plwordnet-4.0.xml");
        }

        private IEnumerable<arraylistLexicalunit> GetNouns()
        {
            return xdoc.Descendants("lexical-unit").Select(x => new arraylistLexicalunit()
            {
                id = int.Parse(x.Attribute("id").Value),
                name = x.Attribute("name").Value,
                pos = x.Attribute("pos").Value,
                desc = x.Attribute("desc").Value,
                source = x.Attribute("source").Value,
                domain = x.Attribute("domain").Value,
                tagcount = int.Parse(x.Attribute("tagcount").Value),
                variant = int.Parse(x.Attribute("variant").Value),
                workstate = x.Attribute("workstate").Value
            }).Where(x => x.pos == "rzeczownik");
        }
        private IEnumerable<arraylistLexicalrelations> GetRelations()
        {
            return xdoc.Descendants("lexicalrelations").Select(x => new arraylistLexicalrelations()
            {
                parent = int.Parse(x.Attribute("parent").Value),
                child = int.Parse(x.Attribute("child").Value),
                relation = int.Parse(x.Attribute("relation").Value),
            }).Where(x => x.relation == 53);
        }


        public List<Tuple<arraylistLexicalunit, arraylistLexicalunit>> GetDerivatesFromWordNet()
        {
            var tupleList = new List<Tuple<arraylistLexicalunit, arraylistLexicalunit>>();
            var nouns = GetNouns();
            var rel = GetRelations();
            var join1 = nouns.Join(
                 rel,
                 n => n.id,
                 r => r.parent,
                 (n, r) => new { n, r })
              .Join(nouns,
              r1 => r1.r.child,
              n => n.id,
              (r1, n) => new { n1 = r1.n, n2 = n })
              .ToList();

            tupleList.AddRange(join1.Select(x => new Tuple<arraylistLexicalunit, arraylistLexicalunit>(x.n1, x.n2)));

            return tupleList;
        }

        public List<DerivatesResult> GetDerivatesResult()
        {
            List<DerivatesResult> result = new List<DerivatesResult>();
            var derivates = GetDerivatesFromWordNet();

            foreach (var item in derivates)
            {
                if (!result.Any(x => x.Male == item.Item2.name && x.Female == item.Item1.name))
                {
                    result.Add(new DerivatesResult()
                    {
                        Male = item.Item2.name,
                        Female = item.Item1.name
                    });
                }
            }
            return result;
        }
    }
}
