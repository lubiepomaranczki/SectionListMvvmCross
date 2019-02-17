using MvvmCross.ViewModels;

namespace SectionListMvvmCross
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<SampleViewModel>();
        }
    }
}
