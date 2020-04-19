namespace University_Management_System_API.Business.Convertor.Common
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    public abstract class BaseParamConverter<TParam, TEntity> : IBaseParamConverter<TParam, TEntity>
        where TEntity : Persistent
    {
        /// <summary>
        /// Takes entity
        /// </summary>
        /// <param name="param">param</param>
        /// <returns>entity</returns>
        public abstract TEntity GetEntity(TParam param);

        /// <summary>
        /// Maps the entity's properties with the corresponding param properties.
		/// if the param's property has the track attribute it will map the property 
		/// to a destination property(from the attribute) in the entity.
        /// </summary>
        /// <param name="param">Param</param>
        /// <param name="entity">Entity</param>
        /// <returns>Mapped entity</returns>
        public TEntity ConvertStandart(TParam param, TEntity entity)
        {
            Dictionary<string, PropertyInfo> paramProp = param.GetType()
                .GetProperties()
                    .Where(p => IsIgnored(p) == false)
                        .ToDictionary(x => x.Name, x => x);

            Dictionary<string, PropertyInfo> entityProp = entity.GetType()
                .GetProperties()
                    .ToDictionary(x => x.Name, x => x);

            foreach (var paramItem in paramProp)
            {
                if (entityProp.ContainsKey(paramItem.Key))
                {
                    entity.GetType().GetProperty(paramItem.Key).SetValue(
                        entity, paramItem.Value.GetValue(param));
                }
            }

            return entity;
        }

        /// <summary>
        /// Sets the entity's specific properties using the metadata for the property
		/// from the related param's property.
        /// </summary>
        /// <param name="param">Param</param>
        /// <param name="entity">Entity</param>
        public abstract void ConvertSpecific(TParam param, TEntity entity);

        public bool IsIgnored(PropertyInfo prop)
        {
            ParamPropertyAttribute ignoreProp =
                (ParamPropertyAttribute)Attribute.GetCustomAttribute(
                    prop, typeof(ParamPropertyAttribute));

            if (ignoreProp != null)
            {
                if (ignoreProp.Ignored == true)
                    return true;
                else
                    return false;
            }

            return false;
        }

        /// <summary>
        /// Convert param to entity
        /// </summary>
        /// <param name="param">Param</param>
        /// <param name="oldEntity">OldEntity</param>
        /// <returns>Entity</returns>
        public TEntity Convert(TParam param, TEntity oldEntity)
        {
            TEntity entity = null;

            if(oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = GetEntity(param);
            }

            entity = ConvertStandart(param, entity);
            ConvertSpecific(param, entity);

            return entity;
        }
    }
}
