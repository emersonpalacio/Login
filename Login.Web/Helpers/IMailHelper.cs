using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Common.Models;

namespace Login.Web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
