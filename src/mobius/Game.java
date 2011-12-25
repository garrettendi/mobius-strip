package mobius;

import mobius.Enums.FileType;

/**
 * Class for Game objects. This contains all the information about the Game.
 * @author Dale Hards
 */
public class Game extends MobiusFile
{
	private String gameFolder; // Folder of the game files for THIS PARTICULAR GAME.
	private String start; 	// The name of the starting room for new games. This should be
	                        // the filename, not including the .xml extension.
	private String name; // The name of the game.

	/**
	 * Constructor. Creates a game with null parameters. The FileType is always Game.
	 * @param _fileName The filename of the game, not including the .xml extension
	 */
	public Game(String _fileName)
	{
		super(FileType.Game, _fileName);
		this.gameFolder = null;
		this.start = null;
	}

	/**
	 * Constructor. The FileType is always Game.
	 * @param _fileName The filename of the game, not including the .xml extension
	 * @param _name Name of the game
	 * @param _gameFolder Folder the game files are contained in
	 * @param _start The name of the starting room for new game. This is the name of the room file minus the extension
	 */
	public Game(String _fileName, String _name, String _gameFolder, String _start)
	{
		super(FileType.Game, _fileName);
		this.name = _name;
		this.gameFolder = _gameFolder;
		this.start = _start;
	}

	public String getFolder() { return gameFolder; }
  public void setFolder(String folder) { this.gameFolder = folder; }

  public String getStart() { return start; }
	public void setStart(String start) { this.start = start; }
}