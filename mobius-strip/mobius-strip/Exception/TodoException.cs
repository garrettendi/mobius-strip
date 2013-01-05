using System;

namespace Mobius.Exception
{
  public class TodoException : System.Exception
  {
    public TodoException () : base("TODO. Please notify author.")
    {
    }
  }
}

