using MvvmCross.ViewModels;
using System.Collections.ObjectModel;

namespace SectionListMvvmCross
{
    public class SampleViewModel : MvxViewModel
    {
        public SampleViewModel()
        {
            SectionedList = new ObservableCollection<BookItem>
            {
                new BookItem("Clean code","Robert C. Martin"),
                new BookItem("Software craftsmanship","Sandro Mancuso")
            };
        }

        public ObservableCollection<BookItem> SectionedList { get; set; }
    }

    public class BookItem
    {
        public BookItem(string name, string author)
        {
            Author = author;
            Name = name;
        }

        public string Author { get; set; }

        public string Name { get; set; }
    }
}
