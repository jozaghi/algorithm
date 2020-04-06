namespace Helper{
  public class Response
  {
    public bool IsSuccess { get; }
    public string Message { get; }
    public bool IsFailure => !IsSuccess;

    private Response(bool isSuccess, string message){
      IsSuccess = isSuccess;
      Message = message;
    }

    public static Response Ok() => new Response(true, string.Empty);

    public static Response Fail(string message) => new Response(false, message);

    public  override string ToString()=>
      IsSuccess ?
          "Success":
          "Fail:"+ Message;
    
  }
}
