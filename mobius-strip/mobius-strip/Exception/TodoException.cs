using System;

namespace Mobius.Exception
{
  internal class TodoException : System.Exception
  {
    internal TodoException () : base("TODO. Please notify author.")
    {
    }
  }
}

