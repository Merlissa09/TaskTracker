using NUnit.Framework;
using TaskDomain;

namespace TaskTracker.Tests.UnitTests;

[TestFixture]
public class TaskItemTests
{
    [Test]
    public void Constructor_SetsTitle_And_Defaults()
    {
        // Arrange
        var title = "Write tests";

        // Act
        var item = new TaskItem(title);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(item.GetTitle(), Is.EqualTo(title));
            Assert.That(item.IsComplete(), Is.False);
            Assert.That(item.GetDescription(), Is.EqualTo(string.Empty));
            Assert.That(item.Id, Is.GreaterThan(0));
        });
    }

    [Test]
    public void MarkComplete_SetsComplete_And_ReturnsTrue()
    {
        // Arrange
        var item = new TaskItem("Complete me");

        // Act
        var result = item.MarkComplete();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.True);
            Assert.That(item.IsComplete(), Is.True);
        });
    }

    [Test]
    public void NewItems_Have_SequentialIds()
    {
        var first = new TaskItem("First");
        var second = new TaskItem("Second");

        Assert.That(second.Id, Is.EqualTo(first.Id + 1));

    }
}
