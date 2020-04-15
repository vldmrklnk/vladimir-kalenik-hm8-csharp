using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
	class MyString
	{
		private char[] symbolMass;
		public int Size
		{
			get => symbolMass.Length;
			set => Size = symbolMass.Length;
		}
		public char this[int index]
		{
			get
			{
				return symbolMass[index];
			}
			private set
			{
				symbolMass[index] = value;
			}
		}
		public MyString(char[] Mass)  // Первый конструктор принимающий массив чаров
		{
			symbolMass = new char[Mass.Length];
			for (int i = 0; i < Mass.Length; i++)
			{
				symbolMass[i] = Mass[i];
			}
		}
		public MyString(char letter, int count) //Второй конструктор принимает длину строки
		{
			symbolMass = new char[count];
			for (int i = 0; i < count; i++)
			{

				symbolMass[i] = letter;
			}
		}
		public int Contains(char[] phrase)
		{
			int index;
			int result = -1;
			if (phrase.Length > symbolMass.Length)
				return result;
			for (int i = 0; i < symbolMass.Length; i++)
			{
				if (symbolMass[i] == phrase[0])
				{
					index = i;
					for (int j = 0; j < phrase.Length; j++)
					{
						if (symbolMass[index++] == phrase[j])
						{
							result = 1;
						}
						else
						{
							result = -1;
							break;
						}

					}
				}

			}
			return result;
		}
		public MyString Substr(int startindex, int length)
		{
			char[] part;
			MyString result;
			if (startindex > (symbolMass.Length - 1) || (startindex + length) > symbolMass.Length)
			{
				part = new char[] { '-' };
				result = new MyString(part);
				return result;
			}
			part = new char[length];
			int j = 0;

			while (j < length)
			{
				for (int i = startindex; i < (startindex + length); i++)
				{
					part[j] = symbolMass[i];
					j++;
				}

			}
			result = new MyString(part);
			return result ;
		}
		public static MyString operator +(MyString a, MyString b)
		{
			char[] mass = new char[a.Size + b.Size];
			MyString c = new MyString(mass);
			int i = 0;
			for (; i < a.Size; i++)
				c[i] = a[i];
			for (int j = 0; j < b.Size; j++)
				c[i + j] = b[j];

				return c;
		}
	}


}



