﻿using ApprovalTests;
using Xunit;

namespace jarai.tdd2.OutsideInTDD.Tests.AcceptanceTests;

public class ApprovalTest
{
    [Fact]
    public void KontoauszugTest()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());
        target.Einzahlen(100);
        target.Abheben(50);

        // Act
        string kontoauszug = target.ErstelleKontoauszug();

        // Assert
        Approvals.Verify(kontoauszug);
    }
}