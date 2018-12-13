using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace DZNEmptyDataSet
{
    // @interface EmptyDataSet (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_EmptyDataSet
    {
        // @property (nonatomic, weak) id<DZNEmptyDataSetSource> emptyDataSetSource __attribute__((iboutlet));
        [Export("emptyDataSetSource")]
        DZNEmptyDataSetSource EmptyDataSetSource();

        [Export("setEmptyDataSetSource:")]
        void SetEmptyDataSetSource(DZNEmptyDataSetSource source);

        [Export("emptyDataSetDelegate")]
        DZNEmptyDataSetDelegate EmptyDataSetDelegate();

        [Export("setEmptyDataSetDelegate:")]
        void SetEmptyDataSetDelegate(DZNEmptyDataSetDelegate @delegate);

        // @property (readonly, getter = isEmptyDataSetVisible, nonatomic) BOOL emptyDataSetVisible;
        [Export("isEmptyDataSetVisible")]
        bool EmptyDataSetVisible();

        // -(void)reloadEmptyDataSet;
        [Export("reloadEmptyDataSet")]
        void ReloadEmptyDataSet();
    }

    // @protocol DZNEmptyDataSetSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface DZNEmptyDataSetSource
    {
        // @optional -(NSAttributedString *)titleForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("titleForEmptyDataSet:")]
        NSAttributedString TitleForEmptyDataSet(UIScrollView scrollView);

        // @optional -(NSAttributedString *)descriptionForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("descriptionForEmptyDataSet:")]
        NSAttributedString DescriptionForEmptyDataSet(UIScrollView scrollView);

        // @optional -(UIImage *)imageForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("imageForEmptyDataSet:")]
        UIImage ImageForEmptyDataSet(UIScrollView scrollView);

        // @optional -(UIColor *)imageTintColorForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("imageTintColorForEmptyDataSet:")]
        UIColor ImageTintColorForEmptyDataSet(UIScrollView scrollView);

        // @optional -(CAAnimation *)imageAnimationForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("imageAnimationForEmptyDataSet:")]
        CAAnimation ImageAnimationForEmptyDataSet(UIScrollView scrollView);

        // @optional -(NSAttributedString *)buttonTitleForEmptyDataSet:(UIScrollView *)scrollView forState:(UIControlState)state;
        [Export("buttonTitleForEmptyDataSet:forState:")]
        NSAttributedString ButtonTitleForEmptyDataSet(UIScrollView scrollView, UIControlState state);

        // @optional -(UIImage *)buttonImageForEmptyDataSet:(UIScrollView *)scrollView forState:(UIControlState)state;
        [Export("buttonImageForEmptyDataSet:forState:")]
        UIImage ButtonImageForEmptyDataSet(UIScrollView scrollView, UIControlState state);

        // @optional -(UIImage *)buttonBackgroundImageForEmptyDataSet:(UIScrollView *)scrollView forState:(UIControlState)state;
        [Export("buttonBackgroundImageForEmptyDataSet:forState:")]
        UIImage ButtonBackgroundImageForEmptyDataSet(UIScrollView scrollView, UIControlState state);

        // @optional -(UIColor *)backgroundColorForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("backgroundColorForEmptyDataSet:")]
        UIColor BackgroundColorForEmptyDataSet(UIScrollView scrollView);

        // @optional -(UIView *)customViewForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("customViewForEmptyDataSet:")]
        UIView CustomViewForEmptyDataSet(UIScrollView scrollView);

        // @optional -(CGPoint)offsetForEmptyDataSet:(UIScrollView *)scrollView __attribute__((deprecated(" Use -verticalOffsetForEmptyDataSet: instead")));
        //[Export("offsetForEmptyDataSet:")]
        //CGPoint OffsetForEmptyDataSet(UIScrollView scrollView);

        // @optional -(CGFloat)verticalOffsetForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("verticalOffsetForEmptyDataSet:")]
        nfloat VerticalOffsetForEmptyDataSet(UIScrollView scrollView);

        // @optional -(CGFloat)spaceHeightForEmptyDataSet:(UIScrollView *)scrollView;
        [Export("spaceHeightForEmptyDataSet:")]
        nfloat SpaceHeightForEmptyDataSet(UIScrollView scrollView);
    }

    // @protocol DZNEmptyDataSetDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface DZNEmptyDataSetDelegate
    {
        // @optional -(BOOL)emptyDataSetShouldFadeIn:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldFadeIn:")]
        bool EmptyDataSetShouldFadeIn(UIScrollView scrollView);

        // @optional -(BOOL)emptyDataSetShouldBeForcedToDisplay:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldBeForcedToDisplay:")]
        bool EmptyDataSetShouldBeForcedToDisplay(UIScrollView scrollView);

        // @optional -(BOOL)emptyDataSetShouldDisplay:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldDisplay:")]
        bool EmptyDataSetShouldDisplay(UIScrollView scrollView);

        // @optional -(BOOL)emptyDataSetShouldAllowTouch:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldAllowTouch:")]
        bool EmptyDataSetShouldAllowTouch(UIScrollView scrollView);

        // @optional -(BOOL)emptyDataSetShouldAllowScroll:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldAllowScroll:")]
        bool EmptyDataSetShouldAllowScroll(UIScrollView scrollView);

        // @optional -(BOOL)emptyDataSetShouldAnimateImageView:(UIScrollView *)scrollView;
        [Export("emptyDataSetShouldAnimateImageView:")]
        bool EmptyDataSetShouldAnimateImageView(UIScrollView scrollView);

        // @optional -(void)emptyDataSetDidTapView:(UIScrollView *)scrollView __attribute__((deprecated(" Use -emptyDataSet:didTapView: instead")));
        //[Export("emptyDataSetDidTapView:")]
        //void EmptyDataSetDidTapView(UIScrollView scrollView);

        // @optional -(void)emptyDataSetDidTapButton:(UIScrollView *)scrollView __attribute__((deprecated(" Use -emptyDataSet:didTapButton: instead")));
        //[Export("emptyDataSetDidTapButton:")]
        //void EmptyDataSetDidTapButton(UIScrollView scrollView);

        // @optional -(void)emptyDataSet:(UIScrollView *)scrollView didTapView:(UIView *)view;
        [Export("emptyDataSet:didTapView:")]
        void EmptyDataSetDidTapView(UIScrollView scrollView, UIView view);

        // @optional -(void)emptyDataSet:(UIScrollView *)scrollView didTapButton:(UIButton *)button;
        [Export("emptyDataSet:didTapButton:")]
        void EmptyDataSetDidTapButton(UIScrollView scrollView, UIButton button);

        // @optional -(void)emptyDataSetWillAppear:(UIScrollView *)scrollView;
        [Export("emptyDataSetWillAppear:")]
        void EmptyDataSetWillAppear(UIScrollView scrollView);

        // @optional -(void)emptyDataSetDidAppear:(UIScrollView *)scrollView;
        [Export("emptyDataSetDidAppear:")]
        void EmptyDataSetDidAppear(UIScrollView scrollView);

        // @optional -(void)emptyDataSetWillDisappear:(UIScrollView *)scrollView;
        [Export("emptyDataSetWillDisappear:")]
        void EmptyDataSetWillDisappear(UIScrollView scrollView);

        // @optional -(void)emptyDataSetDidDisappear:(UIScrollView *)scrollView;
        [Export("emptyDataSetDidDisappear:")]
        void EmptyDataSetDidDisappear(UIScrollView scrollView);
    }

    [Static]
    partial interface Constants
    {
        // extern double DZNEmptyDataSetVersionNumber;
        [Field("DZNEmptyDataSetVersionNumber", "__Internal")]
        double DZNEmptyDataSetVersionNumber { get; }

        // extern const unsigned char [] DZNEmptyDataSetVersionString;
        [Field("DZNEmptyDataSetVersionString", "__Internal")]
        NSString DZNEmptyDataSetVersionString { get; }
    }
}
