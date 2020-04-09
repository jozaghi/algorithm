using Helper;
using System.Collections.Generic;

namespace ArraysAndStrings
{
  class StringCompression: IRunnable
  {
    public string Name => this.GetType().Name;
    public IEnumerable<Response> Run()
    {
      yield return Check.AreEqual("", Compress(""));
      yield return Check.AreEqual(null, Compress(null));
      yield return Check.AreEqual("a3b3c3", Compress("aaabbbccc"));
      yield return Check.AreEqual("abcdefgh", Compress("abcdefgh"));
    }

    public string Compress(string input)
    {
      if(string.IsNullOrEmpty(input)) return input;
      var compressionResult = string.Empty;
      for(var i = 0; i<input.Length;i++)
      {
        var baseChar = input[i];
        var charCount = 1;
        while(i+1<input.Length && input[i+1]==baseChar){
          charCount+=1;
          i++;
        }
        compressionResult+=$"{baseChar}{charCount}";
      }
      return input.Length <= compressionResult.Length?
             input:
             compressionResult;
    }
  }
}