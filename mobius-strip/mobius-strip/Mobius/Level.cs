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
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <value>
    /// The area.
    /// </value>
    public char[][] Area { get { return area; } }
  
    /// <summary>
    /// Gets or sets the area string.
    /// </summary>
    /// <value>
    /// The area string.
    /// </value>
    /// <exception cref='Mobius.Exception.LevelException'>
    /// Is thrown when the height or width is not as declared in the Area property.
    /// </exception>
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

    private int width;
    /// <summary>
    /// Gets the width of the level from the left
    /// </summary>
    /// <value>
    /// The width.
    /// </value>
    public int Width { get { return width; } }

    private int height;
    /// <summary>
    /// Gets the height of the level from the top.
    /// </summary>
    /// <value>
    /// The height.
    /// </value>
    public int Height { get { return height; } }

    private int crowd; 
    /// <summary>
    /// Gets the number of people in the crowd.
    /// </summary>
    /// <value>
    /// The crowd.
    /// </value>
    public int Crowd { get { return crowd; } }
  
    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    public override string Type { get { return Mobius.Enum.FileType.LEVEL; } }
  
    /// <summary>
    /// Initializes a new instance of the <see cref="Mobius.Level"/> class.
    /// </summary>
    /// <param name='id'>
    /// Identifier.
    /// </param>
    /// <param name='width'>
    /// Width.
    /// </param>
    /// <param name='height'>
    /// Height.
    /// </param>
    /// <param name='crowd'>
    /// Crowd number.
    /// </param>
    public Level(String id, int width, int height, int crowd) : base(id)
    {
      this.area = new char[height][];
      this.width = width;
      this.height = height;
      this.crowd = crowd;
    }
  
    /// <summary>
    /// Increments the crowd number.
    /// </summary>
    /// <returns>
    /// The crowd number.
    /// </returns>
    public int IncrementCrowd() 
    { 
      return ++crowd; 
    }
    
    /// <summary>
    /// Decrements the crowd number.
    /// </summary>
    /// <returns>
    /// The crowd number.
    /// </returns>
    public int DecrementCrowd ()
    {
      if (crowd == 0)
        // if crowd is aleady zero, we cannot decrease it
        return crowd;
      return --crowd;
    }
  }
}