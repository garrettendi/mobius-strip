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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageLevel = new System.Windows.Forms.TabPage();
      this.listBoxLevel = new System.Windows.Forms.ListBox();
      this.buttonSave = new System.Windows.Forms.Button();
      this.textBoxLevel = new System.Windows.Forms.TextBox();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.buttonHelp = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPageLevel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPageLevel);
      this.tabControl1.Location = new System.Drawing.Point(117, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(851, 446);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPageLevel
      // 
      this.tabPageLevel.Controls.Add(this.textBoxLevel);
      this.tabPageLevel.Location = new System.Drawing.Point(4, 22);
      this.tabPageLevel.Name = "tabPageLevel";
      this.tabPageLevel.Size = new System.Drawing.Size(843, 420);
      this.tabPageLevel.TabIndex = 0;
      this.tabPageLevel.Text = "Level";
      this.tabPageLevel.UseVisualStyleBackColor = true;
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
      this.buttonSave.Location = new System.Drawing.Point(856, 452);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(98, 23);
      this.buttonSave.TabIndex = 2;
      this.buttonSave.Text = "Save Game";
      this.buttonSave.UseVisualStyleBackColor = true;
      // 
      // textBoxLevel
      // 
      this.textBoxLevel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxLevel.Font = new System.Drawing.Font("Lucida Console", 10F);
      this.textBoxLevel.Location = new System.Drawing.Point(0, 0);
      this.textBoxLevel.Multiline = true;
      this.textBoxLevel.Name = "textBoxLevel";
      this.textBoxLevel.Size = new System.Drawing.Size(843, 420);
      this.textBoxLevel.TabIndex = 0;
      // 
      // buttonOpen
      // 
      this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonOpen.Location = new System.Drawing.Point(127, 451);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(101, 23);
      this.buttonOpen.TabIndex = 3;
      this.buttonOpen.Text = "Open Game";
      this.buttonOpen.UseVisualStyleBackColor = true;
      // 
      // buttonHelp
      // 
      this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonHelp.Location = new System.Drawing.Point(234, 451);
      this.buttonHelp.Name = "buttonHelp";
      this.buttonHelp.Size = new System.Drawing.Size(88, 23);
      this.buttonHelp.TabIndex = 4;
      this.buttonHelp.Text = "Help";
      this.buttonHelp.UseVisualStyleBackColor = true;
      // 
      // CreatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(966, 487);
      this.Controls.Add(this.buttonHelp);
      this.Controls.Add(this.buttonOpen);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.listBoxLevel);
      this.Controls.Add(this.tabControl1);
      this.Name = "CreatorForm";
      this.Text = "Mobius Strip Creator";
      this.tabControl1.ResumeLayout(false);
      this.tabPageLevel.ResumeLayout(false);
      this.tabPageLevel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageLevel;
    private System.Windows.Forms.ListBox listBoxLevel;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.TextBox textBoxLevel;
    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.Button buttonHelp;
  }
}

