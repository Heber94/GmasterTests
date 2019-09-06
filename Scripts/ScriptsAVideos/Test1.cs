using System;

namespace ConsoleApp5
{
    class Test1
    {
		private static int loop = 10;
        static void Main(string[] args)
        {
			
			Console.WriteLine("Testing...");
			for(int l = 0; l < loop; l++){
				Console.WriteLine("...");
			}
        }
    }
}
