using MvvmCross.Platforms.Ios.Views;

namespace SectionListMvvmCross.iOS.Views
{
    public partial class SampleView : MvxViewController<SampleViewModel>
    {
        public SampleView()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitializeUI();
            CreateBindings();
        }

        private void CreateBindings()
        {

        }
    }
}
