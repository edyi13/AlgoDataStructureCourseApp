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
  public static void Main (string[] args) {
    string[] nemo = new string[] {"nemo"};
    string[] fish = new string[] {"dory", "bruce", "marlin", "nemo"};
    string[] everyone = new string[] {"dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt","darla", "hank"};

    string[] large = new string [10000];
    Array.Fill(large,"nemo");
    findNemo(large); //Big O notation = 0(n) --> Linear Time
  }
}