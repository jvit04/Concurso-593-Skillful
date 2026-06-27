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
public class nvtrivia : Form
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

	private int p;

	private int c;

	private int mal;

	private int[] comp;

	private string[] preg;

	private string[] p1;

	private string[] p2;

	private string[] p3;

	private string[] p4;

	private string[] p5;

	private string[] p6;

	private string[] p7;

	private string[] p8;

	private string[] p9;

	private string[] p10;

	private string[] p11;

	private string[] p12;

	private string[] p13;

	private string[] p14;

	private string[] p15;

	private string[] p16;

	private string[] p17;

	private string[] p18;

	private string[] p19;

	private string[] p20;

	private string[] p21;

	private string[] p22;

	private string[] p23;

	private string[] p24;

	private string[] p25;

	private string[] p26;

	private string[] p27;

	private string[] p28;

	private string[] p29;

	private string[] p30;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public nvtrivia()
	{
		base.Load += nv1_Load;
		comp = new int[30];
		preg = new string[30];
		p1 = new string[3];
		p2 = new string[3];
		p3 = new string[3];
		p4 = new string[3];
		p5 = new string[3];
		p6 = new string[3];
		p7 = new string[3];
		p8 = new string[3];
		p9 = new string[3];
		p10 = new string[3];
		p11 = new string[3];
		p12 = new string[3];
		p13 = new string[3];
		p14 = new string[3];
		p15 = new string[3];
		p16 = new string[3];
		p17 = new string[3];
		p18 = new string[3];
		p19 = new string[3];
		p20 = new string[3];
		p21 = new string[3];
		p22 = new string[3];
		p23 = new string[3];
		p24 = new string[3];
		p25 = new string[3];
		p26 = new string[3];
		p27 = new string[3];
		p28 = new string[3];
		p29 = new string[3];
		p30 = new string[3];
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skillful.nvtrivia));
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.Button5 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.Font = new System.Drawing.Font("Fredoka One", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(308, 160);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.MaximumSize = new System.Drawing.Size(699, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(143, 48);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Label1";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button1.BackgroundImage");
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatAppearance.BorderSize = 0;
		this.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("Fredoka One", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button1.ForeColor = System.Drawing.Color.Black;
		this.Button1.Location = new System.Drawing.Point(277, 316);
		this.Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(205, 100);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.Transparent;
		this.Button2.BackgroundImage = Skillful.My.Resources.Resources._5345220;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatAppearance.BorderSize = 0;
		this.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Font = new System.Drawing.Font("Fredoka One", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button2.ForeColor = System.Drawing.Color.Black;
		this.Button2.Location = new System.Drawing.Point(30, 316);
		this.Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(205, 100);
		this.Button2.TabIndex = 2;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.Transparent;
		this.Button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button3.BackgroundImage");
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.FlatAppearance.BorderSize = 0;
		this.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Font = new System.Drawing.Font("Fredoka One", 13.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button3.ForeColor = System.Drawing.Color.Black;
		this.Button3.Location = new System.Drawing.Point(524, 316);
		this.Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(205, 100);
		this.Button3.TabIndex = 3;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.Transparent;
		this.Button4.BackgroundImage = Skillful.My.Resources.Resources.sig;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.FlatAppearance.BorderSize = 0;
		this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.Location = new System.Drawing.Point(602, 15);
		this.Button4.Margin = new System.Windows.Forms.Padding(4);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(50, 50);
		this.Button4.TabIndex = 4;
		this.Button4.UseVisualStyleBackColor = false;
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.Transparent;
		this.Label2.Font = new System.Drawing.Font("Fredoka One", 13.8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(37, 26);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(147, 29);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Pregunta 1";
		this.Button5.BackColor = System.Drawing.Color.Transparent;
		this.Button5.BackgroundImage = Skillful.My.Resources.Resources.cerrartr;
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.FlatAppearance.BorderSize = 0;
		this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.Location = new System.Drawing.Point(679, 15);
		this.Button5.Margin = new System.Windows.Forms.Padding(4);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(50, 50);
		this.Button5.TabIndex = 6;
		this.Button5.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImage = Skillful.My.Resources.Resources.INTERROGACION;
		base.ClientSize = new System.Drawing.Size(755, 434);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		this.MaximumSize = new System.Drawing.Size(755, 434);
		this.MinimumSize = new System.Drawing.Size(755, 434);
		base.Name = "nvtrivia";
		this.Text = "nvtrivia";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void nv1_Load(object sender, EventArgs e)
	{
		VBMath.Randomize();
		preg[0] = "¿De qué estilo arquitectónico es la Catedral de Notre Dame en París?";
		preg[1] = "¿Cuál es el lugar más frío de la tierra?";
		preg[2] = "¿Quién escribió La Odisea?";
		preg[3] = "¿Quién escribió Hamlet?";
		preg[4] = "¿Cuál es el río más largo del mundo?";
		preg[5] = "¿Cómo se llama el animal más rápido del mundo?";
		preg[6] = "¿En qué continente está Ecuador?";
		preg[7] = "¿Dónde originaron los juegos olímpicos?";
		preg[8] = "¿Qué tipo de animal es la ballena?";
		preg[9] = "¿Cómo le llaman a los textos de autores desconocidos?";
		preg[10] = "¿Qué cantidad de huesos en el cuerpo humano adulto?";
		preg[11] = "¿Cuándo acabó la II Guerra Mundial?";
		preg[12] = "¿Qué instrumento óptico permite ver los astros de cerca?";
		preg[13] = "¿Cuál es el primero de la lista de los números primos?";
		preg[14] = "¿En qué país se encuentra la torre de Pisa?";
		preg[15] = "¿En qué lugar del cuerpo se produce la insulina?";
		preg[16] = "¿Qué son los humanos: omnívoros, herbívoros o carnívoros?";
		preg[17] = "¿Cómo se denomina el resultado de la multiplicación?";
		preg[18] = "¿Cuál es el nombre de la lengua oficial en china?";
		preg[19] = "¿Qué año llegó Cristóbal Colón a América?";
		preg[20] = "¿Cuál es el único mamífero capaz de volar?";
		preg[21] = "¿Qué es más pequeño, un átomo o una molécula?";
		preg[22] = "¿Qué producto cultiva más Guatemala?";
		preg[23] = "¿Cuál es la moneda oficial de Estados Unidos?";
		preg[24] = "¿Cual es país más poblado de la Tierra?";
		preg[25] = "¿Cuál es el color que representa la esperanza?";
		preg[26] = "¿Cuántas patas tiene la araña?";
		preg[27] = "¿Cuál es el país más grande del mundo?";
		preg[28] = "¿Dónde se encuentra la famosa Torre Eiffel?";
		preg[29] = "¿Qué deporte practicaba Michael Jordan?";
		p1[0] = "Gótico";
		p2[0] = "Antártida";
		p3[0] = "Homero";
		p4[0] = "Shakespeare";
		p5[0] = "Amazonas";
		p6[0] = "Guepardo";
		p7[0] = "América";
		p8[0] = "Grecia";
		p9[0] = "Mamífero";
		p10[0] = "Anónimo";
		p11[0] = "206";
		p12[0] = "1945";
		p13[0] = "Telescopio";
		p14[0] = "2";
		p15[0] = "Italia";
		p16[0] = "Páncreas";
		p17[0] = "Omnívoros";
		p18[0] = "Producto";
		p19[0] = "Mandarín";
		p20[0] = "1492";
		p21[0] = "Murciélago";
		p22[0] = "Átomo";
		p23[0] = "Café";
		p24[0] = "Dólar";
		p25[0] = "China";
		p26[0] = "Verde";
		p27[0] = "8";
		p28[0] = "Rusia";
		p29[0] = "París";
		p30[0] = "Baloncesto";
		p1[1] = "Románico";
		p1[2] = "Rococó";
		p2[1] = "Canadá";
		p2[2] = "Estonia";
		p3[1] = "Hesíodo";
		p3[2] = "Platón";
		p4[1] = "Hathaway";
		p4[2] = "Cervantes";
		p5[1] = "Nilo";
		p5[2] = "Misisipi";
		p6[1] = "Vencejo";
		p6[2] = "Chita";
		p7[1] = "Asia";
		p7[2] = "Europa";
		p8[1] = "Roma";
		p8[2] = "Egipto";
		p9[1] = "Pez";
		p9[2] = "Anfibio";
		p10[1] = "Desconocido";
		p10[2] = "Indefinido";
		p11[1] = "300";
		p11[2] = "243";
		p12[1] = "1939";
		p12[2] = "1942";
		p13[1] = "Microscopio";
		p13[2] = "Lupa";
		p14[1] = "1";
		p14[2] = "3";
		p15[1] = "Francia";
		p15[2] = "España";
		p16[1] = "Higado";
		p16[2] = "Tiroides";
		p17[1] = "Herbívoros";
		p17[2] = "Carnívoros";
		p18[1] = "Cociente";
		p18[2] = "Residuo";
		p19[1] = "Chino";
		p19[2] = "Latín";
		p20[1] = "1942";
		p20[2] = "1249";
		p21[1] = "Pingüino";
		p21[2] = "Ornitorrinco";
		p22[1] = "Molécula";
		p22[2] = "Ninguno";
		p23[1] = "Banano";
		p23[2] = "Arroz";
		p24[1] = "Euro";
		p24[2] = "Libra";
		p25[1] = "Rusia";
		p25[2] = "Japón";
		p26[1] = "Blanco";
		p26[2] = "Morado";
		p27[1] = "6";
		p27[2] = "10";
		p28[1] = "Inglaterra";
		p28[2] = "China";
		p29[1] = "Marsella";
		p29[2] = "Lyon";
		p30[1] = "Fútbol";
		p30[2] = "Voleibol";
		p = 1;
		Label2.Text = "Pregunta " + Conversions.ToString(p);
		checked
		{
			Label1.Text = preg[(int)Math.Round(29f * VBMath.Rnd())];
			Button4.Enabled = false;
			if (Label1.Size.Height > 36)
			{
				Label1.Location = new Point(254, 100);
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Label1.AutoSize = true;
			if (Operators.CompareString(Label1.Text, preg[0], TextCompare: false) == 0)
			{
				Button1.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[0] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[0]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[1], TextCompare: false) == 0)
			{
				Button1.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[1] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[1]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[2], TextCompare: false) == 0)
			{
				Button1.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[2] >= 1)
				{
					Label1.Text = preg[3];
				}
				comp[2]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[3], TextCompare: false) == 0)
			{
				Button1.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[3] >= 1)
				{
					Label1.Text = preg[4];
				}
				comp[3]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[4], TextCompare: false) == 0)
			{
				Button1.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[4] >= 1)
				{
					Label1.Text = preg[5];
				}
				comp[4]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[5], TextCompare: false) == 0)
			{
				Button1.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[5] >= 1)
				{
					Label1.Text = preg[6];
				}
				comp[5]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[6], TextCompare: false) == 0)
			{
				Button1.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[6] >= 1)
				{
					Label1.Text = preg[7];
				}
				comp[6]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[7], TextCompare: false) == 0)
			{
				Button1.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[7] >= 1)
				{
					Label1.Text = preg[8];
				}
				comp[7]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[8], TextCompare: false) == 0)
			{
				Button1.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[8] >= 1)
				{
					Label1.Text = preg[9];
				}
				comp[8]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[9], TextCompare: false) == 0)
			{
				Button1.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[9] >= 1)
				{
					Label1.Text = preg[10];
				}
				comp[9]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[10], TextCompare: false) == 0)
			{
				Button1.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[10] >= 1)
				{
					Label1.Text = preg[11];
				}
				comp[10]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[11], TextCompare: false) == 0)
			{
				Button1.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[11] >= 1)
				{
					Label1.Text = preg[12];
				}
				comp[11]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[12], TextCompare: false) == 0)
			{
				Button1.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[12] >= 1)
				{
					Label1.Text = preg[13];
				}
				comp[12]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[13], TextCompare: false) == 0)
			{
				Button1.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[13] >= 1)
				{
					Label1.Text = preg[14];
				}
				comp[13]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[14], TextCompare: false) == 0)
			{
				Button1.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[14] >= 1)
				{
					Label1.Text = preg[15];
				}
				comp[14]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[15], TextCompare: false) == 0)
			{
				Button1.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[15] >= 1)
				{
					Label1.Text = preg[16];
				}
				comp[15]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[16], TextCompare: false) == 0)
			{
				Button1.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[16] >= 1)
				{
					Label1.Text = preg[17];
				}
				comp[16]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[17], TextCompare: false) == 0)
			{
				Button1.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[17] >= 1)
				{
					Label1.Text = preg[18];
				}
				comp[17]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[18], TextCompare: false) == 0)
			{
				Button1.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[18] >= 1)
				{
					Label1.Text = preg[19];
				}
				comp[18]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[19], TextCompare: false) == 0)
			{
				Button1.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[19] >= 1)
				{
					Label1.Text = preg[20];
				}
				comp[19]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[20], TextCompare: false) == 0)
			{
				Button1.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[20] >= 1)
				{
					Label1.Text = preg[21];
				}
				comp[20]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[21], TextCompare: false) == 0)
			{
				Button1.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[21] >= 1)
				{
					Label1.Text = preg[22];
				}
				comp[21]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[22], TextCompare: false) == 0)
			{
				Button1.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[22] >= 1)
				{
					Label1.Text = preg[23];
				}
				comp[22]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[23], TextCompare: false) == 0)
			{
				Button1.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[23] >= 1)
				{
					Label1.Text = preg[24];
				}
				comp[23]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[24], TextCompare: false) == 0)
			{
				Button1.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[25], TextCompare: false) == 0)
			{
				Button1.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[24] >= 1)
				{
					Label1.Text = preg[25];
				}
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[26], TextCompare: false) == 0)
			{
				Button1.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[26] >= 1)
				{
					Label1.Text = preg[27];
				}
				comp[26]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[27], TextCompare: false) == 0)
			{
				Button1.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[27] >= 1)
				{
					Label1.Text = preg[28];
				}
				comp[27]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[28], TextCompare: false) == 0)
			{
				Button1.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[28] >= 1)
				{
					Label1.Text = preg[29];
				}
				comp[28]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[29], TextCompare: false) == 0)
			{
				Button1.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[29] >= 1)
				{
					Label1.Text = preg[0];
				}
				comp[29]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Button1.Enabled = true;
		Button2.Enabled = true;
		Button3.Enabled = true;
		Button4.Enabled = false;
		checked
		{
			if (p == 10)
			{
				Interaction.MsgBox("Has completado la trivia, estos son tus resultados: " + Conversions.ToString(c) + " correctas y " + Conversions.ToString(mal) + " incorrectas.");
				MyProject.Forms.Trivia.Show();
				Close();
				p = 0;
				c = 0;
				mal = 0;
				int num = 0;
				do
				{
					comp[num] = 0;
					num++;
				}
				while (num <= 29);
			}
			p++;
			Label2.Text = "Pregunta " + Conversions.ToString(p);
			Label1.Text = preg[(int)Math.Round(29f * VBMath.Rnd())];
			if (Operators.CompareString(Label1.Text, preg[0], TextCompare: false) == 0)
			{
				Button1.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[0] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[0]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[1], TextCompare: false) == 0)
			{
				Button1.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[1] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[1]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[2], TextCompare: false) == 0)
			{
				Button1.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[2] >= 1)
				{
					Label1.Text = preg[3];
				}
				comp[2]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[3], TextCompare: false) == 0)
			{
				Button1.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[3] >= 1)
				{
					Label1.Text = preg[4];
				}
				comp[3]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[4], TextCompare: false) == 0)
			{
				Button1.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[4] >= 1)
				{
					Label1.Text = preg[5];
				}
				comp[4]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[5], TextCompare: false) == 0)
			{
				Button1.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[5] >= 1)
				{
					Label1.Text = preg[6];
				}
				comp[5]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[6], TextCompare: false) == 0)
			{
				Button1.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[6] >= 1)
				{
					Label1.Text = preg[7];
				}
				comp[6]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[7], TextCompare: false) == 0)
			{
				Button1.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[7] >= 1)
				{
					Label1.Text = preg[8];
				}
				comp[7]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[8], TextCompare: false) == 0)
			{
				Button1.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[8] >= 1)
				{
					Label1.Text = preg[9];
				}
				comp[8]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[9], TextCompare: false) == 0)
			{
				Button1.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[9] >= 1)
				{
					Label1.Text = preg[10];
				}
				comp[9]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[10], TextCompare: false) == 0)
			{
				Button1.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[10] >= 1)
				{
					Label1.Text = preg[11];
				}
				comp[10]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[11], TextCompare: false) == 0)
			{
				Button1.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[11] >= 1)
				{
					Label1.Text = preg[12];
				}
				comp[11]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[12], TextCompare: false) == 0)
			{
				Button1.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[12] >= 1)
				{
					Label1.Text = preg[13];
				}
				comp[12]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[13], TextCompare: false) == 0)
			{
				Button1.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[13] >= 1)
				{
					Label1.Text = preg[14];
				}
				comp[13]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[14], TextCompare: false) == 0)
			{
				Button1.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[14] >= 1)
				{
					Label1.Text = preg[15];
				}
				comp[14]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[15], TextCompare: false) == 0)
			{
				Button1.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[15] >= 1)
				{
					Label1.Text = preg[16];
				}
				comp[15]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[16], TextCompare: false) == 0)
			{
				Button1.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[16] >= 1)
				{
					Label1.Text = preg[17];
				}
				comp[16]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[17], TextCompare: false) == 0)
			{
				Button1.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[17] >= 1)
				{
					Label1.Text = preg[18];
				}
				comp[17]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[18], TextCompare: false) == 0)
			{
				Button1.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[18] >= 1)
				{
					Label1.Text = preg[19];
				}
				comp[18]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[19], TextCompare: false) == 0)
			{
				Button1.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[19] >= 1)
				{
					Label1.Text = preg[20];
				}
				comp[19]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[20], TextCompare: false) == 0)
			{
				Button1.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[20] >= 1)
				{
					Label1.Text = preg[21];
				}
				comp[20]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[21], TextCompare: false) == 0)
			{
				Button1.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[21] >= 1)
				{
					Label1.Text = preg[22];
				}
				comp[21]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[22], TextCompare: false) == 0)
			{
				Button1.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[22] >= 1)
				{
					Label1.Text = preg[23];
				}
				comp[22]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[23], TextCompare: false) == 0)
			{
				Button1.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[23] >= 1)
				{
					Label1.Text = preg[24];
				}
				comp[23]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[24], TextCompare: false) == 0)
			{
				Button1.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[25], TextCompare: false) == 0)
			{
				Button1.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[24] >= 1)
				{
					Label1.Text = preg[25];
				}
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[26], TextCompare: false) == 0)
			{
				Button1.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[26] >= 1)
				{
					Label1.Text = preg[27];
				}
				comp[26]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[27], TextCompare: false) == 0)
			{
				Button1.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[27] >= 1)
				{
					Label1.Text = preg[28];
				}
				comp[27]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[28], TextCompare: false) == 0)
			{
				Button1.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[28] >= 1)
				{
					Label1.Text = preg[29];
				}
				comp[28]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[29], TextCompare: false) == 0)
			{
				Button1.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[29] >= 1)
				{
					Label1.Text = preg[0];
				}
				comp[29]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Label1.AutoSize = true;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		checked
		{
			if ((Operators.CompareString(Button1.Text, "Gótico", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Antártida", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Shakespeare", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Homero", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Amazonas", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Guepardo", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "América", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Grecia", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Mamífero", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Anónimo", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "206", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "1945", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Telescopio", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "2", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Italia", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Páncreas", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Omnívoros", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Producto", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Mandarín", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "1492", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Murciélago", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Átomo", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Café", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Dólar", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "China", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Verde", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "8", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Rusia", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "París", TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, "Baloncesto", TextCompare: false) == 0))
			{
				Label1.Text = "CORRECTO";
				c++;
			}
			else
			{
				Label1.Text = "INCORRECTO";
				mal++;
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Button1.Enabled = false;
			Button2.Enabled = false;
			Button3.Enabled = false;
			Button4.Enabled = true;
			Button4.Visible = true;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			if ((Operators.CompareString(Button2.Text, "Gótico", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Antártida", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Shakespeare", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Homero", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Amazonas", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Guepardo", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "América", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Grecia", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Mamífero", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Anónimo", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "206", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "1945", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Telescopio", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "2", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Italia", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Páncreas", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Omnívoros", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Producto", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Mandarín", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "1492", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Murciélago", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Átomo", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Café", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Dólar", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "China", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Verde", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "8", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Rusia", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "París", TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, "Baloncesto", TextCompare: false) == 0))
			{
				Label1.Text = "CORRECTO";
				c++;
			}
			else
			{
				Label1.Text = "INCORRECTO";
				mal++;
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Button1.Enabled = false;
			Button2.Enabled = false;
			Button3.Enabled = false;
			Button4.Enabled = true;
			Button4.Visible = true;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		checked
		{
			if ((Operators.CompareString(Button3.Text, "Gótico", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Antártida", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Shakespeare", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Homero", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Amazonas", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Guepardo", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "América", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Grecia", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Mamífero", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Anónimo", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "206", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "1945", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Telescopio", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "2", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Italia", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Páncreas", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Omnívoros", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Producto", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Mandarín", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "1492", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Murciélago", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Átomo", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Café", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Dólar", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "China", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Verde", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "8", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Rusia", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "París", TextCompare: false) == 0) | (Operators.CompareString(Button3.Text, "Baloncesto", TextCompare: false) == 0))
			{
				Label1.Text = "CORRECTO";
				c++;
			}
			else
			{
				Label1.Text = "INCORRECTO";
				mal++;
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Button1.Enabled = false;
			Button2.Enabled = false;
			Button3.Enabled = false;
			Button4.Enabled = true;
			Button4.Visible = true;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("¿Deseas regresar? Tu progreso sera eliminado.", "Cerrar", MessageBoxButtons.YesNo);
		if (msgBoxResult != MsgBoxResult.Yes)
		{
			return;
		}
		MyProject.Forms.Trivia.Show();
		Hide();
		p = 0;
		c = 0;
		mal = 0;
		int num = 0;
		checked
		{
			do
			{
				comp[num] = 0;
				num++;
			}
			while (num <= 29);
			Label1.Text = preg[(int)Math.Round(29f * VBMath.Rnd())];
			p = 1;
			Label2.Text = "Pregunta " + Conversions.ToString(p);
			Label1.Text = preg[(int)Math.Round(29f * VBMath.Rnd())];
			if (Label1.Size.Height > 36)
			{
				Label1.Location = new Point(254, 60);
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
			Label1.AutoSize = true;
			if (Operators.CompareString(Label1.Text, preg[0], TextCompare: false) == 0)
			{
				Button1.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[0] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[0]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p1[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[1], TextCompare: false) == 0)
			{
				Button1.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[1] >= 1)
				{
					Label1.Text = preg[1];
				}
				comp[1]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p2[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[2], TextCompare: false) == 0)
			{
				Button1.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[2] >= 1)
				{
					Label1.Text = preg[3];
				}
				comp[2]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p3[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[3], TextCompare: false) == 0)
			{
				Button1.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[3] >= 1)
				{
					Label1.Text = preg[4];
				}
				comp[3]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p4[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[4], TextCompare: false) == 0)
			{
				Button1.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[4] >= 1)
				{
					Label1.Text = preg[5];
				}
				comp[4]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p5[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[5], TextCompare: false) == 0)
			{
				Button1.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[5] >= 1)
				{
					Label1.Text = preg[6];
				}
				comp[5]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p6[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[6], TextCompare: false) == 0)
			{
				Button1.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[6] >= 1)
				{
					Label1.Text = preg[7];
				}
				comp[6]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p7[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[7], TextCompare: false) == 0)
			{
				Button1.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[7] >= 1)
				{
					Label1.Text = preg[8];
				}
				comp[7]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p8[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[8], TextCompare: false) == 0)
			{
				Button1.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[8] >= 1)
				{
					Label1.Text = preg[9];
				}
				comp[8]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p9[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[9], TextCompare: false) == 0)
			{
				Button1.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[9] >= 1)
				{
					Label1.Text = preg[10];
				}
				comp[9]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p10[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[10], TextCompare: false) == 0)
			{
				Button1.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[10] >= 1)
				{
					Label1.Text = preg[11];
				}
				comp[10]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p11[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[11], TextCompare: false) == 0)
			{
				Button1.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[11] >= 1)
				{
					Label1.Text = preg[12];
				}
				comp[11]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p12[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[12], TextCompare: false) == 0)
			{
				Button1.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[12] >= 1)
				{
					Label1.Text = preg[13];
				}
				comp[12]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p13[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[13], TextCompare: false) == 0)
			{
				Button1.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[13] >= 1)
				{
					Label1.Text = preg[14];
				}
				comp[13]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p14[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[14], TextCompare: false) == 0)
			{
				Button1.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[14] >= 1)
				{
					Label1.Text = preg[15];
				}
				comp[14]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p15[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[15], TextCompare: false) == 0)
			{
				Button1.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[15] >= 1)
				{
					Label1.Text = preg[16];
				}
				comp[15]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p16[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[16], TextCompare: false) == 0)
			{
				Button1.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[16] >= 1)
				{
					Label1.Text = preg[17];
				}
				comp[16]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p17[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[17], TextCompare: false) == 0)
			{
				Button1.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[17] >= 1)
				{
					Label1.Text = preg[18];
				}
				comp[17]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p18[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[18], TextCompare: false) == 0)
			{
				Button1.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[18] >= 1)
				{
					Label1.Text = preg[19];
				}
				comp[18]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p19[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[19], TextCompare: false) == 0)
			{
				Button1.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[19] >= 1)
				{
					Label1.Text = preg[20];
				}
				comp[19]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p20[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[20], TextCompare: false) == 0)
			{
				Button1.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[20] >= 1)
				{
					Label1.Text = preg[21];
				}
				comp[20]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p21[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[21], TextCompare: false) == 0)
			{
				Button1.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[21] >= 1)
				{
					Label1.Text = preg[22];
				}
				comp[21]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p22[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[22], TextCompare: false) == 0)
			{
				Button1.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[22] >= 1)
				{
					Label1.Text = preg[23];
				}
				comp[22]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p23[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[23], TextCompare: false) == 0)
			{
				Button1.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[23] >= 1)
				{
					Label1.Text = preg[24];
				}
				comp[23]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p24[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[24], TextCompare: false) == 0)
			{
				Button1.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p25[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[25], TextCompare: false) == 0)
			{
				Button1.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[24] >= 1)
				{
					Label1.Text = preg[25];
				}
				comp[24]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p26[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[26], TextCompare: false) == 0)
			{
				Button1.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[26] >= 1)
				{
					Label1.Text = preg[27];
				}
				comp[26]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p27[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[27], TextCompare: false) == 0)
			{
				Button1.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[27] >= 1)
				{
					Label1.Text = preg[28];
				}
				comp[27]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p28[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[28], TextCompare: false) == 0)
			{
				Button1.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[28] >= 1)
				{
					Label1.Text = preg[29];
				}
				comp[28]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p29[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			if (Operators.CompareString(Label1.Text, preg[29], TextCompare: false) == 0)
			{
				Button1.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				if (comp[29] >= 1)
				{
					Label1.Text = preg[0];
				}
				comp[29]++;
				while ((Operators.CompareString(Button1.Text, Button2.Text, TextCompare: false) == 0) | (Operators.CompareString(Button1.Text, Button3.Text, TextCompare: false) == 0) | (Operators.CompareString(Button2.Text, Button3.Text, TextCompare: false) == 0))
				{
					Button2.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
					Button3.Text = p30[(int)Math.Round(2f * VBMath.Rnd())];
				}
			}
			Label1.Left = (int)Math.Round((double)Button1.Left - (double)(Label1.Width - Button1.Width) / 2.0);
		}
	}
}
