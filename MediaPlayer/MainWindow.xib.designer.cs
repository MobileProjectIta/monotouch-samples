// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MediaPlayer {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("MoviePlayerAppDelegate")]
	public partial class MoviePlayerAppDelegate {
		
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				return ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
			}
			set {
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("tabBarController")]
		private MonoTouch.UIKit.UITabBarController tabBarController {
			get {
				return ((MonoTouch.UIKit.UITabBarController)(this.GetNativeField("tabBarController")));
			}
			set {
				this.SetNativeField("tabBarController", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("imageView")]
		private MonoTouch.UIKit.UIImageView imageView {
			get {
				return ((MonoTouch.UIKit.UIImageView)(this.GetNativeField("imageView")));
			}
			set {
				this.SetNativeField("imageView", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIView or subclass
	[MonoTouch.Foundation.Register("MyOverlayView")]
	public partial class MyOverlayView {
	}
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MyMovieViewController")]
	public partial class MyMovieViewController {
		
		[MonoTouch.Foundation.Export("overlayViewButtonPress:")]
		partial void overlayViewButtonPress (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Export("playMovieButtonPressed:")]
		partial void playMovieButtonPressed (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Connect("overlayView")]
		private MonoTouch.UIKit.UIView overlayView {
			get {
				return ((MonoTouch.UIKit.UIView)(this.GetNativeField("overlayView")));
			}
			set {
				this.SetNativeField("overlayView", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIImageView or subclass
	[MonoTouch.Foundation.Register("MyImageView")]
	public partial class MyImageView {
		
		[MonoTouch.Foundation.Connect("viewController")]
		private MonoTouch.UIKit.UIViewController viewController {
			get {
				return ((MonoTouch.UIKit.UIViewController)(this.GetNativeField("viewController")));
			}
			set {
				this.SetNativeField("viewController", value);
			}
		}
	}
}