using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager
{
    class DeleteWebhook
    {
        public static void DeleteWebhookMethod(string webhookUrl)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\n\n[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Log");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Requesting Webhook");
                var request = WebRequest.Create(webhookUrl);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Log");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Webhook requested");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Log");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Deleting Webhook");
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("+");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Webhook deleted!\n\n");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\nSomething went wrong...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Exception");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" " + e + "\n\n");
            }
        }
    }
}
