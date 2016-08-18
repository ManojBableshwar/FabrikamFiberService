
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections.Generic;

namespace FabrikamFiberMobileTest
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
    public class FabrikamFiberWebTest
    {
        [TestMethod]
        [Priority(0)]
        public void MobileHub_VerifyRenameTicketFromContextMenu()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(1)]
        public void MobileHub_VerifyDeleteTicketFromContextMenu()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }
        [TestMethod]
        [Priority(2)]
        public void MobileHub_VerifyRunCompletedTicketFromContextMenu()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(3)]
        public void MobileHub_VerifyRunTicketOnDemandNoActiveTestsFromContextMenu()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(0)]
        public void ServiceHub_VerifyInlineEditParameterValuesInConflictingEdits()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(1)]
        public void ServiceHub_DeleteHistoryComments()
        {
        }
        [TestMethod]
        [Priority(2)]
        public void EndPointHttpClient_SetCountrytoInvalidCountry()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(3)]
        public void ServerDynamicBlade()
        {
        }
        [TestMethod]
        [Priority(3)]
        public void HooksProviderQueryOnDemandInvalidPublisherId()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(2)]
        public void GroupNotReDeletePermissionsToProjectAdminsGroup()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(1)]
        public void HistoryFrameworkInterface_SetCountrytoEmptyString()
        {
        }
        [TestMethod]
        [Priority(0)]
        public void ServiceReqUnregisterWithInvalidRunSettingsFile()
        {
        }
        [TestMethod]
        [Priority(1)]
        public void HooksProviderQueryWithInvalidPublisherId()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }
        [TestMethod]
        [Priority(3)]
        public void HistoryFrameworkService_CreateHistoryForbiddenValuesEmailDeleteress()
        {
        }
        [TestMethod]
        [Priority(0)]

        public void Transform_IntraNav_GeneratedForReferenceDoc()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void Transform_Throws_IfUXTemplateIsInValid()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void Transform_Throws_IfUXTemplateIsNull()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            if (randomNumber > 40)
            {
                Assert.Fail("{0}", ErrorDict.NextMsg());
            }
        }

        [TestMethod]
        [Priority(1)]
        public void TestMethod4()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void TestMethod5()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void Transform_Throws_IfContentIsEmpty()
        {
            //Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void Transform_Throws_IfContentIsNull()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void LoadFromSource_FileDoesNotExist_ThrowsFileNotFoundException()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CacheKey_ReturnsFilePath()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void Constructor_FilePathIsNull_ThrowsArgumentNullException()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void Deserialize_ThrowsNotSupportedException()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void SupportedTypes_ReturnsExtensionDataObject()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CreateSource_PathIsHttp_ReturnsWebResponseDataSource()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CreateSource_PathIsNull_ThrowsArgumentNullException()
        {
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementEmptyUri()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementEmptyDisplay()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementDisplayTextContainingLineBreak()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementUriWithWWW()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementUriWithoutTopLevelDomainName()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestMethod20()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementUrlForDisplay()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void CommentElementNoLinks()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void CommentElementOneLinkWithTextAround()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(3)]
        public void CommentElementSingleLinkAlone()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
        }



    }
}
