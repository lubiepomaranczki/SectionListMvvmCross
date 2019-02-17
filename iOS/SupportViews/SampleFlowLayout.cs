using System;
using CoreGraphics;
using UIKit;

namespace SectionListMvvmCross.iOS.SupportViews
{
    public class SampleFlowLayout : UICollectionViewFlowLayout
    {
        public override bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds)
        {
            return false;
        }

        public override CGPoint TargetContentOffsetForProposedContentOffset(CGPoint proposedContentOffset)
        {
            return base.TargetContentOffsetForProposedContentOffset(proposedContentOffset);
        }
    }
}
