# Supercollider

## Keyboard shortcuts
> See: [sccode.org - Keyboard Shortcuts](https://doc.sccode.org/Reference/KeyboardShortcuts.html)

| Command               | Action                |
| --------------------- | --------------------- |
| **CMD** + **ENTER**   | Run selected command  |
| **SHIFT** + **ENTER** | Execute selected line |

## Server

### Booting server
`s.boot`

### Quitting server
`s.quit`

### Specifying input device
`Server.default.options.inDevice_("Built-in Microph");`

### Specifying output device
`Server.default.options.outDevice_("Built-in Output");`

### Listing devices
```
ServerOptions.devices; // all devices
ServerOptions.inDevices; // input devices
ServerOptions.outDevices; // output devices
```

### Stopping playback
Press **CMD** + **.**

### Functions, arguments, variables
Functions in sclang are objects. When declaring a function using curly brackets, input parameters(arguments) are defined with the `arg` keyword. Variable declarations follow after the arg declarations by using the `var` keyword.

#### Global variables
Letters a-z are so called interpreter variables that have a global scope.

> The global variable s refers to the localhost server

## Tips and tricks
Below are some tips and tricks.

## Errors
Below are some common errors and their fixes.

### Sample rate mismatch
Error message `ERROR: Input sample rate is 44100, but output is 48000. Mismatched sample rates are not supported. To disable input, set the number of input channels to 0.`

#### Fix 1: Disable input channels


#### Fix 2: Setting input in Settings
- Open spotlight search with **CMD** + **SPACEBAR** and search for Audio MIDI setup"
- locate the input/output and match the sample rate