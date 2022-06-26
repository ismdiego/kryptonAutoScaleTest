using System.Windows.Forms;

namespace AutoScaleTest
{
    public partial class ChildForm : Form
    {
        #region Public Constructors

        public ChildForm()
        {
            InitializeComponent();

            this.AutoScaleManual();
        }

        #endregion Public Constructors
    }
}