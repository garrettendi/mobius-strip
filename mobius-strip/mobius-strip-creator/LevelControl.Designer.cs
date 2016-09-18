namespace mobius_strip_creator
{
  partial class LevelControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelId = new System.Windows.Forms.Label();
      this.labelCrowd = new System.Windows.Forms.Label();
      this.textBoxId = new System.Windows.Forms.TextBox();
      this.textBoxCrowd = new System.Windows.Forms.TextBox();
      this.textBoxArea = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelId
      // 
      this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelId.AutoSize = true;
      this.labelId.Location = new System.Drawing.Point(774, 6);
      this.labelId.Name = "labelId";
      this.labelId.Size = new System.Drawing.Size(21, 13);
      this.labelId.TabIndex = 0;
      this.labelId.Text = "ID:";
      // 
      // labelCrowd
      // 
      this.labelCrowd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelCrowd.AutoSize = true;
      this.labelCrowd.Location = new System.Drawing.Point(774, 32);
      this.labelCrowd.Name = "labelCrowd";
      this.labelCrowd.Size = new System.Drawing.Size(40, 13);
      this.labelCrowd.TabIndex = 1;
      this.labelCrowd.Text = "Crowd:";
      // 
      // textBoxId
      // 
      this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxId.Location = new System.Drawing.Point(820, 3);
      this.textBoxId.Name = "textBoxId";
      this.textBoxId.Size = new System.Drawing.Size(100, 20);
      this.textBoxId.TabIndex = 2;
      // 
      // textBoxCrowd
      // 
      this.textBoxCrowd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxCrowd.Location = new System.Drawing.Point(820, 29);
      this.textBoxCrowd.Name = "textBoxCrowd";
      this.textBoxCrowd.Size = new System.Drawing.Size(100, 20);
      this.textBoxCrowd.TabIndex = 3;
      // 
      // textBoxArea
      // 
      this.textBoxArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxArea.Location = new System.Drawing.Point(0, 0);
      this.textBoxArea.Multiline = true;
      this.textBoxArea.Name = "textBoxArea";
      this.textBoxArea.Size = new System.Drawing.Size(768, 422);
      this.textBoxArea.TabIndex = 4;
      // 
      // LevelControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxArea);
      this.Controls.Add(this.textBoxCrowd);
      this.Controls.Add(this.textBoxId);
      this.Controls.Add(this.labelCrowd);
      this.Controls.Add(this.labelId);
      this.Name = "LevelControl";
      this.Size = new System.Drawing.Size(923, 422);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelId;
    private System.Windows.Forms.Label labelCrowd;
    private System.Windows.Forms.TextBox textBoxId;
    private System.Windows.Forms.TextBox textBoxCrowd;
    private System.Windows.Forms.TextBox textBoxArea;
  }
}
