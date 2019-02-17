using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCross.Commands;
using System;
using SectionListMvvmCross.Models;

namespace SectionListMvvmCross
{
    public class SampleViewModel : MvxViewModel
    {
        public SampleViewModel()
        {
            InitList();
        }

        public ObservableCollection<SectionItem> SectionedList { get; set; }

        public ICommand ItemSelectedCmd => new MvxCommand<Book>(ItemSelected);

        private void ItemSelected(Book book)
        {
            Console.WriteLine(book);
        }

        private void InitList()
        {
            SectionedList = new ObservableCollection<SectionItem>
            {
                new SectionItem("Programming books", new List<Book>{
                        new Book("Clean code","Robert C. Martin"),
                        new Book("Software craftsmanship","Sandro Mancuso") }),
                new SectionItem("Horrors", new List<Book>{
                        new Book("IT","Stephen King"),
                        new Book("Birdbox","Josh Malerman"),
                        new Book("Shining", "Stephen King"),
                        new Book("Dracula", "Bram Stoker")}),
                new SectionItem("Thrillers", new List<Book>{
                        new Book("Gone girl","Gillian Flynn"),
                        new Book("The Girl on the Train","Paula Hawkins"),
                        new Book("The Girl with the Dragon Tattoo", "Stieg Larson"),
                        new Book("The Girl Who Played with Fire", "Stieg Larson"),
                        new Book("The Girl Who Kicked the Hornets' Nest", "Stieg Larson")})
            };
        }
    }
}
