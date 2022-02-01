using System;
using System.IO;

namespace PhoneNumber
{
        /// <summary>
        /// 電話番号生成アプリ
        /// </summary>
        /// <param name="args"></param>
		
		internal class Program
    {

		public static void Main()
		{
			const string Number = "080";
			Console.Write(Number); // 3桁

			Random random = new Random(); // 000.000.000.00
			int num = 080;
			
			num = random.Next(1, 9); // 4
			Console.Write(num);
			
			num = random.Next(1, 9); // 5
			Console.Write(num);
			
			num = random.Next(1, 9); // 6
			Console.Write(num);

			num = random.Next(1, 9); // 7
			Console.Write(num);
			
			num = random.Next(1, 9); // 8
			Console.Write(num);
			
			num = random.Next(1, 9); // 9
			Console.Write(num);
			
			num = random.Next(1, 9); // 10
			Console.Write(num);
			
			num = random.Next(1, 9); // 11
			Console.WriteLine(num);
			Console.ReadLine();
        }
    }
}
