# Directory Helper Tool

## Overview

Directory Helper is a simple .NET CLI tool designed to swiftly open a specified directory from the terminal. It provides an easy way to access directories without navigating manually.

## Installation

To use Directory Helper, follow these steps:

1. **Installation:**

   - Install the .NET SDK if you haven't already.

2. **Build the Tool:**

   - Clone this repository or download the source code.
   - Navigate to the project directory in your terminal.
   - Run `dotnet build -c Release` to build the tool.

3. **Installation of the Tool:**
   - Run `dotnet tool install --global --add-source ./nupkg DirectoryHelper` to install the tool globally.

## Usage

Once installed, you can use the tool as follows:

- To open a directory, navigate to the desired location in your terminal.
- Run `helper` to open the current directory in your default file explorer.

## Example

For instance, after installation, navigate to the target directory in the terminal and type `helper`. This command will open the current directory using your default file explorer.

## Notes

- Ensure you have appropriate permissions to access directories.
- This tool assumes compatibility with common file explorers on your system.

## License

This project is licensed under the [MIT License](LICENSE).
