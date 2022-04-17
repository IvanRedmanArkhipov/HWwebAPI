using System.Collections.Generic;
namespace Homework1new
{
    public class ValuesHolder
    {
        public List<string> Values = new List<string>();
        public void Add(string input)
        {
            Values.Add(input);
        }

        public string Get()
        {
            foreach(string i in Values)
            {
                return i;
            }
            return "";
        }

        public void Update(string stringsToUpdate, string newValue)
        {
            for(int i = 0; i < 1; i++ )
            {
                if ( Values[i] == stringsToUpdate )
                {
                    Values[i] = newValue;
                }
            }
        }
        public void Delete(string stringsToDelete)
        {
            Values.Remove(stringsToDelete);
        }
    }
}
