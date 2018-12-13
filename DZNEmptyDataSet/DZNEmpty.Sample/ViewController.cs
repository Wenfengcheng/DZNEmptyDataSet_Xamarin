﻿using System;
using CoreAnimation;
using DZNEmptyDataSet;
using Foundation;
using UIKit;

namespace DZNEmpty.Sample
{
    public partial class ViewController : UIViewController
    {
        private UITableView tableview;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            tableview = new UITableView(this.View.Bounds)
            {
                BackgroundColor = UIColor.White
            };
            tableview.UserInteractionEnabled = true;
            tableview.SetEmptyDataSetDelegate(new TableViewDataSetDelegate());
            tableview.SetEmptyDataSetSource(new TableViewDataSetSource());
            tableview.TableFooterView = new UIView();
            this.View.AddSubview(tableview);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class TableViewDataSetSource : DZNEmptyDataSetSource
    {
        public override UIImage ImageForEmptyDataSet(UIScrollView scrollView)
        {
            return UIImage.FromBundle("placeholder_dropbox");
        }

        public override NSAttributedString TitleForEmptyDataSet(UIScrollView scrollView)
        {
            return new NSAttributedString("Star Your Favorite Files", UIFont.SystemFontOfSize(17f), UIColor.FromRGB(172, 175, 189));
        }

        public override NSAttributedString DescriptionForEmptyDataSet(UIScrollView scrollView)
        {
            NSMutableParagraphStyle style = new NSMutableParagraphStyle()
            {
                LineBreakMode = UILineBreakMode.WordWrap,
                Alignment = UITextAlignment.Center
            };

            return new NSAttributedString("Favorites are saved for offline access.", 
                                          UIFont.SystemFontOfSize(14.5f), 
                                          UIColor.FromRGB(123, 137, 148),
                                          paragraphStyle: style);
        }

        public override CAAnimation ImageAnimationForEmptyDataSet(UIScrollView scrollView)
        {
            CABasicAnimation animation = CABasicAnimation.FromKeyPath("transform");
            animation.From = NSValue.FromCATransform3D(CATransform3D.Identity);
            animation.To = NSValue.FromCATransform3D(CATransform3D.MakeRotation((System.nfloat)(Math.PI / 2), 0, 0, 1));
            animation.Duration = 0.25f;
            animation.RepeatCount = float.MaxValue;
            return animation;
        }

        public override NSAttributedString ButtonTitleForEmptyDataSet(UIScrollView scrollView, UIControlState state)
        {
            return new NSAttributedString("Learn more",
                                                      UIFont.SystemFontOfSize(15f),
                                                      UIColor.FromRGB(0, 126, 229));
        }


        public override UIColor BackgroundColorForEmptyDataSet(UIScrollView scrollView)
        {
            return UIColor.FromRGB(240, 243, 245);
        }
    }

    public class TableViewDataSetDelegate : DZNEmptyDataSetDelegate
    {
        public override bool EmptyDataSetShouldDisplay(UIScrollView scrollView)
        {
            return true;
        }

        public override bool EmptyDataSetShouldAllowTouch(UIScrollView scrollView)
        {
            return true;
        }

        public override bool EmptyDataSetShouldAllowScroll(UIScrollView scrollView)
        {
            return true;
        }

        public override bool EmptyDataSetShouldAnimateImageView(UIScrollView scrollView)
        {
            return false;
        }

        public override void EmptyDataSetDidTapButton(UIScrollView scrollView, UIButton button)
        {
            scrollView.ReloadEmptyDataSet();
        }

        public override void EmptyDataSetDidTapView(UIScrollView scrollView, UIView view)
        {
            scrollView.ReloadEmptyDataSet();
        }
    }
}