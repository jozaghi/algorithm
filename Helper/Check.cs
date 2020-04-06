namespace Helper{
  public static class Check{

    public static Response IsTrue(this bool statement){
      return statement ? 
        Response.Ok():
        Response.Fail("statement most be 'true' given 'false'");
    }

    public static Response IsFalse(this bool statement){
      return !statement ? 
        Response.Ok():
        Response.Fail("statement most be 'false' given 'true'");
    }
  }
}
