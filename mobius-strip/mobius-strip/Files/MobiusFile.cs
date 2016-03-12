using System;

namespace Mobius
{
  [Serializable]
  internal abstract class MobiusFile
  {
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    internal string Id { get; set; }
   
    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    internal abstract string Type { get; }
  
    /// <summary>
    /// Initializes a new instance of the <see cref="Mobius.MobiusFile"/> class.
    /// </summary>
    /// <param name='id'>
    /// Identifier.
    /// </param>
    internal MobiusFile(string id)
    {
      this.Id = id;
    }
  }
}

