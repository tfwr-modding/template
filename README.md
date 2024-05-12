## EcmaScript

A mod for [TheFarmerWasReplaced](https://store.steampowered.com/app/2060160/The_Farmer_Was_Replaced) replacing the python sub-set with a JavaScript sub-set.

## 🚧 Status 🚧
Super early state, do not use this unless you plan to contribute.

## 🚀 Getting Started
1. Have BepInEx installed
2. Clone the repository
3. Run `dotnet build`
4. Copy the `EcmaScript.dll` to the `Plugins` folder under `BepInEx/plugins`
5. Run the game

## 📝 TODO
- [ ] Implement the JavaScript sub-set
- - [ ] Lexer (linear)
- - - [x] identifiers
- - - [ ] numbers
- - - [ ] symbols (`(`, `)`, `{`, `}`, `;`)
- - - [ ] operators (`+`, `-`, `*`, `/`)
- - [ ] Parser
- - - [ ] function declarations
- - - [ ] variable declarations
- - - [ ] expressions
- - - [ ] statements
- - - [ ] blocks

## 📚 Resources
- [TheFarmerWasReplaced](https://store.steampowered.com/app/2060160/The_Farmer_Was_Replaced)
- [BepInEx](https://github.com/BepInEx/BepInEx)
