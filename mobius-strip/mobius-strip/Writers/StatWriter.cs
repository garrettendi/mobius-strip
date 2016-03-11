using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobius
{
  public class StatWriter
  {
    private MainForm form;

    internal StatWriter(MainForm f)
    {
      form = f;
    }

    /// <summary>
    /// Draws the stats bar.
    /// </summary>
    internal void DrawStatsBar()
    {
      form.Writer.AddFullLine(" STATS (1) ::  STR:100  MAG:100  HIT:100  ", "", " ", form.ConsoleWidth, 0, 0);
    }
  }
}
