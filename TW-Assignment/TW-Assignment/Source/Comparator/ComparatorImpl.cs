using System.Collections.Generic;

namespace TW_Assignment.Source.Comparator
{
    public class ComparatorImpl<T> : IComparator<T>
    {
        public T FindGreater(T first, T second)
        {
            if (Comparer<T>.Default.Compare(first, second) >= 0)
                return first;

            return second;
        }
    }

    public interface IComparator<T>
    {
        T FindGreater(T first, T second);
    }
}
