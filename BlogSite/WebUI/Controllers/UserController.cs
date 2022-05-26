using BlogSiteBusiness.Abstract;
using BlogSiteCore.Entities.Enums;
using BlogSiteDataAccess.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModel;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        //private readonly IUserRepository userRepository;
        private readonly IUserService userService;
        private readonly IUserDetailService userDetailService;

        public UserController( IUserService userService,IUserDetailService userDetailService)
        {           
            this.userService = userService;
            this.userDetailService = userDetailService;
        }

        public IActionResult Register()
        {
            UserWithUserDetailVM userWithUserDetailVM = new UserWithUserDetailVM();
            return View(userWithUserDetailVM);
        }

        [HttpPost]
        public IActionResult Register(UserWithUserDetailVM userWithUserDetailVM)
        {
            
            if (ModelState.IsValid)
            {
                userWithUserDetailVM.UserDetail.IsActive = true;
                userWithUserDetailVM.UserDetail.UserRole = UserRole.StandardUser;
                userWithUserDetailVM.UserDetail.Id = userWithUserDetailVM.User.Id;
                
                userService.Add(userWithUserDetailVM.User);
                userDetailService.Add(userWithUserDetailVM.UserDetail);
            }           
          
            return RedirectToAction("Index", "Home");
        }
    }
}
