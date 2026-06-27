using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Skillful;

public class limpiar
{
	public void LimpiarCampos(Form control)
	{
		foreach (object control2 in control.Controls)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(control2);
			if (objectValue is TextBox)
			{
				TextBox textBox = (TextBox)objectValue;
				textBox.Clear();
			}
		}
	}
}
