using System;

namespace Mobius
{
  public class Game : MobiusFile
  {
    // Folder of the game files for THIS PARTICULAR GAME.
    public string GameFolder { get; set; }

    // The name of the starting room for new games. This should be the 
    // filename, not including the .xml extension.
    public string Start { get; set; }

    // The name of the game.
    private string Name { get; set; }

    public override string Type { get { return Mobius.Enum.FileType.GAME; } }

    /// <summary>
    /// Constructor. Creates a <see cref="Mobius.Game"/> class with null parameters. The FileType is always Game.
    /// Initializes a new instance of the <see cref="Mobius.Game"/> class.
    /// </summary>
    /// <param name='id'>
    /// id.
    /// </param>
    public Game(string id) : base(id)
    {
      this.GameFolder = null;
      this.Start = null;
      this.Name = null;
    }

    /// <summary>
    /// Constructor. Creates a <see cref="Mobius.Game"/> class. The FileType is always Game.
    /// </summary>
    /// <param name='id'>
    /// </param>
    /// <param name='name'>
    /// Name of the game
    /// </param>
    /// <param name='gameFolder'>
    /// Folder the game files are contained in
    /// </param>
    /// <param name='start'>
    /// The name of the starting room for new game. This is the name of the room file minus the extension
    /// </param>
    public Game(string id, string name, string gameFolder, string start) : base(id)
    {
      this.Name = name;
      this.GameFolder = gameFolder;
      this.Start = start;
    }
  }
}

