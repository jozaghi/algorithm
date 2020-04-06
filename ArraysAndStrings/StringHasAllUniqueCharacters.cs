using System;
using System.Collections.Generic;
using Helper;

namespace ArraysAndStrings
{
  public class StringHassAllUniqueCharacters:IRunnable
  {
    public string Name => this.GetType().Name;
    public IEnumerable<Response> Run(){
      yield return Check.IsTrue(CheckChars("ali"));
      yield return Check.IsFalse(CheckChars("aili"));
      yield return Check.IsFalse(CheckChars("aila"));
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