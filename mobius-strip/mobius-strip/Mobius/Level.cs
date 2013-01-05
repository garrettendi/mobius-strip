using System;
using System.Text;

namespace Mobius
{
  public class Level : MobiusFile
  {
    // Static variables in order to keep track of all the different chars used
    // to build levels
    public static readonly char floor = ' ';
    public static readonly char wallVert = '|';
    public static readonly char wallHorz = '-';
    public static readonly char doorClosed = '#';
    public static readonly char doorOpen = '_';
    public static readonly char grass = '.';

    private char[][] area;
    public char[][] Area { get { return area; } }

    public string AreaStr 
    {
      get 
      {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < area.Length; i++)
        {
          sb.AppendLine(new string(area[i]));
        }
        return sb.ToString();
      }
      set 
      {
        // use String.split() with regex to recognise, end-of-line and end-of-file
        string[] lines = value.Split(new char[] { '\n', '\r' });
        if (lines.Length != height)
          // We have a different number of lines to the height of the area. Return exception.
          throw new Mobius.Exception.LevelException("The height of the actual room does not match the declared height.", this.Id);
        for (int i = 0; i < lines.Length; i++)
        {
          if (lines[i].Length != width)
            throw new Mobius.Exception.LevelException("The width of the actual room does not match the declared width.", this.Id);
          area[i] = lines[i].ToCharArray();
        }
      }
    }

    // Width of the level from the left
    private int width;
    public int Width { get { return width; } }

    // Height of the level from the top
    private int height;
    public int Height { get { return height; } }

    // Number of people in the crowd
    private int crowd; 
    public int Crowd { get { return crowd; } }

    public override string Type { get { return Mobius.Enum.FileType.LEVEL; } }

    public Level(String id, int width, int height, int crowd) : base(id)
    {
      this.area = new char[height][];
      this.width = width;
      this.height = height;
      this.crowd = crowd;
    }

    public int IncrementCrowd() 
    { 
      return ++crowd; 
    }
    
    public int DecrementCrowd ()
    {
      if (crowd == 0)
        // if crowd is aleady zero, we cannot decrease it
        return crowd;
      return --crowd;
    }
  }
}