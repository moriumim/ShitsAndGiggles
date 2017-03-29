using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightoxTools.Logging
{
    public class AstroLogger
    {
        public static IExceptionLogger ExceptionLogger;

        public static void LogException(string exceptionSource, Exception exception)
        {
            ExceptionLogger?.Handle(exceptionSource, exception);
        }

        public static void LogText(string text, bool important = false)
        {
            Console.WriteLine(text);
        }
    }
}
