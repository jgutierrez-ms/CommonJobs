﻿using System;
using Raven.Client;
namespace CommonJobs.Infrastructure.Migrations
{
    public interface IMigration
    {
        IDocumentStore DocumentStore { get; set; }
        void Down();
        void Up();
    }
}
