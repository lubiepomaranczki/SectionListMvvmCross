using System;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;
using SectionListMvvmCross.iOS.SupportViews;
using Foundation;
using System.Collections.Generic;
using SectionListMvvmCross.Extensions;
using SectionListMvvmCross.Models;

namespace SectionListMvvmCross.iOS.Views
{
    public class BooksViewSource : MvxCollectionViewSource
    {
        private readonly UICollectionView _collectionView;

        public IList<SectionItem> SectionedItemsCollection { get; set; }

        public BooksViewSource(UICollectionView collectionView)
            : base(collectionView, BookCell.Key)
        {
            _collectionView = collectionView;
            collectionView.RegisterClassForCell(typeof(BookCell), BookCell.Key);
            CollectionView.RegisterClassForSupplementaryView(typeof(BookHeader), UICollectionElementKindSection.Header, BookHeader.Key);
            ReloadOnAllItemsSourceSets = true;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            if (SectionedItemsCollection.IsNullOrEmpty())
            {
                return 1;
            }

            return SectionedItemsCollection.Count;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            if (SectionedItemsCollection.IsNullOrEmpty() || SectionedItemsCollection.Count - 1 < (int)section)
            {
                throw new Exception(nameof(GetItemsCount));
            }

            var collection = SectionedItemsCollection[(int)section].Collection;
            if (collection.IsNullOrEmpty())
            {
                throw new Exception("Collection can't be null or empty!");
            }

            return collection.Count;
        }

        protected override object GetItemAt(NSIndexPath indexPath)
        {
            return SectionedItemsCollection[indexPath.Section].Collection[indexPath.Row];
        }

        public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
        {
            var headerView = (BookHeader)collectionView.DequeueReusableSupplementaryView(elementKind, BookHeader.Key, indexPath);

            //TODO do whatever header initialization you need.
            headerView.HeaderText = SectionedItemsCollection[indexPath.Section].HeaderText;

            return headerView;
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView,
            NSIndexPath indexPath, object item)
        {
            return (UICollectionViewCell)CollectionView.DequeueReusableCell(BookCell.Key, indexPath);
        }

        public override void ReloadData()
        {
            CollectionView.Layer.RemoveAllAnimations();
            base.ReloadData();
        }
    }
}
