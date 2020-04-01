public class Response
{
  public bool IsSuccess { get; }
  public string Message { get; }
  public bool IsFailure => !IsSuccess;

  private Response(bool isSuccess, string message){
    IsSuccess = isSuccess;
    Message = message;
  }

  public static Ok() => new Response(true, string.Empty);

  public static Fail(string message) => new Response(false, message);
}