using CursesSharp;
using System;

namespace Testbox
{
  class MainClass
  {  
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
      
      CheckAddString(3, 3, "Written by:  Dale Hards");
      
      RefreshScreen();
      Curses.NapMs(2000);
      
      CheckAddString(3, 3, "Coded by:    Dale Hards");
      
      RefreshScreen();
      Curses.NapMs(2000);
      
      CheckAddString(3, 3, "Produced by: Dale Hards");
      
      RefreshScreen();
      Curses.NapMs(2000);   
    }
    
    public int Cols { get { return Curses.Cols; } }
    public int Rows { get { return Curses.Lines; } }
    
    public void CheckAddString(int x, int y, string str)
    {
      if (x >= 0 && x < Cols && y >= 0 && y < Rows)
        Stdscr.Add(x, y, str);
    }
    
    public void RefreshScreen()
    {
      Stdscr.Move(Curses.Lines - 1, Curses.Cols - 1);
      Stdscr.Refresh();
    }
  }
}
