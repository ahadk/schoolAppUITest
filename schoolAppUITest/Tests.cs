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
			//app.Repl();
			app.Tap(x => x.Id("saveurlbutton"));
			app.Screenshot("Add school validation looks like");

			app.EnterText(x => x.Marked("UrlField"), "grappetite.schoolwebsite.nu");
			app.WaitForElement(x => x.Id("saveurlbutton"),"adding school url",new System.TimeSpan(0,0,200),null,null);
			//app.WaitForElement(x => x.Id("saveurlbutton"), "adding school url", new System.TimeSpan(0, 0, 50), null, null);
			app.Tap(x => x.Id("saveurlbutton"));
			app.Screenshot("login screen");


		}
	}
}

