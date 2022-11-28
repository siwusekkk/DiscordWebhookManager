using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;

namespace WebhookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Console.Write("Enter webhook url: ");
                string webhookUrlInput = Console.ReadLine();
                while (true)
                {
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.WriteLine("\nSelect activity: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("1");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Send Webhook");
                    /////////////////////////////////////////////
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("2");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Delete Webhook");
                    //////////////////////////////////////////////
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("3");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Send Embed");
                    //////////////////////////////////////////////
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("4");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Spam Webhook");
                    //////////////////////////////////////////////
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("5");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Exit");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\nYour choice: ");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter webhooks username: ");
                        string usernameInput = Console.ReadLine();
                        Console.Write("Enter message you want to send: ");
                        string messageInput = Console.ReadLine();
                        SendWebhook.SendWebhookMethod(webhookUrlInput, messageInput, usernameInput);
                    }
                    else if (choice == "2")
                    {
                        DeleteWebhook.DeleteWebhookMethod(webhookUrlInput);
                    }
                    else if (choice == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter webhooks username: ");
                        string usernameInput = Console.ReadLine();
                        Console.Write("Enter embeds title: ");
                        string titleInput = Console.ReadLine();
                        Console.Write("Enter embeds description: ");
                        string descriptionInput = Console.ReadLine();
                        Console.Write("Enter embeds thumbnail url: ");
                        string thumbnailUrlInput = Console.ReadLine();
                        Console.WriteLine("");
                        Embed.SendEmbed.SendEmbedMethod(webhookUrlInput, usernameInput, titleInput, descriptionInput, thumbnailUrlInput);
                    }
                    else if (choice == "4")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter webhooks username: ");
                        string usernameInput = Console.ReadLine();
                        Console.Write("Enter message you want to spam: ");
                        string messageInput = Console.ReadLine();
                        Console.Write("Enter amount of miliseconds between messages (delay): ");
                        string messageDelayInputS = Console.ReadLine();
                        int messageDelayInput = int.Parse(messageDelayInputS);
                        Console.WriteLine("");
                        SpamWebhook.SpamWebhookMethod(webhookUrlInput, usernameInput, messageInput, messageDelayInput);
                    } 
                    else if(choice == "5")
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nSomething went wrong...");
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Something went wrong...");
            }
        }
    }
}