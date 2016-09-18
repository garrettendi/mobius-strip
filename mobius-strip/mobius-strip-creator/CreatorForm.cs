using Mobius;
using Mobius.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobius_strip_creator
{
  public partial class CreatorForm : Form
  {
    public CreatorForm()
    {
      InitializeComponent();
    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      DialogResult res = dialog.ShowDialog();

      if (res == DialogResult.OK)
      {
        Deserialiser de = new Deserialiser();
        levelControl.Current = de.Deserialise("level", dialog.FileName) as Level;
      }
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
      MessageBox.Show(this, "TODO - Help will be displayed here.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      SaveFileDialog dialog = new SaveFileDialog();
      DialogResult res = dialog.ShowDialog();

      if (res == DialogResult.OK)
      {
        Serialiser se = new Serialiser();
        se.Serialise(levelControl.Current, dialog.FileName);
      }
    }

    private void buttonNew_Click(object sender, EventArgs e)
    {
      levelControl.Current = new Level("NEW", 0);
    }
  }
}
