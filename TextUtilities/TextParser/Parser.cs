using System.Collections.Generic;
using System.Linq;

namespace TextUtilities
{
    public class Parser
    {
        public Parser()
        {
            
        }

        public List<string> Parse(string s)
        {
            return s.Split(new[] {' '}).ToList();
        } 
    }
}
