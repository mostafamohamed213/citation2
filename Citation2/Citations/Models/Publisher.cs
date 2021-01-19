using System;
using System.Collections.Generic;

#nullable disable

namespace Citations.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
            ConferenceProceedings = new HashSet<ConferenceProceeding>();
            Magazines = new HashSet<Magazine>();
        }

        public int Publisherid { get; set; }
        public string Name { get; set; }
        public int? Institutionid { get; set; }
        public int? TypeOfPublisher { get; set; }
        public int Country { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual TypeOfPublisher TypeOfPublisherNavigation { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<ConferenceProceeding> ConferenceProceedings { get; set; }
        public virtual ICollection<Magazine> Magazines { get; set; }
    }
}
