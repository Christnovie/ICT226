using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SnailMail;

namespace SnailMailTests
{
    [TestClass]
    public class BatchTest
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidZoneNumberException))]
        public void Batch_With_TargetZone_Too_Low()
        {
            Batch batch = new Batch(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidZoneNumberException))]
        public void Batch_With_TargetZone_Too_High()
        {
            Batch batch = new Batch(5);
        }

        [TestMethod]
        public void Add_Mail_With_Matching_Zone()
        {
            Batch batch = new Batch(2);

            Mail mail = new Mail();
            mail.ZipCode = 2900;

            batch.AddMail(mail);

            Assert.AreEqual(1, batch.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidZoneNumberException))]
        public void Add_Mail_With_Unmatching_Zone()
        {
            Batch batch = new Batch(3);

            Mail mail = new Mail();
            mail.ZipCode = 2900;

            batch.AddMail(mail);
        }
    }
}
