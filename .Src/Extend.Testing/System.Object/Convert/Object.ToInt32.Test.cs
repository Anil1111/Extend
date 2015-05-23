﻿#region Usings

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class ObjectExTest
    {
        [Test]
        public void ToInt32TestCase()
        {
            var expected = RandomValueEx.GetRandomInt32();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt32( value );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void ToInt32TestCase1()
        {
            var expected = RandomValueEx.GetRandomInt32();
            var value = expected.ToString();
            var actual = ObjectEx.ToInt32( value, CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt32TestCase1NullCheck()
        {
            ObjectEx.ToInt32( null, CultureInfo.InvariantCulture );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt32TestCase1NullCheck1()
        {
            ObjectEx.ToInt32( "false", null );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void ToInt32TestCaseNullCheck()
        {
            ObjectEx.ToInt32( null );
        }
    }
}