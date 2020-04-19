namespace University_Management_System_API.DataAccess.DataAccessObject.Common.BaseFile
{
    using System.Collections.Generic;

    public interface IBaseStorage<TEntity, TPK>
    {
        void SaveToDataSource();

        Dictionary<TPK, TEntity> ReadJsonFile();

        Dictionary<TPK, TEntity> ReturnDictionary();
    }
}
