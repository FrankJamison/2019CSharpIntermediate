# C# Intermediate - Classes, Interfaces, and OOP

This repository contains a set of small console apps focused on *object-oriented design* concepts from the Udemy course **C# Intermediate - Classes, Interfaces, and OOP**. Each folder is an independent exercise with its own solution (`.sln`) and console project (`.csproj`).

All projects in this workspace target **.NET Core 2.1** (`netcoreapp2.1`) and are intended to be run from the command line or inside Visual Studio / VS Code.

## Contents

- [Exercise 1 — Design a Stopwatch](#exercise-1--design-a-stopwatch)
- [Exercise 2 — Design a StackOverflow Post](#exercise-2--design-a-stackoverflow-post)
- [Exercise 3 — Design a Stack](#exercise-3--design-a-stack)
- [Exercise 4 — Design a Database Connection](#exercise-4--design-a-database-connection)
- [Exercise 5 — Design a Database Command](#exercise-5--design-a-database-command)
- [Exercise 6 — Design a Workflow Engine](#exercise-6--design-a-workflow-engine)

## Prerequisites

- **.NET SDK** capable of building `netcoreapp2.1` projects.
  - If you’re using a newer SDK (e.g., .NET 6/7/8), you may need to install the **.NET Core 2.1 runtime / targeting pack** or update the target frameworks.
- Windows, macOS, or Linux
- Optional IDE support:
  - Visual Studio
  - VS Code + C# extension

## How to build and run

Each exercise can be built/run independently.

### Run each exercise (from repo root)

```powershell
# Exercise 1
dotnet run --project .\Exercise1-DesignAStopwatch\Exercise1-DesignAStopwatch\Exercise1-DesignAStopwatch.csproj

# Exercise 2
dotnet run --project .\Exercise2-DesignAStackOverflowPost\Exercise2-DesignAStackOverflowPost\Exercise2-DesignAStackOverflowPost.csproj

# Exercise 3
dotnet run --project .\Exercise3-DesignAStack\Exercise3-DesignAStack\Exercise3-DesignAStack.csproj

# Exercise 4
dotnet run --project .\Exercise4-DesignADatabaseConnection\Exercise4-DesignADatabaseConnection\Exercise4-DesignADatabaseConnection.csproj

# Exercise 5
dotnet run --project .\Exercise5-DesignADatabaseCommand\Exercise5-DesignADatabaseCommand\Exercise5-DesignADatabaseCommand.csproj

# Exercise 6
dotnet run --project .\Exercise6-DesignAWorkflowEngine\Exercise6-DesignAWorkflowEngine\Exercise6-DesignAWorkflowEngine.csproj
```

### Option A: Run with `dotnet run`

From the repository root:

```powershell
# Example: run Exercise 1
cd .\Exercise1-DesignAStopwatch\Exercise1-DesignAStopwatch

dotnet run
```

### Option B: Build a solution

```powershell
# Example: build Exercise 6 solution
cd .\Exercise6-DesignAWorkflowEngine

dotnet build .\Exercise6-DesignAWorkflowEngine.sln
```

### Option C: Open the solution in Visual Studio

Open the relevant `.sln` file and run the project.

---

## Exercise 1 — Design a Stopwatch

**Folder:** [Exercise1-DesignAStopwatch/](Exercise1-DesignAStopwatch/)

### Goal

Implement a `Stopwatch` class that simulates a real stopwatch:

- Start timing
- Stop timing
- Query the elapsed duration
- Handle invalid operations (e.g., start twice, stop before start)

### Key files

- [Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Stopwatch.cs](Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Stopwatch.cs)
- [Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Program.cs](Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Program.cs)

### Implementation notes

- `Stopwatch.Duration` is a `TimeSpan` and is updated when `End()` is called.
- Internal state:
  - `_startTime` / `_endTime` (`DateTime`)
  - `_inUse` flag to prevent starting twice or stopping before start
- Invalid usage is handled by printing a message to the console:
  - Starting twice prints: *“The stopwatch has already been started.”*
  - Ending before starting prints: *“The stopwatch has not yet been started.”*

### Run behavior

`Program.cs` demonstrates:

- A normal start → sleep → end cycle
- Resetting to initial state
- Calling `Start()` twice
- Calling `End()` twice

---

## Exercise 2 — Design a StackOverflow Post

**Folder:** [Exercise2-DesignAStackOverflowPost/](Exercise2-DesignAStackOverflowPost/)

### Goal

Model a StackOverflow post with:

- `title` and `description`
- creation `date` (set once)
- vote count that can be changed only through methods

### Key files

- [Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Post.cs](Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Post.cs)
- [Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Program.cs](Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Program.cs)

### Implementation notes

- `Post.date` is set in the constructor to `DateTime.Now` and has a private setter.
- `Post.votes` has a private setter and is mutated via:
  - `UpVote()` → increments by 1
  - `DownVote()` → decrements by 1

### Run behavior

`Program.cs`:

- Prompts for title + description
- Applies a series of up-votes/down-votes
- Prints title, description, creation date, and final vote count

---

## Exercise 3 — Design a Stack

**Folder:** [Exercise3-DesignAStack/](Exercise3-DesignAStack/)

### Goal

Implement a stack with:

- `Push(object obj)`
- `Pop()` returning `object`
- `Clear()`

…and handle edge cases:

- Pushing `null` should be invalid
- Popping from an empty stack should be invalid

### Key files

- [Exercise3-DesignAStack/Exercise3-DesignAStack/Stack.cs](Exercise3-DesignAStack/Exercise3-DesignAStack/Stack.cs)
- [Exercise3-DesignAStack/Exercise3-DesignAStack/Program.cs](Exercise3-DesignAStack/Exercise3-DesignAStack/Program.cs)

### Implementation notes

- Internally uses `System.Collections.Generic.Stack<object>`.
- Edge-case handling in this implementation is console-message-based:
  - `Push(null)` prints an error message and does not push.
  - `Pop()` on an empty stack prints an error message and returns `null`.

### Run behavior

`Program.cs` demonstrates:

- Attempting to push `null`
- Pushing values `1,2,3`
- Popping 4 times (the 4th triggers the empty-stack case)
- Clearing the stack and attempting to pop again

---

## Exercise 4 — Design a Database Connection

**Folder:** [Exercise4-DesignADatabaseConnection/](Exercise4-DesignADatabaseConnection/)

### Goal

Model database connections via a base abstraction:

- `DbConnection` base class encapsulating common concepts:
  - `ConnectionString`
  - `Timeout` (TimeSpan)
  - open/close behaviors
- Derived connections:
  - `SqlConnection`
  - `OracleConnection`

### Key files

- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/DbConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/DbConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/SqlConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/SqlConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/OracleConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/OracleConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/Program.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/Program.cs)

### Implementation notes

- `DbConnection` is an `abstract class` with abstract methods:
  - `OpenConnection()`
  - `CloseConnection()`
- Timeout is set to 30 seconds in the base constructor.
- Connection string validation:
  - If the connection string is null/whitespace, this implementation prints an error message.
- Derived classes simulate open/close by:
  - tracking a boolean “connection open” flag
  - printing messages like *“Connecting to SQL database…”*

### Run behavior

`Program.cs` demonstrates:

- Constructing connections with invalid connection strings (null/whitespace)
- Opening connections
- Attempting to open an already open connection
- Closing connections
- Attempting to close an already closed connection

---

## Exercise 5 — Design a Database Command

**Folder:** [Exercise5-DesignADatabaseCommand/](Exercise5-DesignADatabaseCommand/)

### Goal

Create a `DbCommand` that can execute an instruction against a database connection.

- A command must have:
  - a `DbConnection`
  - an instruction string
- Execution should:
  - open connection
  - run the instruction
  - close connection

### Key files

- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbCommand.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbCommand.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbConnection.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbConnection.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/SqlConnection.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/SqlConnection.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/OracleConnection.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/OracleConnection.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/Program.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/Program.cs)

### Implementation notes

- `DbCommand` validates constructor inputs:
  - `connection` must not be null
  - `instruction` must not be null/whitespace
- If validation fails, this implementation prints an error message and marks the command as not executable (`_okToProcess = false`).
- `Execute()` runs only if `_okToProcess` is true:
  - Calls `_connection.OpenConnection()`
  - Writes the instruction to the console
  - Calls `_connection.CloseConnection()`

### Run behavior

`Program.cs` demonstrates:

- Invalid connection/instruction scenarios
- Executing a command with a `SqlConnection`
- Executing a command with an `OracleConnection` (polymorphism)

---

## Exercise 6 — Design a Workflow Engine

**Folder:** [Exercise6-DesignAWorkflowEngine/](Exercise6-DesignAWorkflowEngine/)

### Goal

Build an extensible workflow engine using interfaces:

- A workflow is a list of activities
- Each activity can be executed
- The engine runs each activity in sequence

### Key files

- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IActivity.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IActivity.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IWorkflow.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IWorkflow.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Workflow.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Workflow.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/WorkflowEngine.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/WorkflowEngine.cs)
- Activities:
  - [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/UploadVideo.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/UploadVideo.cs)
  - [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/CallWebService.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/CallWebService.cs)
  - [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/SendNotificationEmail.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/SendNotificationEmail.cs)
  - [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/ChangeStatus.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/ChangeStatus.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Program.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Program.cs)

### Implementation notes

- `IActivity` defines `void Execute()`.
- `IWorkflow` defines:
  - `AddActivity(IActivity activity)`
  - `RemoveActivity(IActivity activity)`
  - `IEnumerable<IActivity> GetActivities()`
- `Workflow` stores activities in a private list.
- `WorkflowEngine.Run(IWorkflow workflow)` executes each activity in order.

### Run behavior

`Program.cs` creates a workflow and adds 4 activities:

1. Upload video
2. Call web service
3. Send notification email
4. Change status

Then `WorkflowEngine.Run(...)` prints each activity’s console message in sequence.

---

## Notes / Known quirks

These exercises are intentionally small and educational. A few behaviors are worth noting:

- Some classes *print messages* on invalid operations rather than rethrowing exceptions (e.g., `Stopwatch.Start()` called twice, stack pop on empty stack).
- Some constructor validation prints an error message but still completes construction (e.g., `DbConnection` when the connection string is null/whitespace).

If you want, I can also add small per-exercise `README.md` files inside each exercise folder, but this root README is designed to be the single entry point.
