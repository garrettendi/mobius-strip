package mobius;

import java.security.InvalidParameterException;

import exception.LevelException;

import mobius.Enums.FileType;

/**
 * Used to represent Levels, corresponding to a given XML file containing data
 * for a room, town, dungeon, or indeed any kind of area the user may be exploring.
 * Note the field for the "number of people in the crowd". This number represents
 * how many non-interactive people are in the level. By "non-interactive" it is
 * meant that they will not speak or interact with the user in any way other than
 * to fight if fought. If they are fought, they fight with randomly generated specs.
 * See the CrowdMember class for more information.
 * @author Dale Hards
 */
public class Level extends MobiusFile {

  // Static variables in order to keep track of all the different chars used
  // to build levels
  public static final char floor = ' ';
  public static final char wallVert = '|';
  public static final char wallHorz = '-';
  public static final char doorClosed = '#';
  public static final char doorOpen = '_';
  public static final char grass = '.';

  private char[][] area;
  private int width; // Width of the level from the left
  private int height; // Height of the level from the top
  private int crowd; // Number of people in the crowd

  /**
   * Constructor used to build Level object. The x and y are for the width and height
   * respectively, measured from the top left.
   * @param _fileName File name (not including extension)
   * @param _width The width of the level - from the left
   * @param _height The height of the level - from the top
   * @param _crowd The number of people in the crowd of the level.
   */
  public Level(String _fileName, int _width, int _height, int _crowd)
  {
    super(FileType.Level, _fileName);
    area = new char[height][width];
    this.width = _width;
    this.height = _height;
    this.crowd = _crowd;
  }

  public char[][] getArea() { return area; }

  public int getHeight() { return area.length; }

  public int getWidth() { return area[0].length; }
  
  public int getCrowd() { return crowd; }

  public String getAreaString()
  {
    StringBuilder sb = new StringBuilder();
    sb.append(new String(area[0]));
    for (int i = 1; i < area.length; i++)
    {
      sb.append('\n');
      sb.append(area[i]);
    }
    return sb.toString();
  }
  public void setAreaString(String s) throws LevelException
  {
    // use String.split() with regex to recognise, end-of-line and end-of-file
    String[] lines = s.split("[\n\r]");
    if (lines.length != area.length)
      // We have a different number of lines to the height of the area. Return exception.
      throw new LevelException("The height of the actual room does not match the declared height.", this.getFileName());
    for (int i = 0; i < lines.length; i++)
    {
      area[i] = lines[i].toCharArray();
    }
  }
  
  /**
   * Increment the crowd number. I.e. create a new crowd member.
   * @return
   */
  public int incrCrowd() { return ++crowd; }
  
  /**
   * Decrement the crowd number. I.e. remove a crowd member.
   * @return
   */
  public int decrCrowd()
  {
    if (crowd == 0)
      // if crowd is aleady zero, we cannot decrease it
      return crowd;
    return --crowd;
  }
}