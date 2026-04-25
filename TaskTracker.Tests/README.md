# TaskTracker Tests

This folder contains the unit tests for the TaskTracker project. This short guide explains the test conventions we use in class, how to write new tests, and how to run them on your machine.

Prerequisites

- Install the .NET SDK that matches the repository (`net10.0` target). Verify with `dotnet --version`.

Running the tests

- From the repository root run the whole test project:

```bash
dotnet test TaskTracker.Tests/TaskTracker.Tests.csproj
```

- Run a single test (by fully-qualified test name filter):

```bash
dotnet test --filter FullyQualifiedName~TaskTracker.Tests.UnitTests.TaskItemTests.MarkComplete_SetsComplete_And_ReturnsTrue
```

- You can also run tests with your IDE's Test Explorer (Visual Studio or VS Code Test sidebar).

Test file & naming conventions

- Test files end with `Tests.cs` and live under `TaskTracker.Tests/UnitTests`.
- Test classes are named `ThingTests` (for example, `TaskItemTests`).
- Use NUnit attributes: `[TestFixture]` on the class (optional in recent NUnit), `[Test]` on test methods.
- Method naming pattern: `MethodUnderTest_Scenario_ExpectedBehavior`.
  - Example: `MarkComplete_SetsComplete_And_ReturnsTrue`.

Test structure and style

- Follow Arrange-Act-Assert in every test:
  1. Arrange — set up objects and inputs.
  2. Act — call the method under test.
  3. Assert — verify the outcome with a single clear assertion or a small set of related assertions.
- Prefer `Assert.That(actual, Is.EqualTo(expected))` for clear failure messages.
- Keep tests small and focused — one behavior per test.
- Tests must be independent: avoid relying on other tests or global state.

Dealing with shared/static state

- The codebase uses a static counter for `TaskItem` IDs. Tests that rely on exact ID values can become flaky if other tests run first.
- Best practices:
  - Prefer asserting relative behavior (e.g., `second.Id == first.Id + 1`) instead of absolute values.
  - If you must rely on resettable global state, add a `[SetUp]` method to reset it (but only if the class exposes a reset API). If the code does not expose a reset, avoid asserting exact numeric values.

Adding a new test (quick skeleton)

```csharp
using NUnit.Framework;
using TaskDomain;

[TestFixture]
public class MyFeatureTests
{
    [Test]
    public void ActionUnderTest_SomeScenario_ExpectedResult()
    {
        // Arrange
        var item = new TaskItem("example");

        // Act
        var result = item.MarkComplete();

        // Assert
        Assert.That(result, Is.True);
        Assert.That(item.IsComplete(), Is.True);
    }
}
```

Troubleshooting

- If tests fail to build: run `dotnet restore` and ensure the SDK version supports `net10.0`.
- If tests pass locally but fail in CI, check for environment differences or hidden static state.

Helpful tips

- Copy and reuse existing test patterns (e.g., `TaskItemTests.cs`) when adding similar tests.
- Make small, frequent commits for tests so you can revert easily.

Questions or help

- If you're stuck, open an issue in the course repo or ask an instructor. Include the failing test name and the output from `dotnet test`.

Good luck — and happy testing!
