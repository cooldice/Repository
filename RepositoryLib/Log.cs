using System;

namespace RepositoryLib
{
    class Log
    {
        public enum LOGLEVEL
        {
            LOGLEVEL_NONE = 0,
            LOGLEVEL_TRACE,
            LOGLEVEL_DEBUG,
            LOGLEVEL_ERROR,
            LOGLEVEL_MAX
        };

        static public LOGLEVEL LogLevel { get { return logLevel; } set { logLevel = value;  } } 
        static public void Debug(string format, params object[] args)
        {
            string log = String.Format("[DEBUG], " + format, args);
            Console.WriteLine(log);
        }
        static public void Error(string format, params object[] args)
        {
            string log = String.Format("[ERROR], " + format, args);
            Console.WriteLine(log);
        }
        static public void Trace(string format, params object[] args)
        {
            string log = String.Format("[TRACE], " + format, args);
            Console.WriteLine(log);
        }

        static public void Exception(Exception e)
        {
            string log = String.Format("[EXCEPTION]" + e.ToString());
            Console.WriteLine(log);
        }

        static private LOGLEVEL logLevel = LOGLEVEL.LOGLEVEL_NONE;
    }
}
