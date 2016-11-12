using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace schoolAppUITest
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				//.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
				.EnableLocalScreenshots()
				//.ApiKey("9d1925df496b837b07361755dfbcc369")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("Add school screen");
			////app.Repl();
			//app.Tap(x => x.Id("saveurlbutton"));
			//app.Screenshot("Add school validation looks like");

			//app.EnterText(x => x.Marked("UrlField"), "grappetite.schoolwebsite.nu");
			//app.WaitForElement(x => x.Id("saveurlbutton"),"adding school url",new System.TimeSpan(0,2,200),null,null);
			////app.WaitForElement(x => x.Id("saveurlbutton"), "adding school url", new System.TimeSpan(0, 0, 50), null, null);
			//app.Tap(x => x.Id("saveurlbutton"));
			//app.Screenshot("login screen");


			app.WaitForElement(x => x.Id("UrlField"));
			app.Screenshot("AssertionEvent[AppView: Class=[Class: Name=md5bd9d1b70076700800f5b83518703065f.CustomEditText], Id=UrlField, Text=, Marked=, Css=, XPath=, IndexInTree=0, Rect=[Rectangle: Left=0, Top=0, CenterX=800, CenterY=1477, Width=1472, Height=152, Bottom=1553, Right=1536]]");
			app.EnterText(x => x.Id("UrlField"), "grappetite.schoolwebsite.nu");
			app.Screenshot("Entered text: grappetite.schoolwebsite.nu");
			app.Tap(x => x.Id("saveurlbutton"));
			app.Screenshot("Tapped on view with class: CustomButton");
			app.Tap(x => x.Text("Skip"));
			app.Screenshot("Tapped on view with class: CustomButton");
			app.Tap(x => x.Id("menu_image"));
			app.Screenshot("Tapped on view with class: CustomImageView");
			app.Tap(x => x.Id("news_date"));
			app.Screenshot("Tapped on view with class: CustomTextView");
			app.Tap(x => x.Marked("Navigate up"));
			app.Screenshot("Tapped on view with class: ImageButton marked: Navigate up");
			app.Tap(x => x.Class("LinearLayout").Index(16));
			app.Screenshot("Tapped on view with class: LinearLayout");
			app.Tap(x => x.Marked("Navigate up"));
			app.Screenshot("Tapped on view with class: ImageButton marked: Navigate up");
			app.Tap(x => x.Marked("Navigate up"));
			app.Screenshot("Tapped on view with class: ImageButton marked: Navigate up");
			app.Tap(x => x.Id("menu_image").Index(1));
			app.Screenshot("Tapped on view with class: CustomImageView");
			app.Tap(x => x.Id("downarrowimage"));
			app.Screenshot("Tapped on view with class: AppCompatImageView");
			app.Tap(x => x.Text("Jan, 2017"));
			app.Screenshot("Tapped on view with class: AppCompatTextView");
			app.Tap(x => x.Marked("Navigate up"));
			app.Screenshot("Tapped on view with class: ImageButton marked: Navigate up");
			app.TouchAndHold(x => x.Id("menu_image").Index(2));
			app.Screenshot("Long press on view with class: CustomImageView");
			app.Tap(x => x.Id("photo_short_desc"));
			app.Screenshot("Tapped on view with class: CustomTextView");

		}
	}
}


