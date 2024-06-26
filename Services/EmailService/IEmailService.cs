using EmailApp.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace EmailApp.Services.EmailService;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}