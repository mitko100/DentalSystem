﻿namespace DentalSystem.Web.Areas.Identity.Services
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity.UI.Services;


    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return new Task(() => { });
        }
    }
}
