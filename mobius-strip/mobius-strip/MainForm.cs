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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      this.Resize += Form1_Resize;

      this.Load += Form1_Load;

      writer = new ScreenWriter(this);
      journal = new MsgWriter(this);
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
    public ScreenWriter Writer
    {
      get
      {
        return writer;
      }
    }

    private PartyWriter party;
    public PartyWriter Party
    {
      get
      {
        return party;
      }
    }

    private StatWriter stat;
    public StatWriter Stat
    {
      get
      {
        return stat;
      }
    }

    private MapWriter map;
    public MapWriter Map
    {
      get
      {
        return map;
      }
    }

    private MsgWriter journal;
    public MsgWriter Journal
    {
      get
      {
        return journal;
      }
    }    
  
    private int width = 0;
    public int ConsoleWidth
    {
      get
      {
        return width;
      }
    }

    private int height = 0;
    public int ConsoleHeight
    {
      get
      { 
        return height; 
      }
    }

    public string ScreenText
    {
      get
      {
        return this.textBox1.Text;
      }
    }

    public void SetDisplay(StringBuilder display)
    {
      this.textBox1.Text = display.ToString();
    }

    public void OnResize()
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
    public const int PARTY_WIDTH = 14;

    /// <summary>
    /// Height of journal window. Constant.
    /// </summary>
    public const int JOURNAL_HEIGHT = 7;

    /// <summary>
    /// Used to enter execution.
    /// </summary>
    /// <param name='args'>
    /// Arguments. Follow through from Main execution.
    /// </param>
    public void RedrawScreen()
    {
      Writer.EmptyScreen();

      Stat.DrawStatsBar();

      Map.DrawMapWin();

      Party.DrawPartyWin();

      Journal.DrawMessageWin();

      this.textBox1.Select(0, 0);
    }
  }
}
