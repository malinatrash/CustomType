using System;

namespace CustomType
{
    public class HSV
    {
        private double _hue;
        private double _saturation;
        private double _value;

        public HSV(double hue, double saturation, double value)
        {
            this._hue = hue;
            this._saturation = saturation;
            this._value = value;
        }

        public double Hue
        {
            get { return this._hue; }
            set { this._hue = value; }
        }

        public double Saturation
        {
            get { return this._saturation; }
            set { this._saturation = value; }
        }

        public double Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public bool Equals(HSV hsv)
        {
            return (this.Hue == hsv.Hue) && (this.Saturation == hsv.Saturation) && (this.Value == hsv.Value);
        }
    }
}