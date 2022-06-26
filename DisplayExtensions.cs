using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoScaleTest
{
    internal static class DisplayExtensions
    {
        #region Public Constructors

        static DisplayExtensions()
        {
            ScaleFactorF = new SizeF(1.0f, 1.0f);
            ScaleFactorF1 = new SizeF(1.0f, 1.0f);
        }

        #endregion Public Constructors

        #region Properties

        public static float BaseFontSize { get; private set; }
        public static Font ScaledFont { get; private set; }
        public static SizeF ScaleFactorF { get; private set; }

        private static SizeF ScaleFactorF1 { get; set; }

        #endregion Properties

        #region Public Methods

        public static void AutoScaleManual(this Form form)
        {
            if (ScaleFactorF == ScaleFactorF1) return;

            try
            {
                foreach (Control control in form.Controls)
                {
                    AutoScaleManualInternal(control);
                }

                form.Width = (int)(form.Width * ScaleFactorF.Width);
                form.Height = (int)(form.Height * ScaleFactorF.Height);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, $"Error at {nameof(AutoScaleManual)} for {nameof(Form)} {form.Name}");
            }
        }

        public static void AutoScaleManual(this UserControl userControl)
        {
            if (ScaleFactorF == ScaleFactorF1) return;

            try
            {
                AutoScaleManualInternal(userControl);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, $"Error at {nameof(AutoScaleManual)} for {nameof(UserControl)} {userControl.Name}");
            }
        }

        public static void SetDisplaySettings(float baseFontSize, Font scaledFont, float scaleFactorWidth, float scaleFactorHeight)
        {
            DisplayExtensions.BaseFontSize = baseFontSize;
            DisplayExtensions.ScaledFont = scaledFont;
            DisplayExtensions.ScaleFactorF = new SizeF(scaleFactorWidth, scaleFactorHeight);
        }

        #endregion Public Methods

        #region Private Methods

        private static void AutoScaleManualInternal(Control control)
        {
            if (control.Dock != DockStyle.Fill)
            {
                control.Left = (int)(control.Left * ScaleFactorF.Width);
                control.Top = (int)(control.Top * ScaleFactorF.Height);
                control.Width = (int)(control.Size.Width * ScaleFactorF.Width);
                control.Height = (int)(control.Size.Height * ScaleFactorF.Height);
            }

            control.Margin = new Padding(
                (int)(control.Margin.Left * ScaleFactorF.Width),
                (int)(control.Margin.Top * ScaleFactorF.Height),
                (int)(control.Margin.Right * ScaleFactorF.Width),
                (int)(control.Margin.Bottom * ScaleFactorF.Height)
            );

            control.Padding = new Padding(
                (int)(control.Padding.Left * ScaleFactorF.Width),
                (int)(control.Padding.Top * ScaleFactorF.Height),
                (int)(control.Padding.Right * ScaleFactorF.Width),
                (int)(control.Padding.Bottom * ScaleFactorF.Height)
            );

            if (control.Font.SizeInPoints == BaseFontSize)
            {
                control.Font = ScaledFont;
            }
            else
            {
                var font = control.Font;
                var scaleFactor = font.SizeInPoints / BaseFontSize;
                control.Font = new Font(font.FontFamily, font.Size * scaleFactor, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }

            foreach (Control child in control.Controls)
            {
                AutoScaleManualInternal(child);
            }
        }

        #endregion Private Methods
    }
}