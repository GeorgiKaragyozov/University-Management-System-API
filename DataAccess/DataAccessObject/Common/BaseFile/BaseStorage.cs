namespace University_Management_System_API.DataAccess.DataAccessObject.Common
{
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using University_Management_System_API.DataAccess.DataAccessObject.Common.BaseFile;

    public abstract class BaseStorage<TEntity, TPK> : IBaseStorage<TEntity, TPK>
        where TEntity : Persistent
    {
        private List<TEntity> GetList = new List<TEntity>();

        private Dictionary<TPK, TEntity> GetDictionary = new Dictionary<TPK, TEntity>();

        public BaseStorage()
        {
            GetPath();
            GetDictionary = ReadJsonFile();
        }

        /// <summary>
        /// Save data to a Json file .
        /// </summary>
        public void SaveToDataSource()
        {
            string strResultJson = JsonConvert.SerializeObject(GetDictionary);

            File.WriteAllText(GetPath(), strResultJson);
        }

        /// <summary>
        /// Reads from the Json file and writes the read dictionary data .
        /// </summary>
        /// <returns>Оbject dictionary</returns>
        public Dictionary<TPK, TEntity> ReadJsonFile()
        {
            GetList = JsonConvert.DeserializeObject<List<TEntity>>(File.ReadAllText(GetPath()));          

            GetDictionary = GetList.ToDictionary(entity => GetTPK(entity) , entity => entity);

            return GetDictionary;
        }

        /// <summary>
        /// Тakes the data dictionary and returns it .
        /// </summary>
        /// <returns>Оbject dictionary</returns>
        public Dictionary<TPK, TEntity> ReturnDictionary()
        {
            return GetDictionary;
        }

        /// <summary>
        /// Тakes the path of the Json files
        /// </summary>
        /// <returns>Path Json</returns>
        public abstract string GetPath();

        /// <summary>
        /// Takes primary key of entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Primary key</returns>
        public abstract TPK GetTPK(TEntity entity);
    }
}
