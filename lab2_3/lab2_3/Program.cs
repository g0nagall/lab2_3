using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
	class Program
	{
		static void Main(string[] args)
		{
		point:
			Console.Write("Type number of mounth (1-12): ");
			int switch_on = int.Parse(Console.ReadLine());
			switch (switch_on)
			{
				case 1:
					Console.WriteLine("Winter");
					break;
				case 2:
					Console.WriteLine("Winter");
					break;
				case 3:
					Console.WriteLine("Spring");
					break;
				case 4:
					Console.WriteLine("Spring");
					break;
				case 5:
					Console.WriteLine("Spring");
					break;
				case 6:
					Console.WriteLine("Summer");
					break;
				case 7:
					Console.WriteLine("Summer");
					break;
				case 8:
					Console.WriteLine("Summer");
					break;
				case 9:
					Console.WriteLine("Authum");
					break;
				case 10:
					Console.WriteLine("Authum");
					break;
				case 11:
					Console.WriteLine("Authum");
					break;
				case 12:
					Console.WriteLine("Winter");
					break;

				default:
					Console.WriteLine("Try again");
					goto point;
			}
		}
	}
}
