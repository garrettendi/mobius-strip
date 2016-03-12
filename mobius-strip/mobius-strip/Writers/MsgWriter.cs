using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  public class MsgWriter
  {
    private MainForm form;

    internal MsgWriter(MainForm f)
    {
      form = f;
    }

    /// <summary>
    /// Draws the journal window.
    /// </summary>
    internal void DrawMessageWin()
    {
      form.Writer.AddFullLine("*-Messages", "*", "-", form.ConsoleWidth, 0, form.ConsoleHeight - MainForm.JOURNAL_HEIGHT);
      for (int i = form.ConsoleHeight - MainForm.JOURNAL_HEIGHT + 1; i < form.ConsoleHeight - 1; i++)
        form.Writer.AddFullLine("|", "|", " ", form.ConsoleWidth, 0, i);
      form.Writer.AddFullLine("*", "*", "-", form.ConsoleWidth, 0, form.ConsoleHeight - 1);
    }
  }
}
