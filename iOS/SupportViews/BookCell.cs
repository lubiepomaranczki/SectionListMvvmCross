using System;
using FFImageLoading.Cross;
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
        private MvxCachedImageView bookThumbnail;

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

            bookThumbnail = new MvxCachedImageView
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            viewHolder.Add(bookThumbnail);

            bookThumbnail.LeftAnchor.ConstraintEqualTo(viewHolder.LeftAnchor, 8).Active = true;
            bookThumbnail.CenterYAnchor.ConstraintEqualTo(viewHolder.CenterYAnchor).Active = true;
            bookThumbnail.HeightAnchor.ConstraintEqualTo(75).Active = true;
            bookThumbnail.WidthAnchor.ConstraintEqualTo(60).Active = true;
            bookThumbnail.Layer.MasksToBounds = true;
            bookThumbnail.Layer.CornerRadius = 4;

            var textContainer = new UIView
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            viewHolder.Add(textContainer);

            textContainer.LeftAnchor.ConstraintEqualTo(bookThumbnail.RightAnchor, 8).Active = true;
            textContainer.RightAnchor.ConstraintEqualTo(viewHolder.RightAnchor, -8).Active = true;
            textContainer.TopAnchor.ConstraintEqualTo(bookThumbnail.TopAnchor).Active = true;

            bookName = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            textContainer.Add(bookName);

            bookName.LeftAnchor.ConstraintEqualTo(textContainer.LeftAnchor).Active = true;
            bookName.TopAnchor.ConstraintEqualTo(textContainer.TopAnchor).Active = true;
            bookName.RightAnchor.ConstraintEqualTo(textContainer.RightAnchor).Active = true;

            bookAuthor = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            textContainer.Add(bookAuthor);

            bookAuthor.LeftAnchor.ConstraintEqualTo(textContainer.LeftAnchor).Active = true;
            bookAuthor.TopAnchor.ConstraintEqualTo(bookName.BottomAnchor, 4).Active = true;
            bookAuthor.RightAnchor.ConstraintEqualTo(textContainer.RightAnchor).Active = true;
            bookAuthor.BottomAnchor.ConstraintEqualTo(textContainer.BottomAnchor).Active = true;
        }

        private void InitializeBindings()
        {
            this.DelayBind(() =>
            {
                var set = (this).CreateBindingSet<BookCell, Book>();
                set.Bind(bookThumbnail).For(c => c.ImagePath).To(vm => vm.PhotoUri);
                set.Bind(bookName).To(vm => vm.Name);
                set.Bind(bookAuthor).To(vm => vm.Author);
                set.Apply();
            });
        }
    }
}
