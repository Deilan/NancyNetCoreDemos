﻿using Nancy;

namespace NancyNetCoreDemos.FromScratchV1.Nancy
{
    public class AppNancyModule : NancyModule
    {
        public AppNancyModule()
        {
            Get["/"] = _ => View["index"];
            Get["/{fileName}"] = parameters => View[parameters.fileName];
        }
    }
}
