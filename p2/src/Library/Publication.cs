using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }
        // Introduje el metodo AsText para ver el string de la publicación 
        public string AsText()
        {
            List<string> PubString = new List<string>();
            
            foreach (PublicationItem item in items)
            {
                PubString.Add($"{item.Quantity} de {item.Material.Name}, a ${item.Price}");
            }
            return string.Join(PubString.ToArray());
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
        
        
    }
}