﻿
using System;
using System.Drawing;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace DemoApp1.iOS
{
	public partial class testViewCtrl : UIViewController
	{
		public testViewCtrl () : base ("testViewCtrl", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}       
       
	}
}
