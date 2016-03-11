using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  public class MapWriter
  {
    private MainForm form;

    public MapWriter(MainForm f)
    {
      form = f;
    }

    public void DrawMapWin()
    {
      form.Writer.AddFullLine("*", "*", "-", form.ConsoleWidth - MainForm.PARTY_WIDTH, 0, 1);
      for (int i = 2; i < form.ConsoleHeight - MainForm.JOURNAL_HEIGHT - 1; i++)
        form.Writer.AddFullLine("|", "|", " ", form.ConsoleWidth - MainForm.PARTY_WIDTH, 0, i);
      form.Writer.AddFullLine("*", "*", "-", form.ConsoleWidth - MainForm.PARTY_WIDTH, 0, form.ConsoleHeight - MainForm.JOURNAL_HEIGHT - 1);
    }
  }
}
