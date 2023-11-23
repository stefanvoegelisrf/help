# macOS

## Shortcuts

| Command                 | Action                  |
| ----------------------- | ----------------------- |
| **CMD** + **SHIFT** + . | Show hidden files       |
| **CMD** + **SHIFT** + 4 | Take screenshot(custom) |
| **CMD** + **SHIFT** + 3 | Take screenshot(screen) |

## Installing .NET

> See: [learn.microsoft.com - Install on MacOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos)

### Add to Z Shell path

- Navigate to `/Users/Username/`
- Show hidden files with **CMD** + **SHIFT** + **.**
- Open file `.zprofile`
- Add to path variable
  - Path exists: add `:$HOME/dotnet` to PATH
  - Path does not exist: Add line  with `export PATH=$PATH:$HOME/dotnet`
- Add DOTNET_ROOT: add line `export DOTNET_ROOT=$HOME/dotnet` at end of file