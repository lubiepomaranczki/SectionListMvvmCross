using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace SectionListMvvmCross.iOS.SupportViews
{
    public class BookCell : MvxCollectionViewCell
    {
        public static NSString Key = new NSString("BookCell");

        private UILabel bookName;
        private UILabel bookAuthor;

        public BookCell(IntPtr handle) : base(string.Empty, handle)
        {
            InitializeUi();
            InitializeBindings();
        }

        private void InitializeUi()
        {
            bookName = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            Add(bookName);

            bookName.LeftAnchor.ConstraintEqualTo(LeftAnchor, 8).Active = true;
            bookName.TopAnchor.ConstraintEqualTo(TopAnchor, 8).Active = true;
            bookName.RightAnchor.ConstraintEqualTo(RightAnchor, 8).Active = true;

            bookAuthor = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            Add(bookAuthor);

            bookAuthor.LeftAnchor.ConstraintEqualTo(LeftAnchor, 8).Active = true;
            bookAuthor.TopAnchor.ConstraintEqualTo(bookName.BottomAnchor, 8).Active = true;
            bookAuthor.RightAnchor.ConstraintEqualTo(RightAnchor, 8).Active = true;
            bookAuthor.BottomAnchor.ConstraintEqualTo(BottomAnchor, -8).Active = true;
        }

        private void InitializeBindings()
        {
            this.DelayBind(() =>
            {
                var set = (this).CreateBindingSet<BookCell, BookItem>();
                set.Bind(bookName).To(vm => vm.Name);
                set.Bind(bookAuthor).To(vm => vm.Author);
                set.Apply();
            });
        }
    }
}
