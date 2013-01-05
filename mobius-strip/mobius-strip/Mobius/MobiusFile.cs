using System;

namespace Mobius
{
  [Serializable]
  public abstract class MobiusFile
  {
    public string Id { get; set; }
   
    public abstract string Type { get; }

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

