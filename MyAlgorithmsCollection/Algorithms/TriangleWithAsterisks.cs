using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithmsCollection.Algorithms
{
    public class TriangleWithAsterisks
    {
        public static void DrawCenterTriangle(int lines)
        {
			string response;
			for (int i = 0; i < lines; i++)
			{
				response = "";
				int quantity = 2 * i + 1;
				int spaces = lines - i - 1;
				for (int j = spaces; j >= 0; j--)
				{
					response += " ";
				}
				for (int k = 1; k <= quantity; k++)
				{
					response += "*";
				}
				Console.WriteLine(response);
			}
		}

		public static void DrawLeftTriangle(int lines)
		{
			string response;
			for (int i = 1; i <= lines; i++)
			{
				response = "";
				for (int j = 1; j <= i; j++)
				{
					response += "*";
				}
				Console.WriteLine(response);
			}
		}
	}
}
