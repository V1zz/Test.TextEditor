using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test.TextEditor
{
	public interface IStartForm
	{
		string FilePath { get; }
		string Content { get; set; }

		void SetSymbolCount(int count);

		event EventHandler FileOpenClick;
		event EventHandler FileSaveClick;
		event EventHandler ContentChanged;
	}

	public partial class StartForm : Form, IStartForm
	{
		public StartForm()
		{
			InitializeComponent();

			btnOpenFile.Click += new EventHandler(BtnOpenFile_Click);
			btnSaveFile.Click += BtnSaveFile_Click;
			tBoxContent.TextChanged += TBoxContent_TextChanged;
            btnSelectFile.Click += BtnSelectFile_Click;
            tBoxFontSize.ValueChanged += TBoxFontSize_ValueChanged;
		}

        #region IStartForm implementation

        public string FilePath => tBoxFilePath.Text;

		public string Content
		{
			get => tBoxContent.Text;
			set => tBoxContent.Text = value 
								   ?? throw new ArgumentNullException(paramName: value, 
																	  message: "Attempt to set NULL value in the field \\'tBoxContent\\'");
		}

		public void SetSymbolCount(int count)
		{
			sSLblSymbolsCountPrintOut.Text = count.ToString();
		}

		public event EventHandler FileOpenClick;
		public event EventHandler FileSaveClick;
		public event EventHandler ContentChanged;

        #endregion

        #region EVENTS FORWARDING

        private void BtnOpenFile_Click(object sender, EventArgs e)
		{
			FileOpenClick?.Invoke(this, EventArgs.Empty);
			//if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);  ===>  Original code 
		}

		private void BtnSaveFile_Click(object sender, EventArgs e)
		{
			FileOpenClick?.Invoke(this, EventArgs.Empty);
			//if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);  ===>  Original code 
		}

		private void TBoxContent_TextChanged(object sender, EventArgs e) 
		{
			FileOpenClick?.Invoke(this, EventArgs.Empty);
			//if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);  ===>  Original code 
		}

		#endregion

		#region Internal controls.

		///<summary>
		///      Calls the standard file attachment dialog box, 
		///    from the property of which the string value of the path to the file 
		///    is assigned to the "FilePath" property after clicking "OK" button.
		///    The default display type is "* .tхt", but all types can be selected.
		///      When the user has selected the file, there is a need for confirmation by pressing the "OK" button. 
		///    Calling the event again at the end of the function makes this easier by 2 clicks on the selected file.
		///</summary>
		private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Text files|*.txt|All files|*.*" };

			//Setting "FilePath" property to the string value of the path to the selected file, if "OK" is pressed.
			if (dialog.ShowDialog() == DialogResult.OK)
            {
                tBoxFilePath.Text = dialog.FileName;
				FileOpenClick?.Invoke(this, EventArgs.Empty);
            }
        }

		/// <summary>
		///		При установке размера шрифта значение Font Family будет заменено программным значением по умолчанию ().
		/// </summary>
		/// <defaults>
		///		<fontFamily> Calibri </fontFamily>
		/// </defaults>
		private void TBoxFontSize_ValueChanged(object sender, EventArgs e)
		{
			tBoxContent.Font = new Font("Calibri", (float)tBoxFontSize.Value);
		}

        #endregion

        private void tBoxContent_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
