﻿using MediatR;
using ServerManagement.Detectors.Responses.Updates;
using System;
using System.Collections.Generic;

namespace ServerManagement.Detectors.Requests.Updates
{
    public class DetectRequest : IRequest<List<WindowsUpdate>>
    {
        public string ComputerName { get; set; } = Environment.MachineName;
    }
}