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
    }

    void Form1_Load(object sender, EventArgs e)
    {
      this.OnResize();
      this.EmptyScreen();
      this.RedrawScreen();
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

    public void SetDisplay(StringBuilder display)
    {
      //for (int i = 1; i < this.ConsoleHeight; i++)
      //{
      //  display.Insert(i * (ConsoleHeight - 1), "\r\n");
      //}
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
      this.EmptyScreen();

      DrawStatsBar();

      DrawMapWin();

      DrawPartyWin();

      DrawJournalWin();

      //RefreshScreen();

      this.textBox1.Select(0, 0);
    }

    private void DrawMapWin()
    {
      AddFullLine("*", "*", "-", this.ConsoleWidth - PARTY_WIDTH, 0, 1);
      for (int i = 2; i < this.ConsoleHeight - JOURNAL_HEIGHT - 1; i++)
        AddFullLine("|", "|", " ", this.ConsoleWidth - PARTY_WIDTH, 0, i);
      AddFullLine("*", "*", "-", this.ConsoleWidth - PARTY_WIDTH, 0, this.ConsoleHeight - JOURNAL_HEIGHT - 1);
    }

    public void EmptyScreen()
    {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < this.ConsoleWidth; i++)
      {
        builder.Append("£");
      }
      for(int i = 1; i < this.ConsoleHeight; i++)
      {
        builder.Append("\r\n");
        for (int j = 0; j < this.ConsoleWidth; j++)
        {
          builder.Append("£");
        }
      }
      this.SetDisplay(builder);
    }

    /// <summary>
    /// Taken from the FireworkDemo of CursesSharp - GNU LESSER GENERAL PUBLIC LICENSE 
    /// http://curses-sharp.sourceforge.net/ - Original Author: R. Konklewski. 
    /// Used to check and add strings anywhere in the terminal.
    /// </summary>
    /// <param name='x'>
    /// Column to insert string at.
    /// </param>
    /// <param name='y'>
    /// Line to add string at.
    /// </param>
    /// <param name='str'>
    /// String to add.
    /// </param>
    public void CheckAddString(int col, int line, string str)
    {
      if (col >= 0 && col < this.ConsoleWidth && line >= 0 && line < this.ConsoleHeight)
      {
        string raw = this.textBox1.Text;

        int index = line * (this.ConsoleWidth + 2) + col;

        StringBuilder builder = new StringBuilder(raw);
        IEnumerable<char> chars = str.ToCharArray().AsEnumerable();
        int counter = 0;
        foreach (char c in chars)
        {
          if (index != 0 && ((line > 0 && index % this.ConsoleWidth + 2 == 0) || (line == 0 && index % ConsoleWidth == 0)))
            break;
          builder[index++] = c;
        }
        
        this.SetDisplay(builder);
      }
    }

    /// <summary>
    /// Draws the stats bar.
    /// </summary>
    private void DrawStatsBar()
    {
      AddFullLine(" STATS (1) ::  STR:100  MAG:100  HIT:100  ", "", " ", ConsoleWidth, 0, 0);
      //AddFullLine("123456789012345678901234567890123456789012", "", " ", 42, 0, 0);
    }

    private void AddFullLine(string pre, string post, string filler, int width, int col, int line)
    {
      StringBuilder builder = new StringBuilder(pre);
      while (builder.Length <= width - post.Length - 1)
      {
        builder.Append(filler);
      }
      builder.Append(post);

      CheckAddString(col, line, builder.ToString());
    }
       
    /// <summary>
    /// Draws the party window.
    /// </summary>
    private void DrawPartyWin()
    {
      AddFullLine("*-Party", "*", "-", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 1);
      AddFullLine("|", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 2);
      AddFullLine("| (1)", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 3);
      AddFullLine("| STR: 100", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 4);
      AddFullLine("|", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 5);
      AddFullLine("| (2)", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 6);
      AddFullLine("| STR: 100", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, 7);
      for (int i = 8; i < this.ConsoleHeight - JOURNAL_HEIGHT - 1; i++)
        AddFullLine("|", "|", " ", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, i);
      AddFullLine("*", "*", "-", PARTY_WIDTH, this.ConsoleWidth - PARTY_WIDTH, this.ConsoleHeight - JOURNAL_HEIGHT - 1);
    }

    /// <summary>
    /// Draws the journal window.
    /// </summary>
    private void DrawJournalWin()
    {
      AddFullLine("*-Journal", "*", "-", this.ConsoleWidth, 0, this.ConsoleHeight - JOURNAL_HEIGHT);
      for (int i = this.ConsoleHeight - JOURNAL_HEIGHT + 1; i < this.ConsoleHeight - 1; i++)
        AddFullLine("|", "|", " ", this.ConsoleWidth, 0, i);
      AddFullLine("*", "*", "-", this.ConsoleWidth, 0, this.ConsoleHeight - 1);
    }

  }
}
