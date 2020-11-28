using ServiceA.Domain;
using System.Threading.Tasks;

namespace ServiceA.Service.Contract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
