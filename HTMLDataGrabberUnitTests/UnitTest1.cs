using HTMLDataGrabber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HTMLDataGrabberUnitTests
{
    [TestClass]
    public class HTMLDataGrabberTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void idGetter_nullURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage(null);

            Assert.AreEqual(dg.GetTextById("test"), "Error: URI is null.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void idGetter_invalidURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("invalidURI");

            Assert.AreEqual(dg.GetTextById("test"), "Error: URI is not in the correct format.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void idGetter_nullIDError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");

            Assert.AreEqual(dg.GetTextById(null), "Error: id is null.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void idGetter_invalidIDError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");

            Assert.AreEqual(dg.GetTextById("invalidID"), "Error: element with id invalidID could not be found.");

        }

        //test for string list by xpath
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathListGetter_nullXpathError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextListByXpath(null)[0], "Error: elements could not be found.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathListGetter_invalidXpathError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextListByXpath("invalidXpath")[0], "Error: elements could not be found.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathListGetter_nullURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage(null);
            Assert.AreEqual(dg.GetTextListByXpath("test")[0], "Error: URI is null.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathListGetter_invalidURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("invalidURI");
            Assert.AreEqual(dg.GetTextListByXpath("test")[0], "Error: URI is not in the correct format.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathGetter_nullXpathError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextByXpath(null), "Error: xpath is null.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathGetter_invalidXpathError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextByXpath("invalidXpath"), "Error: element with xpath invalidXpath could not be found.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathGetter_nullURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage(null);
            Assert.AreEqual(dg.GetTextByXpath("test"), "Error: URI is null.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void xpathGetter_invalidURIError()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("invalidURI");
            Assert.AreEqual(dg.GetTextByXpath("test"), "Error: URI is not in the correct format.");
        }

        [TestMethod]
        public void imageDownloader_invalidImage()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.DownloadImage("invalidImageUrl"), null);
        }

        [TestMethod]
        public void idGetter_validID()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://ac.tuiasi.ro/");
            Assert.AreEqual(dg.GetTextById("tuiasi-logo-facultate").Trim(), "Facultatea de Automatică și Calculatoare");
        }

        [TestMethod]
        public void idGetter_validID2()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.emag.ro/");
            Assert.AreEqual(dg.GetTextById("my_cart").Trim(), "Coșul meu");
        }

        [TestMethod]
        public void xpathListGetter_validXpath()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextListByXpath("//a")[0], "Imagini");
        }

        [TestMethod]
        public void xpathGetter_validXpath()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreEqual(dg.GetTextByXpath("//a"), "Imagini");
        }

        [TestMethod]
        public void xpathGetter_validXpath2()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.emag.ro");
            Assert.AreEqual(dg.GetTextByXpath("//a[@title='Genius']").Trim(), "Genius");
        }

        [TestMethod]
        public void imageDownloader_validImage()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreNotEqual(dg.DownloadImage("https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png"), null);
        }

        [TestMethod]
        public void imageDownloader_validImage2()
        {
            DataGrabber dg = new DataGrabber();
            dg.SetPage("https://www.google.com");
            Assert.AreNotEqual(dg.DownloadImage("https://www.wikipedia.org/portal/wikipedia.org/assets/img/Wikipedia-logo-v2.png"), null);
        }

    }
}
