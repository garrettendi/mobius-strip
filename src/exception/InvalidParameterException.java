package exception;

/**
 * Except to be thrown when a parameter of a xml file is invalid.
 * @author Dale Hards
 *
 */
public class InvalidParameterException extends Exception {

	private String type;
	private String fileName;
	private String parameterName;
	private String parameterValue;

	/**
	 * Constructor
	 * @param type The type of file being loaded
	 * @param fileName The name of the file being loaded
	 * @param parameterName The parameter being loaded
	 * @param parameterValue The value of the parameter being loaded
	 * @param message The message to display to the user
	 */
	public InvalidParameterException(String _type,
                									 String _fileName,
                									 String _parameterName,
                									 String _parameterValue,
                									 String message)
	{
		super(message);
		this.type = _type;
		this.fileName = _fileName;
		this.parameterName = _parameterName;
		this.parameterValue = _parameterValue;
	}

	public String getType()	{ return type; }
	public String getFileName()	{ return fileName; }
	public String getParameterName() { return parameterName; }
	public String getParameterValue()	{	return parameterValue; }

	// Don't need to override toString()
}
