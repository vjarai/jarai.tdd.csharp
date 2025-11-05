# .NET 9.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 9.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 9.0 upgrade.
3. Upgrade jarai.tdd4b.Adapter.csproj
4. Upgrade jarai.tdd8.Kniffel.Legacy.csproj
5. Upgrade jarai.tdd9.Kniffel.csproj
6. Upgrade jarai.tdd5.AutoFixture.csproj
7. Upgrade jarai.tdd4.Moq.csproj
8. Upgrade jarai.tdd7.MarsRoverKata.csproj
9. Upgrade jarai.tdd6.DependencyInjection.DIY.csproj
10. Upgrade jarai.tdd3.TestDoubles.csproj
11. Upgrade jarai.tdd2.OutsideInTDD.csproj
12. Upgrade jarai.tdd1.RedGreenRefactor.csproj
13. Upgrade jarai.tdd4b.Adapter.Tests.csproj
14. Upgrade jarai.tdd8.Kniffel.Legacy.Tests.csproj
15. Upgrade jarai.tdd9.Kniffel.Tests.csproj
16. Upgrade jarai.tdd5.AutoFixture.Tests.csproj
17. Upgrade jarai.tdd4.Moq.Tests.csproj
18. Upgrade jarai.tdd7.MarsRoverKata.Tests.csproj
19. Upgrade jarai.tdd6.DependencyInjection.NetCore.csproj
20. Upgrade jarai.tdd0.Refresher.csproj
21. Upgrade jarai.tdd3.TestDoubles.Tests.csproj
22. Upgrade jarai.tdd2.OutsideInTDD.Tests.csproj
23. Upgrade jarai.tdd1.RedGreenRefactor.Tests.csproj
24. Run unit tests to validate upgrade in the projects listed below:
  - jarai.tdd4b.Adapter.Tests.csproj
  - jarai.tdd8.Kniffel.Legacy.Tests.csproj
  - jarai.tdd9.Kniffel.Tests.csproj
  - jarai.tdd5.AutoFixture.Tests.csproj
  - jarai.tdd4.Moq.Tests.csproj
  - jarai.tdd7.MarsRoverKata.Tests.csproj
  - jarai.tdd3.TestDoubles.Tests.csproj
  - jarai.tdd2.OutsideInTDD.Tests.csproj
  - jarai.tdd1.RedGreenRefactor.Tests.csproj

## Settings

### Excluded projects

| Project name | Description |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

| Package Name | Current Version | New Version | Description |
|:-----------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.Extensions.Hosting | 7.0.1 | 9.0.10 | Recommended for .NET 9.0 |

### Project upgrade details

#### jarai.tdd4b.Adapter.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd8.Kniffel.Legacy.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd9.Kniffel.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd5.AutoFixture.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd4.Moq.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd7.MarsRoverKata.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd6.DependencyInjection.DIY.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`
NuGet packages changes:
  - Microsoft.Extensions.Hosting should be updated from `7.0.1` to `9.0.10` (*recommended for .NET 9.0*)

#### jarai.tdd3.TestDoubles.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd2.OutsideInTDD.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd1.RedGreenRefactor.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd4b.Adapter.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd8.Kniffel.Legacy.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd9.Kniffel.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net8.0` to `net9.0`

#### jarai.tdd5.AutoFixture.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd4.Moq.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd7.MarsRoverKata.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd6.DependencyInjection.NetCore.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`
NuGet packages changes:
  - Microsoft.Extensions.Hosting should be updated from `7.0.1` to `9.0.10` (*recommended for .NET 9.0*)

#### jarai.tdd0.Refresher.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd3.TestDoubles.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd2.OutsideInTDD.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`

#### jarai.tdd1.RedGreenRefactor.Tests.csproj modifications
Project properties changes:
  - Target framework should be changed from `net6.0` to `net9.0`
