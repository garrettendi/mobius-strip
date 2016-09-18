using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mobius.Helpers
{
  public class Deserialiser
  {
    /// <summary>
    /// Deserialise a file based on it's type
    /// </summary>
    /// <param name="type">Type of file</param>
    /// <param name="path">Path of file</param>
    /// <returns>File after being deserialised</returns>
    public MobiusFile Deserialise(string type, string path)
    {
      switch (type)
      {
        case Mobius.Enum.FileType.LEVEL:
          {
            return DeserialiseLevel(path);
          }
      }
      return null;
    }

    /// <summary>
    /// Deserialise a level file
    /// </summary>
    /// <param name="path">Path of file</param>
    /// <returns>Level file after being deserialised</returns>
    private Level DeserialiseLevel(string path)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(Level));
      using (StreamReader reader = new StreamReader(path))
      {
        Level level = (Level)serializer.Deserialize(reader);
        return level;
      }
    }
  }
}
