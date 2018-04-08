using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.sinif.islem
{
    class Stringislemler
    {


        public static string TurkceKarakterCevir(string data)
        {
            data = data.Replace(",", "").Replace("\"", "").Replace("'", "").Replace(":", "").Replace(";", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(")", "").Replace("(", " ").Replace("&", " ").Replace(" ", " ").Replace("#", "sharp");

            if (data.Length > 255) // siz isterseniz bu sayıyı düşürüp artırabilirsiniz.
            {
                data = data.Substring(0, 255);
                data = data.Substring(0, data.LastIndexOf(" "));
            }
            data = data.Replace(" ", "-").ToLower(); // boşluk karakterini - ile değiştiriyoruz
            // son olarak ise türkçe karakterlerimizi değiştirerek linklerde oluşabilecek hataların önüne geçiyoruz
            // return ile de son halini geri döndürüyoruz.
            return data.Replace("ş", "s").Replace("Ş", "s").Replace("ç", "c").Replace("Ç", "c").Replace("ö", "o").Replace("Ö", "o").Replace("ü", "u").Replace("Ü", "u").Replace("İ", "i").Replace("ı", "i").Replace("ğ", "g").Replace("Ğ", "g");
        }

    }
}
