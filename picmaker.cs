using System;
using System.IO;

namespace HomeworkOneNS {
  class HomeworkOne {

    static double distance(int x1, int y1, int x2, int y2) {
      return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }

    static void Main(String[] args) {

      // using (StreamWriter sw = new StreamWriter("image.ppm")) {
      //
      //   sw.WriteLine("P3 500 500 255");
      //
      //   int x, y, x1, x2, y1, y2;
      //
      //   x1 = 100;
      //   y1 = 150;
      //   x2 = 400;
      //   y2 = 350;
      //   for (y = 0; y < 500; y++) {
      //     for (x = 0; x < 500; x++) {
      //       double d1 = distance(x, y, x1, y1);
      //       double d2 = distance(x, y, x2, y2);
      //       double dd = Math.Abs(d1 + d2);
      //       if ( dd > 405 && dd < 408 ) {
      //         sw.WriteLine("255 0 0 ");
      //       }
      //       else {
      //         sw.WriteLine("255 255 255 ");
      //       }
      //     }
      //   }
      //
      // }

      Random randObj;
      if (args.Length > 1) {
        Console.WriteLine(String.Format("Attempting to seed random with {0}", args[1]));
        try {
          randObj = new Random(Convert.ToInt32(args[1]));
        }
        catch (Exception e) {
          Console.Write("Invalid input:\n\t");
          Console.WriteLine(e.Message);
          Console.WriteLine("\nUsing default seed");
          randObj = new Random();
        }
      }
      else {
        Console.WriteLine("Using default seed");
        randObj = new Random();
      }

      using (StreamWriter sw = new StreamWriter("image.ppm")) {

        sw.WriteLine("P3 500 500 255");

        int x, y, ctr1 = randObj.Next(265), ctr2 = randObj.Next(64);
        for (y = -500; y < 1000; y++) {
          for (x = -500; x < 1000; x++) {
            if (x >= 0 && x < 500 && y >= 0 && y < 500 && Math.Pow(Math.Pow((x - 250) / 180.0, 2) + Math.Pow(((-1 * y) + 250) / 180.0, 2) - 1, 3) < Math.Pow((x - 250) / 180.0, 2) * Math.Pow(((-1 * y) + 250) / 180.0, 3)) {
              sw.WriteLine(String.Format("255 {0} {0} ", ctr1));
              ctr1++;
              ctr1 %= 256;
            }
            else if (Math.Pow(Math.Pow((x - 250) / 600.0, 2) + Math.Pow(((-1 * y) + 250) / 600.0, 2) - 1, 3) < Math.Pow((x - 250) / 600.0, 2) * Math.Pow(((-1 * y) + 250) / 600.0, 3)) {
              if (x >= 0 && x < 500 && y >= 0 && y < 500) {
                sw.WriteLine(String.Format("{0} {1} 255 ", 192 + ctr2, 255 - ctr2));
              }
              ctr2++;
              ctr2 %= 64;
            }
          }
        }
      }

      ////////////////////////// Death Star Boi //////////////////////////

      // seed Random
      // Random randObj;
      // if (args.Length > 1) {
      //   Console.WriteLine(String.Format("Attempting to seed random with {0}", args[1]));
      //   try {
      //     randObj = new Random(Convert.ToInt32(args[1]));
      //   }
      //   catch (Exception e) {
      //     Console.Write("Invalid input:\n\t");
      //     Console.WriteLine(e.Message);
      //     Console.WriteLine("\nUsing default seed");
      //     randObj = new Random();
      //   }
      // }
      // else {
      //   Console.WriteLine("Using default seed");
      //   randObj = new Random();
      // }
      //
      // using (StreamWriter sw = new StreamWriter("image.ppm")) {
      //
      //   sw.WriteLine("P3 500 500 255");
      //
      //   // make circleboi
      //   int x, y, ctr = 0;
      //   for (y = 0; y < 500; y++) {
      //     for (x = 0; x < 500; x++) {
      //       if (distance(x, y, 250, 250) > 140) {
      //         sw.WriteLine("0 0 0 ");
      //         // arr[y, x] = 0;
      //       }
      //       else {
      //         int c;
      //         double d = distance(x, y, 200, 200);
      //         if (d < 30) {
      //           d = distance(x, y, 175, 175);
      //           c = Convert.ToInt32( (d * 2.8 + 70) * (236 / 256.0) ) + ctr;
      //           if (c < 0) c = 0;
      //           sw.WriteLine(String.Format("{0} {0} {0} ", c));
      //           ctr += 11;
      //           ctr %= 20;
      //         }
      //         else {
      //           c = Convert.ToInt32( (255 - d * 1.6) * (236 / 256.0) ) + ctr;
      //           if (c < 0) c = 0;
      //           sw.WriteLine(String.Format("{0} {0} {0} ", c));
      //           // arr[y, x] = c;
      //           ctr += 11;
      //           ctr %= 20;
      //         }
      //       }
      //     }
      //   }
      // }


      // // seed Random
      // Random randObj;
      // if (args.Length > 1) {
      //   Console.WriteLine(String.Format("Attempting to seed random with {0}", args[1]));
      //   try {
      //     randObj = new Random(Convert.ToInt32(args[1]));
      //   }
      //   catch (Exception e) {
      //     Console.Write("Invalid input:\n\t");
      //     Console.WriteLine(e.Message);
      //     Console.WriteLine("\nUsing default seed");
      //     randObj = new Random(42069);
      //   }
      // }
      // else {
      //   Console.WriteLine("Using default seed");
      //   randObj = new Random(42069);
      // }
      //
      // using (StreamWriter sw = new StreamWriter("image.ppm")) {
      //
      //   // write initial line
      //   sw.WriteLine("P3 512 512 255");
      //
      //   int i, j;
      //   for (i = 0; i < 512; i++) {
      //     for (j = 0; j < 512; j++) {
      //       int r, g, b, temp;
      //
      //       if (i > 450) {
      //         r = 100;
      //
      //         g = 255 - randObj.Next(10) * 10;
      //
      //         b = 100;
      //       }
      //       else {
      //         int d = (int)(distance(j, i, 256, 450));
      //
      //         // setting cool rgb values
      //         temp = 255 - d;
      //         if (temp < 0) temp = 0;
      //         temp %= 256;
      //         r = temp;
      //
      //         temp = d;
      //         if (temp > 255 && temp <= 511) temp = 511 - temp;
      //         if (temp > 511) temp = 0;
      //         g = temp;
      //
      //         temp = d;
      //         if (temp < 0) temp = 0;
      //         if (temp > 255) temp = 255;
      //         b = temp;
      //       }
      //
      //
      //       sw.WriteLine(String.Format("{0} {1} {2}", r, g, b));
      //     }
      //   }
      //

    } // end Main method

  } // end HomeworkOne class

} // end HomeworkOneNS namespace
