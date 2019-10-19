using System;
using System.Collections.Generic;
using System.Linq;

namespace TW_Assignment.Source.duplicateString
{
    public class UniqueList
    {
        public static List<String> DeDuplicate(List<String> list)
        {
            return list.Distinct().ToList();
        }
    }

}
