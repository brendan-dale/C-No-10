using System;
using System.Collections.Generic;

class Program {
  static void Main () {
   
    //Assignment 1
    string[] array1 = { "Your name is ", "My name is not ",  "Its nice to see you today, ",  };

    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();

   for (int i = 0; i < array1.Length; i++)
    {
      Console.WriteLine(array1[i] + name);
    }
      Console.WriteLine();
    //Assignment 2 & 3, infinite loop, broken
      for (int a = 0; a < 50; a--) {
            Console.WriteLine("value : {0}", a);
            break;
         }
    
    //Assignment 4
    int[] array2 = { 2, 45, 65, 75, 87 };

    for (int i = 0; i < array2.Length; i++)
      {
        Console.WriteLine(array2[i]);
      }

    //Assignment 5
    int[] array3 = { 4, 5, 12, 3, 187 };

    for (int i = 0; i <= 4; i++)
      {
        Console.WriteLine(array3[i]);
      }
      Console.WriteLine();
    //Assignment 6, 7 & 8
     string[] array4 = { "apple", "oranges", "banana", "kiwi", "tangerine", "watermelon", "dragonfruit" };

     Console.WriteLine("Let's see if your favorite fruit is listed in my array. Enter your favorite fruit: ");
     string fruit = Console.ReadLine();

     int index1 = Array.IndexOf(array4, fruit);

     for (int i = 0; i < array4.Length; i++)
     {
       
       if (fruit == array4[i])
       {
         Console.WriteLine("Your favorite fruit is in my array at index: " + index1);
         break;
       }
       else if (fruit != array4[i])
       {
        Console.WriteLine("Your fruit isn't in my array.");
        break;
       }    
     }

    //Assignment 9 & 10
    List<string> List1 = new List<string>() { "red", "green", "blue", "purple", "orange", "blue", "black", "white", "yellow", "brown", "cyan", "magenta" };

    Console.WriteLine();
    Console.WriteLine("Please enter your favorite color: ");
    string color = Console.ReadLine();

    foreach (string ListItem in List1)
    {
      if (ListItem == color)
      {
        int index2 = List1.IndexOf(ListItem);
        Console.WriteLine("Your color is in my list at index: ");
        Console.WriteLine(index2);
      }
      else
      {
        Console.WriteLine("Your color isn't in my list.");
        break;
      }
    } 
    Console.WriteLine();

    //Assignment 11
     List<string> names = new List<string>() { "Robert", "Steve", "Bradley", "Arthur", "Harry", "Arthur", "Joey"};
     List<string> duplicates = new List<string>();

    foreach (string name2 in names)
      {
        Console.WriteLine(name2);
      }


      



  }
}