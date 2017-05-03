﻿#region Usings

using System;
using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    
    public partial class StringExTest
    {
        [Fact]
        public void MatchesTest()
        {
            const String emaiLpattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            const String validEmail = "dave.senn@myDomain.com";
            const String invalidEmail = "dave.senn-myDomain.com";

            var actual = validEmail.Matches( emaiLpattern );
            Assert.Equal( 1, actual.Count );

            actual = invalidEmail.Matches( emaiLpattern );
            Assert.Equal( 0, actual.Count );
        }

        [Fact]
        public void MatchesTest1()
        {
            const String emaiLpattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            const String validEmail = "dave.senn@myDomain.com";
            const String invalidEmail = "dave.senn-myDomain.com";

            var actual = validEmail.Matches( emaiLpattern, RegexOptions.Compiled );
            Assert.Equal( 1, actual.Count );

            actual = invalidEmail.Matches( emaiLpattern, RegexOptions.Compiled );
            Assert.Equal( 0, actual.Count );
        }

        [Fact]
        public void MatchesTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Matches( null, "", RegexOptions.Compiled );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void MatchesTest1NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".Matches( null, RegexOptions.Compiled );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void MatchesTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Matches( null, "" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void MatchesTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".Matches( null );

            test.ShouldThrow<ArgumentNullException>();
        }

#if PORTABLE45
        [Fact]
        public void MatchesTest2()
        {
            const String emaiLpattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            const String validEmail = "dave.senn@myDomain.com";
            const String invalidEmail = "dave.senn-myDomain.com";

            var actual = validEmail.Matches( emaiLpattern, RegexOptions.Compiled, 100.ToSeconds() );
            Assert.Equal( 1, actual.Count );

            actual = invalidEmail.Matches( emaiLpattern, RegexOptions.Compiled, 100.ToSeconds() );
            Assert.Equal( 0, actual.Count );
        }

        [Fact]
        public void MatchesTest2NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Matches( null, "", RegexOptions.Compiled, 100.ToSeconds() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void MatchesTest2NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".Matches( null, RegexOptions.Compiled, 100.ToSeconds() );

            test.ShouldThrow<ArgumentNullException>();
        }
#endif
    }
}