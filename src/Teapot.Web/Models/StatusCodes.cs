﻿using System.Collections.Generic;

namespace Teapot.Web.Models
{
    public class StatusCodes : Dictionary<int, StatusCode>
    {
        public StatusCodes()
        {
            Add(200, new StatusCode
            {
                Description = "OK",
            });
            Add(201, new StatusCode
            {
                Description = "Created",
            });
            Add(202, new StatusCode
            {
                Description = "Accepted"
            });
            Add(203, new StatusCode
            {
                Description = "Non-Authoritative Information"
            });
            Add(204, new StatusCode
            {
                Description = "No Content",
                ExcludeBody = true
            });
        }
    }
}