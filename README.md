# DZNEmptyDataSet_Xamarin
[![Version Status](https://img.shields.io/cocoapods/v/DZNEmptyDataSet.svg?style=flat)](http://cocoadocs.org/docsets/DZNEmptyDataSet)

Port of Xamarin iOS of the [DZNEmptyDataSet](https://github.com/dzenbot/DZNEmptyDataSet)

### NuGet
* [Xamarin.iOS.DZNEmptyDataSet](https://www.nuget.org/packages/Xamarin.iOS.DZNEmptyDataSet) [![NuGet](https://img.shields.io/nuget/v/Xamarin.iOS.DZNEmptyDataSet.svg?label=NuGet)](https://www.nuget.org/packages/Xamarin.iOS.DZNEmptyDataSet)

### The Empty Data Set Pattern
Also known as *[Empty State](http://emptystat.es/)* or *[Blank Slate](http://patternry.com/p=blank-slate/)*.

Most applications show lists of content (data sets), which many turn out to be empty at one point, specially for new users with blank accounts. Empty screens create confusion by not being clear about what's going on, if there is an error/bug or if the user is supposed to do something within your app to be able to consume the content.

Please read this very interesting article about [*Designing For The Empty States*](http://tympanus.net/codrops/2013/01/09/designing-for-the-empty-states/).

![Screenshots_Row1](https://raw.githubusercontent.com/dzenbot/DZNEmptyDataSet/v2-swift/Examples/Applications/Screenshots/Screenshots_row1.png)
![Screenshots_Row2](https://raw.githubusercontent.com/dzenbot/DZNEmptyDataSet/v2-swift/Examples/Applications/Screenshots/Screenshots_row2.png)
(*These are real life examples, available in the 'Applications' sample project in the v2-Swift branch*)

**[Empty Data Sets](http://pttrns.com/?did=1&scid=30)** are helpful for:
* Avoiding white-screens and communicating to your users why the screen is empty.
* Calling to action (particularly as an onboarding process).
* Avoiding other interruptive mechanisms like showing error alerts.
* Being consistent and improving the user experience.
* Delivering a brand presence.


### Features
* Compatible with UITableView and UICollectionView. Also compatible with UISearchDisplayController and UIScrollView.
* Gives multiple possibilities of layout and appearance, by showing an image and/or title label and/or description label and/or button.
* Uses NSAttributedString for easier appearance customisation.
* Uses auto-layout to automagically center the content to the tableview, with auto-rotation support. Also accepts custom vertical and horizontal alignment.
* Background color customisation.
* Allows tap gesture on the whole tableview rectangle (useful for resigning first responder or similar actions).
* For more advanced customisation, it allows a custom view.
* Compatible with Storyboard.
* Compatible with iOS 6, tvOS 9, or later.
* Compatible with iPhone, iPad, and Apple TV.
* **App Store ready**
