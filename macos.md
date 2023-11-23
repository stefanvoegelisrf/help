# macOS

## Shortcuts

| Command                 | Action                  |
| ----------------------- | ----------------------- |
| **CMD** + **SHIFT** + . | Show hidden files       |
| **CMD** + **SHIFT** + 4 | Take screenshot(custom) |
| **CMD** + **SHIFT** + 3 | Take screenshot(screen) |

## Installing .NET

> See: [learn.microsoft.com - Install on MacOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos)
> 
> Make sure to install the **ARM64** version for Apple Silicon(M1, M2, M3)

## Issues

### C# Dev Kit unable to find .NET SDK

When a project has been opened which contains C# files and VS Code is closed afterwards(without quitting VS Code completely), when opening C# files again, the C# Dev Kit is unable to find the .NET SDK. To fix this, make sure to quit VS Code completely. The C# Dev Kit should be able to locate the SDK again.