using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW_Assignment.Source.exceptions
{
    public class StackTraceImpl : StackTrace {
    public void clearStackTrace()  {
        method1();
    }

    private void method1()  {
        method2();
    }

    private void method2()  {
        method3();
    }

    private void method3()  {
        throw new Exception("Exceptiom from method3");
    }
}

}
