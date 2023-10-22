# Web

- [Web](#web)
  - [WebAssmebly](#webassmebly)
    - [What is WebAssembly?](#what-is-webassembly)
    - [WebAssembly vs. JavaScript](#webassembly-vs-javascript)
      - [Use cases for WebAssembly](#use-cases-for-webassembly)
        - [Inside the browser](#inside-the-browser)
        - [Outside the browser](#outside-the-browser)
    - [Key concepts](#key-concepts)


## WebAssmebly

### What is WebAssembly?

WebAssembly is low-level code that runs in modern browsers. It can run alongside JavaScript and can work together with it and also share WebAssembly modules. WebAssembly is not intended to be written by hand, rather to be used as a compilation target for other languages.

> See: [Mozilla - What is WebAssembly](https://developer.mozilla.org/en-US/docs/WebAssembly/Concepts#what_is_webassembly)

### WebAssembly vs. JavaScript

WebAssembly is not a replacement for JavaScript. WebAssembly is intended for tasks that require native performance. WebAssembly must be compiled, whereas JavaScript does not have a compilation step. JavaScript has a huge ecosystem of frameworks and libraries.

> See: [Mozilla - How does WebAssembly fit into the web platform](https://developer.mozilla.org/en-US/docs/WebAssembly/Concepts#how_does_webassembly_fit_into_the_web_platform)

#### Use cases for WebAssembly

WebAssembly has [high-level goals](https://webassembly.org/docs/high-level-goals/) that define what WebAssembly aims to achieve. From these, we can also derive the use cases.

The listed use cases are not a complete list, rather the use cases that would be most relevant for me. To see the full list, view the link below.

> See: [WebAssembly use cases](https://webassembly.org/docs/use-cases/)

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

TODO: Add intro for web assembly and how to use it with c# and javascript


