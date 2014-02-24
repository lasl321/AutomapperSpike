using NUnit.Framework;
using AMapper = AutoMapper.Mapper;

namespace AutomapperSpike
{
    [TestFixture]
    public class MapperTests
    {
        [SetUp]
        public void SetUp()
        {
            _mapper = new Mapper(new[] {new Profile()});
        }

        private const int TestAge = 3321;
        private const string TestName = "FooBar";
        private Mapper _mapper;

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

        private class Profile : AutoMapper.Profile
        {
            protected override void Configure()
            {
                AMapper.CreateMap<Source, Destination>();
            }
        }

        [Test]
        public void ShouldDoStuff()
        {
            var destination = _mapper.Map<Destination>(new Source
            {
                Age = TestAge,
                Name = TestName
            });

            Assert.That(destination.Age, Is.EqualTo(TestAge));
            Assert.That(destination.Name, Is.EqualTo(TestName));
        }
    }
}