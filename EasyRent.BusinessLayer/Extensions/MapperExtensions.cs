using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace EasyRent.BusinessLayer.Extensions
{
    public static class MapperExtensions
    {
        public static IEnumerable<TDestionation> MapCollection<TDestionation>(this IMapper mapper, object source)
        {
            if (source is IEnumerable)
            {
                return mapper.Map<IEnumerable<TDestionation>>(source);
            }

            return null;
        }
    }
}