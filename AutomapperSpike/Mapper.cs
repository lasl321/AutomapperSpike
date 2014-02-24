using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperSpike
{
    public class Mapper
    {
        public T Map<T>(object source)
        {
            return (T)AutoMapper.Mapper.Map(source, source.GetType(), typeof(T));
        }
    }
}
