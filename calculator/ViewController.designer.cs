// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace calculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ResultLabel { get; set; }

		[Action ("AcButton:")]
		partial void AcButton (Foundation.NSObject sender);

		[Action ("buttonAdd:")]
		partial void buttonAdd (Foundation.NSObject sender);

		[Action ("buttonDivide:")]
		partial void buttonDivide (Foundation.NSObject sender);

		[Action ("buttonDot:")]
		partial void buttonDot (Foundation.NSObject sender);

		[Action ("buttonEight:")]
		partial void buttonEight (Foundation.NSObject sender);

		[Action ("buttonFive:")]
		partial void buttonFive (Foundation.NSObject sender);

		[Action ("buttonFour:")]
		partial void buttonFour (Foundation.NSObject sender);

		[Action ("buttonNine:")]
		partial void buttonNine (Foundation.NSObject sender);

		[Action ("buttonOne:")]
		partial void buttonOne (Foundation.NSObject sender);

		[Action ("buttonResult:")]
		partial void buttonResult (Foundation.NSObject sender);

		[Action ("buttonSeven:")]
		partial void buttonSeven (Foundation.NSObject sender);

		[Action ("buttonSix:")]
		partial void buttonSix (Foundation.NSObject sender);

		[Action ("buttonSubtract:")]
		partial void buttonSubtract (Foundation.NSObject sender);

		[Action ("buttonThree:")]
		partial void buttonThree (Foundation.NSObject sender);

		[Action ("buttonTimes:")]
		partial void buttonTimes (Foundation.NSObject sender);

		[Action ("buttonTwo:")]
		partial void buttonTwo (Foundation.NSObject sender);

		[Action ("buttonZero:")]
		partial void buttonZero (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
		}
	}
}
