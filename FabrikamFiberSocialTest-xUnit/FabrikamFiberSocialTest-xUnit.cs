using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace FabrikamFiberSocialTest_xUnit
{
    public class FabrikamFiberSocialTest_xUnit
    {
        [Fact(Skip = "Takes too long")]
        public void CreateTicketFromFBPost()
        {
            Console.WriteLine("testing sample consle output for passed test");
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        [Trait("Category","SocialTest")]
        [Trait("Severity", "Medium")]
        [Trait("Owner", "mabables")]
        [Trait("Priority", "1")]
        public void CreateTicketFromLinkedInPost()
        {
            Console.WriteLine("testing sample consle output for failed test");
            Assert.Equal(5, Add(2, 2));
        }

        private readonly ITestOutputHelper output;

        public FabrikamFiberSocialTest_xUnit(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CreateTicketFromTwitterPost()
        {
            //var temp = "the console";
            output.WriteLine(@"
                Requestig access via TwitterAuthClient... 
                Setting up TwitterApiClient object...
                Getting service status with twitterApiClient.getStatusesService...
               
                ");
                Assert.True(false, "getStatusesService unknown error. Failed to get service status");
        }
        [Fact]
        public void AnalyzeYoutubePostSentiment()
        {
            //var temp = "the console";
            output.WriteLine(@"
                Requestig access via FBAuthClient... 
                Setting up FBApiClient object...
                Getting service status with FBApiClient.getStatusesService...
                Findig ratio of likes to dislikes...             
                ");
            int likes = 100;
            int dislikes = 0;
            //force divide by zero error... :-)
            float ratio = likes / dislikes; 
        }

        int Add(int x, int y)
        {
            return x + y;
        }





        /* See here for more data: http://xunit.github.io/docs/capturing-output.html
        https://www.pluralsight.com/courses/xunitdotnet-test-framework
        
        private readonly IMessageSink diagnosticMessageSink;

        public FabrikamFiberSocialTest_xUnit(IMessageSink diagnosticMessageSink)
        {
            this.diagnosticMessageSink = diagnosticMessageSink;
        }

        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases)
            where TTestCase : ITestCase
        {
            var result = testCases.ToList();  // Run them in discovery order
            var message = new DiagnosticMessage("Ordered {0} test cases", result.Count);
            diagnosticMessageSink.OnMessage(message);
            return result;
        }*/
    }
}

