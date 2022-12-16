using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotNet
{
    class Program
    {
        static bool traceEnabled = false;
        static BooleanSwitch switchForConsole = new BooleanSwitch("ConsoleSwitch", "Switch for letting trace at console");
        static TraceSwitch traceSwitchTest = new TraceSwitch("TraceSwitch", "Trace Switch testing");

        internal static void TracePrint()
        {
            Trace.Indent();
            Trace.WriteLine("Entering Trace");
            Console.WriteLine("Hello World.");
            Trace.WriteLine("Exiting Trace");
            Trace.Unindent();
        }

        internal static void traceWriteOutputToFile(string message)
        {
            string @filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!traceEnabled)
            {
                traceEnabled = !traceEnabled;
                Trace.Listeners.Add(new TextWriterTraceListener(@filePath + @"\log.log"));
            }
            Trace.WriteLine(message, ".NetWarning");
        }
        internal static void traceWithConsoleTraceListener()
        {
            if (switchForConsole.Enabled)
            {
                var myWriter = new ConsoleTraceListener();
                Trace.Listeners.Add(myWriter);
                TracePrint();
            }
        }


        internal static void traceWriteOutputToEventLog(string message)
        {
            var eventListener = new EventLogTraceListener("DotNetAppEventListener");
            Trace.Listeners.Add(eventListener);
            TracePrint();
        }

        internal static void traceSwitchTestWarning()
        {
            if (traceSwitchTest.TraceWarning)
                TracePrint();
            if (traceSwitchTest.TraceInfo)
                TracePrint();
        }

        internal static void traceSwitchWithCondition()
        {
            var myWriter = new ConsoleTraceListener();
            Trace.Listeners.Add(myWriter);
            Trace.WriteLineIf(traceSwitchTest.TraceWarning, "Entering Warning Trace");
            Trace.WriteLineIf(traceSwitchTest.TraceInfo, "Entering Info Trace");
        }



        static void Main(string[] args)
        {
            Trace.AutoFlush = true;
            //traceWriteOutputToFile("Message Warning");
            //switchForConsole.Enabled = true;
            //traceWithConsoleTraceListener();

            //raceSwitchTest.Level = TraceLevel.Error;
            //traceSwitchTestWarning();

            //var myWriter = new ConsoleTraceListener();
            //Trace.Listeners.Add(myWriter);
            //Trace.Assert(2 == 2);
            // Trace.Fail("Unknown Error");



            System.Threading.Thread.Sleep(11500);
        }
      
    }
}
