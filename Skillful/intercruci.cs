using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Skillful.My;
using Skillful.My.Resources;

namespace Skillful;

[DesignerGenerated]
public class intercruci : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public intercruci()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.intercruci));
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Button2.BackColor = System.Drawing.Color.Black;
		this.Button2.BackgroundImage = Skillful.My.Resources.Resources.CERR1;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Location = new System.Drawing.Point(629, 12);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(34, 35);
		this.Button2.TabIndex = 3;
		this.Button2.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.Proyecto_nuevo__3_;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Location = new System.Drawing.Point(454, 297);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(180, 90);
		this.Button1.TabIndex = 4;
		this.Button1.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.BackgroundImage = Skillful.My.Resources.Resources.h;
		base.ClientSize = new System.Drawing.Size(675, 410);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Button2);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "intercruci";
		this.Text = "intercruci";
		base.ResumeLayout(false);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Form1.Show();
		Close();
		MyProject.Computer.Audio.Stop();
		MyProject.Computer.Audio.Play(Resources.Riddiman_Tranquillity, AudioPlayMode.BackgroundLoop);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.menucru.Show();
		Close();
	}

	private void jugar_Click(object sender, EventArgs e)
	{
	}
}
