using UIKit;
using SectionListMvvmCross.iOS.SupportViews;
using CoreGraphics;
using System.Drawing;

namespace SectionListMvvmCross.iOS.Views
{
    public partial class SampleView
    {
        private SampleCollectionView booksCollectionView;

        private void InitializeUI()
        {
            EdgesForExtendedLayout = UIRectEdge.None;
            View.BackgroundColor = UIColor.FromRGB(40, 40, 40);

            var container = new UIView
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            Add(container);
            container.LeftAnchor.ConstraintEqualTo(View.LeftAnchor).Active = true;
            container.TopAnchor.ConstraintEqualTo(View.TopAnchor).Active = true;
            container.RightAnchor.ConstraintEqualTo(View.RightAnchor).Active = true;
            container.BottomAnchor.ConstraintEqualTo(View.BottomAnchor).Active = true;

            var infoLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "This is a sample View with UICollectionView",
                TextColor = UIColor.FromRGB(245, 241, 230)
            };

            container.Add(infoLabel);
            infoLabel.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            infoLabel.TopAnchor.ConstraintEqualTo(View.TopAnchor, 16).Active = true;
            infoLabel.HeightAnchor.ConstraintEqualTo(50).Active = true;

            var flowLayout = new UICollectionViewFlowLayout
            {
                ItemSize = new CGSize(View.Frame.Width, 100),
                ScrollDirection = UICollectionViewScrollDirection.Vertical,
                MinimumInteritemSpacing = 4,
                MinimumLineSpacing = 4,
                HeaderReferenceSize = new CGSize(View.Frame.Width, 50),
                SectionInset = new UIEdgeInsets(4, 0, 4, 0)
            };

            booksCollectionView = new SampleCollectionView(flowLayout)
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = UIColor.Clear
            };

            container.Add(booksCollectionView);
            booksCollectionView.LeftAnchor.ConstraintEqualTo(View.LeftAnchor, 8).Active = true;
            booksCollectionView.TopAnchor.ConstraintEqualTo(infoLabel.BottomAnchor, 8).Active = true;
            booksCollectionView.RightAnchor.ConstraintEqualTo(View.RightAnchor, -8).Active = true;
            booksCollectionView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor).Active = true;
        }
    }
}
