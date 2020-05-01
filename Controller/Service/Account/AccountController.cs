namespace University_Management_System_API.Controller.Service.Account
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Processor.Account;
    using University_Management_System_API.Controller.Service.Common;

    public class AccountController 
        : BaseController<AccountParam, AccountResult, long, IAccountProcessor>
    {
        public AccountController(IAccountProcessor processor)
           : base(processor)
        {
        }
    }
}
