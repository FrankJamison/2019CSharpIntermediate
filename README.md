# C# Intermediate OOP Exercises (Portfolio-Ready)

This repo is a collection of small, focused C# console applications that demonstrate object-oriented design fundamentals: encapsulation, inheritance, polymorphism, and interface-driven extensibility. Each folder is an independent exercise with its own solution (.sln) and project (.csproj).

If you’re an employer/recruiter: this is intentionally “small surface area” code with clear separation of concerns and deliberate edge-case handling.
If you’re a developer: each exercise is a self-contained example you can run in seconds and extend in a realistic direction.

## What this demonstrates

Core engineering signals covered across the exercises:

- OOP fundamentals: state + behavior modeling, invariants, encapsulation
- Inheritance + polymorphism: shared base abstractions, derived implementations
- Interfaces for extensibility: open/closed principle via new classes, not edits
- Defensive coding: invalid state detection and predictable behavior
- Practical .NET types: DateTime, TimeSpan, generics, IEnumerable

## Tech stack

- Language: C#
- Runtime/SDK target: .NET 8 (net8.0)
- App type: console apps (no external dependencies)
- IDEs: Visual Studio or VS Code

SDK note: this repo does not pin an SDK with global.json. As of January 15, 2026 it builds in this workspace using dotnet --version → 10.0.102 while targeting net8.0.

## Repository structure

Each exercise is fully independent:

- One folder per exercise
- One solution (.sln) per exercise
- One console project (.csproj) per exercise

This makes it easy to open a single exercise in Visual Studio or run one exercise from the command line without pulling in others.

## Quick start (build/run)

Prerequisites:

- Install a .NET SDK that can build net8.0 projects
- Windows/macOS/Linux supported

From the repo root, run any exercise by pointing dotnet at the project file.

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

Build in Release (optional):

```powershell
dotnet build .\Exercise6-DesignAWorkflowEngine\Exercise6-DesignAWorkflowEngine.sln -c Release
```

## Exercises (what to look for)

### Exercise 1 — Design a Stopwatch

Folder: [Exercise1-DesignAStopwatch/](Exercise1-DesignAStopwatch/)

What it shows:

- Modeling state transitions (running vs not running)
- Capturing elapsed time using DateTime/TimeSpan
- Guarding invalid operations (start twice, stop before start)

Key implementation:

- [Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Stopwatch.cs](Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Stopwatch.cs)
- [Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Program.cs](Exercise1-DesignAStopwatch/Exercise1-DesignAStopwatch/Program.cs)

Behavior note: invalid usage is handled by printing messages to the console rather than throwing up the call stack.

### Exercise 2 — Design a StackOverflow Post

Folder: [Exercise2-DesignAStackOverflowPost/](Exercise2-DesignAStackOverflowPost/)

What it shows:

- Encapsulation: votes cannot be set from outside the type
- Immutable-ish creation metadata (created date set once)
- Simple domain modeling with a tight public API

Key implementation:

- [Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Post.cs](Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Post.cs)
- [Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Program.cs](Exercise2-DesignAStackOverflowPost/Exercise2-DesignAStackOverflowPost/Program.cs)

### Exercise 3 — Design a Stack

Folder: [Exercise3-DesignAStack/](Exercise3-DesignAStack/)

What it shows:

- Using generics internally while exposing a flexible object-based API
- Edge-case handling (null push, pop on empty)
- Clear separation of responsibilities: Stack class owns its invariants

Key implementation:

- [Exercise3-DesignAStack/Exercise3-DesignAStack/Stack.cs](Exercise3-DesignAStack/Exercise3-DesignAStack/Stack.cs)
- [Exercise3-DesignAStack/Exercise3-DesignAStack/Program.cs](Exercise3-DesignAStack/Exercise3-DesignAStack/Program.cs)

Behavior note: the course prompt suggests throwing InvalidOperationException for misuse; this implementation prints messages and returns null for empty-pop.

### Exercise 4 — Design a Database Connection

Folder: [Exercise4-DesignADatabaseConnection/](Exercise4-DesignADatabaseConnection/)

What it shows:

- Base-class abstraction for shared concepts (connection string, timeout)
- Derived types implementing the open/close operations
- Polymorphism at the call site (base type contract, derived behavior)

Key implementation:

- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/DbConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/DbConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/SqlConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/SqlConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/OracleConnection.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/OracleConnection.cs)
- [Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/Program.cs](Exercise4-DesignADatabaseConnection/Exercise4-DesignADatabaseConnection/Program.cs)

Behavior note: invalid connection strings are detected, but this implementation prints an error and still completes construction.

### Exercise 5 — Design a Database Command

Folder: [Exercise5-DesignADatabaseCommand/](Exercise5-DesignADatabaseCommand/)

What it shows:

- Composition: a command depends on a connection, not a specific database
- Constructor validation (no null connection, no empty instruction)
- Polymorphic execution: same DbCommand can target different connection types

Key implementation:

- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbCommand.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbCommand.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbConnection.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/DbConnection.cs)
- [Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/Program.cs](Exercise5-DesignADatabaseCommand/Exercise5-DesignADatabaseCommand/Program.cs)

### Exercise 6 — Design a Workflow Engine

Folder: [Exercise6-DesignAWorkflowEngine/](Exercise6-DesignAWorkflowEngine/)

What it shows:

- Interface-driven design for extensibility (IActivity)
- Workflow execution that is decoupled from concrete activities
- Open/closed principle: add a new activity without changing the engine

Key implementation:

- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IActivity.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/IActivity.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/WorkflowEngine.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/WorkflowEngine.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Workflow.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Workflow.cs)
- [Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Program.cs](Exercise6-DesignAWorkflowEngine/Exercise6-DesignAWorkflowEngine/Program.cs)

## Developer notes (how to extend this)

If you want to take this from “exercise” to “production style”, the most valuable next steps would be:

- Swap Console.WriteLine-based error handling for exceptions (or a result type) where appropriate
- Add unit tests (xUnit/NUnit) for edge cases (start/stop ordering, empty stack pop, etc.)
- Introduce dependency injection + logging abstractions in the workflow engine
- Add a global.json to pin a known-good .NET SDK version

