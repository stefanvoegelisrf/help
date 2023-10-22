# Web

- [Web](#web)
  - [WebAssmebly](#webassmebly)
    - [What is WebAssembly?](#what-is-webassembly)
    - [WebAssembly vs. JavaScript](#webassembly-vs-javascript)
      - [Use cases for WebAssembly](#use-cases-for-webassembly)
        - [Inside the browser](#inside-the-browser)
        - [Outside the browser](#outside-the-browser)
    - [Key concepts](#key-concepts)
    - [Writing WebAssembly with .NET](#writing-webassembly-with-net)
    - [Usage with JavaScript](#usage-with-javascript)
    - [Writing WebAssembly with AssemblyScript](#writing-webassembly-with-assemblyscript)
      - [AssemblyScript example](#assemblyscript-example)


## WebAssmebly

### What is WebAssembly?

WebAssembly is low-level code that runs in modern browsers. It can run alongside JavaScript and can work together with it and also share WebAssembly modules. WebAssembly is not intended to be written by hand, rather to be used as a compilation target for other languages.

> See: [Mozilla - What is WebAssembly](https://developer.mozilla.org/en-US/docs/WebAssembly/Concepts#what_is_webassembly)

### WebAssembly vs. JavaScript

WebAssembly is not a replacement for JavaScript. WebAssembly is intended for tasks that require native performance. WebAssembly must be compiled, whereas JavaScript does not have a compilation step. JavaScript has a huge ecosystem of frameworks and libraries.

> See: [Mozilla - How does WebAssembly fit into the web platform](https://developer.mozilla.org/en-US/docs/WebAssembly/Concepts#how_does_webassembly_fit_into_the_web_platform)

#### Use cases for WebAssembly

WebAssembly has [WebAssembly - High-level goals](https://webassembly.org/docs/high-level-goals/) that define what WebAssembly aims to achieve. From these, we can also derive the use cases.

The listed use cases are not a complete list, rather the use cases that would be most relevant for me. To see the full list, view the link below.

> See: [WebAssembly - Use cases](https://webassembly.org/docs/use-cases/)

##### Inside the browser

- Better execution of cross-compiled languages
- Image/video edition
- Games
- Peer-to-peer applications
- Music application
- Image recognition
- Live video augmentation(e.g. AR filters)
- VR & AR
- CAD apps
- Platform simulation/emulation
- Remote desktop
- VPN

##### Outside the browser

- Server-side application
- Hybrid native apps on mobile

### Key concepts

> See: [Mozilla - WebAssembly key concepts](https://developer.mozilla.org/en-US/docs/WebAssembly/Concepts#webassembly_key_concepts)

- **Module**: A module is a compiled WebAssembly binary. It declares imports and exports like ES modules and is stateless.
- **Memory**: Memory is an ArrayBuffer that is accessed by WebAssembly memory access instructions.
- **Table**: A typed array containing references(e.g. functions).
- **Instance**: A module paired with the runtime state(memory, table and variables).

WebAssembly modules, memories, tables and instance can be created with JavaScript. Exports of WebAssembly instances can be called by JavaScript as functions.

### Writing WebAssembly with .NET

> See: [Fermyon - Running .NET in WebAssembly](https://www.fermyon.com/blog/dotnet-wasi)

C# already compiles to a binary executable format called .NET bytecode. This bytecode is dependent on the .NET Standard library and if used, other bytecode like packages from NuGet.

So to use the bytecode in WebAssembly, the .NET runtime, NuGet packages and your own code get compiled to WebAssembly bytecode.

> To achieve this, there is a [GitHub - WASI SDK](https://github.com/SteveSandersonMS/dotnet-wasi-sdk) which can be used(experimental). Such a project has to be built specially, see [GitHub - WASI SDK - Building](https://github.com/SteveSandersonMS/dotnet-wasi-sdk#building-this-repo-from-source)

Detailed instructions on usage with C# can be seen in the linked articles as they are likely to change anyway.

### Usage with JavaScript

> See: [Mozilla - WebAssembly - Using the JavaScript API](https://developer.mozilla.org/en-US/docs/WebAssembly/Using_the_JavaScript_API)

### Writing WebAssembly with AssemblyScript

[AssemblyScript](https://www.assemblyscript.org/) is code that targets the WebAssembly feature set. AssemblyScript is written in a variant of TypeScript but with WebAssembly types. AssemblyScript then compiles to WebAssembly.

AssemblyScript provides a [standard library](https://www.assemblyscript.org/stdlib/globals.html) similar to typical JavaScript functions.

#### AssemblyScript example

```
export function fib(n: i32): i32 {
  var a = 0, b = 1
  if (n > 0) {
    while (--n) {
      let t = a + b
      a = b
      b = t
    }
    return b
  }
  return a
}
```

