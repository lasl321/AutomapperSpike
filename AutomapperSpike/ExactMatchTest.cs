using NUnit.Framework;
using AutoMapperMapper = AutoMapper.Mapper;

namespace AutomapperSpike
{
    [TestFixture]
    public class ExactMatchTest
    {
        [SetUp]
        public void SetUp()
        {
            AutoMapperMapper.Reset();
            AutoMapperMapper.CreateMap<Source, Destination>();
        }

        private class Source
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        private class Destination
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        [Test]
        public void ShouldBeOk()
        {
            AutoMapperMapper.AssertConfigurationIsValid();
        }
    }
}