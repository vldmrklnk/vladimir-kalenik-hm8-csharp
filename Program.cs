using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] text = new char[] { 'h', 'e', 'l', 'l', 'o' };
			MyString message = new MyString(text);
			char[] ph = new char[] { 'e', 'l', 'l' };
			Console.WriteLine(message.Contains(ph));
			MyString same = new MyString('b', 7);
			for (int i = 0; i < same.Size; i++)
			{
				Console.WriteLine(same[i]);
			}
			MyString piece = message.Substr(1, 2);
			for (int i = 0; i < piece.Size; i++)
			{
				Console.WriteLine(piece[i]);
			}
			char[] text1 = new char[] { ',', ' ', 'w', 'o', 'r', 'l', 'd', '!' };
			MyString message1 = new MyString(text1);
			MyString plus = message + message1;
			for (int i = 0; i < plus.Size; i++)
			{
				Console.WriteLine(plus[i]);
			}

			Console.ReadLine();
		}

	}
}
