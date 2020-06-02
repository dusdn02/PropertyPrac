using System;
using System.Security.Cryptography.X509Certificates;
namespace PropertyPrac

public class Box
{
	public int width;
	public int height;

	public Box(int width, int height)
    {
		this.width = width;
		this.height = height;
    }

	public int Area()
    {
		return this.width * this.height;
    }
}
