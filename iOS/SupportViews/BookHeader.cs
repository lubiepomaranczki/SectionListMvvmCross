using Foundation;
using UIKit;

namespace SectionListMvvmCross.iOS.SupportViews
{
    public class BookHeader : UICollectionReusableView
    {
        public static readonly NSString Key = new NSString("BookHeader");
        private UILabel headerText;

        public string HeaderText
        {
            get { return headerText.Text; }
            set
            {
                headerText.Text = value;
                SetNeedsDisplay();
            }
        }

        [Export("initWithFrame:")]
        public BookHeader(System.Drawing.RectangleF frame)
            : base(frame)
        {
            BackgroundColor = UIColor.FromRGBA(170, 170, 170, 170);

            headerText = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                TextColor = UIColor.FromRGB(245, 241, 230),
                TextAlignment = UITextAlignment.Center
            };
            AddSubview(headerText);

            headerText.LeftAnchor.ConstraintEqualTo(LeftAnchor).Active = true;
            headerText.RightAnchor.ConstraintEqualTo(RightAnchor).Active = true;
            headerText.CenterYAnchor.ConstraintEqualTo(CenterYAnchor).Active = true;
        }
    }
}
