using CursesSharp;
using System;
using System.Text;

namespace Mobius
{
  class MainClass
  {  
    public const int PARTY_WIDTH = 14;
    public const int JOURNAL_HEIGHT = 7;
    
    public static void Main (string[] args)
    {
      Curses.InitScr();
      try
      {
        MainClass m = new MainClass();
        
        for (int i = 0; i < 5; i++)
          m.Main2(args);
      }
      finally
      {
        Curses.EndWin();
      }
    }
    
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
    
    public static void CheckAddString(int x, int y, string str)
    {
      if (x >= 0 && x < Curses.Cols && y >= 0 && y < Curses.Lines)
        Stdscr.Add(y, x, str);
    }
    
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
    
    public static void RefreshScreen()
    {
      Stdscr.Move(Curses.Lines - 1, Curses.Cols - 1);
      Stdscr.Refresh();
    }

    private static void DrawStatsBar()
    {
      FullLine(" STATS (1) ::  STR:100  MAG:100  HIT:100  ", "", ' ', 0, 0, 0);
    }

    private static void DrawMapWin()
    {
      FullLine("*-Map", "*", '-', 1, 0, PARTY_WIDTH + 1);
      
      for (int i = 2; i < Curses.Lines - JOURNAL_HEIGHT - 1; i++)
        FullLine("|", "|", ' ', i, 0, PARTY_WIDTH + 1);
      
      FullLine("*", "*", '-', Curses.Lines - JOURNAL_HEIGHT - 1, 0, PARTY_WIDTH + 1);
    }
    
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

    private static void DrawJournalWin()
    {
      FullLine("*-Journal", "*", '-', Curses.Lines - JOURNAL_HEIGHT, 0, 0);
      for (int i = Curses.Lines - JOURNAL_HEIGHT + 1; i <= Curses.Lines - 1; i++)
        FullLine("|", "|", ' ', i, 0, 0);     
      FullLine("*", "*", '-', Curses.Lines - 1, 0, 0);
    }
  }
}