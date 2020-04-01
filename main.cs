using System;
using ArraysAndStrings;
class MainClass {
  public static void Main (string[] args) {
    Run();
  }

  public static void Run(){
    var algorithms = new IRunable[]{
      new StringHassAllUniqueCharacters()
    };
    foreach(var algorithm in algorithms){
      algorithm.Run();
    }
  }

}