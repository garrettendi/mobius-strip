using System;

namespace Mobius.Exception
{
	public class InvalidParameterException : System.Exception
	{
    public string Type { get; set; }
    public string FileName { get; set; }
    public string ParameterName { get; set; }
    public string ParameterValue { get; set; }

    public InvalidParameterException(string type,
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
