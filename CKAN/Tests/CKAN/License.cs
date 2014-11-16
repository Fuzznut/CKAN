﻿using NUnit.Framework;

namespace CKANTests
{
    [TestFixture]
    public class License
    {
        [Test]
        public void LicenseGood()
        {
            var license = new CKAN.License("GPL-3.0");
            Assert.IsInstanceOf<CKAN.License>(license);
            Assert.AreEqual("GPL-3.0", license.ToString());
        }

        public void LicenseBad()
        {
            Assert.Throws<CKAN.BadMetadataKraken>(delegate
            {
                // Not a valid license string, contains spaces.
                new CKAN.License("GPL 3.0");
            });
        }
    }
}

