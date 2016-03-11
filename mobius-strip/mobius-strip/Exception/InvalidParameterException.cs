using System;

namespace Mobius.Exception
{
	internal class InvalidParameterException : System.Exception
	{
    internal string Type { get; set; }
    internal string FileName { get; set; }
    internal string ParameterName { get; set; }
    internal string ParameterValue { get; set; }

    internal InvalidParameterException(string type,
                                     string fileName,
                                     string parameterName,
                                     string parameterValue,
                                     string message) : base(message)
    {
      this.Type = type;
      this.FileName = fileName;
      this.ParameterName = parameterName;
      this.ParameterValue = parameterValue;
    }
	}
}
