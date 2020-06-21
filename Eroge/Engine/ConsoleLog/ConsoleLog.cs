using System;
using System.IO;
using System.Threading.Tasks;

namespace Eroge.Engine.ConsoleLog
{
    public class ConsoleLog
    {
        ///<summary> Print Okay Message in console </summary>
        public static Action<object> OkayAction = (object obj) => Message(obj);
        
        ///<summary> Print Error Message in console </summary>
        public static Action<object> ErrorAction = (object obj) => ErrorMessage(obj);

        private static void Message(object message)
        {
            Console.WriteLine(message);
        }

        private static void ErrorMessage(object message)
        {
            Console.WriteLine(message);
        }

        public static void PrintErrorMessage(string message)
        {
            Task task = new Task( ErrorAction, "[ERROR] " + message);
            task.Start();
            
        }

        public static void PrintMessage(string message)
        {
            Task task = new Task( OkayAction, message);
            task.Start();
        }

        
    }
}