using System;
using System.Drawing;
using AppKit;
using CoreGraphics;
using Foundation;

namespace CustomType
{
    public partial class ViewController : NSViewController
    {
        // RGB value = HSVToRGB(color);
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            colorView.Color = NSColor.FromRgb(colorHue.IntValue, colorSaturation.IntValue, colorValue.IntValue);
        }

        public override NSObject RepresentedObject
        {
            get { return base.RepresentedObject; }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void changeHue(NSSlider sender)
        {
            HSV color = new HSV(colorHue.IntValue, colorSaturation.IntValue, colorValue.IntValue);
            RGB value = Logic.HSVToRGB(color);
            colorView.Color = NSColor.FromRgb(value.RedComponent, value.GreenComponent, value.BlueComponent);

            redTF.StringValue = $"{value.RedComponent}";
            greenTF.StringValue = $"{value.BlueComponent}";
            blueTF.StringValue = $"{value.GreenComponent}";
        }


        partial void changeValue(NSSlider sender)
        {
            HSV color = new HSV(colorHue.IntValue, colorSaturation.IntValue, colorValue.IntValue);
            RGB value = Logic.HSVToRGB(color);
            colorView.Color = NSColor.FromRgb(value.RedComponent, value.GreenComponent, value.BlueComponent);
            redTF.StringValue = $"{value.RedComponent}";
            greenTF.StringValue = $"{value.BlueComponent}";
            blueTF.StringValue = $"{value.GreenComponent}";
        }

        partial void changeSaturation(NSSlider sender)
        {
            HSV color = new HSV(colorHue.IntValue, colorSaturation.IntValue, colorValue.IntValue);
            RGB value = Logic.HSVToRGB(color);
            colorView.Color = NSColor.FromRgb(value.RedComponent, value.GreenComponent, value.BlueComponent);
            redTF.StringValue = $"{value.RedComponent}";
            greenTF.StringValue = $"{value.BlueComponent}";
            blueTF.StringValue = $"{value.GreenComponent}";
        }

        partial void refreshColor(NSButton sender)
        {
            colorView.Color = NSColor.FromRgb(redTF.IntValue, greenTF.IntValue, blueTF.IntValue);
            colorHue.DoubleValue = Logic.RGBToHSV(redTF.IntValue, greenTF.IntValue, blueTF.IntValue).Hue;
            colorSaturation.DoubleValue = Logic.RGBToHSV(redTF.IntValue, greenTF.IntValue, blueTF.IntValue).Saturation;
            colorValue.DoubleValue = Logic.RGBToHSV(redTF.IntValue, greenTF.IntValue, blueTF.IntValue).Value;
        }
    }
}