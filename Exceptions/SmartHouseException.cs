using System;

namespace ProjectSmartHouse.Exceptions;

public class SmartHouseException : Exception
{
    public SmartHouseException(string message) : base(message)
    {
    }
}