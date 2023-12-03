# Accessibility

- [Accessibility](#accessibility)
  - [Web design](#web-design)
    - [App design](#app-design)
    - [Testing](#testing)
  - [Writing](#writing)
    - [Accessibility text](#accessibility-text)
    - [Alternative text / Alt text](#alternative-text--alt-text)
    - [Captions](#captions)
    - [Embedded text in images](#embedded-text-in-images)
  - [Implementing accessibility](#implementing-accessibility)
    - [Do](#do)
    - [Don't](#dont)
  - [Assistive technologies](#assistive-technologies)
    - [Keyboard](#keyboard)
    - [Screen readers](#screen-readers)


## Web design
For designing content on the web, follow the [W3 guidelines](https://www.w3.org/WAI/standards-guidelines/wcag/).

**At a glance:**
- Perceivable
    - Provide text alternatives for non-text content.
    - Provide captions and other alternatives for multimedia.
    - Create content that can be presented in different ways, including by assistive technologies, without losing meaning.
    - Make it easier for users to see and hear content.
- Operable
    - Make all functionality available from a keyboard.
    - Give users enough time to read and use content.
    - Do not use content that causes seizures or physical reactions.
    - Help users navigate and find content.
    - Make it easier to use inputs other than keyboard.
- Understandable
    - Make text readable and understandable.
    - Make content appear and operate in predictable ways.
    - Help users avoid and correct mistakes.
- Robust
    - Maximize compatibility with current and future user tools.

### App design
- For designing on IOS, follow the [Apple developer accessibility resources](https://developer.apple.com/accessibility/).
- For designing on Android, use [Android developer accessibility resources](https://developer.android.com/guide/topics/ui/accessibility).

### Testing
- Android: [Testing app accessibility](https://developer.android.com/guide/topics/ui/accessibility/testing)

## Writing

### Accessibility text

This is the text used by screen reader software. Screen readers read aloud on-screen text and elements including alternative text.

### Alternative text / Alt text

Alternative text translates visual UI into text-based UI. Alt text describes an image for users who don't see them. If images fail to load, also users who would see the image, can refer to the alt text.

> Use short informative phrasing.

### Captions

Captions are the text that appear below an asset. They explain an asset’s contextual information–the who, what, when, and where. Both sighted and screen reader users rely on captions for descriptions of assets.

### Embedded text in images

Screen readers are unable to read text that is embedded in imagery. If there is essential information embedded as text in the image, include the essential information in the alt text.


## Implementing accessibility

By using standard platform controls and semantic HTML (on the web), apps automatically contain the markup and code needed to work well with a platform’s assistive technology. Meeting each platform's accessibility standards and supporting its assistive technology (including shortcuts and structure) gives users an efficient experience.

### Do

> Use native elements

### Don't

> Don't use non-standard elements as this would need extra testing

## Assistive technologies

### Keyboard

- Hardware or software controllers
- D-Pad, keyboard, trackball
- Linear Navigation from selection to selection

### Screen readers

- Vision impairments, difficulty in reading
- Verbalize visible content and reading it aloud
- Make use of invisible content like alt texts
- Braille display or reading text aloud
- Popular screen readers
    - Chrome Vox
    - Apple VoiceOver
    - Google TalkBack
    - [NVDA: Non Visual Desktop Access](https://www.nvaccess.org/)
    - [JAWS: Job Access With Speech](https://www.freedomscientific.com/products/software/jaws/)
    - [BRLTTY](https://brltty.app/)

