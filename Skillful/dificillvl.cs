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
public class dificillvl : Form
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

	public dificillvl()
	{
		base.Load += dificillvl_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.dificillvl));
		this.fuente = new System.Windows.Forms.Label();
		this.comprobar = new System.Windows.Forms.Button();
		this.volver = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.fuente.AutoSize = true;
		this.fuente.BackColor = System.Drawing.Color.Transparent;
		this.fuente.Font = new System.Drawing.Font("Arial", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.fuente.Location = new System.Drawing.Point(69, 81);
		this.fuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.fuente.Name = "fuente";
		this.fuente.Size = new System.Drawing.Size(96, 32);
		this.fuente.TabIndex = 11;
		this.fuente.Text = "Label1";
		this.fuente.Visible = false;
		this.comprobar.BackgroundImage = Skillful.My.Resources.Resources.comprobar;
		this.comprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.comprobar.FlatAppearance.BorderSize = 0;
		this.comprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.comprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.comprobar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comprobar.Location = new System.Drawing.Point(1006, 735);
		this.comprobar.Margin = new System.Windows.Forms.Padding(4);
		this.comprobar.Name = "comprobar";
		this.comprobar.Size = new System.Drawing.Size(213, 62);
		this.comprobar.TabIndex = 14;
		this.comprobar.UseVisualStyleBackColor = true;
		this.volver.BackColor = System.Drawing.Color.Transparent;
		this.volver.BackgroundImage = Skillful.My.Resources.Resources.VOLVER_001;
		this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.volver.FlatAppearance.BorderSize = 0;
		this.volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.volver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.volver.Location = new System.Drawing.Point(1245, 735);
		this.volver.Margin = new System.Windows.Forms.Padding(4);
		this.volver.Name = "volver";
		this.volver.Size = new System.Drawing.Size(213, 62);
		this.volver.TabIndex = 13;
		this.volver.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = Skillful.My.Resources.Resources.conf;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Location = new System.Drawing.Point(917, 735);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(62, 62);
		this.Button1.TabIndex = 19;
		this.Button1.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.difici;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(1680, 825);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.comprobar);
		base.Controls.Add(this.volver);
		base.Controls.Add(this.fuente);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "dificillvl";
		this.Text = "dificillvl";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void dificillvl_Load(object sender, EventArgs e)
	{
		Font font = new Font(fuente.Font.FontFamily, 16f);
		Font font2 = new Font(fuente.Font.FontFamily, 10f);
		checked
		{
			if (nrnd == 1)
			{
				pos[0] = new Point(240, 120);
				pos[1] = new Point(360, 90);
				pos[2] = new Point(180, 180);
				pos[3] = new Point(420, 150);
				pos[4] = new Point(90, 330);
				pos[5] = new Point(120, 210);
				pos[6] = new Point(360, 360);
				pos[7] = new Point(180, 180);
				pos[8] = new Point(150, 420);
				pos[9] = new Point(270, 270);
				pos[10] = new Point(210, 480);
				pos[11] = new Point(480, 210);
				pos[12] = new Point(90, 540);
				pos[13] = new Point(540, 180);
				pos[14] = new Point(120, 450);
				nlet[0] = 8;
				nlet[1] = 8;
				nlet[2] = 8;
				nlet[3] = 7;
				nlet[4] = 9;
				nlet[5] = 6;
				nlet[6] = 6;
				nlet[7] = 12;
				nlet[8] = 9;
				nlet[9] = 8;
				nlet[10] = 7;
				nlet[11] = 7;
				nlet[12] = 4;
				nlet[13] = 6;
				nlet[14] = 3;
				do
				{
					int num = nlet[cont];
					for (int i = 0; i <= num; i++)
					{
						if (i == 0)
						{
							if (cont == 7)
							{
								npal[i] = new Label();
								npal[i].TextAlign = ContentAlignment.MiddleCenter;
								npal[i].Size = new Size(30, 30);
								npal[i].Font = font2;
								npal[i].BackColor = Color.Transparent;
								npal[i].Location = new Point(150, 210);
								npal[i].Text = Conversions.ToString(cont + 1);
								base.Controls.Add(npal[i]);
							}
							else
							{
								npal[i] = new Label();
								npal[i].TextAlign = ContentAlignment.MiddleCenter;
								npal[i].Size = new Size(30, 30);
								npal[i].Font = font2;
								npal[i].BackColor = Color.Transparent;
								npal[i].Location = pos[cont];
								npal[i].Text = Conversions.ToString(cont + 1);
								base.Controls.Add(npal[i]);
							}
							continue;
						}
						if ((cont == 14) | (unchecked(cont % 2) == 1))
						{
							pos[cont].Y += 30;
						}
						else
						{
							pos[cont].X += 30;
						}
						if (unchecked((cont == 1 && i == 1) | (cont == 1 && i == 3) | (cont == 1 && i == 8) | (cont == 3 && i == 1) | (cont == 3 && i == 7) | (cont == 5 && i == 4) | (cont == 7 && i == 5) | (cont == 7 && i == 8) | (cont == 7 && i == 12) | (cont == 9 && i == 2) | (cont == 9 && i == 5) | (cont == 9 && i == 7) | (cont == 11 && i == 5) | (cont == 13 && i == 6) | (cont == 14 && i == 3)))
						{
							pal[1, 1] = pal[0, 4];
							pal[1, 3] = pal[2, 6];
							pal[1, 8] = pal[4, 9];
							pal[3, 1] = pal[2, 8];
							pal[3, 7] = pal[6, 2];
							pal[5, 4] = pal[4, 1];
							pal[7, 5] = pal[4, 3];
							pal[7, 8] = pal[8, 1];
							pal[7, 12] = pal[12, 3];
							pal[9, 2] = pal[4, 6];
							pal[9, 5] = pal[8, 4];
							pal[9, 7] = pal[10, 2];
							pal[11, 5] = pal[6, 4];
							pal[13, 6] = pal[6, 6];
							pal[14, 3] = pal[12, 1];
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
				while (cont != 15);
				pos[cont - 1].X = 600;
				pos[cont - 1].Y = 60;
				int num2 = 0;
				do
				{
					info[num2] = new Label();
					info[num2].Size = new Size(550, 30);
					info[num2].Font = font2;
					info[num2].BackColor = Color.Transparent;
					info[num2].Location = pos[cont - 1];
					pos[cont - 1].Y += 30;
					base.Controls.Add(info[num2]);
					num2++;
				}
				while (num2 <= 16);
				info[0].Text = "Horizontal: ";
				info[1].Text = "1.- Nube espacial de gases y elementos quimicos en forma de polvo.";
				info[2].Text = "3.- Cuerpo celeste opaco que gira alrededor de un planeta.";
				info[3].Text = "5.- Fragmento de un cuerpo celeste que ingresa a la atmosfera terrestre.";
				info[4].Text = "7.- Cuerpo celeste que orbita alrededor Sol que deja un rastro luminoso.";
				info[5].Text = "9.- Cuerpo rocoso como un planeta de menor volumen que orbita alrededor de ellos.";
				info[6].Text = "11.- Agrupacion de estrellas, planetas, y materia en un region del espacio.";
				info[7].Text = "13.- Satelite natural que gira alrededor de la Tierra y refleja la luz del sol.";
				info[8].Text = "Vertical";
				info[9].Text = "2.- Conjunto de todo lo existente fisicamente.";
				info[10].Text = "4.- Medio donde se encuentra la materia y puede moverse a traves de este.";
				info[11].Text = "6.- Nombre que se le otorga a la inmensidad del universo y todo lo existente.";
				info[12].Text = "8.- Agrupacion de estrellas que forman una figura determinada.";
				info[13].Text = "10.- Fuerza fundamental del universo que mantiene la atraccion entre la materia.";
				info[14].Text = "12.- Cuerpo celeste redondo y masivo que gira alrededor de una estella.";
				info[15].Text = "14.- Movimiento que describe el giro de un cuerpo alrededor de otro .";
				info[16].Text = "15.- Estrella masiva que produce su propia luz y energia.";
				return;
			}
			Point location = new Point(150, 150);
			int[] array = new int[15];
			int[] array2 = new int[15];
			array[0] = 60;
			array2[0] = 240;
			array[1] = 150;
			array2[1] = 90;
			array[2] = 150;
			array2[2] = 300;
			array[3] = 210;
			array2[3] = 150;
			array[4] = 150;
			array2[4] = 360;
			array[5] = 330;
			array2[5] = 240;
			array[6] = 210;
			array2[6] = 420;
			array[7] = 390;
			array2[7] = 360;
			array[8] = 150;
			array2[8] = 480;
			array[9] = 390;
			array2[9] = 90;
			array[10] = 210;
			array2[10] = 570;
			array[11] = 450;
			array2[11] = 150;
			array[12] = 240;
			array2[12] = 180;
			array[13] = 510;
			array2[13] = 240;
			array[14] = 300;
			array2[14] = 120;
			nlet[0] = 5;
			nlet[1] = 4;
			nlet[2] = 7;
			nlet[3] = 4;
			nlet[4] = 6;
			nlet[5] = 7;
			nlet[6] = 10;
			nlet[7] = 6;
			nlet[8] = 5;
			nlet[9] = 4;
			nlet[10] = 5;
			nlet[11] = 8;
			nlet[12] = 7;
			nlet[13] = 7;
			nlet[14] = 4;
			do
			{
				int num3 = nlet[cont] + 1;
				for (int j = 0; j <= num3; j++)
				{
					if (j == 0)
					{
						npal[j] = new Label();
						npal[j].TextAlign = ContentAlignment.MiddleCenter;
						npal[j].Size = new Size(30, 30);
						npal[j].Font = font2;
						npal[j].BackColor = Color.Transparent;
						npal[j].Location = new Point(array[cont], array2[cont]);
						npal[j].Text = Conversions.ToString(cont + 1);
						base.Controls.Add(npal[j]);
						continue;
					}
					if ((cont == 0) | (unchecked(cont % 2) == 0))
					{
						array[cont] += 30;
					}
					else
					{
						array2[cont] += 30;
					}
					if (unchecked((cont == 1 && j == 5) | (cont == 3 && j == 3) | (cont == 3 && j == 5) | (cont == 5 && j == 2) | (cont == 5 && j == 4) | (cont == 6 && j == 4) | (cont == 7 && j == 2) | (cont == 8 && j == 6) | (cont == 10 && j == 6) | (cont == 11 && j == 9) | (cont == 12 && j == 5) | (cont == 12 && j == 7) | (cont == 13 && j == 6) | (cont == 14 && j == 3)))
					{
						pal[1, 5] = pal[0, 3];
						pal[3, 3] = pal[0, 5];
						pal[3, 5] = pal[2, 2];
						pal[5, 2] = pal[2, 6];
						pal[5, 4] = pal[4, 6];
						pal[6, 4] = pal[5, 6];
						pal[7, 2] = pal[6, 6];
						pal[8, 6] = pal[5, 8];
						pal[10, 6] = pal[7, 7];
						pal[11, 9] = pal[6, 8];
						pal[12, 5] = pal[9, 3];
						pal[12, 7] = pal[11, 1];
						pal[13, 6] = pal[6, 10];
						pal[14, 3] = pal[9, 1];
					}
					else
					{
						pal[cont, j] = new TextBox();
						pal[cont, j].TextAlign = HorizontalAlignment.Center;
						pal[cont, j].Size = new Size(30, 30);
						pal[cont, j].MaxLength = 1;
						pal[cont, j].Font = font;
						pal[cont, j].Multiline = true;
						pal[cont, j].Location = new Point(array[cont], array2[cont]);
						base.Controls.Add(pal[cont, j]);
					}
				}
				cont++;
			}
			while (cont != 15);
			location.X = 590;
			location.Y = 70;
			int num4 = 0;
			do
			{
				info[num4] = new Label();
				info[num4].Size = new Size(550, 30);
				info[num4].Font = font2;
				info[num4].BackColor = Color.Transparent;
				info[num4].Location = location;
				location.Y += 30;
				base.Controls.Add(info[num4]);
				num4++;
			}
			while (num4 <= 16);
			info[0].Text = "Horizontal: ";
			info[1].Text = "1.- Capa exterior transparente en la parte delantera del ojo.";
			info[2].Text = "3.- Proteína del cuerpo que forma fibras.";
			info[3].Text = "5.- Conducto que empieza en la laringe y que se extiende hasta el tórax.";
			info[4].Text = "7.- Estado de equilibrio entre todos los sistemas del cuerpo.";
			info[5].Text = "9.- Hueso más largo y más grande de la extremidad superior.";
			info[6].Text = "11.- Protege el cerebro y proveer un sitio de adhesión para los músculos faciales.";
			info[7].Text = "13.- Órgano pequeño, en forma de tubo, unido a la primera parte del intestino grueso.";
			info[8].Text = "15.- Región del cuerpo formada por el esternón, las vértebras torácicas, y las costillas";
			info[9].Text = "Vertical:";
			info[10].Text = "2.- Hueso largo que conecta los huesos de la parte superior de la pierna con los inferiores.";
			info[11].Text = "4.- Mucosa de tejido de la lengua que limita el movimiento de un miembro móvil en el cuerpo.";
			info[12].Text = "6.- Parte del encéfalo que se encuentra en el lado posterior del cráneo.";
			info[13].Text = "8.- Conducto musculoso, que permite y contribuye al paso de los alimentos.";
			info[14].Text = "10.- Parte Lateral de los dos huesos.";
			info[15].Text = "12.- Hueso que se ubica en la parte superior de las costillas.";
			info[16].Text = "14.- Sirve para bajar los niveles de glucosa en la sangre.";
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

	private void comprobar_Click(object sender, EventArgs e)
	{
		Font font = new Font(fuente.Font.FontFamily, 16f);
		Font font2 = new Font(fuente.Font.FontFamily, 10f);
		int num = 0;
		string[] array = new string[16];
		cont = 0;
		checked
		{
			if (nrnd == 1)
			{
				nlet[0] = 8;
				nlet[1] = 8;
				nlet[2] = 8;
				nlet[3] = 7;
				nlet[4] = 9;
				nlet[5] = 6;
				nlet[6] = 6;
				nlet[7] = 12;
				nlet[8] = 9;
				nlet[9] = 8;
				nlet[10] = 7;
				nlet[11] = 7;
				nlet[12] = 4;
				nlet[13] = 6;
				nlet[14] = 3;
				do
				{
					int num2 = nlet[cont];
					for (int i = 1; i <= num2; i++)
					{
						array[cont] += pal[cont, i].Text.ToLower().ToString();
					}
					cont++;
				}
				while (cont != 15);
				if (Operators.CompareString(array[0], "nebulosa", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[1], "universo", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[2], "satelite", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[3], "espacio", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[4], "meteorito", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[5], "cosmos", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[6], "cometa", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[7], "constelacion", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[8], "asteroide", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[9], "gravedad", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[10], "galaxia", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[11], "planeta", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[12], "luna", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[13], "orbita", TextCompare: false) == 0)
				{
					num++;
				}
				if (Operators.CompareString(array[14], "sol", TextCompare: false) == 0)
				{
					num++;
				}
				if (num == 15)
				{
					Interaction.MsgBox("Correcto");
				}
				else
				{
					Interaction.MsgBox("Intentalo de nuevo");
				}
				return;
			}
			nlet[0] = 5;
			nlet[1] = 4;
			nlet[2] = 7;
			nlet[3] = 4;
			nlet[4] = 6;
			nlet[5] = 7;
			nlet[6] = 10;
			nlet[7] = 6;
			nlet[8] = 5;
			nlet[9] = 4;
			nlet[10] = 5;
			nlet[11] = 8;
			nlet[12] = 7;
			nlet[13] = 7;
			nlet[14] = 4;
			do
			{
				int num3 = nlet[cont] + 1;
				for (int j = 1; j <= num3; j++)
				{
					array[cont] += pal[cont, j].Text.ToLower().ToString();
				}
				cont++;
			}
			while (cont != 15);
			if (Operators.CompareString(array[0], "cornea", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[1], "femur", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[2], "colageno", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[3], "freno", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[4], "traquea", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[5], "cerebelo", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[6], "homeostasis", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[7], "esofago", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[8], "humero", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[9], "radio", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[10], "craneo", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[11], "clavicula", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[12], "apendice", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[13], "insulina", TextCompare: false) == 0)
			{
				num++;
			}
			if (Operators.CompareString(array[14], "torax", TextCompare: false) == 0)
			{
				num++;
			}
			if (num == 15)
			{
				Interaction.MsgBox("Correcto");
			}
			else
			{
				Interaction.MsgBox("Esta mal");
			}
		}
	}

	private void volver_Click(object sender, EventArgs e)
	{
		base.FormBorderStyle = FormBorderStyle.None;
		Close();
		MyProject.Forms.menucru.Show();
	}
}
