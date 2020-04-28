namespace University_Management_System_API.Controller.Service.Common
{
    using System;
    using System.Linq;
    using Castle.Core.Internal;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;
    using University_Management_System_API.Business.Processor.Common;

    [Authorize]
    [ApiController]
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public abstract class BaseController<TParam, TResult, TPK, TBaseProcessor> : ControllerBase

        where TBaseProcessor : IBaseProcessor<TParam, TResult, TPK> 
    {
        private TBaseProcessor _processor;
        public TBaseProcessor Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        public BaseController(TBaseProcessor processor)
        {
            this.Processor = processor;
        }
    
        /// <summary>
        /// Function to create new entity .
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>new param</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the param is null</response> 
        [HttpPost(nameof(Create))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        public ActionResult Create([FromBody]TParam param)
        {
            if (param == null)
            {
                BadRequest();
            }

            try
            {
                TResult result = Processor.Create(param);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        /// Function to create new list of entities .
        /// </summary>
        /// <param name="param">list of params</param>
        /// <returns>new params</returns>
        /// <response code="201">Returns newly created items</response>
        /// <response code="400">If the param is null</response> 
        [HttpPost(nameof(CreateByList))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateByList([FromBody]List<TParam> param)
        {
            if (param == null)
            {
                BadRequest();
            }

            try
            {
                List<TResult> result = Processor.Create(param);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        /// Function to delete a entity by id.
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response</returns>
        /// <response code="200">Returns deleted items by Id</response>
        /// <response code="400">If the param's id is null</response> 
        [HttpDelete("EraseById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult EraseById(TPK id)
        {
            if(id == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Erase(id);

                if(id == null)
                {
                    NotFound();
                }

                return Ok($"The entity with id = {id} was successfully deleted .");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        /// Function to delete entities by list.
        /// </summary>
        /// <param name="idList">list params's id</param>
        /// <returns>response</returns>
        /// <response code="200">Returns deleted items</response>
        /// <response code="400">If the param's id is null</response> 
        [HttpDelete("EraseByList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Erase(List<TPK> idList)
        {
            if(idList == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Erase(idList);

                return Ok("The entity was successfully removed.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to find an entity by id .
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response and information about the param</returns>
        /// <response code="302">Returns the found item by id</response>
        /// <response code="400">If the param's id is null</response> 
        [HttpGet("FindByPk/{id}")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult FindByPk(TPK id)
        {
            if (id == null)
            {
                BadRequest();
            }

            try
            {
                TResult result = Processor.Find(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to find all created entities and print their information .
        /// </summary>
        /// <returns>params</returns>
        /// <response code="302">Returns the found item</response>
        [HttpGet(nameof(ListAll))]
        [Authorize(Roles = "admin")]     
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ListAll()
        {
            try
            {
                List<TResult> results = Processor.Find();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to find an entity by field
        /// </summary>
        /// <param name="field">field</param>
        /// <param name="value">value</param>
        /// <returns>response and information about the param</returns>
        /// <response code="302">Returns the found item by field and value</response>
        /// <response code="400">If the field or value are null</response> 
        [HttpGet("FindByField/{field}/{value}")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "admin")]
        public ActionResult FindByField(string field, string value)
        {
            if(field == null && value == null)
            {
                BadRequest();
            }

            try
            {
                List<TResult> result = Processor.Find(field, value);

                if(!result.IsNullOrEmpty())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <response code="200"></response>
        /// <response code="400"></response> 
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("FindByFieldSingle/{field}/{value}")]
        public ActionResult FindByFieldSingle(string field, string value)
        {
            if (field == null && value == null)
            {
                BadRequest();
            }

            try
            {
                TResult result = Processor.Find(field, value)
                    .FirstOrDefault();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        ///  Function to find an entity by name .
        /// </summary>
        /// <param name="name">param's name</param>
        /// <returns>response and information about the param</returns>
        /// <response code="302">Returns the found item by name</response>
        /// <response code="400">If the name is null</response> 
        [HttpGet("FindByName/{name}")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult FindByName(string name)
        {
            if (name == null)
            {
                BadRequest();
            }

            try
            {
                TResult result = Processor.FindByName(name);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        ///  Function to find an entity by code .
        /// </summary>
        /// <param name="code">param's code</param>
        /// <returns>response and information about the param</returns>
        /// <response code="302">Returns the found item by code</response>
        /// <response code="400">If the code is null</response> 
        [HttpGet("FindByCode/{code}")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult FindByCode(string code)
        {
            if (code == null)
            {
                BadRequest();
            }

            try
            {
                TResult result = Processor.FindByCode(code);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to update information about a entity .
        /// </summary>
        /// <param name="id">param's id</param>
        /// <param name="param">param</param>
        /// <returns>response and update param</returns>
        /// <response code="200">Returns the updated object</response>
        /// <response code="400">If the id or param are null</response> 
        [HttpPut("Update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Update(TPK id, [FromBody]TParam param)
        {
            if (id == null && param == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Update(id, param);

                return Ok($"The entity updated successfully . {param}");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to update information about list of entities .
        /// </summary>
        /// <param name="param">params</param>
        /// <returns>response and update params</returns>
        /// <response code="200">Returns updated objects</response>
        /// <response code="400">If the params are null</response> 
        [HttpPut("UpdateByList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Update(List<TParam> param)
        {
            if(param == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Update(param);

                return Ok($"The entities have been updated. {param}");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Function to update inactive a entity by id.
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response</returns>
        /// <response code="200">Returns update items by Id</response>
        /// <response code="400">If the param's id is null</response> 
        [HttpPut("DeleteById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]     
        public ActionResult DeleteById(TPK id)
        {
            if (id == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Delete(id);

                if (id == null)
                {
                    NotFound();
                }

                return Ok($"Entity id = {id} successfully updated to inactive .");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        /// Function to update inactive entities by list.
        /// </summary>
        /// <param name="idList">list params's id</param>
        /// <returns>response</returns>
        /// <response code="200">Returns update items</response>
        /// <response code="400">If the param's id is null</response> 
        [HttpPut("DeleteByList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete(List<TPK> idList)
        {
            if (idList == null)
            {
                BadRequest();
            }

            try
            {
                Processor.Delete(idList);

                return Ok("The entities was successfully update to inactive.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
