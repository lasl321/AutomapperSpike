using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AMapper = AutoMapper.Mapper;

namespace AutomapperSpike
{
    [TestFixture]
    public class MapperTests
    {
        private const int TestAge = 3321;
        private const string TestName = "FooBar";
        private Mapper _mapper;

        [SetUp]
        public void SetUp()
        {
            _mapper = new Mapper(new[] { new Profile() });
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

        class Profile : AutoMapper.Profile
        {
            protected override void Configure()
            {
                AMapper.CreateMap<Source, Destination>();
            }
        }
    }
}
