using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AMapper = AutoMapper.Mapper;

namespace AutomapperSpike
{
    public class MissingPropertyTest
    {
        class Source
        {
            public int Age { get; set; }
        }

        class Destination
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            AMapper.Reset();
            AMapper.CreateMap<Source, Destination>();
        }

        [Test]
        [ExpectedException(typeof(AutoMapper.AutoMapperConfigurationException), 
            ExpectedMessage = "Unmapped members were found", 
            MatchType = MessageMatch.Contains)]
        public void ShouldThrowException()
        {
            AMapper.AssertConfigurationIsValid();
        }
    }


}
