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
public class facillvl : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comprobar")]
	private Button _comprobar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("volver")]
	private Button _volver;

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

	public facillvl()
	{
		base.Load += facillvl_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.facillvl));
		this.fuente = new System.Windows.Forms.Label();
		this.comprobar = new System.Windows.Forms.Button();
		this.volver = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.fuente.AutoSize = true;
		this.fuente.BackColor = System.Drawing.Color.Transparent;
		this.fuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.fuente.Font = new System.Drawing.Font("Arial", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.fuente.Location = new System.Drawing.Point(43, 52);
		this.fuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.fuente.Name = "fuente";
		this.fuente.Size = new System.Drawing.Size(96, 32);
		this.fuente.TabIndex = 11;
		this.fuente.Text = "Label1";
		this.fuente.Visible = false;
		this.comprobar.BackColor = System.Drawing.Color.Transparent;
		this.comprobar.BackgroundImage = Skillful.My.Resources.Resources.comprobar;
		this.comprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.comprobar.FlatAppearance.BorderSize = 0;
		this.comprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.comprobar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comprobar.Location = new System.Drawing.Point(1069, 530);
		this.comprobar.Margin = new System.Windows.Forms.Padding(4);
		this.comprobar.Name = "comprobar";
		this.comprobar.Size = new System.Drawing.Size(213, 62);
		this.comprobar.TabIndex = 17;
		this.comprobar.UseVisualStyleBackColor = false;
		this.volver.BackColor = System.Drawing.Color.Transparent;
		this.volver.BackgroundImage = Skillful.My.Resources.Resources.VOLVER_001;
		this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.volver.FlatAppearance.BorderSize = 0;
		this.volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.volver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.volver.Location = new System.Drawing.Point(1312, 530);
		this.volver.Margin = new System.Windows.Forms.Padding(4);
		this.volver.Name = "volver";
		this.volver.Size = new System.Drawing.Size(213, 62);
		this.volver.TabIndex = 16;
		this.volver.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.conf;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Location = new System.Drawing.Point(982, 530);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(62, 62);
		this.Button1.TabIndex = 18;
		this.Button1.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.fac2;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(1680, 652);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.volver);
		base.Controls.Add(this.fuente);
		base.Controls.Add(this.comprobar);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "facillvl";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void volver_Click(object sender, EventArgs e)
	{
		base.FormBorderStyle = FormBorderStyle.None;
		Close();
		MyProject.Forms.menucru.Show();
	}

	private void Button1_Click(object sender, EventArgs e)
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

	private void comprobar_Click(object sender, EventArgs e)
	{
		int num = 0;
		string[] array = new string[15];
		cont = 0;
		checked
		{
			if (nrnd == 1)
			{
				nlet[0] = 11;
				nlet[1] = 7;
				nlet[2] = 8;
				nlet[3] = 8;
				nlet[4] = 9;
				nlet[5] = 6;
				do
				{
					int num2 = nlet[cont] + 1;
					for (int i = 1; i <= num2; i++)
					{
						array[cont] += pal[cont, i].Text.ToLower().ToString();
					}
					cont++;
				}
				while (cont != 6);
				if (Operators.CompareString(array[0], "invertebrado", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[1], "omnivoro", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[2], "herbivoro", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[3], "carnivoro", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[4], "vertebrado", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[5], "habitat", TextCompare: false) == 0)
				{
					num++;
				}
				if (num == 6)
				{
					Interaction.MsgBox("Correcto");
				}
				else
				{
					Interaction.MsgBox("Intentalo de nuevo");
				}
				return;
			}
			nlet[0] = 4;
			nlet[1] = 3;
			nlet[2] = 4;
			nlet[3] = 3;
			nlet[4] = 6;
			nlet[5] = 4;
			nlet[6] = 3;
			do
			{
				int num3 = nlet[cont] + 1;
				for (int j = 1; j <= num3; j++)
				{
					array[cont] += pal[cont, j].Text.ToLower().ToString();
				}
				cont++;
			}
			while (cont != 7);
			if (Operators.CompareString(array[0], "arbol", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[1], "raiz", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[2], "fruta", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[3], "flor", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[4], "semilla", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[5], "tallo", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[6], "hoja", TextCompare: false) == 0)
			{
				num++;
			}
			if (num == 7)
			{
				Interaction.MsgBox("Correcto");
			}
			else
			{
				Interaction.MsgBox("Intentalo de nuevo");
			}
		}
	}

	private void facillvl_Load(object sender, EventArgs e)
	{
		Font font = new Font(fuente.Font.FontFamily, 16f);
		Font font2 = new Font(fuente.Font.FontFamily, 10f);
		checked
		{
			if (nrnd == 1)
			{
				pos[0] = new Point(120, 330);
				pos[1] = new Point(180, 240);
				pos[2] = new Point(180, 180);
				pos[3] = new Point(270, 90);
				pos[4] = new Point(240, 450);
				pos[5] = new Point(360, 240);
				nlet[0] = 11;
				nlet[1] = 7;
				nlet[2] = 8;
				nlet[3] = 8;
				nlet[4] = 9;
				nlet[5] = 6;
				do
				{
					int num = nlet[cont] + 1;
					for (int i = 0; i <= num; i++)
					{
						if (i == 0)
						{
							npal[i] = new Label();
							npal[i].TextAlign = ContentAlignment.MiddleCenter;
							npal[i].Size = new Size(30, 30);
							npal[i].Font = font2;
							npal[i].BackColor = Color.Transparent;
							npal[i].Location = pos[cont];
							npal[i].Text = Conversions.ToString(cont + 1);
							base.Controls.Add(npal[i]);
							continue;
						}
						if ((cont == 0) | (unchecked(cont % 2) == 0))
						{
							pos[cont].X += 30;
						}
						else
						{
							pos[cont].Y += 30;
						}
						if (unchecked((cont == 1 && i == 3) | (cont == 3 && i == 3) | (cont == 3 && i == 8) | (cont == 5 && i == 3) | (cont == 5 && i == 7)))
						{
							pal[1, 3] = pal[0, 2];
							pal[3, 3] = pal[2, 3];
							pal[3, 8] = pal[0, 5];
							pal[5, 3] = pal[0, 8];
							pal[5, 7] = pal[4, 4];
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
				while (cont != 6);
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
					BackgroundImage = Resources.FACCRU;
					num2++;
				}
				while (num2 <= 7);
				info[0].Text = "Horizontal: ";
				info[1].Text = "1.- Tipo de animal que no posee esqueleto.";
				info[2].Text = "3.- Tipo de animal que se alimenta de plantas.";
				info[3].Text = "5.- Tipo de animal que posee un esqueleto interno.";
				info[4].Text = "Vertical: ";
				info[5].Text = "2.- Tipo de animal que se alimenta de plantas y carne.";
				info[6].Text = "4.- Tipo de animal que se alimentan de carne.";
				info[7].Text = "6.- Lugar donde vive un animal.";
				return;
			}
			pos[0] = new Point(180, 270);
			pos[1] = new Point(240, 240);
			pos[2] = new Point(270, 330);
			pos[3] = new Point(330, 210);
			pos[4] = new Point(270, 390);
			pos[5] = new Point(420, 270);
			pos[6] = new Point(480, 270);
			nlet[0] = 4;
			nlet[1] = 3;
			nlet[2] = 4;
			nlet[3] = 3;
			nlet[4] = 6;
			nlet[5] = 4;
			nlet[6] = 3;
			do
			{
				int num3 = nlet[cont] + 1;
				for (int j = 0; j <= num3; j++)
				{
					if (j == 0)
					{
						npal[j] = new Label();
						npal[j].TextAlign = ContentAlignment.TopCenter;
						npal[j].Size = new Size(30, 30);
						npal[j].Font = font;
						npal[j].BackColor = Color.Transparent;
						npal[j].Location = pos[cont];
						npal[j].Text = Conversions.ToString(cont + 1);
						base.Controls.Add(npal[j]);
						continue;
					}
					if ((cont == 6) | (unchecked(cont % 2) == 1))
					{
						pos[cont].Y += 30;
					}
					else
					{
						pos[cont].X += 30;
					}
					if (unchecked((cont == 1 && j == 1) | (cont == 3 && j == 2) | (cont == 3 && j == 4) | (cont == 5 && j == 2) | (cont == 5 && j == 4) | (cont == 6 && j == 4)))
					{
						pal[1, 1] = pal[0, 2];
						pal[3, 2] = pal[0, 5];
						pal[3, 4] = pal[2, 2];
						pal[5, 2] = pal[2, 5];
						pal[5, 4] = pal[4, 5];
						pal[6, 4] = pal[4, 7];
					}
					else
					{
						pal[cont, j] = new TextBox();
						pal[cont, j].TextAlign = HorizontalAlignment.Center;
						pal[cont, j].Size = new Size(30, 30);
						pal[cont, j].MaxLength = 1;
						pal[cont, j].Font = font;
						pal[cont, j].Multiline = true;
						pal[cont, j].Location = pos[cont];
						base.Controls.Add(pal[cont, j]);
					}
				}
				cont++;
			}
			while (cont != 7);
			pos[cont].X = 660;
			pos[cont].Y = 100;
			int num4 = 0;
			do
			{
				info[num4] = new Label();
				info[num4].Size = new Size(600, 30);
				info[num4].Font = font2;
				info[num4].Location = pos[cont];
				pos[cont].Y += 30;
				info[num4].BackColor = Color.Transparent;
				base.Controls.Add(info[num4]);
				num4++;
			}
			while (num4 <= 8);
			info[0].Text = "Horizontal: ";
			info[1].Text = "1.- Tipo de planta grande que tiene tronco.";
			info[2].Text = "3.- Parte de la planta que contiene sus semillas, generalmente comestible.";
			info[3].Text = "5.- Grano dentro de las frutas que da origen a una nueva planta.";
			info[4].Text = "Vertical: ";
			info[5].Text = "2.- Parte de la planta que crece en la tierra que absorbe agua y nutrientes.";
			info[6].Text = "4.- Parte de la planta la cual tiene petalos de colores llamativos.";
			info[7].Text = "6.- Parte central de la planta que la sostiene";
			info[8].Text = "7.- Parte de la planta que crece de las ramas, en su mayoria de color verde.";
		}
	}
}
