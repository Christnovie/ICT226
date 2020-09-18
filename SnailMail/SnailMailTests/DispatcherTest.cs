using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SnailMail;

namespace SnailMailTests
{
    [TestClass]
    public class DispatcherTest
    {
        [TestMethod]
        public void Unique_Mail_For_One_Zone()
        {
            Dispatcher dispatcher = new Dispatcher();
            Mail mail;

            mail = new Mail();
            mail.ZipCode = 4000;
            dispatcher.Dispatch(mail);

            Assert.AreEqual(1, dispatcher.BatchFor(4).Count);
        }

        [TestMethod]
        public void Multiple_Mail_For_One_Zone()
        {
            Dispatcher dispatcher = new Dispatcher();
            Mail mail;

            mail = new Mail();
            mail.ZipCode = 2000;
            dispatcher.Dispatch(mail);

            mail = new Mail();
            mail.ZipCode = 2204;
            dispatcher.Dispatch(mail);

            mail = new Mail();
            mail.ZipCode = 2999;
            dispatcher.Dispatch(mail);

            Assert.AreEqual(3, dispatcher.BatchFor(2).Count);
        }

        [TestMethod]
        public void Multiple_Mail_For_Two_Zones()
        {
            Dispatcher dispatcher = new Dispatcher();
            Mail mail;

            mail = new Mail();
            mail.ZipCode = 1450;
            dispatcher.Dispatch(mail);

            mail = new Mail();
            mail.ZipCode = 3001;
            dispatcher.Dispatch(mail);

            mail = new Mail();
            mail.ZipCode = 3900;
            dispatcher.Dispatch(mail);

            Assert.AreEqual(1, dispatcher.BatchFor(1).Count);
            Assert.AreEqual(2, dispatcher.BatchFor(3).Count);
        }

        [TestMethod]
        [ExpectedException(typeof(NoBatchException))]
        public void Batch_For_Non_Used_Zone()
        {
            Dispatcher dispatcher = new Dispatcher();
            Mail mail;
            
            mail = new Mail();
            mail.ZipCode = 1450;
            dispatcher.Dispatch(mail);

            dispatcher.BatchFor(2);
        }
    }
}
