using System;

class MainClass {
  public static void Main (string[] args) {

/* Creates class with int under name blah for 5 indices*/
int[] blah = new int[5];

/* This sets the values in those 5 indices */
blah[0] = 11;
blah[1] = 54;
blah[2] = 31;
blah[3] = 74;
blah[4] = 99;

/* This displays the index 0 for blah */
Console.WriteLine(blah[0]);
    
    
/* This creates a class with int under name blahblah for 5 indices*/
int[] blahblah = {1, 3, 5, 7, 9};

/* This displays the index 0 for blahblah */
Console.WriteLine(blahblah[0]);




  }
}
