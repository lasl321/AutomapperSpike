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
        private Mapper _mapper;

        [SetUp]
        public void SetUp()
        {
            AMapper.Reset();
            AMapper.CreateMap<Source, Destination>();
            _mapper = new Mapper();
        }

        [Test]
        public void ShouldDoStuff()
        {
            var destination = _mapper.Map<Destination>(new Source());

            Assert.That(destination, Is.InstanceOf<Destination>());
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
    }
}
