namespace University_Management_System_API.Business.Convertor.Common
{
    public interface IBaseResultConverter<TEntity, TResult>
    {
        TResult ConvertStandart(TEntity entity, TResult result);

        void ConvertSpecific(TEntity entity, TResult result);

        TResult Convert(TEntity entity);
    }
}
