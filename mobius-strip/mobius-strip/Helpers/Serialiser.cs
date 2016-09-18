using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mobius.Helpers
{
  public class Serialiser
  {
    /// <summary>
    /// Serialise an object
    /// </summary>
    /// <param name="file">The object for the file to write</param>
    /// <param name="path">The path to write to</param>
    public void Serialise(MobiusFile file, string path)
    {
      switch (file.Type)
      {
        case Mobius.Enum.FileType.LEVEL:
          {
            SerialiseLevel((Level)file, path);
            break;
          }
      }
    }

    /// <summary>
    /// Serialise Level files
    /// </summary>
    /// <param name="level">The object for the level file to write</param>
    /// <param name="path">The path to write to</param>
    private void SerialiseLevel(Level level, string path)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(Level));
      StreamWriter writer = new StreamWriter(path);
      serializer.Serialize(writer, level);
    }
  }
}
