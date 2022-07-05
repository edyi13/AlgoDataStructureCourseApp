using System;

class Program {
  public static void findNemo(string[] arr){
    for(int i = 0; i < arr.Length;i++){
        Console.WriteLine(arr[i]);
      if(arr[i] == "nemo"){
        Console.WriteLine("Found Nemo!!!");
      }
    }
    
  }
  public static void Main (string[] args) {
    string[] nemo = new string[] {"nemo"};
    findNemo(nemo);
  }
}