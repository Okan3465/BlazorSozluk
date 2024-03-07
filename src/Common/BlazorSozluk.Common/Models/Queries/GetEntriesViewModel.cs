using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.Queries
{
    public class GetEntriesViewModel   //dışarı dönecek model
    {
        public Guid Id { get; set; }   //ekranın solunda bulunan entrylerin ID'si
        public string Subject { get; set; }  //Konusu
        public int CommentCount { get; set; }  //Yorum sayısı
    }
}
