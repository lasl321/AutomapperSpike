using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperSpike
{
    public class Mapper
    {
        public Mapper(IEnumerable<AutoMapper.Profile> profiles)
        {
            AutoMapper.Mapper.Reset();

            AutoMapper.Mapper.Initialize(c =>
            {
                foreach (var profile in profiles)
                {
                    c.AddProfile(profile);
                }
            });
        }

        public T Map<T>(object source)
        {
            return AutoMapper.Mapper.Map<T>(source);
        }
    }
}
