using System;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;
using SectionListMvvmCross.iOS.SupportViews;
using Foundation;
using System.Collections;

namespace SectionListMvvmCross.iOS.Views
{
    public class BooksViewSource : MvxCollectionViewSource
    {
        private readonly UICollectionView _collectionView;

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
            return 2;
            //if (Headers == null || !Headers.Any())
            //{
            //    return 1;
            //}

            //return Headers.Count;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 2;
            //if (Headers == null || !Headers.Any())
            //{
            //    return 0;
            //}

            //return Headers[(int)section].ItemCount;
        }

        //protected override object GetItemAt(NSIndexPath indexPath)
        //{
        //    return Headers[indexPath.Section].Players[indexPath.Row];
        //}

        public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
        {
            var headerView = (BookHeader)collectionView.DequeueReusableSupplementaryView(elementKind, BookHeader.Key, indexPath);
            headerView.HeaderText = "Test";
            return headerView;
        }

        public override void ReloadData()
        {
            CollectionView.Layer.RemoveAllAnimations();
            base.ReloadData();
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView,
            NSIndexPath indexPath, object item)
        {
            return (UICollectionViewCell)CollectionView.DequeueReusableCell(BookCell.Key, indexPath);
        }
    }
}
