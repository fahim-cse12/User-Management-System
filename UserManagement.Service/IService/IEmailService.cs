using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Service.Models;

namespace UserManagement.Service.IService
{
    public interface IEmailService
    {
       void SendEmail(Message message);
    }
}
