using System;
using System.Collections.Specialized;

namespace TW_Assignment.Source.characterCount
{
    public class CharacterCount
    {
        public static OrderedDictionary CountCharacters(string input)
        {
            OrderedDictionary myDict = new OrderedDictionary();

            foreach (var i in input.Replace(" ",""))
            {
                if (myDict.Contains((Object)i.ToString()))
                {
                    myDict[(Object)i] = (Int32)myDict[(Object)i] + 1;
                }
                else
                    myDict.Add(i.ToString(), 1);
            }

            return myDict;
        }
    }

}
