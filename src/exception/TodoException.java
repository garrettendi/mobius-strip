package exception;

/**
 * Runtime exception to be thrown when a method or block of code has yet to be
 * implemented. This is used purely for development use. Released code must NEVER 
 * throw these exceptions. Extends RuntimeException so can be thrown without 
 * declaring in the method signature (as such code should never be released).
 * @author Dale Hards
 *
 */
public class TodoException extends RuntimeException {

	public TodoException()
	{
		super("TODO. Please notify author.");
	}
	
}
