using System;

namespace Mobius
{
  internal class Game : MobiusFile
  {
    /// <summary>
    /// Gets or sets the folder of the game files for THIS PARTICULAR GAME.
    /// </summary>
    /// <value>
    /// Folder of the game files for THIS PARTICULAR GAME.
    /// </value>
    internal string GameFolder { get; set; }

    /// <summary>
    /// Gets or sets the name of the starting room for new games. This should be the 
    /// filename, not including the .xml extension..
    /// </summary>
    /// <value>
    /// The starting room for new games. This should be the 
    /// filename, not including the .xml extension..
    /// </value>
    internal string Start { get; set; }

    /// <summary>
    /// Gets or sets the the name of the game.
    /// </summary>
    /// <value>
    /// The name of the game.
    /// </value>
    private string Name { get; set; }
  
    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    internal override string Type { get { return Mobius.Enum.FileType.GAME; } }

    /// <summary>
    /// Constructor. Creates a <see cref="Mobius.Game"/> class with null parameters. The FileType is always Game.
    /// Initializes a new instance of the <see cref="Mobius.Game"/> class.
    /// </summary>
    /// <param name='id'>
    /// id.
    /// </param>
    internal Game(string id) : base(id)
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
    internal Game(string id, string name, string gameFolder, string start) : base(id)
    {
      this.Name = name;
      this.GameFolder = gameFolder;
      this.Start = start;
    }
  }
}

