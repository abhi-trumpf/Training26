using System;
using System.Collections.Generic;
using System.Text;

namespace newconsole1 {
   public class Program3 {
      public static void coolerDay () {
         int[] array = [30, 31, 29, 32, 28, 27, 30, 25]; // program to next cooler day
         /*
			int[] input1 = new int[8];
			Console.WriteLine("enter the inputs in order");
			for (int i = 0; i < 8; i++) {
				input1[i] = int.Parse(Console.ReadLine());
			}*/
         for (int i = 0; i < array.Length; i++) {
            int x = array[i];
            for (int j = i + 1; j < array.Length; j++) {
               int z = j - i;
               int y = array[j];
               if (y < x) {
                  Console.WriteLine ($"The next cooler day after {x} is {y} (first cooler day) - wait ({z}) days");
                  break;
               }
            }
         }
      }
      public static void Main (string[] args) {
         coolerDay ();

      }
   }
}
