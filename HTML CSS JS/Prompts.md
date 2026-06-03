# Prompt 
Give me a coding challenge for a junior programmer using only HTML, CSS, and javascript
# Response
Here is a practical and engaging coding challenge tailored for a junior developer. It hits the "sweet spot" by testing DOM manipulation, state management, and layout skills without relying on any external libraries or APIs.

## The Challenge: Build an Interactive Password Generator
### Objective: Create a clean, single-page application that generates a random password based on criteria selected by the user.

### Core Requirements
1. HTML (Structure & Semantics)
You will need to build a user interface that includes:

A display area to show the generated password.

A range slider ( <input type="range"> ) to select the password length (e.g., between 8 and 32 characters).

A real-time text display showing the current number selected on the slider.

Four checkboxes ( <input type="checkbox"> ) for the user to select character types:

Include Uppercase Letters

Include Lowercase Letters

Include Numbers

Include Symbols

A "Generate Password" button.

### 2. CSS (Styling & Layout)
Layout: Use Flexbox or CSS Grid to center the generator on the screen and neatly align the labels and inputs.

Aesthetics: Give it a modern card look (think rounded corners, a subtle box-shadow, and a clean color palette).

Interactive States: Add :hover, :focus, and :active states to the button, checkboxes, and slider so the user feels the interactivity.

Responsiveness: Ensure the generator looks good on both a desktop monitor and a mobile phone screen.

### 3. JavaScript (Logic & DOM Manipulation)
Event Listeners: * Listen for changes on the range slider to update the length number displayed on the screen dynamically.

Listen for a click on the "Generate Password" button.

Validation: If the user clicks "Generate" but hasn't checked any of the checkboxes, display a polite error message or alert asking them to select at least one option.

### The Algorithm:

Create strings or arrays containing the available characters (e.g., const upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ").

Based on which checkboxes are checked, build a "master pool" of characters.

Use a loop and Math.random() to pick characters from that master pool until you reach the desired length.

DOM Updates: Inject the final generated password back into the HTML display area.
