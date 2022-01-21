using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class ItemModel
    {
        [Key]
        public string item_id { get; set; }

        public string item_name { get; set; }

        public float price { get; set; }

        public string descript { get; set; }

        public bool availability { get; set; }

        public float popularity { get; set; }

        public string m_type { get; set; }

        public byte[] Itemimage { get; set; }

        public Image BinaryToImageConv(byte[] binaryData)
        {
            MemoryStream ms = new MemoryStream(binaryData);
            Image img = Image.FromStream(ms);
            return img;
        }

        public byte[] ImageToBinaryConv(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

    }
}