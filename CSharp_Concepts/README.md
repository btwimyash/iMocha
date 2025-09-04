# C# Concepts - Hello World Web Application

This is a basic "Hello World" web application built with ASP.NET Core and C#.

## Features

- Modern, responsive web design
- Beautiful gradient background with glassmorphism effects
- Animated elements with CSS
- Real-time server timestamp display
- Built with ASP.NET Core 8.0 and Razor Pages

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022, VS Code, or any C# IDE

## How to Run

1. **Navigate to the project directory:**
   ```bash
   cd "CSharp Concepts"
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Open your browser and navigate to:**
   ```
   https://localhost:5001
   ```
   or
   ```
   http://localhost:5000
   ```

## Project Structure

```
CSharp Concepts/
├── Pages/
│   ├── Index.cshtml          # Main Hello World page
│   ├── Index.cshtml.cs       # Page model
│   ├── _ViewStart.cshtml     # View configuration
│   └── Shared/
│       └── _Layout.cshtml    # Layout template
├── Program.cs                # Application entry point
├── CSharp Concepts.csproj    # Project file
└── README.md                 # This file
```

## Technologies Used

- **ASP.NET Core 8.0** - Web framework
- **C# 8.0** - Programming language
- **Razor Pages** - UI framework
- **HTML5 & CSS3** - Frontend technologies
- **Glassmorphism Design** - Modern UI design pattern

## Customization

You can customize the appearance by modifying the CSS styles in the `Index.cshtml` file. The application uses modern CSS features like:

- CSS Grid and Flexbox for layout
- CSS Custom Properties (variables)
- CSS Animations and Transitions
- Backdrop filters for glassmorphism effects
- Linear gradients for backgrounds

Enjoy exploring C# web development! 🚀
