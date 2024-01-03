using Promact.Core.Models;
using System.Threading.Tasks;

namespace Promact.Core.Mail
{
    public interface IMailService
    {
        Task<SendEmailResult> SendEmailAsync(SimpleEmailRequest simpleEmailRequest);
        Task<SendEmailResult> SendTemplatedEmailAsync(TemplatedEmailRequest templatedEmailRequest);
    }
}
