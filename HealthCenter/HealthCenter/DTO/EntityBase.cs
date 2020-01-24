using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace HealthCenter
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; } = 0;
        [Computed]
        public virtual DateTime? LastModified { get; set; } = null;

        protected void CopyValues<TEntityParent, TEntityDeprived>(TEntityParent ParentInstance, TEntityDeprived ChildIntance)
           where TEntityParent : class, IEntity
           where TEntityDeprived : class, IEntity
        {
            if (ParentInstance != null) // identifies if the entity is null
            {
                var properties = ParentInstance.GetType().GetProperties();
                foreach (PropertyInfo prop in properties)
                {
                    if (prop.CanWrite == true)
                    {
                        PropertyInfo prop2 = ParentInstance.GetType().GetProperty(prop.Name);
                        prop2.SetValue(ChildIntance, prop.GetValue(ParentInstance, null), null);
                    }
                }
            }
            else
            {

            }
        }

    }
}
