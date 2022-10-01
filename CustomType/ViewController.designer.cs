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
		AppKit.NSTextField blueLabel { get; set; }

		[Outlet]
		AppKit.NSTextField blueTF { get; set; }

		[Outlet]
		AppKit.NSSlider colorHue { get; set; }

		[Outlet]
		AppKit.NSSlider colorSaturation { get; set; }

		[Outlet]
		AppKit.NSSlider colorValue { get; set; }

		[Outlet]
		AppKit.NSColorWell colorView { get; set; }

		[Outlet]
		AppKit.NSTextField greenLabel { get; set; }

		[Outlet]
		AppKit.NSTextField greenTF { get; set; }

		[Outlet]
		AppKit.NSTextField redLabel { get; set; }

		[Outlet]
		AppKit.NSTextField redTF { get; set; }

		[Action ("changeHue:")]
		partial void changeHue (AppKit.NSSlider sender);

		[Action ("changeSaturation:")]
		partial void changeSaturation (AppKit.NSSlider sender);

		[Action ("changeValue:")]
		partial void changeValue (AppKit.NSSlider sender);

		[Action ("refreshColor:")]
		partial void refreshColor (AppKit.NSButton sender);

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

			if (redLabel != null) {
				redLabel.Dispose ();
				redLabel = null;
			}

			if (redTF != null) {
				redTF.Dispose ();
				redTF = null;
			}

			if (greenLabel != null) {
				greenLabel.Dispose ();
				greenLabel = null;
			}

			if (greenTF != null) {
				greenTF.Dispose ();
				greenTF = null;
			}

			if (blueLabel != null) {
				blueLabel.Dispose ();
				blueLabel = null;
			}

			if (blueTF != null) {
				blueTF.Dispose ();
				blueTF = null;
			}

		}
	}
}
