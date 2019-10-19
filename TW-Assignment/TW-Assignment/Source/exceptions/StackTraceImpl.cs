using System;

namespace TW_Assignment.Source.exceptions
{
    public class StackTraceImpl : IStackTrace {
    public void ClearStackTrace()
        {
            Method1();
        }

    private void Method1()  {
        Method2();
    }

    private void Method2()  {
        Method3();
    }

    private void Method3()  {
        throw new Exception("Exceptiom from method3");
    }
}

}
