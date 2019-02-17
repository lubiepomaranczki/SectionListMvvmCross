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
                        new Book("Clean code","Robert C. Martin","https://images-na.ssl-images-amazon.com/images/I/515iEcDr1GL._SX385_BO1,204,203,200_.jpg"),
                        new Book("Software craftsmanship","Sandro Mancuso","https://static01.helion.com.pl/global/okladki/326x466/80afbd7391cf9f41dd07ee5f862de25b,prorze.jpg") }),
                new SectionItem("Horrors", new List<Book>{
                        new Book("IT","Stephen King","https://prodimage.images-bn.com/pimages/9781501175466_p0_v2_s550x406.jpg"),
                        new Book("Birdbox","Josh Malerman","https://images-na.ssl-images-amazon.com/images/I/51Dp6C5wjFL._SX325_BO1,204,203,200_.jpg"),
                        new Book("Shining", "Stephen King","https://prodimage.images-bn.com/pimages/9780525565321_p0_v2_s550x406.jpg"),
                        new Book("Dracula", "Bram Stoker","https://images-na.ssl-images-amazon.com/images/I/51Z040Fzy3L._SX321_BO1,204,203,200_.jpg")}),
                new SectionItem("Thrillers", new List<Book>{
                        new Book("Gone girl","Gillian Flynn","https://images-na.ssl-images-amazon.com/images/I/416TH3igfOL._SX322_BO1,204,203,200_.jpg"),
                        new Book("The Girl on the Train","Paula Hawkins","https://images-na.ssl-images-amazon.com/images/I/8183Y1myPvL.jpg"),
                        new Book("The Girl with the Dragon Tattoo", "Stieg Larson","https://cdn.waterstones.com/override/v1/large/9780/8570/9780857054036.jpg"),
                        new Book("The Girl Who Played with Fire", "Stieg Larson","https://images-na.ssl-images-amazon.com/images/I/51TDyDCQCZL._SX277_BO1,204,203,200_.jpg"),
                        new Book("The Girl Who Kicked the Hornets' Nest", "Stieg Larson","https://images-na.ssl-images-amazon.com/images/I/51wARxtg-HL._SX338_BO1,204,203,200_.jpg")})
            };
        }
    }
}
