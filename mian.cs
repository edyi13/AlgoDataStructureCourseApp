using System;
using System.Diagnostics;

class Program {
  
  public static void findNemo(string[] arr){
    // Stopwatch sw = Stopwatch.StartNew();
    for(int i = 0; i < arr.Length;i++){
      if(arr[i] == "nemo"){
        Console.WriteLine("Found Nemo!!!");
      }      
    }
    // sw.Stop();
    // Console.WriteLine("Finding nemo takes " + sw.Elapsed.TotalMilliseconds);
  }

  public static void logFirst2Boxes(int[] boxes){
     Console.WriteLine(boxes[0]);
     Console.WriteLine(boxes[1]);
  }
  
  
  public static void Main (string[] args) {
    string[] nemo = new string[] {"nemo"};
    string[] fish = new string[] {"dory", "bruce", "marlin", "nemo"};
    string[] everyone = new string[] {"dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt","darla", "hank"};

    string[] large = new string [10000];
    Array.Fill(large,"nemo");
    //findNemo(large); //Big O notation = 0(n) --> Linear Time
    /************************************************************/

    int[] arr = new int[]{1,2,3,4,5};
    logFirst2Boxes(arr); //Big O notation 0(1) --> Constant Time
  }
}