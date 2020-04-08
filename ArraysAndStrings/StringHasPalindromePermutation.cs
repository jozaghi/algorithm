using Helper;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
  class StringHasPalindromePermutation:IRunnable
  {
    public string Name => this.GetType().Name;
    public IEnumerable<Response> Run()
    {
      yield return Check.IsFalse(CheckInput("ali"));
      yield return Check.IsFalse(CheckInput("alia"));
      yield return Check.IsTrue(CheckInput("alila"));
      yield return Check.IsTrue(CheckInput(""));
      yield return Check.IsTrue(CheckInput(null));
      yield return Check.IsTrue(CheckInput("aabbccd"));
      yield return Check.IsFalse(CheckInput("aabbccdo"));
    }

    private bool CheckInput(string input)
    {
      if(input == null)
        return true;
      var map = GetCharNumbersMap(input);
      return !(map.Count(p=> p.Value % 2 != 0)>1);
    }
    private Dictionary<char,int> GetCharNumbersMap(string input)
    {
      var result = new Dictionary<char,int>();
      foreach(var character in input){
        result[character] = result.ContainsKey(character) ? 
          result[character] + 1:
          1;
      }
      return result;
    }
  }
}