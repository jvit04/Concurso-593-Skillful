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
public class mediolvl : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("volver")]
	private Button _volver;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comprobar")]
	private Button _comprobar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	private Random rnd;

	private int nrnd;

	private TextBox[,] pal;

	private int[] nlet;

	private int cont;

	private Label[] info;

	private Label[] npal;

	private Point[] pos;

	private int c;

	[field: AccessedThroughProperty("fuente")]
	internal virtual Label fuente
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button volver
	{
		[CompilerGenerated]
		get
		{
			return _volver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = volver_Click;
			Button button = _volver;
			if (button != null)
			{
				button.Click -= value2;
			}
			_volver = value;
			button = _volver;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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
			EventHandler value2 = Button1_Click_1;
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

	public mediolvl()
	{
		base.Load += mediolvl_Load;
		rnd = new Random();
		nrnd = rnd.Next(2);
		pal = new TextBox[16, 16];
		nlet = new int[16];
		info = new Label[17];
		npal = new Label[15];
		pos = new Point[15];
		c = 1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.mediolvl));
		this.fuente = new System.Windows.Forms.Label();
		this.volver = new System.Windows.Forms.Button();
		this.comprobar = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.fuente.AutoSize = true;
		this.fuente.BackColor = System.Drawing.Color.Transparent;
		this.fuente.Font = new System.Drawing.Font("Arial", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.fuente.Location = new System.Drawing.Point(53, 43);
		this.fuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.fuente.Name = "fuente";
		this.fuente.Size = new System.Drawing.Size(96, 32);
		this.fuente.TabIndex = 16;
		this.fuente.Text = "Label1";
		this.fuente.Visible = false;
		this.volver.BackColor = System.Drawing.Color.Transparent;
		this.volver.BackgroundImage = Skillful.My.Resources.Resources.VOLVER_001;
		this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.volver.FlatAppearance.BorderSize = 0;
		this.volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.volver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.volver.Location = new System.Drawing.Point(1275, 686);
		this.volver.Margin = new System.Windows.Forms.Padding(4);
		this.volver.Name = "volver";
		this.volver.Size = new System.Drawing.Size(213, 62);
		this.volver.TabIndex = 18;
		this.volver.UseVisualStyleBackColor = false;
		this.comprobar.BackColor = System.Drawing.Color.Transparent;
		this.comprobar.BackgroundImage = Skillful.My.Resources.Resources.comprobar;
		this.comprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.comprobar.FlatAppearance.BorderSize = 0;
		this.comprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.comprobar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comprobar.Location = new System.Drawing.Point(1031, 686);
		this.comprobar.Margin = new System.Windows.Forms.Padding(4);
		this.comprobar.Name = "comprobar";
		this.comprobar.Size = new System.Drawing.Size(213, 62);
		this.comprobar.TabIndex = 19;
		this.comprobar.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.conf;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Location = new System.Drawing.Point(935, 686);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(62, 62);
		this.Button1.TabIndex = 20;
		this.Button1.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.Proyecto_nuevo__4_;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(1665, 825);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.comprobar);
		base.Controls.Add(this.volver);
		base.Controls.Add(this.fuente);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "mediolvl";
		this.Text = "mediolvl";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void comprobar_Click(object sender, EventArgs e)
	{
		int num = 0;
		string[] array = new string[15];
		cont = 0;
		nlet[0] = 5;
		nlet[1] = 7;
		nlet[2] = 9;
		nlet[3] = 5;
		nlet[4] = 7;
		nlet[5] = 7;
		nlet[6] = 4;
		nlet[7] = 8;
		nlet[8] = 4;
		checked
		{
			do
			{
				int num2 = nlet[cont] + 1;
				for (int i = 1; i <= num2; i++)
				{
					array[cont] += pal[cont, i].Text.ToLower().ToString();
				}
				cont++;
			}
			while (cont != 9);
			if (Operators.CompareString(array[0], "celula", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[1], "electron", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[2], "termometro", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[3], "tejido", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[4], "diabetes", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[5], "bacteria", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[6], "atomo", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[7], "nitrogeno", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[8], "virus", TextCompare: false) == 0)
			{
				num++;
			}
			if (num == 9)
			{
				Interaction.MsgBox("Correcto");
			}
			else
			{
				Interaction.MsgBox("Intentalo de nuevo");
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		if (c % 2 == 0)
		{
			base.FormBorderStyle = FormBorderStyle.None;
		}
		else
		{
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		}
		checked
		{
			c++;
		}
	}

	private void volver_Click(object sender, EventArgs e)
	{
		base.FormBorderStyle = FormBorderStyle.None;
		Close();
		MyProject.Forms.menucru.Show();
	}

	private void mediolvl_Load(object sender, EventArgs e)
	{
		Font font = new Font(fuente.Font.FontFamily, 16f);
		Font font2 = new Font(fuente.Font.FontFamily, 10f);
		pos[0] = new Point(210, 180);
		pos[1] = new Point(270, 150);
		pos[2] = new Point(120, 360);
		pos[3] = new Point(180, 300);
		pos[4] = new Point(240, 450);
		pos[5] = new Point(330, 210);
		pos[6] = new Point(240, 510);
		pos[7] = new Point(390, 240);
		pos[8] = new Point(480, 300);
		nlet[0] = 5;
		nlet[1] = 7;
		nlet[2] = 9;
		nlet[3] = 5;
		nlet[4] = 7;
		nlet[5] = 7;
		nlet[6] = 4;
		nlet[7] = 8;
		nlet[8] = 4;
		checked
		{
			do
			{
				int num = nlet[cont] + 1;
				for (int i = 0; i <= num; i++)
				{
					if (i == 0)
					{
						npal[i] = new Label();
						npal[i].TextAlign = ContentAlignment.TopCenter;
						npal[i].Size = new Size(30, 30);
						npal[i].Font = font;
						npal[i].Location = pos[cont];
						npal[i].Text = Conversions.ToString(cont + 1);
						npal[i].BackColor = Color.Transparent;
						base.Controls.Add(npal[i]);
						continue;
					}
					if ((cont == 8) | (unchecked(cont % 2) == 1))
					{
						pos[cont].Y += 30;
					}
					else
					{
						pos[cont].X += 30;
					}
					if (unchecked((cont == 1 && i == 1) | (cont == 1 && i == 7) | (cont == 3 && i == 2) | (cont == 5 && i == 5) | (cont == 5 && i == 8) | (cont == 7 && i == 4) | (cont == 7 && i == 7) | (cont == 7 && i == 9) | (cont == 8 && i == 5)))
					{
						pal[1, 1] = pal[0, 2];
						pal[1, 7] = pal[2, 5];
						pal[3, 2] = pal[2, 2];
						pal[5, 5] = pal[2, 7];
						pal[5, 8] = pal[4, 3];
						pal[7, 4] = pal[2, 9];
						pal[7, 7] = pal[4, 5];
						pal[7, 9] = pal[6, 5];
						pal[8, 5] = pal[4, 8];
					}
					else
					{
						pal[cont, i] = new TextBox();
						pal[cont, i].TextAlign = HorizontalAlignment.Center;
						pal[cont, i].Size = new Size(30, 30);
						pal[cont, i].MaxLength = 1;
						pal[cont, i].Font = font;
						pal[cont, i].Multiline = true;
						pal[cont, i].Location = pos[cont];
						base.Controls.Add(pal[cont, i]);
					}
				}
				cont++;
			}
			while (cont != 9);
			pos[cont].X = 660;
			pos[cont].Y = 120;
			int num2 = 0;
			do
			{
				info[num2] = new Label();
				info[num2].Size = new Size(600, 30);
				info[num2].Font = font2;
				info[num2].Location = pos[cont];
				pos[cont].Y += 30;
				info[num2].BackColor = Color.Transparent;
				base.Controls.Add(info[num2]);
				num2++;
			}
			while (num2 <= 10);
			info[0].Text = "Horizontal: ";
			info[1].Text = "1.- Unidad fundamental de los organismos vivos.";
			info[2].Text = "3.- Instrumento para medir la temperatura.";
			info[3].Text = "5.- Enfermedad causada por el exceso de azucar en la sangre.";
			info[4].Text = "7.- Particula fundamental del universo que posee nucleo y electrones.";
			info[5].Text = "Vertical";
			info[6].Text = "2.- Particula con carga electrica negativa.";
			info[7].Text = "4.- Conjunto de celulas que realiza una funcion.";
			info[8].Text = "6.- Microorganismo unicelular sin núcleo.";
			info[9].Text = "8.- Nombre del elemento quimico cuyo simbolo es N.";
			info[10].Text = "9.- Microorganismo infeccioso que se replica dentro de otras celulas.";
		}
	}
}
