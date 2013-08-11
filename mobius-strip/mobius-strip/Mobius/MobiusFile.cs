using System;

namespace Mobius
{
  [Serializable]
  public abstract class MobiusFile
  {
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public string Id { get; set; }
   
    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    public abstract string Type { get; }
  
    /// <summary>
    /// Initializes a new instance of the <see cref="Mobius.MobiusFile"/> class.
    /// </summary>
    /// <param name='id'>
    /// Identifier.
    /// </param>
    public MobiusFile(string id)
    {
      this.Id = id;
    }

    #region unported java
//    public static MobiusFile loadFromFile(String path)
//    {
//      try
//      {
//        Object obj = XmlWriter.fromXmlFile(path);
//        Mobius.loadedFiles.add(path);
//        return (obj instanceof MobiusFile ? (MobiusFile)obj : null);
//      }
//      catch (IOException e)
//      {
//        // TODO Issue #7, curses library to change font colour and display text properly.
//        System.out.println("Problem encountered loading file: ");
//        System.out.println("\t" + path);
//        System.out.println(e.getMessage());
//        // TODO Log stack trace
//      }
//      return null;
//    } 
    #endregion
  }
}

