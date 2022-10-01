using System;

namespace CustomType
{
    public class Logic
    {
        public static RGB HSVToRGB(HSV colorHSV)
            {
                double red = 0, green = 0, blue = 0;
        
                if (colorHSV.Saturation == 0)
                {
                    red = colorHSV.Value;
                    green = colorHSV.Value;
                    blue = colorHSV.Value;
                }
                else
                {
                    int i;
                    double f, p, q, t;
        
                    if (colorHSV.Hue == 360)
                        colorHSV.Hue = 0;
                    else
                        colorHSV.Hue = colorHSV.Hue / 60;
        
                    i = (int)Math.Truncate(colorHSV.Hue);
                    f = colorHSV.Hue - i;
        
                    p = colorHSV.Value * (1.0 - colorHSV.Saturation);
                    q = colorHSV.Value * (1.0 - (colorHSV.Saturation * f));
                    t = colorHSV.Value * (1.0 - (colorHSV.Saturation * (1.0 - f)));
        
                    switch (i)
                    {
                        case 0:
                            red = colorHSV.Value;
                            green = t;
                            blue = p;
                            break;
        
                        case 1:
                            red = q;
                            green = colorHSV.Value;
                            blue = p;
                            break;
        
                        case 2:
                            red = p;
                            green = colorHSV.Value;
                            blue = t;
                            break;
        
                        case 3:
                            red = p;
                            green = q;
                            blue = colorHSV.Value;
                            break;
        
                        case 4:
                            red = t;
                            green = p;
                            blue = colorHSV.Value;
                            break;
        
                        default:
                            red = colorHSV.Value;
                            green = p;
                            blue = q;
                            break;
                    }
                }
        
                return new RGB((byte)(red * 255), (byte)(green * 255), (byte)(blue * 255));
            }
        public static HSV RGBToHSV(int red, int green, int blue)
        {
            double delta, min;
            double h = 0, s, v;

            min = Math.Min(Math.Min(red, green), blue);
            v = Math.Max(Math.Max(red, green), blue);
            delta = v - min;

            if (v == 0.0)
                s = 0;
            else
                s = delta / v;

            if (s == 0)
                h = 0.0;

            else
            {
                if (red == v)
                    h = (green - blue) / delta;
                else if (green == v)
                    h = 2 + (blue - red) / delta;
                else if (blue == v)
                    h = 4 + (red - green) / delta;

                h *= 60;

                if (h < 0.0)
                    h = h + 360;
            }

            return new HSV(h, s, (v / 255));
        }
    }
}