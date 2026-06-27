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
public class Sudoku : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	private int[] v1;

	private int[] v2;

	private int[] v3;

	private int[] v4;

	private int[] v5;

	private int[] v6;

	private int[] v7;

	private int[] v8;

	private int[] v9;

	private int c;

	private TextBox[] text1;

	private TextBox[] text2;

	private TextBox[] text3;

	private TextBox[] text4;

	private TextBox[] text5;

	private TextBox[] text6;

	private TextBox[] text7;

	private TextBox[] text8;

	private TextBox[] text9;

	private int[] f1;

	private int[] f2;

	private int[] f3;

	private int[] f4;

	private int[] f5;

	private int[] f6;

	private int[] f7;

	private int[] f8;

	private int[] f9;

	private int[] b1;

	private int[] b2;

	private int[] b3;

	private int[] b4;

	private int[] b5;

	private int[] b6;

	private int[] b7;

	private int[] b8;

	private int[] b9;

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

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox2_Click;
			PictureBox pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox2 = value;
			pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public Sudoku()
	{
		base.Load += Sudoku_Load;
		v1 = new int[9];
		v2 = new int[9];
		v3 = new int[9];
		v4 = new int[9];
		v5 = new int[9];
		v6 = new int[9];
		v7 = new int[9];
		v8 = new int[9];
		v9 = new int[9];
		text1 = new TextBox[9];
		text2 = new TextBox[9];
		text3 = new TextBox[9];
		text4 = new TextBox[9];
		text5 = new TextBox[9];
		text6 = new TextBox[9];
		text7 = new TextBox[9];
		text8 = new TextBox[9];
		text9 = new TextBox[9];
		f1 = new int[9];
		f2 = new int[9];
		f3 = new int[9];
		f4 = new int[9];
		f5 = new int[9];
		f6 = new int[9];
		f7 = new int[9];
		f8 = new int[9];
		f9 = new int[9];
		b1 = new int[9];
		b2 = new int[9];
		b3 = new int[9];
		b4 = new int[9];
		b5 = new int[9];
		b6 = new int[9];
		b7 = new int[9];
		b8 = new int[9];
		b9 = new int[9];
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.Sudoku));
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		base.SuspendLayout();
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.inicio;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Location = new System.Drawing.Point(286, 207);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(112, 57);
		this.Button1.TabIndex = 1;
		this.Button1.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.Transparent;
		this.Button2.BackgroundImage = Skillful.My.Resources.Resources.MicrosoftTeams_image__6_;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Location = new System.Drawing.Point(145, 320);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(40, 40);
		this.Button2.TabIndex = 2;
		this.Button2.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.Transparent;
		this.Button3.BackgroundImage = Skillful.My.Resources.Resources.checkmark;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.FlatAppearance.BorderSize = 0;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Location = new System.Drawing.Point(191, 320);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(40, 40);
		this.Button3.TabIndex = 3;
		this.Button3.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.Transparent;
		this.Button4.BackgroundImage = Skillful.My.Resources.Resources.cerrar;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.FlatAppearance.BorderSize = 0;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.Location = new System.Drawing.Point(643, 6);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(28, 28);
		this.Button4.TabIndex = 4;
		this.Button4.UseVisualStyleBackColor = false;
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Image = Skillful.My.Resources.Resources.SU1;
		this.PictureBox1.Location = new System.Drawing.Point(191, 123);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(300, 78);
		this.PictureBox1.TabIndex = 5;
		this.PictureBox1.TabStop = false;
		this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox2.Image = Skillful.My.Resources.Resources.Proyecto_nuevo__1_;
		this.PictureBox2.Location = new System.Drawing.Point(425, 82);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(66, 217);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 6;
		this.PictureBox2.TabStop = false;
		this.PictureBox2.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.BLN;
		base.ClientSize = new System.Drawing.Size(675, 410);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Sudoku";
		this.Text = "Sudoku";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		base.ResumeLayout(false);
	}

	private void Sudoku_Load(object sender, EventArgs e)
	{
		MyProject.Computer.Audio.Stop();
		MyProject.Computer.Audio.Play(Resources.zad____Ghosts, AudioPlayMode.BackgroundLoop);
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		c = 1;
		Point point = new Point(100, 100);
		PictureBox1.Visible = false;
		PictureBox2.Visible = true;
		Button1.Visible = false;
		Button2.Visible = true;
		Button3.Visible = true;
		point.X = 185;
		point.Y = 100;
		int num = 0;
		checked
		{
			do
			{
				text1[num] = new TextBox();
				text1[num].TextAlign = HorizontalAlignment.Center;
				text1[num].Size = new Size(25, 26);
				text1[num].MaxLength = 1;
				text1[num].Location = new Point(point.X, point.Y);
				if (unchecked(num == 2 || num == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text1[num]);
				num++;
			}
			while (num <= 8);
			text1[3].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text1[3].Enabled = false;
			text1[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text1[6].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num2 = 0;
			do
			{
				text2[num2] = new TextBox();
				text2[num2].TextAlign = HorizontalAlignment.Center;
				text2[num2].Size = new Size(25, 26);
				text2[num2].MaxLength = 1;
				text2[num2].Location = new Point(point.X, point.Y);
				if (unchecked(num2 == 2 || num2 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text2[num2]);
				num2++;
			}
			while (num2 <= 8);
			text2[4].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text2[4].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num3 = 0;
			do
			{
				text3[num3] = new TextBox();
				text3[num3].TextAlign = HorizontalAlignment.Center;
				text3[num3].Size = new Size(25, 26);
				text3[num3].MaxLength = 1;
				text3[num3].Location = new Point(point.X, point.Y);
				if (unchecked(num3 == 2 || num3 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text3[num3]);
				num3++;
			}
			while (num3 <= 8);
			text3[1].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text3[1].Enabled = false;
			text3[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text3[6].Enabled = false;
			point.X += 30;
			point.Y = 100;
			int num4 = 0;
			do
			{
				text4[num4] = new TextBox();
				text4[num4].TextAlign = HorizontalAlignment.Center;
				text4[num4].Size = new Size(25, 26);
				text4[num4].MaxLength = 1;
				text4[num4].Location = new Point(point.X, point.Y);
				if (unchecked(num4 == 2 || num4 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text4[num4]);
				num4++;
			}
			while (num4 <= 8);
			text4[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text4[2].Enabled = false;
			text4[3].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text4[3].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num5 = 0;
			do
			{
				text5[num5] = new TextBox();
				text5[num5].TextAlign = HorizontalAlignment.Center;
				text5[num5].Size = new Size(25, 26);
				text5[num5].MaxLength = 1;
				text5[num5].Location = new Point(point.X, point.Y);
				if (unchecked(num5 == 2 || num5 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text5[num5]);
				num5++;
			}
			while (num5 <= 8);
			text5[1].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text5[1].Enabled = false;
			text5[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text5[5].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num6 = 0;
			do
			{
				text6[num6] = new TextBox();
				text6[num6].TextAlign = HorizontalAlignment.Center;
				text6[num6].Size = new Size(25, 26);
				text6[num6].MaxLength = 1;
				text6[num6].Location = new Point(point.X, point.Y);
				if (unchecked(num6 == 2 || num6 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text6[num6]);
				num6++;
			}
			while (num6 <= 8);
			text6[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text6[5].Enabled = false;
			text6[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text6[6].Enabled = false;
			point.X += 30;
			point.Y = 100;
			int num7 = 0;
			do
			{
				text7[num7] = new TextBox();
				text7[num7].TextAlign = HorizontalAlignment.Center;
				text7[num7].Size = new Size(25, 26);
				text7[num7].MaxLength = 1;
				text7[num7].Location = new Point(point.X, point.Y);
				if (unchecked(num7 == 2 || num7 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text7[num7]);
				num7++;
			}
			while (num7 <= 8);
			text7[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text7[2].Enabled = false;
			text7[7].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text7[7].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num8 = 0;
			do
			{
				text8[num8] = new TextBox();
				text8[num8].TextAlign = HorizontalAlignment.Center;
				text8[num8].Size = new Size(25, 26);
				text8[num8].MaxLength = 1;
				text8[num8].Location = new Point(point.X, point.Y);
				if (unchecked(num8 == 2 || num8 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text8[num8]);
				num8++;
			}
			while (num8 <= 8);
			text8[4].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text8[4].Enabled = false;
			point.X += 25;
			point.Y = 100;
			int num9 = 0;
			do
			{
				text9[num9] = new TextBox();
				text9[num9].TextAlign = HorizontalAlignment.Center;
				text9[num9].Size = new Size(25, 26);
				text9[num9].MaxLength = 1;
				text9[num9].Location = new Point(point.X, point.Y);
				if (unchecked(num9 == 2 || num9 == 5))
				{
					point.Y += 25;
				}
				else
				{
					point.Y += 20;
				}
				base.Controls.Add(text9[num9]);
				num9++;
			}
			while (num9 <= 8);
			text9[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text9[2].Enabled = false;
			text9[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text9[5].Enabled = false;
			point.X += 25;
			point.Y = 100;
			VBMath.Randomize();
			while ((Operators.CompareString(text1[3].Text, text1[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[3].Text, text2[4].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[3].Text, text4[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text1[3]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text1[3].Text) == 10.0)
				{
					text1[3].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text1[6].Text, text3[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text1[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text1[6]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text1[6].Text) == 10.0)
				{
					text1[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text2[4].Text, text1[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text2[4].Text, text8[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text2[4]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text2[4].Text) == 10.0)
				{
					text2[4].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text3[1].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text3[1].Text, text3[6].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text3[1]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text3[1].Text) == 10.0)
				{
					text3[1].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text3[6].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text3[6].Text, text3[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text3[6].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text3[6]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text3[6].Text) == 10.0)
				{
					text3[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text4[2].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text4[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text7[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text9[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text4[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text4[2].Text) == 10.0)
				{
					text4[2].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text4[3].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text4[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text1[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text4[3]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text4[3].Text) == 10.0)
				{
					text4[3].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text5[1].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[1].Text, text3[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[1].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text5[1]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text5[1].Text) == 10.0)
				{
					text5[1].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text5[5].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text4[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text5[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text5[5].Text) == 10.0)
				{
					text5[5].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text6[5].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text4[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text5[5].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text6[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text6[5].Text) == 10.0)
				{
					text6[5].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text6[6].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[6].Text, text3[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[6].Text, text1[6].Text, TextCompare: false) == 0))
			{
				if (Conversions.ToDouble(text6[6].Text) == 10.0)
				{
					text6[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text7[2].Text, text7[7].Text, TextCompare: false) == 0) | (Operators.CompareString(text7[2].Text, text9[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text7[2].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text7[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text7[2].Text) == 10.0)
				{
					text7[2].Text = Conversions.ToString(1);
				}
			}
			while (Operators.CompareString(text7[7].Text, text7[2].Text, TextCompare: false) == 0)
			{
				TextBox textBox;
				(textBox = text7[7]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text7[7].Text) == 10.0)
				{
					text7[7].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text8[4].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text8[4].Text, text2[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text8[4]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text8[4].Text) == 10.0)
				{
					text8[4].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text9[2].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text7[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text9[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text9[2].Text) == 10.0)
				{
					text9[2].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text9[5].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[5].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[5].Text, text9[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text8[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text9[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text9[5].Text) == 10.0)
				{
					text9[5].Text = Conversions.ToString(1);
				}
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		limpiar limpiar2 = new limpiar();
		MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("¿Estas seguro de borrar todos los datos?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (msgBoxResult == MsgBoxResult.Yes)
		{
			limpiar2.LimpiarCampos(this);
		}
		checked
		{
			text1[3].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text1[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text2[4].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text3[1].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text3[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text4[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text4[3].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text5[1].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text5[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text6[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text6[6].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text7[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text7[7].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text8[4].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text9[2].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			text9[5].Text = Conversions.ToString((int)Math.Round(8f * VBMath.Rnd() + 1f));
			while ((Operators.CompareString(text1[3].Text, text1[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[3].Text, text2[4].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[3].Text, text4[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text1[3]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text1[3].Text) == 10.0)
				{
					text1[3].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text1[6].Text, text3[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text1[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text1[6]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text1[6].Text) == 10.0)
				{
					text1[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text2[4].Text, text1[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text2[4].Text, text8[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text2[4]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text2[4].Text) == 10.0)
				{
					text2[4].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text3[1].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text3[1].Text, text3[6].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text3[1]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text3[1].Text) == 10.0)
				{
					text3[1].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text3[6].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text3[6].Text, text3[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text1[6].Text, text3[6].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text3[6]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text3[6].Text) == 10.0)
				{
					text3[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text4[2].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text4[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text7[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[2].Text, text9[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text4[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text4[2].Text) == 10.0)
				{
					text4[2].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text4[3].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text4[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text4[3].Text, text1[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text4[3]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text4[3].Text) == 10.0)
				{
					text4[3].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text5[1].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[1].Text, text3[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[1].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text5[1]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text5[1].Text) == 10.0)
				{
					text5[1].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text5[5].Text, text5[1].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text5[5].Text, text4[3].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text5[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text5[5].Text) == 10.0)
				{
					text5[5].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text6[5].Text, text6[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text4[3].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[5].Text, text5[5].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text6[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text6[5].Text) == 10.0)
				{
					text6[5].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text6[6].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[6].Text, text3[6].Text, TextCompare: false) == 0) | (Operators.CompareString(text6[6].Text, text1[6].Text, TextCompare: false) == 0))
			{
				if (Conversions.ToDouble(text6[6].Text) == 10.0)
				{
					text6[6].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text7[2].Text, text7[7].Text, TextCompare: false) == 0) | (Operators.CompareString(text7[2].Text, text9[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text7[2].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text7[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text7[2].Text) == 10.0)
				{
					text7[2].Text = Conversions.ToString(1);
				}
			}
			while (Operators.CompareString(text7[7].Text, text7[2].Text, TextCompare: false) == 0)
			{
				TextBox textBox;
				(textBox = text7[7]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text7[7].Text) == 10.0)
				{
					text7[7].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text8[4].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text8[4].Text, text2[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text8[4]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text8[4].Text) == 10.0)
				{
					text8[4].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text9[2].Text, text9[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text7[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text4[2].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text9[2]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text9[2].Text) == 10.0)
				{
					text9[2].Text = Conversions.ToString(1);
				}
			}
			while ((Operators.CompareString(text9[5].Text, text6[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[5].Text, text5[5].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[5].Text, text9[2].Text, TextCompare: false) == 0) | (Operators.CompareString(text9[2].Text, text8[4].Text, TextCompare: false) == 0))
			{
				TextBox textBox;
				(textBox = text9[5]).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
				if (Conversions.ToDouble(text9[5].Text) == 10.0)
				{
					text9[5].Text = Conversions.ToString(1);
				}
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		int num = 0;
		checked
		{
			do
			{
				v1[num] = (int)Math.Round(Conversion.Val(text1[num].Text));
				v2[num] = (int)Math.Round(Conversion.Val(text2[num].Text));
				v3[num] = (int)Math.Round(Conversion.Val(text3[num].Text));
				v4[num] = (int)Math.Round(Conversion.Val(text4[num].Text));
				v5[num] = (int)Math.Round(Conversion.Val(text5[num].Text));
				v6[num] = (int)Math.Round(Conversion.Val(text6[num].Text));
				v7[num] = (int)Math.Round(Conversion.Val(text7[num].Text));
				v8[num] = (int)Math.Round(Conversion.Val(text8[num].Text));
				v9[num] = (int)Math.Round(Conversion.Val(text9[num].Text));
				num++;
			}
			while (num <= 8);
			int num2 = 0;
			do
			{
				if (num2 == 0)
				{
					f1[num2] = v1[0];
					f2[num2] = v1[1];
					f3[num2] = v1[2];
					f4[num2] = v1[3];
					f5[num2] = v1[4];
					f6[num2] = v1[5];
					f7[num2] = v1[6];
					f8[num2] = v1[7];
					f9[num2] = v1[8];
					b1[num2] = v1[0];
					b2[num2] = v1[3];
					b3[num2] = v1[6];
					b4[num2] = v4[0];
					b5[num2] = v4[3];
					b6[num2] = v4[6];
					b7[num2] = v7[0];
					b8[num2] = v7[3];
					b9[num2] = v7[6];
				}
				if (num2 == 1)
				{
					f1[num2] = v2[0];
					f2[num2] = v2[1];
					f3[num2] = v2[2];
					f4[num2] = v2[3];
					f5[num2] = v2[4];
					f6[num2] = v2[5];
					f7[num2] = v2[6];
					f8[num2] = v2[7];
					f9[num2] = v2[8];
					b1[num2] = v1[1];
					b2[num2] = v1[4];
					b3[num2] = v1[7];
					b4[num2] = v4[1];
					b5[num2] = v4[4];
					b6[num2] = v4[7];
					b7[num2] = v7[1];
					b8[num2] = v7[4];
					b9[num2] = v7[7];
				}
				if (num2 == 2)
				{
					f1[num2] = v3[0];
					f2[num2] = v3[1];
					f3[num2] = v3[2];
					f4[num2] = v3[3];
					f5[num2] = v3[4];
					f6[num2] = v3[5];
					f7[num2] = v3[6];
					f8[num2] = v3[7];
					f9[num2] = v3[8];
					b1[num2] = v1[2];
					b2[num2] = v1[5];
					b3[num2] = v1[8];
					b4[num2] = v4[2];
					b5[num2] = v4[5];
					b6[num2] = v4[8];
					b7[num2] = v7[2];
					b8[num2] = v7[5];
					b9[num2] = v7[8];
				}
				if (num2 == 3)
				{
					f1[num2] = v4[0];
					f2[num2] = v4[1];
					f3[num2] = v4[2];
					f4[num2] = v4[3];
					f5[num2] = v4[4];
					f6[num2] = v4[5];
					f7[num2] = v4[6];
					f8[num2] = v4[7];
					f9[num2] = v4[8];
					b1[num2] = v2[0];
					b2[num2] = v2[3];
					b3[num2] = v2[6];
					b4[num2] = v5[0];
					b5[num2] = v5[3];
					b6[num2] = v5[6];
					b7[num2] = v8[0];
					b8[num2] = v8[3];
					b9[num2] = v8[6];
				}
				if (num2 == 4)
				{
					f1[num2] = v5[0];
					f2[num2] = v5[1];
					f3[num2] = v5[2];
					f4[num2] = v5[3];
					f5[num2] = v5[4];
					f6[num2] = v5[5];
					f7[num2] = v5[6];
					f8[num2] = v5[7];
					f9[num2] = v5[8];
					b1[num2] = v2[1];
					b2[num2] = v2[4];
					b3[num2] = v2[7];
					b4[num2] = v5[1];
					b5[num2] = v5[4];
					b6[num2] = v5[7];
					b7[num2] = v8[1];
					b8[num2] = v8[4];
					b9[num2] = v8[7];
				}
				if (num2 == 5)
				{
					f1[num2] = v6[0];
					f2[num2] = v6[1];
					f3[num2] = v6[2];
					f4[num2] = v6[3];
					f5[num2] = v6[4];
					f6[num2] = v6[5];
					f7[num2] = v6[6];
					f8[num2] = v6[7];
					f9[num2] = v6[8];
					b1[num2] = v2[2];
					b2[num2] = v2[5];
					b3[num2] = v2[8];
					b4[num2] = v5[2];
					b5[num2] = v5[5];
					b6[num2] = v5[8];
					b7[num2] = v8[2];
					b8[num2] = v8[5];
					b9[num2] = v8[8];
				}
				if (num2 == 6)
				{
					f1[num2] = v7[0];
					f2[num2] = v7[1];
					f3[num2] = v7[2];
					f4[num2] = v7[3];
					f5[num2] = v7[4];
					f6[num2] = v7[5];
					f7[num2] = v7[6];
					f8[num2] = v7[7];
					f9[num2] = v7[8];
					b1[num2] = v3[0];
					b2[num2] = v3[3];
					b3[num2] = v3[6];
					b4[num2] = v6[0];
					b5[num2] = v6[3];
					b6[num2] = v6[6];
					b7[num2] = v9[0];
					b8[num2] = v9[3];
					b9[num2] = v9[6];
				}
				if (num2 == 7)
				{
					f1[num2] = v8[0];
					f2[num2] = v8[1];
					f3[num2] = v8[2];
					f4[num2] = v8[3];
					f5[num2] = v8[4];
					f6[num2] = v8[5];
					f7[num2] = v8[6];
					f8[num2] = v8[7];
					f9[num2] = v8[8];
					b1[num2] = v3[1];
					b2[num2] = v3[4];
					b3[num2] = v3[7];
					b4[num2] = v6[1];
					b5[num2] = v6[4];
					b6[num2] = v6[7];
					b7[num2] = v9[1];
					b8[num2] = v9[4];
					b9[num2] = v9[7];
				}
				if (num2 == 8)
				{
					f1[num2] = v9[0];
					f2[num2] = v9[1];
					f3[num2] = v9[2];
					f4[num2] = v9[3];
					f5[num2] = v9[4];
					f6[num2] = v9[5];
					f7[num2] = v9[6];
					f8[num2] = v9[7];
					f9[num2] = v9[8];
					b1[num2] = v3[2];
					b2[num2] = v3[5];
					b3[num2] = v3[8];
					b4[num2] = v6[2];
					b5[num2] = v6[5];
					b6[num2] = v6[8];
					b7[num2] = v9[2];
					b8[num2] = v9[5];
					b9[num2] = v9[8];
				}
				num2++;
			}
			while (num2 <= 8);
			int num3 = 0;
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			do
			{
				num4 += v1[num3] + v2[num3] + v3[num3] + v4[num3] + v5[num3] + v6[num3] + v7[num3] + v8[num3] + v9[num3];
				num5 += f1[num3] + f2[num3] + f3[num3] + f4[num3] + f5[num3] + f6[num3] + f7[num3] + f8[num3] + f9[num3];
				num6 += b1[num3] + b2[num3] + b3[num3] + b4[num3] + b5[num3] + b6[num3] + b7[num3] + b8[num3] + b9[num3];
				num3++;
			}
			while (num3 <= 8);
			int num7 = default(int);
			if (num4 == 405)
			{
				num7++;
			}
			if (num5 == 405)
			{
				num7++;
			}
			if (num6 == 405)
			{
				num7++;
			}
			if (num7 == 3)
			{
				Interaction.MsgBox("¡FELICIDADES!, has completado correctamente el nivel", MsgBoxStyle.OkOnly, "Lo lograste");
			}
			else
			{
				Interaction.MsgBox("La resolución del sudoku no es correcta, vuelve a intentarlo", MsgBoxStyle.OkOnly, "Error");
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		limpiar limpiar2 = new limpiar();
		MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("¿Quieres salir del Sudoku?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (msgBoxResult == MsgBoxResult.Yes)
		{
			MyProject.Computer.Audio.Stop();
			MyProject.Computer.Audio.Play(Resources.Riddiman_Tranquillity, AudioPlayMode.BackgroundLoop);
			MyProject.Forms.Form1.Show();
			Close();
		}
	}
}
