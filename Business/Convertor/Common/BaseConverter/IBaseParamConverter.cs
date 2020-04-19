namespace University_Management_System_API.Business.Convertor.Common
{
    public interface IBaseParamConverter<TParam, TEntity>
    {
        TEntity GetEntity(TParam param);

        TEntity ConvertStandart(TParam param, TEntity entity);

        void ConvertSpecific(TParam param, TEntity entity);

        TEntity Convert(TParam param, TEntity entity);
    }
}
