﻿using AutoFixture;

namespace FoSouzaDev.Common.Domain.UnitaryTests;

public abstract class BaseTest
{
    protected Fixture Fixture { get; private set; }

    protected BaseTest() => Fixture = new();
}