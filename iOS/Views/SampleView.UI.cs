using UIKit;

namespace SectionListMvvmCross.iOS.Views
{
    public partial class SampleView
    {
        private void InitializeUI()
        {
            EdgesForExtendedLayout = UIRectEdge.None;
            View.BackgroundColor = UIColor.White;

            var container = new UIView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = UIColor.Cyan
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
                TextColor = UIColor.Black
            };

            container.Add(infoLabel);
            infoLabel.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            infoLabel.TopAnchor.ConstraintEqualTo(View.TopAnchor, 16).Active = true;
            infoLabel.HeightAnchor.ConstraintEqualTo(50).Active = true;
        }
    }
}
