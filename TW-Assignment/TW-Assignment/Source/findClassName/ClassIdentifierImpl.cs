using System;
using TW_Assignment.Source.exceptions;

namespace TW_Assignment.Source.findClassName
{
    public class ClassIdentifierImpl<T, E> : IClassIdentifier<T, E>
    {
        public String[] IdentifyClasses(T parameterOne, E parameterTwo)
        {
            return new String[] { parameterOne.GetType().Name, parameterTwo.GetType().Name };
        }
    }

}
