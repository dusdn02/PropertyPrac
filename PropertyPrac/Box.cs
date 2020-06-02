using System;
using System.Globalization;

namespace PropertyPrac
{
	public class Box
	{
		const int WIDTH_DEFAULT = 1;
		const int SIZE_DEFAULT = 1;
		private int width;
		private int height;


		public int Width
        {
			get { return width; }
            set
            {
				this.width = IsPositive(value);
            }
        }

		public int Height
		{
			get { return height; }
			set
			{
				this.height = IsPositive(value);
			}
		}


		public Box(int width, int height)
		{
			if (width > 0 && height > 0)
			{
				this.width = width;
				this.height = height;
			}
            else
            {
				this.width = WIDTH_DEFAULT;
				this.height = SIZE_DEFAULT;
				Console.WriteLine("매개변수는 양수이어야 합니다.");
				Console.WriteLine("width = ", WIDTH_DEFAULT, " height = ",SIZE_DEFAULT,"로 추정 됩니다.");
            }
		}

		public int Area()
		{
			return this.width * this.height;
		}

		public int GetWidth()
        {
			return this.width;
        }

		public void SetWidth(int width)
		{
			this.width = IsPositive(width);
		}

		public int GetHeight()
		{
			return this.width;
		}

		public void SetHeight(int height)
		{
			this.height = IsPositive(height);
		}

		private int IsPositive(int value)
        {
			if (value > 0)
			{
				return value;
			}
			else
			{
				Console.WriteLine("매개변수는 양수이어야 합니다.");
				Console.WriteLine(" height = ", SIZE_DEFAULT, "로 추정 됩니다.");
				return SIZE_DEFAULT;
			}
		}
	}
}