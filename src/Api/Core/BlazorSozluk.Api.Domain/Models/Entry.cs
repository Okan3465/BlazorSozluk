using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Domain.Models
{
    public  class Entry :BaseEntity
    {
        public string Subject { get; set; }

        public string Content { get; set; }

        public Guid CreatedById { get; set; }  //Entryi'i oluşturan kişinin ID'si                                            
        public virtual User CreatedBy { get; set; } //yukarıdaki ID'den User'a ulaşabilmem lazım

        public virtual ICollection<EntryComment> EntryComments { get; set; }  //Birden fazla yorum olacağı için ICollection kullanıyoruz.
                                                                              //ilişkiler kurulurken virtual tanımlanmazsa include ederken hata alınır.
                                                                              //Virtual olarak tanımlıyoruz kullanmadığımız zaman da hata almasın
        public virtual ICollection<EntryVote> EntryVotes { get; set; }
        public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }
    }
}
