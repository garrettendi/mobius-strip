using CursesSharp;
using System;
using System.Text;

namespace Mobius
{
  class MainClass
  {  
    /// <summary>
    /// Width of party window. Constant.
    /// </summary>
    public const int PARTY_WIDTH = 14;
    
    /// <summary>
    /// Height of journal window. Constant.
    /// </summary>
    public const int JOURNAL_HEIGHT = 7;
    
    /// <summary>
    /// The entry point of the program, where the program control starts and ends.
    /// </summary>
    /// <param name='args'>
    /// The command-line arguments. Do not specify any.
    /// </param>
    public static void Main (string[] args)
    {
      Curses.InitScr();
      try
      {
        MainClass m = new MainClass();
        
        m.Main2(args);
      }
      finally
      {
        Curses.EndWin();
      }
    }
    
    /// <summary>
    /// Used to enter execution.
    /// </summary>
    /// <param name='args'>
    /// Arguments. Follow through from Main execution.
    /// </param>
    public void Main2 (string[] args)
    {
      Stdscr.Blocking = false;
      Curses.Echo = false;
      
      Stdscr.Erase();
      
      DrawStatsBar();
      
      DrawMapWin();
      
      DrawPartyWin();
      
      DrawJournalWin();
      
      RefreshScreen();     
      
      while(true)
        continue;
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
    public static void CheckAddString(int x, int y, string str)
    {
      if (x >= 0 && x < Curses.Cols && y >= 0 && y < Curses.Lines)
        Stdscr.Add(y, x, str);
    }
    
    /// <summary>
    /// Creates a full line of text
    /// </summary>
    /// <param name='prePend'>
    /// Text to place at the beginning of the line
    /// </param>
    /// <param name='postPend'>
    /// Text to place at the end of the line.
    /// </param>
    /// <param name='filler'>
    /// Filler character to fill the rest of the line - this can be the empty space.
    /// </param>
    /// <param name='y'>
    /// The line to place this on
    /// </param>
    /// <param name='preXOffset'>
    /// Which column to place the start of the line at
    /// </param>
    /// <param name='postXOffset'>
    /// Columns away from the end of a full terminal line to end at.
    /// </param>
    public static void FullLine(string prePend, string postPend, char filler, int y, int preXOffset, int postXOffset)
    {
      if (y < 0 || y >= Curses.Lines)
        return;
      StringBuilder str = new StringBuilder();
      str.Append(prePend);
      
      int fillLength = Curses.Cols - prePend.Length - postPend.Length - preXOffset - postXOffset + 1;
      
      for (int i = 1; i < fillLength; i++)
        str.Append(filler);
      
      str.Append(postPend);
      
      // Remove last char for blinking cursor
      if (y == Curses.Lines - 1)
        str.Remove(str.Length - 1, 1);
      
      Stdscr.Add(y, preXOffset, str.ToString());
    }
    
    /// <summary>
    /// Refreshes the screen and moves cursor to bottom right of terminal.
    /// </summary>
    public static void RefreshScreen()
    {
      Stdscr.Move(Curses.Lines - 1, Curses.Cols - 1);
      Stdscr.Refresh();
    }
  
    /// <summary>
    /// Draws the stats bar.
    /// </summary>
    private static void DrawStatsBar()
    {
      FullLine(" STATS (1) ::  STR:100  MAG:100  HIT:100  ", "", ' ', 0, 0, 0);
    }
  
    /// <summary>
    /// Draws the map window.
    /// </summary>
    private static void DrawMapWin()
    {
      FullLine("*-Map", "*", '-', 1, 0, PARTY_WIDTH + 1);
      
      for (int i = 2; i < Curses.Lines - JOURNAL_HEIGHT - 1; i++)
        FullLine("|", "|", ' ', i, 0, PARTY_WIDTH + 1);
      
      FullLine("*", "*", '-', Curses.Lines - JOURNAL_HEIGHT - 1, 0, PARTY_WIDTH + 1);
    }
    
    /// <summary>
    /// Draws the party window.
    /// </summary>
    private static void DrawPartyWin()
    {
      FullLine("*-Party", "*", '-', 1, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("|", "|", ' ', 2, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("| (1)", "|", ' ', 3, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("| STR: 100", "|", ' ', 4, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("|", "|", ' ', 5, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("| (2)", "|", ' ', 6, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("| STR: 100", "|", ' ', 7, Curses.Cols - PARTY_WIDTH, 0);
      for (int i = 8; i < Curses.Lines - JOURNAL_HEIGHT - 1; i++)
        FullLine("|", "|", ' ', i, Curses.Cols - PARTY_WIDTH, 0);
      FullLine("*", "*", '-', Curses.Lines - JOURNAL_HEIGHT - 1, Curses.Cols - PARTY_WIDTH, 0);
    }
  
    /// <summary>
    /// Draws the journal window.
    /// </summary>
    private static void DrawJournalWin()
    {
      FullLine("*-Journal", "*", '-', Curses.Lines - JOURNAL_HEIGHT, 0, 0);
      for (int i = Curses.Lines - JOURNAL_HEIGHT + 1; i <= Curses.Lines - 1; i++)
        FullLine("|", "|", ' ', i, 0, 0);     
      FullLine("*", "*", '-', Curses.Lines - 1, 0, 0);
    }
  }
}