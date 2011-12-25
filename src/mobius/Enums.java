package mobius;

/**
 * Enums class to contain all of the enumerations used through the project. This is in order
 * to have a central place in the code to keep account of any parameter names or values that
 * might be used in more than one place.
 * @author Dale Hards
 */
public class Enums
{
	public enum FileType
	{
		Game ("game"),
		Level ("level");

		private final String typeName;

		private FileType(String _typeName)
		{
		  this.typeName = _typeName;
		}

		public String getTypeName() { return typeName; }

		public String toString()
		{
		  return typeName;
		}
	}
}
