# TaskTracker

A task management application built with ASP.NET Core.

## Description

TaskTracker is a web-based application for managing and tracking tasks efficiently.

## Prerequisites

- .NET 9.0 SDK or later
- A code editor (VS Code, Visual Studio, or Rider)

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Merlissa09/TaskTracker.git
   cd TaskTracker
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

## Usage

Run the application:

```bash
cd TaskTracker
dotnet run
```

The application will start and display the local URL (typically `http://localhost:5000`).

## Project Structure

- `TaskTracker/` - Main application project
- `Domain/` - Domain models and entities
- `README.md` - This file
- `LICENSE` - License information

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

### Basic Git Commands

All of these commands can be typed into your terminal. Make sure your terminal is scoped to the correct project

- `git branch insert-name-of-branch` - this command will create a branch with the given name

- `git checkout insert-name-of-branch` - this command will checkout the branch so you can work on it

- `git branch` - this command will show you all your local branches

- `git fetch` - a command used to download new data (commits, files, and branches) from a remote repository into your local repository without integrating those changes into your current working file

- `git pull` - used to download content from a remote repository and immediately update the local repository to match that content. It is essentially a combination of two separate commands: `git fetch` followed by `git merge`


## License

See the [LICENSE](LICENSE) file for details.
