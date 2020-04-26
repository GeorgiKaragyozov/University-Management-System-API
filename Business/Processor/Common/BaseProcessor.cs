namespace University_Management_System_API.Business.Processor.Common
{
    using System;
    using System.Collections.Generic;
    using University_Management_System_API.Business.Convertor;
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public abstract class BaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TPK, TEntity>
        : IBaseProcessor<TParam, TResult, TPK>

        where TResultConverter : IBaseResultConverter<TEntity, TResult>
        where TParamConverter : IBaseParamConverter<TParam, TEntity>
        where TDao : IBaseDao<TEntity, TPK>
        where TParam : BaseParam
        where TEntity : Persistent
    {
        private TDao _dao;
        public TDao Dao
        {
            get { return _dao; }
            set { _dao = value; }
        }


        private TParamConverter _paramConverter;
        public TParamConverter ParamConverter
        {
            get { return _paramConverter; }
            set { _paramConverter = value; }
        }


        private TResultConverter _resultConverter;
        public TResultConverter ResultConverter
        {
            get { return _resultConverter; }
            set { _resultConverter = value; }
        }

        public BaseProcessor(TDao dao,
            TParamConverter paramConverter,
            TResultConverter resultConverter)

        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        /// <summary>
        /// Function to create new entity .
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>entity</returns>
        public TResult Create(TParam param)
        {
            TEntity entity = null;

            param.DateCreated = DateTime.Now;
            entity = ParamConverter.Convert(param, entity);
            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        /// <summary>
        /// Function to create new entities .
        /// </summary>
        /// <param name="param">params</param>
        /// <returns>entities</returns>
        public List<TResult> Create(List<TParam> param)
        {
            List<TEntity> entities = new List<TEntity>();
            param.ForEach(item => entities.Add(ParamConverter.Convert(item, null)));

            Dao.Save(entities);

            List<TResult> result = new List<TResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));

            return result;
        }

        /// <summary>
        /// Function to delete a entity .
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response</returns>
        public void Erase(TPK id)
        {
            Dao.Erase(id);
        }

        /// <summary>
        /// Function to delete entities .
        /// </summary>
        /// <param name="idList">list params's id</param>
        /// <returns>response</returns>
        public void Erase(List<TPK> idList)
        {
            Dao.Erase(idList);
        }

        /// <summary>
        /// Function to update inactive a entity .
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response</returns>
        public void Delete(TPK id)
        {
            Dao.Delete(id);
        }

        /// <summary>
        /// Function to update inactive entities .
        /// </summary>
        /// <param name="idList">list params's id</param>
        /// <returns>response</returns>
        public void Delete(List<TPK> idList)
        {
            Dao.Delete(idList);
        }

        /// <summary>
        /// Function to find an entity by id .
        /// </summary>
        /// <param name="id">param's id</param>
        /// <returns>response and information about the entity</returns>
        public TResult Find(TPK id)
        {
            TEntity entity = Dao.Find(id);
            TResult result = ResultConverter.Convert(entity);

            return result;
        }

        /// <summary>
        /// Function to find all created entities and print their information .
        /// </summary>
        /// <returns>entities</returns>
        public List<TResult> Find()
        {
            List<TEntity> entities = Dao.Find();
            List<TResult> results = new List<TResult>();

            foreach (TEntity item in entities)
            {
                if(item.Active != 0)
                {
                    results.Add(ResultConverter.Convert(item));
                }             
            }

            return results;
        }

        /// <summary>
        /// Function to find an entity by field
        /// </summary>
        /// <param name="field">field</param>
        /// <param name="value">value</param>
        /// <returns>response and information about the entity</returns>
        public List<TResult> Find(string field, string value)
        {
            List<TEntity> entities = Dao.Find(field, value);
            List<TResult> results = new List<TResult>();

            foreach (var item in entities)
            {
                if (item.Active != 0)
                {
                    results.Add(ResultConverter.Convert(item));
                }
            }

            return results;
        }

        /// <summary>
        ///  Function to find an entity by name .
        /// </summary>
        /// <param name="name">entity's name</param>
        /// <returns>response and information about the entity</returns>
        public TResult FindByName(string name)
        {
            TEntity entity = Dao.FindByName(name);
            TResult result = ResultConverter.Convert(entity);

            return result;
        }

        /// <summary>
        ///  Function to find an entity by code .
        /// </summary>
        /// <param name="code">entity's code</param>
        /// <returns>response and information about the entity</returns>
        public TResult FindByCode(string code)
        {
            TEntity entity = Dao.FindByCode(code);
            TResult result = ResultConverter.Convert(entity);

            return result;
        }

        /// <summary>
        /// Function to update information about a entity .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <param name="param">entity</param>
        /// <returns>response and update entity</returns>
        public void Update(TPK id, TParam param)
        {
            TEntity oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                TEntity newEntity = Dao.Update(ParamConverter.Convert(param, oldEntity));
                Dao.Update(newEntity);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Function to update information about entities .
        /// </summary>
        /// <param name="param">entities</param>
        /// <returns>response and update entities</returns>
        public void Update(List<TParam> param)
        {
            List<TEntity> entities = new List<TEntity>();

            foreach (var item in param)
            {
                TEntity oldEntity = Dao.Find(GetTPK(item));

                if(oldEntity != null)
                {
                    entities.Add(ParamConverter.Convert(item, oldEntity));
                }
            }

            Dao.Update(entities);
        }

        /// <summary>
        /// Takes primary key of param
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>param's id</returns>
        protected abstract TPK GetTPK(TParam param);

        /// <summary>
        /// function that validates а param. 
        /// </summary>
        /// <param name="param">param</param>
        public void ValidateParameters(TParam param)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// function that validates list of params .
        /// </summary>
        /// <param name="param">params</param>
        public void ValidateParameters(List<TParam> param)
        {
            throw new NotImplementedException();
        }    
    }
}
