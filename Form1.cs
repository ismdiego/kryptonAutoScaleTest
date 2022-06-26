using System.Drawing;
using System.Windows.Forms;

namespace AutoScaleTest
{
    public partial class Form1 : Form
    {
        #region Public Constructors

        public Form1()
        {
            InitializeComponent();

            var scaleFactor = 2.0f;
            this.lblScaleFactor.Text = $"Current scale factor: {scaleFactor:0.00}";

            var font = this.Font;
            var scaledFont = new Font(font.FontFamily, font.Size * scaleFactor, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);

            DisplayExtensions.SetDisplaySettings(font.SizeInPoints, scaledFont, scaleFactor, scaleFactor);

            // NOTE: Change Krypton control BaseFontSize if palette is paletteBase
            //if (this.kryptonManager1.GlobalPalette is PaletteBase paletteBase) paletteBase.BaseFontSize *= scaleFactor;

            this.AutoScaleManual();
        }

        #endregion Public Constructors

        #region Private Methods

        private void button1_Click(object sender, System.EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.ShowDialog(this);
        }

        #endregion Private Methods
    }
}