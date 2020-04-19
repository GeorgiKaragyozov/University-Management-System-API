namespace University_Management_System_API.DataAccess.DataAccessObject.Common
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using University_Management_System_API.DataAccess.DataAccessObject.Common.BaseFile;

    public abstract class BaseDaoFile<TEntity, TPK, TStorage> : IBaseDao<TEntity, TPK>
         where TEntity : Persistent
         where TStorage : IBaseStorage<TEntity,TPK>
    {
        private TStorage _dataStorage;

        public TStorage DataStorage
        {
            get { return _dataStorage; }
            set { _dataStorage = value; }
        }

        public BaseDaoFile(TStorage storage)
        {
            this.DataStorage = storage;
        }

        /// <summary>
        /// Function to delete an entity from the json file by id .
        /// </summary>
        /// <param name="id">entity's id</param>
        public void Erase(TPK id)
        {
            TEntity entity = Find(id);
            Erase(entity);        
        }

        /// <summary>
        /// Function to delete an entity from the json file by entity .
        /// </summary>
        /// <param name="entity">entity</param>
        public void Erase(TEntity entity)
        {
            DataStorage.ReturnDictionary()
                .Remove(GetPK(entity));
        }

        /// <summary>
        /// Function to delete entities from the json file by list from the id .
        /// </summary>
        /// <param name="idList">list of id</param>
        public void Erase(List<TPK> idList)
        {
            idList.ForEach(x => Erase(x));
        }

        /// <summary>
        /// Function to update inactive an entity from the json file by id .
        /// </summary>
        /// <param name="id">entity's id</param>
        public void Delete(TPK id)
        {
            TEntity entity = Find(id);

            entity.Active = 0;

            Update(entity);
        }

        /// <summary>
        /// Function to update inactive an entity from the json file by entity .
        /// </summary>
        /// <param name="entity">entity</param>
        public void Delete(TEntity entity)
        {
            entity.Active = 0;

            Update(entity);
        }

        /// <summary>
        /// Function to update inactive entities from the json file by list from the id .
        /// </summary>
        /// <param name="idList">list of id</param>
        public void Delete(List<TPK> idList)
        {
            idList.ForEach(e => Delete(e));
        }

        /// <summary>
        /// Function to find entities from the json file by list from the entities .
        /// </summary>
        /// <returns>List of entities found</returns>
        public List<TEntity> Find()
        {
            return DataStorage.ReturnDictionary()
                .Values
                .ToList();
        }

        /// <summary>
        /// Function to find an entity from the json file by id .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <returns>The entity found</returns>
        public TEntity Find(TPK id)
        {
            return DataStorage.ReturnDictionary()
                .Where(x => x.Key.Equals(id))
                .Single()
                .Value;
        }

        /// <summary>
        /// Function to find an entity from the json file by field name .
        /// </summary>
        /// <param name="name">The entity name field</param>
        /// <returns>The entity found</returns>
        public TEntity FindByName(string name)
        {
            //
            return DataStorage.ReturnDictionary()
               .Where(entity => entity.Value.Equals(name))
               .FirstOrDefault()
               .Value;
        }

        /// <summary>
        /// Function to find an entity from the json file by field code .
        /// </summary>
        /// <param name="code">The entity code field</param>
        /// <returns>The entity found</returns>
        public TEntity FindByCode(string code)
        {
            //
            return DataStorage.ReturnDictionary()
               .Where(n => n.Value.Equals(code))
               .Single()
               .Value;
        }

        /// <summary>
        /// Function to find entities from the json file by field .
        /// </summary>
        /// <param name="field">The name of the field</param>
        /// <param name="value">field value</param>
        /// <returns>List of entities found</returns>
        public List<TEntity> Find(string field, string value)
        {
            //
            return DataStorage.ReturnDictionary()
               .Values
               .Where(entity => entity.GetType().GetProperty(field).GetValue(entity, null)
               .ToString()
               .Equals(value, StringComparison.OrdinalIgnoreCase))
               .ToList();
        }

        /// <summary>
        /// Function to save the new entity to the json file .
        /// </summary>
        /// <param name="entity">an entity</param>
        /// <returns>The saved entity</returns>
        public TEntity Save(TEntity entity)
        {
            DataStorage.ReturnDictionary().Add(GetPK(entity), entity);

            DataStorage.SaveToDataSource();

            return entity;
        }

        /// <summary>
        /// Function to save the new list of entities to the json file .
        /// </summary>
        /// <param name="entity">List of entities</param>
        /// <returns>The saved list of entities</returns>
        public List<TEntity> Save(List<TEntity> entity)
        {
            entity.ForEach(ent => Save(ent));

            return entity;
        }

        /// <summary>
        /// Function to update entity to the json file .
        /// </summary>
        /// <param name="entity">an entity</param>
        /// <returns>The updated entity</returns>
        public TEntity Update(TEntity entity)
        {
            Erase(entity);

            Save(entity);

            return entity;
        }

        /// <summary>
        /// Function to update list of entitie to the json file .
        /// </summary>
        /// <param name="entity">List of entities</param>
        /// <returns>The updated list of entities</returns>
        public List<TEntity> Update(List<TEntity> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }

        ///<summary>
        /// Takes primary key of entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Primary key</returns>
        protected abstract TPK GetPK(TEntity entity);
    }
}
