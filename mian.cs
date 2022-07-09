using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

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
//Google video section 4 C# solution
  public static bool hasPairWithSum(int[] arr, int sum){
		HashSet<int> complements = new HashSet<int>();
		int val = 0;
		foreach(var item in arr){
			if(complements.TryGetValue(item, out val))
				return true;
			complements.Add(sum-item);
		}
		return false;
	}
//Key Points 
//Given 2 arrays, lets a user know (true false) whether these two arrays contain any common items
/**
For example:
['a','b','c','x']
['z','y','i']
should return false
---------------------------
['a','b','c','x']
['z','y','x']
should return true

2 parameters in - no size limit
return Boolean
**/
//My Solution #1
	public static bool containsCommonItem(string[] arr1, string[] arr2){
    string[] smallest = arr1.Length < arr2.Length ? arr1 : arr2;
    string[] largest = arr1.Length > arr2.Length ? arr1 : arr2;
    for(int i = 0; i < smallest.Length; i++){
      if(Array.Exists(largest, element => element == smallest[i]))
         return true;
    }
    return false;
  }

  //My Solution #2
	public static bool containsCommonItem2(string[] arr1, string[] arr2){		
    string[] smallest = arr1.Length < arr2.Length ? arr1 : arr2;
    string[] largest = arr1.Length > arr2.Length ? arr1 : arr2;
    if(smallest.Intersect(largest).Any())
      return true;
    
		return false;
  }

  //Course Solution
  public static bool containsCommonItemCourse(string[] arr1, string[] arr2){
    //loop through 1st array and create a hashmap or object where properties === items in the array
    //loop through second array and check if item in second array exists on reated object

    var dictSearch = new Dictionary<string, bool>();

    for(int i = 0; i < arr1.Length; i++){
      if(arr1[i] != null && !dictSearch.ContainsKey(arr1[i]))
        dictSearch.Add(arr1[i],true);     
    }

    for(int j = 0; j < arr2.Length; j++){
      if(dictSearch.ContainsKey(arr2[j])){
        return true;
      }
    }

    return false;
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
    //logFirst2Boxes(arr); //Big O notation 0(1) --> Constant Time

    /**************************************************************/
    int[] arr1 = new int[] {1,2,3,9};		
		int[] arr2 = new int[] {1,2,4,4};
		//var result1 = hasPairWithSum(arr1,8);		
		//var result2 = hasPairWithSum(arr2,8);
     //Big O notation = 0(n) --> Linear Time		
		//Console.WriteLine(result1);		
		//Console.WriteLine(result2);

    
    string[] arr3 = new string[] {"a",null,"c","x"};		
		string[] arr4 = new string[] {"z","y","x"};
    var result = containsCommonItem(arr3, arr4);
     //Big O notation = 0(a+b) --> Linear Time	Because arrays have different length
    Console.WriteLine(result);

    var result3 = containsCommonItem2(arr3, arr4);
     //Big O notation = 0(a+b) --> Linear Time	Because arrays have different length
    Console.WriteLine(result3);

    
    var result2 = containsCommonItemCourse(arr3, arr4);
     //Big O notation = 0(a+b) --> Linear Time	Because arrays have different length
    Console.WriteLine(result2);
  }
}