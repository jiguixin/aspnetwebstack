﻿using Xunit;

namespace System.Web.Mvc.Test
{
    public class HttpDeleteAttributeTest
    {
        [Fact]
        public void IsValidForRequestReturnsFalseIfHttpVerbIsNotPost()
        {
            HttpVerbAttributeHelper.TestHttpVerbAttributeWithInvalidVerb<HttpDeleteAttribute>("POST");
        }

        [Fact]
        public void IsValidForRequestReturnsTrueIfHttpVerbIsPost()
        {
            HttpVerbAttributeHelper.TestHttpVerbAttributeWithValidVerb<HttpDeleteAttribute>("DELETE");
        }

        [Fact]
        public void IsValidForRequestThrowsIfControllerContextIsNull()
        {
            HttpVerbAttributeHelper.TestHttpVerbAttributeNullControllerContext<HttpDeleteAttribute>();
        }
    }
}
