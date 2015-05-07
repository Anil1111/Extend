﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace PortableExtensions.Testing
{
    [TestFixture]
    public partial class Int64ExTest
    {
        [Test]
        public void PercentageOfTestCase()
        {
            const Int64 number = 1000;
            const Int32 expected = 500;
            var actual = number.PercentageOf( (Int64) 50 );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void PercentageOfTestCase1()
        {
            const Int64 number = 1000;
            const Int32 expected = 500;
            var actual = number.PercentageOf( (Double) 50 );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        [ExpectedException( typeof (DivideByZeroException) )]
        public void PercentageOfTestCase1DivideByZeroException()
        {
            const Int64 number = 0;
            number.PercentageOf( (Double) 50 );
        }

        [Test]
        public void PercentageOfTestCase2()
        {
            const Int64 number = 1000;
            const Int32 expected = 500;
            var actual = number.PercentageOf( (Int64) 50 );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        [ExpectedException( typeof (DivideByZeroException) )]
        public void PercentageOfTestCase2DivideByZeroException()
        {
            const Int64 number = 0;
            number.PercentageOf( (Int64) 50 );
        }

        [Test]
        public void PercentageOfTestCase3()
        {
            const Int64 number = 1000;
            const Int32 expected = 500;
            var actual = number.PercentageOf( new Decimal( 50 ) );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        [ExpectedException( typeof (DivideByZeroException) )]
        public void PercentageOfTestCase3DivideByZeroException()
        {
            const Int64 number = 0;
            number.PercentageOf( new Decimal( 50 ) );
        }

        [Test]
        public void PercentageOfTestCase4()
        {
            const Int64 number = 1000;
            const Int32 expected = 500;
            var actual = number.PercentageOf( 50 );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        [ExpectedException( typeof (DivideByZeroException) )]
        public void PercentageOfTestCase4DivideByZeroException()
        {
            const Int64 number = 0;
            number.PercentageOf( 50 );
        }

        [Test]
        [ExpectedException( typeof (DivideByZeroException) )]
        public void PercentageOfTestCaseDivideByZeroException()
        {
            const Int64 number = 0;
            number.PercentageOf( (Int64) 50 );
        }
    }
}