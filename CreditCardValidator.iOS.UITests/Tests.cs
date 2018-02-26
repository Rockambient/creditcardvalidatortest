using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace CreditCardValidator.iOS.UITests
{
	[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
        Platform platform;

        public Tests(Platform platform){
            this.platform = platform;
        }

		[SetUp]
		public void BeforeEachTest()
		{
            if(platform == Platform.Android){
                app = ConfigureApp.Android.StartApp(); 
            }
            else
			app = ConfigureApp.iOS.StartApp();
		}

		[Test]
		public void CreditCardNumber_TooShort_DisplayErrorMessage()
		{
            app.WaitForElement(c => c.Marked("creditCardNumberText"));
            app.EnterText(c => c.Marked("creditCardNumberText"), new string('9', 15));
            app.Tap(c => c.Marked("validateButton"));

            app.WaitForElement(c => c.Marked("errorMessagesText").Text("Credit card number is too short."));
		}
	}
}


