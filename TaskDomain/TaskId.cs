using System.Threading;

namespace TaskDomain;

/// <summary>
/// Represents a unique, immutable identifier for a Task.
/// This class supports inheritance; subclasses should rely on the base id
/// generation rather than attempting to replace or mutate id behavior.
/// </summary>
/// <remarks>
/// - The class uses an atomic static counter to generate ids in a thread-safe way.
/// - Instances are immutable: the <see cref="Id"/> is assigned once in the constructor
///   and exposes only a getter.
/// - The class is not sealed so it can be extended. However, the id generation
///   is intentionally private and the <see cref="Id"/> property is not virtual,
///   which prevents subclasses from overriding the identity behavior. Subclasses
///   may extend behavior via composition or by adding new members, but should
///   call the base constructor to obtain a unique id.
/// </remarks>
public class TaskId
{
    // thread-safe static counter shared by all TaskId instances
    private static int s_totalCount;

    /// <summary>
    /// Gets the total number of <see cref="TaskId"/> instances that have been created.
    /// </summary>
    /// <remarks>
    /// Exposed as a static read-only value backed by an atomic counter so callers
    /// can observe how many ids have been allocated without being able to modify it.
    /// </remarks>
    public static int TotalCount => s_totalCount;

    /// <summary>
    /// The unique id assigned to this instance.
    /// </summary>
    /// <remarks>
    /// This value is assigned once during construction and is immutable thereafter.
    /// Making the property read-only prevents modifications from outside and from
    /// derived types (if the class were not sealed).
    /// </remarks>
    public int Id { get; }

    /// <summary>
    /// Initializes a new <see cref="TaskId"/>, assigning a globally-unique id.
    /// </summary>
    /// <remarks>
    /// Uses <see cref="Interlocked.Increment(ref int)"/> to increment the shared
    /// counter atomically. This ensures unique ids even when multiple threads
    /// construct <see cref="TaskId"/> instances concurrently.
    /// </remarks>
    public TaskId()
    {
        Id = Interlocked.Increment(ref s_totalCount);
    }

    /// <summary>
    /// Returns the current value of <see cref="TotalCount"/>.
    /// </summary>
    public static int GetTotalTaskCount()
    {
        return TotalCount;
    }

    /// <summary>
    /// Returns the id assigned to this instance.
    /// </summary>
    public int GetId()
    {
        return Id;
    }
}