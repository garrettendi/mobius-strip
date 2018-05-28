using System;
using System.ComponentModel;
using System.Text;

namespace Mobius
{
  [Serializable, System.Xml.Serialization.XmlRoot("Level")]
  public class Level : MobiusFile
  {
    // Static variables in order to keep track of all the different chars used
    // to build levels
    internal static readonly char floor = ' ';
    internal static readonly char wallVert = '|';
    internal static readonly char wallHorz = '-';
    internal static readonly char doorClosed = '#';
    internal static readonly char doorOpen = '_';
    internal static readonly char grass = '.';

    private char[][] area;
    [System.Xml.Serialization.XmlElement("Area")]
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <value>
    /// The area.
    /// </value>
    public char[][] Area { get { return area; } set { area = value; InvokePropertyChanged(new PropertyChangedEventArgs("Area")); } }

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
        if (Area == null)
          return string.Empty;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < Area.Length; i++)
        {
          sb.AppendLine(new string(Area[i]));
        }
        return sb.ToString();
      }
      set 
      {
        // use String.split() with regex to recognise, end-of-line and end-of-file
        string[] lines = value.Split(new string[] { "\n", "\r", "\r\n" }, StringSplitOptions.None);
        //if (lines.Length != height)
        //  // We have a different number of lines to the height of the area. Return exception.
        //  throw new Mobius.Exception.LevelException("The height of the actual room does not match the declared height.", this.Id);
        Area = new char[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
          //if (lines[i].Length != width)
          //  throw new Mobius.Exception.LevelException("The width of the actual room does not match the declared width.", this.Id);
          Area[i] = lines[i].ToCharArray();
        }
      }
    }

    //private int width;
    //[System.Xml.Serialization.XmlElement("Width")]
    ///// <summary>
    ///// Gets the width of the level from the left
    ///// </summary>
    ///// <value>
    ///// The width.
    ///// </value>
    //public int Width { get { return width; } }

    //private int height;
    //[System.Xml.Serialization.XmlElement("Height")]
    ///// <summary>
    ///// Gets the height of the level from the top.
    ///// </summary>
    ///// <value>
    ///// The height.
    ///// </value>
    //public int Height { get { return height; } }

    private int crowd;

    public event PropertyChangedEventHandler PropertyChanged;

    [System.Xml.Serialization.XmlElement("Crowd")]
    /// <summary>
    /// Gets the number of people in the crowd.
    /// </summary>
    /// <value>
    /// The crowd.
    /// </value>
    public int Crowd { get { return crowd; } set { crowd = value; InvokePropertyChanged(new PropertyChangedEventArgs("Crowd")); } }
  
    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    internal override string Type { get; } = Mobius.Enum.FileType.LEVEL;

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
    public Level(String id, int crowd) : base(id)
    {
      //this.area = new char[height][];
      //this.width = width;
      //this.height = height;
      this.crowd = crowd;
      this.id = id;
    }
  
    /// <summary>
    /// Increments the crowd number.
    /// </summary>
    /// <returns>
    /// The crowd number.
    /// </returns>
    internal int IncrementCrowd() 
    { 
      return ++crowd; 
    }
    
    /// <summary>
    /// Decrements the crowd number.
    /// </summary>
    /// <returns>
    /// The crowd number.
    /// </returns>
    internal int DecrementCrowd()
    {
      if (crowd == 0)
        // if crowd is aleady zero, we cannot decrease it
        return crowd;
      return --crowd;
    }
  }
}