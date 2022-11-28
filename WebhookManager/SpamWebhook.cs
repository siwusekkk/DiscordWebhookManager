using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager
{
    class SpamWebhook
    {
        public static void SpamWebhookMethod(string webhookUrl, string username, string message, int messageDelay)
        {
            WebClient wc = new WebClient();
            try
            {
                while (true)
                {
                    wc.UploadValues(webhookUrl, new NameValueCollection
                    {
                        {
                            "content", message
                        },
                        {
                            "username", username
                        }
                    });
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("+");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Message sent\n");
                    Thread.Sleep(messageDelay);
                }
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
