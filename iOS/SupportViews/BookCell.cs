using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using SectionListMvvmCross.Models;
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
            var viewHolder = new UIView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = UIColor.FromRGB(245, 241, 230)
            };
            Add(viewHolder);
            viewHolder.LeftAnchor.ConstraintEqualTo(LeftAnchor, 8).Active = true;
            viewHolder.TopAnchor.ConstraintEqualTo(TopAnchor).Active = true;
            viewHolder.RightAnchor.ConstraintEqualTo(RightAnchor, -8).Active = true;
            viewHolder.BottomAnchor.ConstraintEqualTo(BottomAnchor).Active = true;
            viewHolder.Layer.CornerRadius = 8;

            bookName = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            viewHolder.Add(bookName);

            bookName.LeftAnchor.ConstraintEqualTo(viewHolder.LeftAnchor, 8).Active = true;
            bookName.TopAnchor.ConstraintEqualTo(viewHolder.TopAnchor, 8).Active = true;
            bookName.RightAnchor.ConstraintEqualTo(viewHolder.RightAnchor, -8).Active = true;

            bookAuthor = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            viewHolder.Add(bookAuthor);

            bookAuthor.LeftAnchor.ConstraintEqualTo(viewHolder.LeftAnchor, 8).Active = true;
            bookAuthor.TopAnchor.ConstraintEqualTo(bookName.BottomAnchor, 8).Active = true;
            bookAuthor.RightAnchor.ConstraintEqualTo(viewHolder.RightAnchor, -8).Active = true;
            bookAuthor.BottomAnchor.ConstraintEqualTo(viewHolder.BottomAnchor, -8).Active = true;
        }

        private void InitializeBindings()
        {
            this.DelayBind(() =>
            {
                var set = (this).CreateBindingSet<BookCell, Book>();
                set.Bind(bookName).To(vm => vm.Name);
                set.Bind(bookAuthor).To(vm => vm.Author);
                set.Apply();
            });
        }
    }
}
