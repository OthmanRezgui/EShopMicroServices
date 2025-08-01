﻿using System;
namespace BuildingBlocks.Exceptions
{
    internal class BadRequestException : Exception
    {
        public string? Details { get; }

        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(string message, string details) : base(message)
        {
            Details = details;
        }
    }
}
