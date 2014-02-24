using AutoMapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMapper = AutoMapper.Mapper;

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
            AMapper.Reset();
            AMapper.CreateMap<Source, Destination>();
        }

        [Test]
        public void ShouldBeOk()
        {
            AMapper.AssertConfigurationIsValid();
        }
    }
}
