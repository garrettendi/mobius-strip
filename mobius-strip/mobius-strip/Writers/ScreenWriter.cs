using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  public class ScreenWriter
  {
    MainForm form;

    internal ScreenWriter(MainForm f)
    {
      form = f;
    }

    internal void AddFullLine(string pre, string post, string filler, int width, int col, int line)
    {
      StringBuilder builder = new StringBuilder(pre);
      while (builder.Length <= width - post.Length - 1)
      {
        builder.Append(filler);
      }
      builder.Append(post);

      CheckAddString(col, line, builder.ToString());
    }

    internal void EmptyScreen()
    {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < form.ConsoleHeight; i++)
      {        
        for (int j = 0; j < form.ConsoleWidth; j++)
        {
          builder.Append("£");
        }
        if (i < form.ConsoleHeight - 1) builder.Append("\r\n");
      }
      form.SetDisplay(builder);
    }

    /// <summary>
    /// Taken from the FireworkDemo of CursesSharp - GNU LESSER GENERAL PUBLIC LICENSE 
    /// http://curses-sharp.sourceforge.net/ - Original Author: R. Konklewski. 
    /// Used to check and add strings anywhere in the terminal.
    /// </summary>
    /// <param name='col'>
    /// Column to insert string at.
    /// </param>
    /// <param name='line'>
    /// Line to add string at.
    /// </param>
    /// <param name='str'>
    /// String to add.
    /// </param>
    internal void CheckAddString(int col, int line, string str)
    {
      if (col >= 0 && col < form.ConsoleWidth && line >= 0 && line < form.ConsoleHeight)
      {
        string raw = form.ScreenText;

        int index = line * (form.ConsoleWidth + 2) + col;

        StringBuilder builder = new StringBuilder(raw);
        IEnumerable<char> chars = str.ToCharArray().AsEnumerable();

        foreach (char c in chars)
        {
          if (index != 0 && ((line > 0 && index % form.ConsoleWidth + 2 == 0) || (line == 0 && index % form.ConsoleWidth == 0)))
            break;
          builder[index++] = c;
        }

        form.SetDisplay(builder);
      }
    }
  }
}
