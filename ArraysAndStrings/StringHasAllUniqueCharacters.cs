using System;
using System.Collections.Generic;
namespace ArraysAndStrings
{
  public class StringHassAllUniqueCharacters:IRunable
  {
    public void Run(){
      Console.WriteLine(CheckChars("aili"));
    }
    public bool CheckChars(string input){
      var charMap = new HashSet<Char>();
      foreach(char character in input){
        if(charMap.Contains(character)){
          return false;
        }
        charMap.Add(character);
      }
      return true;
    }
  }
}