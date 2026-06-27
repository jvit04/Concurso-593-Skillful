using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Skillful.My;
using Skillful.My.Resources;

namespace Skillful;

[DesignerGenerated]
public class menucru : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dificil")]
	private Button _dificil;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inter")]
	private Button _inter;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("facil")]
	private Button _facil;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comprobar")]
	private Button _comprobar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	internal virtual Button dificil
	{
		[CompilerGenerated]
		get
		{
			return _dificil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dificil_Click;
			Button button = _dificil;
			if (button != null)
			{
				button.Click -= value2;
			}
			_dificil = value;
			button = _dificil;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button inter
	{
		[CompilerGenerated]
		get
		{
			return _inter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = inter_Click;
			Button button = _inter;
			if (button != null)
			{
				button.Click -= value2;
			}
			_inter = value;
			button = _inter;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button facil
	{
		[CompilerGenerated]
		get
		{
			return _facil;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _facil;
			if (button != null)
			{
				button.Click -= value2;
			}
			_facil = value;
			button = _facil;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("volver")]
	internal virtual Button volver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button comprobar
	{
		[CompilerGenerated]
		get
		{
			return _comprobar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comprobar_Click;
			Button button = _comprobar;
			if (button != null)
			{
				button.Click -= value2;
			}
			_comprobar = value;
			button = _comprobar;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

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

	public menucru()
	{
		base.Load += Form1_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.menucru));
		this.dificil = new System.Windows.Forms.Button();
		this.inter = new System.Windows.Forms.Button();
		this.facil = new System.Windows.Forms.Button();
		this.volver = new System.Windows.Forms.Button();
		this.comprobar = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.dificil.BackColor = System.Drawing.Color.Transparent;
		this.dificil.BackgroundImage = Skillful.My.Resources.Resources.DIFI1;
		this.dificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.dificil.FlatAppearance.BorderSize = 0;
		this.dificil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.dificil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.dificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.dificil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.dificil.Location = new System.Drawing.Point(600, 230);
		this.dificil.Margin = new System.Windows.Forms.Padding(4);
		this.dificil.Name = "dificil";
		this.dificil.Size = new System.Drawing.Size(236, 116);
		this.dificil.TabIndex = 13;
		this.dificil.UseVisualStyleBackColor = false;
		this.inter.BackColor = System.Drawing.Color.Transparent;
		this.inter.BackgroundImage = Skillful.My.Resources.Resources.MEDIO_002;
		this.inter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.inter.FlatAppearance.BorderSize = 0;
		this.inter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.inter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.inter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.inter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.inter.Location = new System.Drawing.Point(351, 248);
		this.inter.Margin = new System.Windows.Forms.Padding(4);
		this.inter.Name = "inter";
		this.inter.Size = new System.Drawing.Size(217, 72);
		this.inter.TabIndex = 12;
		this.inter.UseVisualStyleBackColor = false;
		this.facil.BackColor = System.Drawing.Color.Transparent;
		this.facil.BackgroundImage = Skillful.My.Resources.Resources.facil;
		this.facil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.facil.FlatAppearance.BorderSize = 0;
		this.facil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.facil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.facil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.facil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.facil.Location = new System.Drawing.Point(73, 230);
		this.facil.Margin = new System.Windows.Forms.Padding(4);
		this.facil.Name = "facil";
		this.facil.Size = new System.Drawing.Size(236, 116);
		this.facil.TabIndex = 10;
		this.facil.UseVisualStyleBackColor = false;
		this.volver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.volver.Location = new System.Drawing.Point(1189, 578);
		this.volver.Margin = new System.Windows.Forms.Padding(4);
		this.volver.Name = "volver";
		this.volver.Size = new System.Drawing.Size(160, 62);
		this.volver.TabIndex = 14;
		this.volver.Text = "Volver";
		this.volver.UseVisualStyleBackColor = true;
		this.comprobar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comprobar.Location = new System.Drawing.Point(1357, 578);
		this.comprobar.Margin = new System.Windows.Forms.Padding(4);
		this.comprobar.Name = "comprobar";
		this.comprobar.Size = new System.Drawing.Size(213, 62);
		this.comprobar.TabIndex = 15;
		this.comprobar.Text = "Comprobar";
		this.comprobar.UseVisualStyleBackColor = true;
		this.Button2.BackColor = System.Drawing.Color.Black;
		this.Button2.BackgroundImage = Skillful.My.Resources.Resources.CERR1;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Location = new System.Drawing.Point(839, 38);
		this.Button2.Margin = new System.Windows.Forms.Padding(4);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(45, 43);
		this.Button2.TabIndex = 16;
		this.Button2.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.PRINCIPAL;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(900, 505);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.comprobar);
		base.Controls.Add(this.volver);
		base.Controls.Add(this.inter);
		base.Controls.Add(this.facil);
		base.Controls.Add(this.dificil);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Location = new System.Drawing.Point(1040, 580);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "menucru";
		this.Text = "menucru";
		base.ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Hide();
		MyProject.Forms.facillvl.Show();
	}

	private void cerrar_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void inter_Click(object sender, EventArgs e)
	{
		Hide();
		MyProject.Forms.mediolvl.Show();
	}

	private void dificil_Click(object sender, EventArgs e)
	{
		Hide();
		MyProject.Forms.dificillvl.Show();
	}

	private void comprobar_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		MyProject.Forms.intercruci.Show();
		Hide();
	}
}
