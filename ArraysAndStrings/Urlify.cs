using Helper;
using System.Collections.Generic;
using System;

namespace ArraysAndStrings
{
  class Urlify:IRunnable
  {
    public string Name => this.GetType().Name;
    public IEnumerable<Response> Run()
    {
      yield return Check.AreEqual(Parse("ali"),"ali");
      yield return Check.AreEqual(Parse("ali reza"),"ali%20reza");
    }

    public string Parse(string input){
      if(string.IsNullOrEmpty(input))
        return string.Empty;

      var result = string.Empty;
      foreach(var character in input)
      {
        result+= (character == ' ')?
          "%20":
          character.ToString();
      }
      return result;
    }
  }
}