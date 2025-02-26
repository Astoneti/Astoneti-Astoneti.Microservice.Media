﻿using System;

namespace Astoneti.Microservice.Media.Data.Entities
{
    public class NewsEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
