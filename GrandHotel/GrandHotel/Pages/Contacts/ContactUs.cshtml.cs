using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace GrandHotel.Pages.Contacts
{
    public class ContactUsModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage message = new MailMessage();
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                    message.From = new MailAddress("test.grandhotel@gmail.com");
                    message.To.Add(new MailAddress("test.grandhotel@gmail.com"));
                    message.Subject = "Test";
                    message.IsBodyHtml = true; //to make message body as html  
                    message.Body = $"<div><span style='font-weight: bold'>The message was sent by</span> : {Contact.Name} </div><div><span style='font-weight: bold'>Email</span> : {Contact.Email}</div><div style='margin-top: 30px'>{Contact.Message}</div>";
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com"; //for gmail host  
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("test.grandhotel@gmail.com", "Bogossian1987");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    
                    TempData["Confirm"] = "Your message was successfully sent.";
                }
                catch (Exception)
                {
                    TempData["Confirm"] = "Sorry we were unable to send your message.";
                }
            }
            
            return Page();
        }
    }
}