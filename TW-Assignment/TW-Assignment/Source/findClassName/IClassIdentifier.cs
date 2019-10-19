using System;

namespace TW_Assignment.Source.findClassName
{

    public interface IClassIdentifier<T, E>
    {
        String[] IdentifyClasses(T parameterOne, E parameterTwo);
    }

}
