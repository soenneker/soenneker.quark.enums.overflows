[![](https://img.shields.io/nuget/v/soenneker.quark.enums.overflows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.overflows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.overflows/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.overflows/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.overflows/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.overflows/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.overflows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.overflows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.overflows/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.overflows/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Overflows

Strongly typed CSS `overflow` values for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Overflows
```

## Usage

```csharp
OverflowKeyword overflow = OverflowKeyword.Auto;
string cssValue = overflow.Value; // "auto"
```

Use the same values for `overflow`, `overflow-x`, or `overflow-y`. The type also includes CSS-wide values from `GlobalKeyword`.

## Values

| Member | CSS value | Behavior |
| --- | --- | --- |
| `Auto` | `auto` | Adds scrolling when the content requires it. |
| `Hidden` | `hidden` | Clips overflow while retaining a scroll container. |
| `Clip` | `clip` | Clips overflow without creating a scroll container. |
| `Visible` | `visible` | Allows content to paint outside the box. |
| `Scroll` | `scroll` | Creates a scroll container. |
