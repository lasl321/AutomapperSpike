using AutoMapper;
using NUnit.Framework;
using AutoMapperMapper = AutoMapper.Mapper;

namespace AutomapperSpike
{
    public class MissingPropertyTest
    {
        [SetUp]
        public void SetUp()
        {
            AutoMapperMapper.Reset();
            AutoMapperMapper.CreateMap<Source, Destination>();
        }

        [Test]
        [ExpectedException(typeof (AutoMapperConfigurationException),
            ExpectedMessage = "Unmapped members were found",
            MatchType = MessageMatch.Contains)]
        public void ShouldThrowException()
        {
            AutoMapperMapper.AssertConfigurationIsValid();
        }

        private class Destination
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        private class Source
        {
            public int Age { get; set; }
        }
    }
}