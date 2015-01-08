using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int oneByte = 0x8000;
			Console.WriteLine(oneByte);
			Console.WriteLine(Convert.ToString(oneByte, 2));
			Console.WriteLine("======================");


			int newByte = oneByte >> 1;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16,'0'));
			Console.WriteLine("======================");

			newByte = newByte >> 1;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			Console.WriteLine("======================");

			newByte = newByte >> 1;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			Console.WriteLine("======================");

			newByte = newByte + 0x8000;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			Console.WriteLine("======================");

			newByte = newByte >> 1;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			Console.WriteLine("======================");

			newByte = newByte >> 1;
			Console.WriteLine(newByte);
			Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			Console.WriteLine("======================");

			BitArray ba = new BitArray(new int[1] {newByte});
			Console.WriteLine("length "+ba.Length);


			foreach (bool b in ba)
			{
				Console.Write(b ? "T": "=");
			}

			Console.WriteLine();

			for (int i = 0; i < 15; i++)
			{

				newByte = newByte >> 1;
				ba = new BitArray(new int[1] {newByte});

				foreach (bool b in ba)
				{
					Console.Write(b ? "T" : "=");
				}
				Console.WriteLine();
			}


			//for (int i = 0; i <= 15; i++)
			//{
			//	newByte = newByte >> 1;
			//	Console.WriteLine(Convert.ToString(newByte, 2).PadLeft(16, '0'));
			//}






			//Console.WriteLine(oneByte & 1);
			//Console.WriteLine(Convert.ToString(oneByte & 1, 2));
			//Console.WriteLine((oneByte & 1) == 1);



			//byte[] twoBytes = new byte[] {0xAA};
			//Console.WriteLine(twoBytes.Count());

			//BitArray ba = new BitArray(twoBytes);
			//foreach (bool pos in ba)
			//{
			//	Console.Write("{0}", pos ? 1: 0);
			//}
			//Console.WriteLine();

			//Console.WriteLine("======================");


			//byte[] textAsBytes = System.Text.Encoding.ASCII.GetBytes("asdfasfasf");

			//List<string> binaries = new List<string>();
			//foreach (byte textAsByte in textAsBytes)
			//{
			//	Console.Write(Convert.ToString(textAsByte, 2));
			//	binaries.Add(Convert.ToString(textAsByte, 2));
			//	Console.WriteLine();
			//}

			//foreach (string binary in binaries)
			//{
			//	var num = Convert.ToInt32(binary, 2);
			//	Console.Write((char)num);
				
			//}

			//int i = (oneByte << 1) & oneByte;
			//Console.WriteLine(Convert.ToString(i, 2));
			//int x = oneByte << 1;
			//Console.WriteLine(Convert.ToString(x, 2));
			//int v = x & oneByte;
			//Console.WriteLine(v.ToString(),2);

			//int p = x << 1;
			//Console.WriteLine(p.ToString(),2);

			//i = (i >> 1) & i;
			//Console.WriteLine(Convert.ToString(i, 2));

			//i = i << 10;
			//Console.WriteLine(Convert.ToString(i, 2));


		}
	}
}
