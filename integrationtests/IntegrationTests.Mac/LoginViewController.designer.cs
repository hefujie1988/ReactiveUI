// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IntegrationTests.Mac
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		AppKit.NSButton CancelButton { get; set; }

		[Outlet]
		AppKit.NSButton LoginButton { get; set; }

		[Outlet]
		AppKit.NSSecureTextField PasswordField { get; set; }

		[Outlet]
		AppKit.NSTextField UsernameField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (UsernameField != null) {
				UsernameField.Dispose ();
				UsernameField = null;
			}

			if (PasswordField != null) {
				PasswordField.Dispose ();
				PasswordField = null;
			}

			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}

			if (LoginButton != null) {
				LoginButton.Dispose ();
				LoginButton = null;
			}
		}
	}
}
