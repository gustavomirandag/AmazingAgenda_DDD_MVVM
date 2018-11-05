using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AmazingAgenda.Infrastructure.Extensions
{
    public static class ObjectExtensions
    {
        public static void CopyPropertiesFrom(this object target, object source)
        {
            if (target == null || source == null) throw new ArgumentNullException(nameof(target),
                "Target or Source null");
            var targetPropertiesDic = target.GetType().GetProperties().Where(p => p.CanWrite).ToDictionary(p => p.Name, StringComparer.CurrentCultureIgnoreCase);
            foreach (var sourceProp in source.GetType().GetProperties().Where(p => p.CanRead))
            {
                PropertyInfo targetProp;
                if (targetPropertiesDic.TryGetValue(sourceProp.Name, out targetProp))
                {
                    targetProp.SetValue(target, sourceProp.GetValue(source, null), null);
                }
            }
        }
    }
}
