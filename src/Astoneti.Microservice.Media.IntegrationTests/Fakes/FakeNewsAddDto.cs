﻿using Astoneti.Microservice.Media.Business.Contracts;

namespace Astoneti.Microservice.Media.IntegrationTests.Fakes
{
    public class FakeNewsAddDto : INewsAddDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
