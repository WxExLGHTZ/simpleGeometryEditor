# GeometryEditor

A Windows Forms application for interactively creating and editing 2D geometry - lines, circles, and polylines - with JSON-based file persistence.


## Motivation

GeometryEditor provides an interactive drawing canvas where users place geometric primitives by clicking directly on the screen. The application translates screen coordinates into a mathematical world coordinate system, separating visual representation from the underlying geometry model. Drawings can be saved and loaded as structured JSON files (`.drw`), preserving full type information for all curve types.

## Features

- **Draw lines** by selecting start and end points on the canvas
- **Draw circles** by placing a center point and defining the radius via a second click
- **Draw polylines** with an arbitrary number of vertices, finished by right-click
- **Save and load drawings** as JSON files with automatic type serialization
- **Toggle visibility** of individual geometry types (lines, circles, polylines) independently
- **Compute geometric properties** including curve length, polygon area, and planarity checks
- **Cancel operations** at any point via right-click without corrupting the drawing state

## Tech Stack

| Category | Technology |
|----------|------------|
| Language | C# 8.0 |
| Runtime | .NET Core 3.1 |
| UI | Windows Forms |
| Serialization | Newtonsoft.Json 12.0.3 |
| IDE | Visual Studio 2017+ |

## Architecture

The solution is split into three projects with clear dependency direction: **MathLibrary** provides the foundational types (`Point`, `Vector`, `PointVectorBase`) with 3D coordinate arithmetic, tolerance-based equality, and vector operations like cross product, dot product, and normalization. **GeometryLibrary** builds on this with curve types (`Line`, `Circle`, `Polyline`), a `Drawing` container managing the curve collection and serialization, and a delegate-based click handler pattern that decouples geometry creation logic from the UI. **GeometryEditorApp** is the WinForms frontend that wires toolbar buttons to click handlers, transforms between screen and world coordinates, and renders curves via GDI+.

The click handler pattern is worth noting: each curve type defines a static `CurveClickHandler` method matching a shared delegate signature. The form holds a single handler reference that gets swapped when the user selects a different drawing tool — no switch statements, no conditional logic in the UI layer.

## Getting Started

### Prerequisites

- Windows 10 or later
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet/3.1) or later
- Visual Studio 2017+ (optional, for IDE support)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/<your-username>/GeometryEditor.git
   cd GeometryEditor
   ```

2. Restore dependencies and build:
   ```bash
   dotnet build GeometryEditor.sln
   ```

3. Run the application:
   ```bash
   dotnet run --project GeometryEditorApp/GeometryEditorApp.csproj
   ```

## Usage

1. Launch the application. The main window shows an empty canvas with a toolbar.
2. Select a drawing tool (Line, Circle, or Polyline) from the toolbar.
3. Click on the canvas to place points. The status bar guides you through each step.
4. For polylines, left-click to add vertices and right-click to finish.
5. Use the visibility toggle buttons to show or hide specific geometry types.
6. Save your drawing via **File → Save** (or the toolbar button). Drawings are stored as `.drw` files.
7. Reopen saved drawings via **File → Open**.
