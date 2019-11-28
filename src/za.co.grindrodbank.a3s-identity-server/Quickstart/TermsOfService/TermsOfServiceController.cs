﻿using System;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using za.co.grindrodbank.a3s.Managers;
using za.co.grindrodbank.a3s.Repositories;
using za.co.grindrodbank.a3sidentityserver.Quickstart.UI;

namespace za.co.grindrodbank.a3sidentityserver.Quickstart.UI
{
    [SecurityHeaders]
    [Authorize]
    public class TermsOfServiceController : Controller
    {
        private readonly CustomUserManager userManager;
        private readonly ITermsOfServiceRepository termsOfServiceRepository;

        public TermsOfServiceController(CustomUserManager userManager, ITermsOfServiceRepository termsOfServiceRepository)
        {
            this.userManager = userManager;
            this.termsOfServiceRepository = termsOfServiceRepository;
        }

        /// <summary>
        /// Entry point into the terms of service workflow
        /// </summary>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index(string returnUrl)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            if (user == null)
                throw new AuthenticationException("Invalid login data");

            var vm = BuildTermsOfServiceViewModel(returnUrl);
            return View(vm);
        }






        /************************************************/
        /* helper APIs for the TermsOfServiceController */
        /************************************************/
        private TermsOfServiceViewModel BuildTermsOfServiceViewModel(string returnUrl)
        {

            return new TermsOfServiceViewModel();
        }

    }
}
