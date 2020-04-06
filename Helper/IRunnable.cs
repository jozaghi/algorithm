using System.Collections.Generic;

namespace Helper{
  public interface IRunnable
  {
    string Name { get; }
    IEnumerable<Response> Run();
  }
}
