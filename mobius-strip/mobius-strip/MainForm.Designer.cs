﻿namespace Mobius
{
  partial class MainForm
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.White;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(966, 487);
      this.textBox1.TabIndex = 0;
      this.textBox1.WordWrap = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(966, 487);
      this.Controls.Add(this.textBox1);
      this.Name = "MainForm";
      this.Text = "Mobius Strip";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;

  }
}

