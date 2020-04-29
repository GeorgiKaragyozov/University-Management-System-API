namespace University_Management_System_API.Controller.Service.Auth
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Authorization;
    using University_Management_System_API.Business.Processor.Auth;
    using University_Management_System_API.Business.Convertor.Auth;
    using System.Collections.Generic;

    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthProcessor _processor;
        public IAuthProcessor Processor
        {
            get { return this._processor; }
            set { this._processor = value; }
        }

        public AuthController(IAuthProcessor processor)
        {
            this.Processor = processor;
        }

        /// <summary>
        /// function that creates a new user session
        /// </summary>
        /// <returns>new param</returns>
        /// <response code="200">Login Successfully</response>
        /// <response code="400"></response> 
        [HttpGet(nameof(Login))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Login()
        {           
            try
            {
                string authTokenUser = Processor.GetAuthToken();

                if(authTokenUser == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(authTokenUser);
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// function that searches for an existing user session and deletes it
        /// </summary>
        /// <returns>new param</returns>
        /// <response code="200">Logout Successfully</response>
        /// <response code="400"></response> 
        [HttpGet(nameof(Logout))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Logout()
        {          
            try
            {
                Processor.EraseApiSession();

                return Ok("Session was successfully delete.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }         
        }

        [HttpPost(nameof(Register))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        public ActionResult Register([FromBody]RegisterParam param)
        {
            try
            {       
                return Ok(Processor.Register(param));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetUserGroups/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        public ActionResult GetUserGroups(string userId)
        {
            try
            {
                if(userId != null)
                {
                    List<string> results = Processor.GetUserGroups(userId);
                    return Ok(results);
                }

                return BadRequest();          
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
