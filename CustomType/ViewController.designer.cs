// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomType
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSSlider colorHue { get; set; }

		[Outlet]
		AppKit.NSSlider colorSaturation { get; set; }

		[Outlet]
		AppKit.NSSlider colorValue { get; set; }

		[Outlet]
		AppKit.NSColorWell colorView { get; set; }

		[Outlet]
		AppKit.NSTextField rgbValue { get; set; }

		[Action ("changeHue:")]
		partial void changeHue (AppKit.NSSlider sender);

		[Action ("changeSaturation:")]
		partial void changeSaturation (AppKit.NSSlider sender);

		[Action ("changeValue:")]
		partial void changeValue (AppKit.NSSlider sender);

		[Action ("setColor:")]
		partial void setColor (AppKit.NSButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (colorHue != null) {
				colorHue.Dispose ();
				colorHue = null;
			}

			if (colorSaturation != null) {
				colorSaturation.Dispose ();
				colorSaturation = null;
			}

			if (colorValue != null) {
				colorValue.Dispose ();
				colorValue = null;
			}

			if (colorView != null) {
				colorView.Dispose ();
				colorView = null;
			}

			if (rgbValue != null) {
				rgbValue.Dispose ();
				rgbValue = null;
			}

		}
	}
}
