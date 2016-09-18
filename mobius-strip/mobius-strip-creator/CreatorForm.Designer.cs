namespace mobius_strip_creator
{
  partial class CreatorForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBoxLevel = new System.Windows.Forms.ListBox();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.buttonHelp = new System.Windows.Forms.Button();
      this.buttonNew = new System.Windows.Forms.Button();
      this.panelButtons = new System.Windows.Forms.Panel();
      this.panelMain = new System.Windows.Forms.Panel();
      this.levelControl = new mobius_strip_creator.LevelControl();
      this.panelButtons.SuspendLayout();
      this.panelMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBoxLevel
      // 
      this.listBoxLevel.Dock = System.Windows.Forms.DockStyle.Left;
      this.listBoxLevel.FormattingEnabled = true;
      this.listBoxLevel.Location = new System.Drawing.Point(0, 0);
      this.listBoxLevel.Name = "listBoxLevel";
      this.listBoxLevel.Size = new System.Drawing.Size(120, 487);
      this.listBoxLevel.TabIndex = 1;
      // 
      // buttonSave
      // 
      this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSave.Location = new System.Drawing.Point(736, 12);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(98, 23);
      this.buttonSave.TabIndex = 2;
      this.buttonSave.Text = "Save Game";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // buttonOpen
      // 
      this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonOpen.Location = new System.Drawing.Point(113, 12);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(101, 23);
      this.buttonOpen.TabIndex = 3;
      this.buttonOpen.Text = "Open Game";
      this.buttonOpen.UseVisualStyleBackColor = true;
      this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
      // 
      // buttonHelp
      // 
      this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonHelp.Location = new System.Drawing.Point(220, 12);
      this.buttonHelp.Name = "buttonHelp";
      this.buttonHelp.Size = new System.Drawing.Size(88, 23);
      this.buttonHelp.TabIndex = 4;
      this.buttonHelp.Text = "Help";
      this.buttonHelp.UseVisualStyleBackColor = true;
      this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
      // 
      // buttonNew
      // 
      this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonNew.Location = new System.Drawing.Point(6, 12);
      this.buttonNew.Name = "buttonNew";
      this.buttonNew.Size = new System.Drawing.Size(101, 23);
      this.buttonNew.TabIndex = 5;
      this.buttonNew.Text = "New Game";
      this.buttonNew.UseVisualStyleBackColor = true;
      this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
      // 
      // panelButtons
      // 
      this.panelButtons.Controls.Add(this.buttonNew);
      this.panelButtons.Controls.Add(this.buttonSave);
      this.panelButtons.Controls.Add(this.buttonOpen);
      this.panelButtons.Controls.Add(this.buttonHelp);
      this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelButtons.Location = new System.Drawing.Point(120, 440);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(846, 47);
      this.panelButtons.TabIndex = 6;
      // 
      // panelMain
      // 
      this.panelMain.Controls.Add(this.levelControl);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(120, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(846, 440);
      this.panelMain.TabIndex = 7;
      // 
      // levelControl
      // 
      this.levelControl.Current = null;
      this.levelControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.levelControl.Location = new System.Drawing.Point(0, 0);
      this.levelControl.Name = "levelControl";
      this.levelControl.Size = new System.Drawing.Size(846, 440);
      this.levelControl.TabIndex = 0;
      // 
      // CreatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(966, 487);
      this.Controls.Add(this.panelMain);
      this.Controls.Add(this.panelButtons);
      this.Controls.Add(this.listBoxLevel);
      this.Name = "CreatorForm";
      this.Text = "Mobius Strip Creator";
      this.panelButtons.ResumeLayout(false);
      this.panelMain.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ListBox listBoxLevel;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.Button buttonHelp;
    private System.Windows.Forms.Button buttonNew;
    private System.Windows.Forms.Panel panelButtons;
    private System.Windows.Forms.Panel panelMain;
    private LevelControl levelControl;
  }
}

