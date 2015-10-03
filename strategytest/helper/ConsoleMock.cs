using System;
using System.IO;

namespace strategy
{
    /// <summary>
    /// Redirects Console output to a string in memory
    /// </summary>
    public class ConsoleMock
    {
        private StringWriter consoleStream = null;

        public ConsoleMock()
        {
            consoleStream = new StringWriter();
            Console.SetOut(consoleStream);
        }
        
        public string Output()
        {
            String s = consoleStream.ToString().Trim();
            consoleStream.GetStringBuilder().Clear();
            return s;
        }
    }
}
