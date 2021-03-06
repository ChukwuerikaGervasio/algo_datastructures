using System;

namespace ConsoleApplication
{
    public class MockMailSender : IMailSender
    {
        private readonly ILogging logging;

        public MockMailSender(ILogging logging)
        {
            // when instantiating this class, Ninject will automatically resolve which
            // implementation of ILogging to use and pass it in
            this.logging = logging;
        }
        public void Send(string toAddress, string subject)
        {
            logging.Debug("Sending Mail");
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }    
}
