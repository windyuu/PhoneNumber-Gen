using static System.Console;
using System;

namespace PhoneNumber
{
	/// <summary>
	/// 電話番号生成アプリ 
	/// </summary>
	/// <param name="args"></param>

	public class Program
	{
		public void Method()
        {
            while (true)
            {
				if (ReadLine() != ".")
					Main(); break;
            }
        }
		
		public static void Main()
        {
			string Number = "080";

			Random random = new Random(); // 000.000.000.00

			for (int phone = 0; phone < 8; phone++)
            {
				Number += random.Next(1, 9);
            }
			WriteLine(Number); WriteLine("続行するにはキーを押してください...");

			Program program = new Program();
			program.Method();
		}
	}
}
