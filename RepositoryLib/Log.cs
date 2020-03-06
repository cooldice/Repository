using System;

namespace RepositoryLib
{
    class Log
    {
        public enum LOGLEVEL
        {
            NONE = 0,
            TRACE,
            DEBUG,
            ERROR,
            EXCEPTION,
            MAX
        };

        static public LOGLEVEL LogLevel { get { return _logLevel; } set { _logLevel = value;  } } 
        static public void Debug(string format, params object[] args)
        {
            log(LOGLEVEL.DEBUG, format, args);
        }
        static public void Error(string format, params object[] args)
        {
            log(LOGLEVEL.ERROR, format, args);
        }
        static public void Trace(string format, params object[] args)
        {
            log(LOGLEVEL.TRACE, format, args);
        }

        static public void Exception(Exception e)
        {
            log(LOGLEVEL.EXCEPTION, "{0}", e.ToString());
        }

        static private void log(LOGLEVEL loglevel, string format, params object[] args)
        {
            if (loglevel < LogLevel)
                return;

            string log = String.Format("[" + loglevel.ToString() + "], " + format, args);
            Console.WriteLine(log);
        }

        static private LOGLEVEL _logLevel = LOGLEVEL.TRACE;
    }
}
