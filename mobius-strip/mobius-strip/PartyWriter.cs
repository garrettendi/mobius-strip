using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  internal class PartyWriter
  {
    private MainForm form;

    internal PartyWriter(MainForm f)
    {
      form = f;
    }

    /// <summary>
    /// Draws the party window.
    /// </summary>
    internal void DrawPartyWin()
    {
      form.Writer.AddFullLine("*-Party", "*", "-", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 1);
      form.Writer.AddFullLine("|", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 2);
      form.Writer.AddFullLine("| (1)", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 3);
      form.Writer.AddFullLine("| STR: 100", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 4);
      form.Writer.AddFullLine("|", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 5);
      form.Writer.AddFullLine("| (2)", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 6);
      form.Writer.AddFullLine("| STR: 100", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, 7);
      for (int i = 8; i < form.ConsoleHeight - MainForm.JOURNAL_HEIGHT - 1; i++)
        form.Writer.AddFullLine("|", "|", " ", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, i);
      form.Writer.AddFullLine("*", "*", "-", MainForm.PARTY_WIDTH, form.ConsoleWidth - MainForm.PARTY_WIDTH, form.ConsoleHeight - MainForm.JOURNAL_HEIGHT - 1);
    }
  }
}
