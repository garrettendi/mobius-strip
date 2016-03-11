using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobius
{
  internal partial class MainForm : Form
  {
    internal MainForm()
    {
      InitializeComponent();

      this.Resize += Form1_Resize;

      this.Load += Form1_Load;

      writer = new ScreenWriter(this);
      journal = new JournalWriter(this);
      map = new MapWriter(this);
      party = new PartyWriter(this);
      stat = new StatWriter(this);
    }

    void Form1_Load(object sender, EventArgs e)
    {
      this.OnResize();
      Writer.EmptyScreen();
      this.RedrawScreen();
    }

    private ScreenWriter writer;
    internal ScreenWriter Writer
    {
      get
      {
        return writer;
      }
    }

    private PartyWriter party;
    internal PartyWriter Party
    {
      get
      {
        return party;
      }
    }

    private StatWriter stat;
    internal StatWriter Stat
    {
      get
      {
        return stat;
      }
    }

    private MapWriter map;
    internal MapWriter Map
    {
      get
      {
        return map;
      }
    }

    private JournalWriter journal;
    internal JournalWriter Journal
    {
      get
      {
        return journal;
      }
    }    
  
    private int width = 0;
    internal int ConsoleWidth
    {
      get
      {
        return width;
      }
    }

    private int height = 0;
    internal int ConsoleHeight
    {
      get
      { 
        return height; 
      }
    }

    internal string ScreenText
    {
      get
      {
        return this.textBox1.Text;
      }
    }

    internal void SetDisplay(StringBuilder display)
    {
      this.textBox1.Text = display.ToString();
    }

    internal void OnResize()
    {
      Graphics g = this.CreateGraphics();
      float fw = g.MeasureString("H", textBox1.Font).Width - 4.5f;
      g.Dispose();

      float result = this.Width / fw;
      this.width = (int)Math.Floor(result);

      result = this.Height / (textBox1.Font.Height);
      this.height = (int)Math.Floor(result);

      this.RedrawScreen();
    }

    void Form1_Resize(object sender, EventArgs e)
    {
      OnResize();
    }

    /// <summary>
    /// Width of party window. Constant.
    /// </summary>
    internal const int PARTY_WIDTH = 14;

    /// <summary>
    /// Height of journal window. Constant.
    /// </summary>
    internal const int JOURNAL_HEIGHT = 7;

    /// <summary>
    /// Used to enter execution.
    /// </summary>
    /// <param name='args'>
    /// Arguments. Follow through from Main execution.
    /// </param>
    internal void RedrawScreen()
    {
      Writer.EmptyScreen();

      Stat.DrawStatsBar();

      Map.DrawMapWin();

      Party.DrawPartyWin();

      Journal.DrawJournalWin();

      this.textBox1.Select(0, 0);
    }
  }
}
