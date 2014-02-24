using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AutoMapper;

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
            Mapper.Reset();
            Mapper.CreateMap<Source, Destination>();
        }

        [Test]
        [ExpectedException(typeof(AutoMapperConfigurationException), 
            ExpectedMessage = "Unmapped members were found", 
            MatchType = MessageMatch.Contains)]
        public void ShouldThrowException()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }


}
