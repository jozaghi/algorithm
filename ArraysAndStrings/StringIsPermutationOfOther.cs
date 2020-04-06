using Helper;
using System.Collections.Generic;

namespace ArraysAndStrings
{
  class StringIsPermutationOfOther: IRunnable
  {
    public string Name => this.GetType().Name;
    public IEnumerable<Response> Run()
    {
      yield return Check.IsFalse(CheckChars("aila","asss"));
      yield return Check.IsFalse(CheckChars("assa","asss"));
      yield return Check.IsTrue(CheckChars("ali","ila"));
      yield return Check.IsFalse(CheckChars("ali=","ila"));
      yield return Check.IsFalse(CheckChars("","ila"));
      yield return Check.IsFalse(CheckChars(null,"ila"));
    }

    private bool CheckChars(string first, string second)
    {
      if(string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
        return true;
      if((string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(second))||
        (!string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second)))
        return false;
      if(first.Length != second.Length)
        return false;
      
      var map = new Dictionary<char,int>();
      foreach(var c in first){
        map[c] = map.ContainsKey(c)?
                  map[c]+1:
                  1;
      }
      foreach(var c in second)
      {
        if(!map.ContainsKey(c))
          return false;
        
        map[c] = map[c] -1;
        
        if(map[c]<0)
          return false;
      }
      return true;
    }
  }
}