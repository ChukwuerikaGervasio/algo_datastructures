namespace ConsoleApplication
{
    public class FormHandler : IFormHandler
    {
        private readonly IMailSender mailSender;

        public FormHandler(IMailSender mailSender)
        {
            // this class requires a concrete implementationof IMailSender, so we
            // need to pass it in through the constructor (called Constructor Injection)
            this.mailSender = mailSender;
        }
        
        public void Handle(string toAddress)
        {
            mailSender.Send(toAddress, "Sending a mail");
        }
    }
}
