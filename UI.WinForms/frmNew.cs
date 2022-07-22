using System.Windows.Forms;
using UI.WinForms.Library;

namespace UI.WinForms {
	public partial class frmNew : Form {
		public frmNew ( ) {
			this.InitializeComponent ();
		}

		internal frmNew ( EFileType filter ) : this () {
			// Filter visible components
			if ( filter > 0 ) {
				this.Filter = filter;
			}
		}

		internal EFileType Filter { get; set; } = EFileType.None;


	}
}
