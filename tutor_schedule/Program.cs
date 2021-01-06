using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_schedule
{
    class Program
    {
        static Telegram.Bot.TelegramBotClient botClient = null;
        static void Main(string[] args)
        {
            botClient = new Telegram.Bot.TelegramBotClient("1540919518:AAGdQsfV0cugPqldiKTCooHs5aqBURKNQv0");

            botClient.OnMessage += BotClient_OnMessageAsync;

            botClient.StartReceiving();
            Console.Read();
        }

        private static async void BotClient_OnMessageAsync(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "hello!");
        }
    }
}
