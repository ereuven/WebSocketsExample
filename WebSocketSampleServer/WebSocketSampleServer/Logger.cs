using System;
using System.Runtime.CompilerServices;

namespace WebSocketSampleServer
{
    internal static class Logger
    {
        public static void Log(object message, Exception ex = null, [CallerMemberName]string location = "(Caller name not set)")
        {
            var msg = $"{DateTime.Now.ToString("o")} {location}: {message?.ToString()}";
            if (ex != null)
            {
                msg += Environment.NewLine + ex.ToString();
            }
            Console.WriteLine(msg);
        }
    }
}
