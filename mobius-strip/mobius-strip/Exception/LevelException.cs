using System;

namespace Mobius.Exception
{
  internal class LevelException : System.Exception
  {
    internal string FileName { get; set; }

    internal LevelException (string fileName, string message) : base(message)
    {
      FileName = fileName;
    }
  }
}

