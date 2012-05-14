// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ioscore
{
	[Register ("ios_coreViewController")]
	partial class ios_coreViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel theLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (theLabel != null) {
				theLabel.Dispose ();
				theLabel = null;
			}
		}
	}
}
