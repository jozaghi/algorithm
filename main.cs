using System;
using ArraysAndStrings;
using Helper;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Run();
  }

  public static void Run(){
    var algorithms = new IRunnable[]{
      new StringHassAllUniqueCharacters(),
      new StringIsPermutationOfOther()
    };
    foreach(var algorithm in algorithms){
      var results = algorithm.Run().ToList();
      Console.WriteLine("______________________________________");
      Console.WriteLine(algorithm.Name);
      for(var i=0;i<results.Count();i++){
        Console.WriteLine((i+1)+") "+results[i]);
      }
    }
  }

}