
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections.Generic;

namespace FabrikamFiberWebTest
{
    [TestClass]
    public class FabrikamFiberWebTest
    {
        public static class ErrorDict
        {
            public static int MsgCounter = 1;
            public static string NextMsg ()
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
        [TestMethod]
        [Priority(2)]
        public void TicketsHub_VerifyRenameTicketFromContextMenu()
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
        public void TicketsHub_VerifyDeleteTicketFromContextMenu()
        {
        }
        [TestMethod]
        [Priority(1)]
        public void TicketsHub_VerifyRunCompletedTicketFromContextMenu()
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
        [Priority(0)]
        public void TicketsHub_VerifyRunTicketOnDemandNoActiveTestsFromContextMenu()
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
        public void CustomerHub_VerifyInlineEditParameterValuesInConflictingEdits()
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
        [Priority(3)]
        public void CustomerHub_AddProfileComments()
        {
        }
        [TestMethod]
        [Priority(3)]
        public void PSHttpClient_SetCountrytoInvalidCountry()
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
        public void AccountDynamicBlade()
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
        public void HooksProviderQueryOnDemandInvalidPublisherId()
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
        public void DoNotReaddPermissionsToProjectAdminsGroup()
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
        public void ProfileFrameworkInterface_SetCountrytoEmptyString()
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
        public void CallUnregisterWithInvalidRunSettingsFile()
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
        [Priority(0)]
        public void HooksProviderQueryWithInvalidPublisherId()
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
        public void ProfileFrameworkService_CreateProfileForbiddenValuesEmailAddress()
        {
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenNoResultTests()
        {
            //Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenKeywordsTests()
        {
            //Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenQuotedStringTests()
        {
            //Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenMultiLineCommentTests()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenIgnoreTests()
        {
            //   Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void ScanTokenSingleLineCommentTests()
        {
          //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(1)]
        public void TestArgumentCanStartWithUnderscore()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestArgumentStartInvalidCharRejected()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestArgumentWithVSOParameters()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void ParsingOfChangesetArgumentReturnsDepotAndActualChangeList()
        {
            //  Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void ParsingOfChangesetArgumentReturnsNullDepotAndActualChangeList()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void ParsingOfChangesetArgumentWithLocalPathReturnsDepotAndActualChangeList()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void VerifyAllChangesetArgumentsWithDefaultOptionsReturnsTrue()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void VerifyAllChangesetArgumentsWithdifferentOptionsReturnsFalse()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestSubmitTicketWithRequiredReviewer()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestCreateReviewMultipleTikcetsWithRequiredReviewer()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        public void TestCreateReviewWithInvalidTikcetArgument()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        [CssIteration("vstfs:///Classification/Node/3ab4f649")]
        [CssProjectStructure("vstfs:///Classification/Node/a8a26a10")]

        public void SubmitNewReviewBasedOnCommitInGitSourceControl()
        {
               Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        [HostType("ASP.NET")]

        public void SubmitNewReviewBasedOnCommitsFromMultipleGitEnlistments()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        [Ignore]
        [Description("This test is flaky, ignoring it till its fixed")]
        public void VerifyThatBookmarkIsCreatedAndDeletedSuccesfully()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        [WorkItem(1)]
        [WorkItem(2)]
        public void VerifySuccessfulBookmarkFileCreationForMultiTickets()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(2)]
        [Obsolete("Will be removed in next version.")]
        public void SubmitNewReviewBasedOnSingleSdChangelist()
        {
            // Assert.Fail("{0}", ErrorDict.NextMsg());
        }

        [TestMethod]
        [Priority(3)]
        public void SingleLineWordReplacementsTicketComment()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
            // Assert.Fail("Test method threw exception: System.AggregateException: One or more errors occurred. ---> FabrikamFiber.ServiceGateway.Core.WebApi.ObjectAlreadyExistsException: TF200019: The object already exists on the Server");
        }

        [TestMethod]
        [Priority(2)]
        public void CollapseCommentsCollection()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
            //Assert.Fail("Test method threw exception: System.AggregateException: One or more errors occurred. ---> FabrikamFiber.ServiceGateway.Core.WebApi.ObjectAlreadyExistsException: TF200019: The object already exists on the Server");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("CriticalTest")]
        [TestProperty("Time", "Long")]
        [TestProperty("TestPass", "Accessibility")]
        [Owner("Manoj Bableshwar")]
        [Description("This is gets collections of service tickets and process them")]
        public void CollapseCollectionToNonempty()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 50);
            System.Threading.Thread.Sleep(randomNumber);
            Assert.Fail("{0}", ErrorDict.NextMsg());
            //Assert.Fail("Test method threw exception: System.AggregateException: One or more errors occurred. ---> FabrikamFiber.ServiceGateway.Core.WebApi.ObjectAlreadyExistsException: TF200019: The object already exists on the Server");
        }
    }
}
