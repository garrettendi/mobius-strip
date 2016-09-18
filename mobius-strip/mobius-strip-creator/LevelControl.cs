using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mobius;

namespace mobius_strip_creator
{
  public partial class LevelControl : UserControl
  {
    public LevelControl()
    {
      InitializeComponent();

      Current = new Level("NEW", 0);

      textBoxArea.DataBindings.Add("Text", Current, "AreaStr");
      textBoxCrowd.DataBindings.Add("Text", Current, "Crowd");
      textBoxId.DataBindings.Add("Text", Current, "Id");
    }

    public Level Current { get; set; }
  }
}
