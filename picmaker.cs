using System;
using System.IO;

namespace HomeworkOneNS {
  class HomeworkOne {

    static void Main(String[] args) {
      using (StreamWriter sw = new StreamWriter("image.ppm")) {

        // write initial line
        sw.WriteLine("P3 512 512 255");

        int i, j;
        for (i = 0; i < 512; i++) {
          for (j = 0; j < 512; j++) {
            sw.WriteLine(String.Format("{0} {1} {2}", i % 256, j % 256, (i + j) / 2));
          }
        }
      }

    } // end Main method

  } // end HomeworkOne class

} // end HomeworkOneNS namespace
