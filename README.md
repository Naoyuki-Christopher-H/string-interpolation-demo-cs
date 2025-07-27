# String Interpolation Demo in C\#

This project demonstrates the use of **string interpolation** in C# for cleaner and more readable string formatting.

## Overview

String interpolation is a feature in C# that makes it easier to format strings by embedding expressions directly within string literals. 
It uses the `$` symbol and curly braces `{}` to evaluate expressions inside strings.

This demo includes a simple example using a `Solution` class that outputs a formatted message using string interpolation.

## Features

* Basic usage of string interpolation in C#
* Demonstrates:

  * Simple text output
  * Embedding string variables
  * Embedding integer variables

## Code Example

```csharp
public Solution()
{
    String FirstName = "Yuki";
    String LastName = "James";
    int Age = 33;

    Console.WriteLine($"Hello There.");
    Console.WriteLine($"My name is {LastName}.");
    Console.WriteLine($"{FirstName} {LastName}.");
    Console.WriteLine($"I am {Age} years old.");
}
```

## Output

```
Hello There.
My name is James.
Yuki James.
I am 33 years old.
```

## Getting Started

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) installed

### Running the Program

1. Clone the repository:

   ```bash
   git clone https://github.com/Naoyuki-Christopher-H/string-interpolation-demo-cs.git
   cd string-interpolation-demo-cs
   ```

2. Build and run the project:

   ```bash
   dotnet run
   ```

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---
