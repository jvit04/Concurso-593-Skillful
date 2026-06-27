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
public class Form1 : Form
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
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

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

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
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

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox3_Click;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public Form1()
	{
		base.Load += Form1_Load;
		InitializeComponent();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("¿Deseas salir del portal?", "Cerrar", MessageBoxButtons.YesNo);
		if (msgBoxResult == MsgBoxResult.Yes)
		{
			Close();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("Programa desarrollado por: Milton Castillo, Daniel López, Arthur Pérez, Kamila Rivera, José Viteri", MsgBoxStyle.OkOnly, "Autores");
		Interaction.MsgBox("2022", MsgBoxStyle.OkOnly, "Año de creación");
		Interaction.MsgBox("1.0", MsgBoxStyle.OkOnly, "Versión");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Sudoku.Show();
		Hide();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		MyProject.Computer.Audio.Stop();
		MyProject.Computer.Audio.Play(Resources.Electro_Light__Symbolism, AudioPlayMode.BackgroundLoop);
		MyProject.Forms.Trivia.Show();
		Hide();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		MyProject.Computer.Audio.Stop();
		MyProject.Computer.Audio.Play(Resources.Scott_Buckley_Signal_To_Noise, AudioPlayMode.BackgroundLoop);
		MyProject.Forms.intercruci.Show();
		Hide();
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("Riddiman - Tranquillity, Electro-Light - Symbolism, .zad - Ghosts, Scott Buckley - Signal To Noise", MsgBoxStyle.OkOnly, "Música");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		MyProject.Computer.Audio.Stop();
		MyProject.Computer.Audio.Play(Resources.Riddiman_Tranquillity, AudioPlayMode.BackgroundLoop);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.Form1));
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		base.SuspendLayout();
		this.Button4.BackColor = System.Drawing.Color.Transparent;
		this.Button4.BackgroundImage = Skillful.My.Resources.Resources.Proyecto_nuevo;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.FlatAppearance.BorderSize = 0;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.Location = new System.Drawing.Point(771, 33);
		this.Button4.Margin = new System.Windows.Forms.Padding(4);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(36, 36);
		this.Button4.TabIndex = 7;
		this.Button4.UseVisualStyleBackColor = false;
		this.Button5.BackColor = System.Drawing.Color.Transparent;
		this.Button5.BackgroundImage = Skillful.My.Resources.Resources.cerrar;
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.FlatAppearance.BorderSize = 0;
		this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.Location = new System.Drawing.Point(815, 33);
		this.Button5.Margin = new System.Windows.Forms.Padding(4);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(39, 36);
		this.Button5.TabIndex = 8;
		this.Button5.UseVisualStyleBackColor = false;
		this.Button3.BackgroundImage = Skillful.My.Resources.Resources.CRUCIGRAMA;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.FlatAppearance.BorderSize = 0;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.Button3.Location = new System.Drawing.Point(604, 201);
		this.Button3.Margin = new System.Windows.Forms.Padding(4);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(217, 246);
		this.Button3.TabIndex = 6;
		this.Button3.UseVisualStyleBackColor = true;
		this.Button2.BackgroundImage = Skillful.My.Resources.Resources.VAL1;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.Button2.Location = new System.Drawing.Point(327, 201);
		this.Button2.Margin = new System.Windows.Forms.Padding(4);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(217, 246);
		this.Button2.TabIndex = 5;
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.SUDOKU;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.Button1.Location = new System.Drawing.Point(53, 201);
		this.Button1.Margin = new System.Windows.Forms.Padding(4);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(217, 246);
		this.Button1.TabIndex = 4;
		this.Button1.UseVisualStyleBackColor = true;
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Image = Skillful.My.Resources.Resources.skillful_letras;
		this.PictureBox1.Location = new System.Drawing.Point(300, 44);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(312, 89);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 9;
		this.PictureBox1.TabStop = false;
		this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox2.Image = Skillful.My.Resources.Resources.SKILLFUL_LOGO;
		this.PictureBox2.Location = new System.Drawing.Point(116, 44);
		this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(96, 89);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 10;
		this.PictureBox2.TabStop = false;
		this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox3.Image = Skillful.My.Resources.Resources.Proyecto_nuevo__3_1;
		this.PictureBox3.Location = new System.Drawing.Point(721, 33);
		this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(41, 36);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox3.TabIndex = 11;
		this.PictureBox3.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.BackgroundImage = Skillful.My.Resources.Resources.fondo;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(900, 505);
		base.Controls.Add(this.PictureBox3);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "Form1";
		this.Text = "Form1";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		base.ResumeLayout(false);
	}
}
