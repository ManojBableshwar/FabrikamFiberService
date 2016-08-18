
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections.Generic;



namespace FabrikamFiberServiceTest
{
    public static class ErrorDict
    {
        public static int MsgCounter = 1;
        public static string NextMsg()
        {
            if (MsgCounter > 5) { MsgCounter = 1; }
            return ErrorMsgs[MsgCounter++];
        }
        public static Dictionary<int, string> ErrorMsgs = new Dictionary<int, string>
            {
                {1, "Test method threw exception: System.AggregateException: One or more errors occurred. ---> FabrikamFiber.ServiceGateway.Core.WebApi.ObjectAlreadyExistsException: TF310, 5019: The object already exists on the Server" },
                {2, "InitializeFileStorageService threw exception. System.IO.IOException: System.IO.IOException: The process cannot access the file 'http%3A%2F%2FCO1CDFLWEB02%2FService%2FReviewListenerService.svc_609032ff-e557-4f79-a16c-aa97350ab8d7.cfrevsum' because it is being used by another process.. " },
                {3, "System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. Parameter name: index 00:21.314 Evaluate.AreEqual failed. Expected:<2>. Actual:<0>. "},
                {4, "Test method threw exception: System.AggregateException: One or more errors occurred. ---> FabrikamFiber.Core.Data.Exceptions.InvalidRequestException: Transitioning of release from state Rejected to state Cancelled is not allowed."},
                {5, "Test method threw exception: FabrikamFiber.Core.Data.Exceptions.TimeoutException Could not find the required lock from the service handler.. exceeded execution time-out period."}
            };
    }
    [TestClass]
    public class FabrikamFiberServiceTest
    {


        [TestMethod]
        [Priority(1)]
        public void ProcessValidJsonInSwagger()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void RESTThatShouldHaveBeenHttpRequest()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void ParamsCountMismatchInRESTJson()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void ParamsMismatchInRESTJson()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void MissingMethodInRESTJson()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void MissingValuesInRESTJson()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void InvalidRESTJasonError()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest_ContainsParens()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest_EndsWithSlash()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest_StartsWithSlash()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 35)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest_ContainsNumbers()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void LogicalSiteNameTest_MixedCase()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(3)]
        public void LogicalSiteNameTest_Empty()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest_Null()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void LogicalSiteNameTest()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestMethod16()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_FlagNotSetForDefaultScope_ReturnsRequestedScope()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_FlagNotSetForDefaultOrRequestedScope_DefaultEnablementIsTrue()
        {
            //   Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_FlagNotSetForDefaultOrRequestedScope_ReturnsFalse()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_RequestScopeCacheDoesNotHaveData_RetrievesFromPersistentCacheAndSetsRequestScopedCache()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_RequestScopeCacheHasData_BypassesPersistentCache()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_PersistentCacheProviderThrowsException_LogsExceptionAndReturnsFalse()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void IsEnabled_RequestScopedCacheProviderThrowsException_LogsExceptionAndReturnsFalse()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        public void IsEnabled_ServiceIsDisabled_NoOp()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        public void IsEnabled_FeatureParamIsNull_ThrowsArgumentNullException()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

    }
}
