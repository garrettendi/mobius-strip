using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  public class JournalWriter
  {
    private MainForm form;

    public JournalWriter(MainForm f)
    {
      form = f;
    }

    /// <summary>
    /// Draws the journal window.
    /// </summary>
    public void DrawJournalWin()
    {
      form.Writer.AddFullLine("*-Journal", "*", "-", form.ConsoleWidth, 0, form.ConsoleHeight - MainForm.JOURNAL_HEIGHT);
      for (int i = form.ConsoleHeight - MainForm.JOURNAL_HEIGHT + 1; i < form.ConsoleHeight - 1; i++)
        form.Writer.AddFullLine("|", "|", " ", form.ConsoleWidth, 0, i);
      form.Writer.AddFullLine("*", "*", "-", form.ConsoleWidth, 0, form.ConsoleHeight - 1);
    }
  }
}
