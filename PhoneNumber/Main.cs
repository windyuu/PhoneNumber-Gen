using System;

namespace PhoneNumber
{
    public class Program
    {
        public static void Main()
        {
            string Number = "080";
            Random random = new Random();

            for (int phone = 0; phone < 8; phone++)
            {
                Number += random.Next(1, 9);
            }

            Console.WriteLine(Number);
            Console.WriteLine("続行するにはEnterキーを押してください。\n\n処理を終了するには文字を入力してからキーを押してください。");

            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine(Number);
                Console.WriteLine("続行するにはEnterキーを押してください。\n\n処理を終了するには文字を入力してからキーを押してください。");
            }
        }
    }
}
