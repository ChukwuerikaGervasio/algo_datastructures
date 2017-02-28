using System;
using System.Reflection;

using Ninject;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new Bindings());
            var mailSender = kernel.Get<IMailSender>();

            var formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
