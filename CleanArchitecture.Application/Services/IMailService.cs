﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IMailService
    {
        Task SendMailService(string toEmail, string subject, string body);
    }
}
