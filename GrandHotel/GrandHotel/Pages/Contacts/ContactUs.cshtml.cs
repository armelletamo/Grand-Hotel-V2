using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;

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
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(Contact.Name, Contact.Email));
                    message.To.Add(new MailboxAddress("youremail@example.com"));
                    message.Subject = $"[Contact from Grand Hotel website] { Contact.Subject }";

                    var builder = new BodyBuilder
                    {
                        HtmlBody = $"<div><span style='font-weight: bold'>The message was sent by</span> : {Contact.Name} </div><div><span style='font-weight: bold'>Email</span> : {Contact.Email}</div><div style='margin-top: 30px'>{Contact.Message}</div>"
                    };

                    message.Body = builder.ToMessageBody();

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("test.grandhotel@gmail.com", "Bogossian1987");
                        client.Send(message);
                        client.Disconnect(true);
                    }
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