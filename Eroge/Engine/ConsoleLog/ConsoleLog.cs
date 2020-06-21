using System;
using System.IO;

namespace Eroge.Engine.ConsoleLog
{
    public static class ConsoleLog
    {
        ///<summary> Print Okay Message in console </summary>
        public static Action<object> OkayMess = (object obj) => PrintMessage(obj);
        
        ///<summary> Print Error Message in console </summary>
        public static Action<object> ErrorMess = (object obj) => PrintErrorMessage(obj);

        private static void PrintMessage(object message)
        {
            Console.WriteLine(message);
        }

        private static void PrintErrorMessage(object message)
        {
            Console.WriteLine(message);
        }

    }
}