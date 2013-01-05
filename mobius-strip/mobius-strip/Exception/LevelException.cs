using System;

namespace Mobius.Exception
{
  public class LevelException : System.Exception
  {
    public string FileName { get; set; }

    public LevelException (string fileName, string message) : base(message)
    {
      FileName = fileName;
    }
  }
}

