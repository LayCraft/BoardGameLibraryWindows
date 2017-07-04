using System;
using System.Windows.Forms;
using BoardGameLibrary.Data;


namespace BoardGameLibrary
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
        GameRepository BoardGameLibrary = new GameRepository();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new GameManagerDialog(BoardGameLibrary));
    }

  }
}
