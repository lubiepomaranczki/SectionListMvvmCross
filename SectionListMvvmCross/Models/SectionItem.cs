using System.Collections.Generic;

namespace SectionListMvvmCross.Models
{
    public class SectionItem
    {
        public SectionItem(string headerText, IList<Book> collection)
        {
            HeaderText = headerText;
            Collection = collection;
        }

        public string HeaderText { get; set; }

        public IList<Book> Collection { get; set; }
    }
}
