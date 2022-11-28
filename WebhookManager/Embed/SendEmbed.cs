using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager.Embed
{
    class SendEmbed
    {
        public static void SendEmbedMethod(string webhookUrl, string username, string title, string description, string thumbnailUrl)
        {
            try
            {
                WebRequest request = (HttpWebRequest)WebRequest.Create(webhookUrl);
                request.ContentType = "application/json";
                request.Method = "POST";
                using (var sw = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(new
                    {
                        username,
                        embeds = new[]
                        {
                            new
                            {
                                description,
                                title,
                                color = "16515859",
                                thumbnail = new Thumbnail
                                {
                                    url = thumbnailUrl,
                                }
                            }
                        }
                    });
                    sw.Write(json);
                }
                var response = (HttpWebResponse)request.GetResponse();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("+");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Embed sent\n");
                Thread.Sleep(500);
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
