using namespace Helper{
  public static class Check{

    public static Response IsTrue(this bool statement){
      return statement ? 
        Response.Ok():
        Response.False("statement most be 'true' given 'false'");
    }

  }
}
