using System;
using System.Collections.Generic;

namespace Mobius
{
  public class MobiusStrip
  {
    public static readonly string GAMES_DIRECTORY = "/games/"; // Folder that ALL GAMES are located in
    
    // Use this to keep track of all files we have loaded. Once the garbage collector has
    // discarded an object, it is removed from the list. In this way, we work with a cache
    // and only completely new and files are loaded, only as needed.
    // TODO use a GENERIC list that disallows duplicates
    // TODO could this caching cause a memory leak?
    public static List<string> loadedFiles = new List<string>();
    public static readonly string FILE_EXTENSION = ".xml";
    
    /**
     * @param args
     */
    public static void Main(String[] args)
    {
      // TODO Auto-generated method stub
      //String game = args[0];

      Console.WriteLine("Mobius Strip");
    }
  }
}
