using System;

namespace CustomType
{
    public class RGB
    {
        private byte _redComponent;
        private byte _greenComponent;
        private byte _blueComponent;

        public RGB(byte redComponent, byte greenComponent, byte blueComponent)
        {
            this._redComponent = redComponent;
            this._greenComponent = greenComponent;
            this._blueComponent = blueComponent;
        }

        public byte RedComponent
        {
            get { return this._redComponent; }
            set { this._redComponent = value; }
        }

        public byte GreenComponent
        {
            get { return this._greenComponent; }
            set { this._greenComponent = value; }
        }

        public byte BlueComponent
        {
            get { return this._blueComponent; }
            set { this._blueComponent = value; }
        }

        public bool Equals(RGB rgb)
        {
            return (this.RedComponent == rgb.RedComponent)
                   && (this.GreenComponent == rgb.GreenComponent)
                   && (this.BlueComponent == rgb.BlueComponent);
        }
    }
}