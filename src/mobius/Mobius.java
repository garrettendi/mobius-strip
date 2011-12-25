package mobius;

import java.util.ArrayList;

/**
 * This is the class that begins the engine.
 * @author Dale Hards
 */
public class Mobius
{
	public static final String GAMES_DIRECTORY = "/games/"; // Folder that ALL GAMES are located in

	// Use this to keep track of all files we have loaded. Once the garbage collector has
	// discarded an object, it is removed from the list. In this way, we work with a cache
	// and only completely new and files are loaded, only as needed.
	// TODO use a GENERIC list that disallows duplicates
	// TODO could this caching cause a memory leak?
	public static ArrayList<String> loadedFiles = new ArrayList<String>();
	public static final String FILE_EXTENSION = ".xml";

	/**
	 * @param args
	 */
	public static void main(String[] args)
	{
		// TODO Auto-generated method stub
		String game = args[0];
	}
}
