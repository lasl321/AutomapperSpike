using AutoMapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperSpike
{
    [TestFixture]
    public class ExactMatchTest
    {
        class Source
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        class Destination
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        
        [SetUp]
        public void SetUp()
        {
            Mapper.Reset();
            Mapper.CreateMap<Source, Destination>();
        }

        [Test]
        public void ShouldBeOk()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
