using Newtonsoft.Json;
using System;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public class Size
    {
        [JsonProperty(Order = 35, PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(Order = 36, PropertyName = "height")]
        public int Height { get; set; }

        public override string ToString()
        {
            return Width + "," + Height;
        }



        public static Size Confine(int boundingSquare, Size imageSize)
        {
            return Confine(new Size { Width = boundingSquare, Height = boundingSquare }, imageSize);
        }

        public static Size Confine(Size requiredSize, Size imageSize)
        {
            if (imageSize.Width <= requiredSize.Width && imageSize.Height <= requiredSize.Height)
            {
                return imageSize;
            }
            var scaleW = requiredSize.Width / (double)imageSize.Width;
            var scaleH = requiredSize.Height / (double)imageSize.Height;
            var scale = Math.Min(scaleW, scaleH);
            return new Size
            {
                Width = (int)Math.Round((imageSize.Width * scale)),
                Height = (int)Math.Round((imageSize.Height * scale))
            };
        }
    }
}
