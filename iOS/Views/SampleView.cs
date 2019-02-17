using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace SectionListMvvmCross.iOS.Views
{
    public partial class SampleView : MvxViewController<SampleViewModel>
    {
        private BooksViewSource booksCollectionViewSource;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitializeUI();
            CreateBindings();
        }

        private void CreateBindings()
        {
            booksCollectionView.Source = booksCollectionViewSource = new BooksViewSource(booksCollectionView);

            var set = this.CreateBindingSet<SampleView, SampleViewModel>();
            set.Bind(booksCollectionViewSource).For(v => v.ItemsSource).To(vm => vm.SectionedList);
            set.Apply();
        }
    }
}
