using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mobius;
using System.Windows.Forms;

namespace Mobius.Test
{
  [TestFixture]
  public class TestMainForm
  {
    [Test, Explicit]
    public void TestAdHoc()
    {
      MainForm form = new MainForm();
      Application.Run(new MainForm());
    }
  }
}
