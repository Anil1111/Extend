﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void KeepLettersTestCase()
        {
            var actual = "a1b2c3".KeepLetters();
            Assert.AreEqual( "abc", actual );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void KeepLettersTestCaseNullCheck()
        {
            StringEx.KeepLetters( null );
        }
    }
}