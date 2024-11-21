# Pi Approximation CLI Application

## Overview

This is a C# console application that approximates the value of Pi using the **Monte Carlo method**. The program simulates random points within a square and calculates the ratio of points that fall inside a unit circle to estimate the value of Pi. The application is designed with extensibility in mind and demonstrates the use of OOP principles in C#.

## Features

- **Monte Carlo Method**: Uses random sampling to approximate Pi based on geometric probabilities.
- **Efficient Simulation**: Handles up to one million points for a high-precision approximation.
- **Interface-Driven Design**: The `IPiService` interface makes it easy to swap in different Pi approximation algorithms.
- **Extensible**: The `Point` class and modular methods allow for additional enhancements and experiments.

## Algorithm Explanation

The Monte Carlo method approximates Pi by simulating random points in a 2D square of side length 1. The proportion of points that fall inside the unit circle (centered at the origin) compared to the total points in the square approximates the ratio of the area of the circle to the square. Since the area of a unit circle is \( \pi \), the formula is:

\[
\pi \approx 4 \times \frac{\text{Number of Points Inside Circle}}{\text{Total Number of Points}}
\]

## Code Structure

### Files and Key Components

1. **`IPiService.cs`**  
   Defines the `IPiService` interface with a single method `ApproxPi()` for approximating Pi.

2. **`Point.cs`**  
   Represents a 2D point with `X` and `Y` coordinates of type `double`.

3. **`PiService.cs`**  
   Implements the Monte Carlo method to approximate Pi. Key methods include:
   - `ApproxPi()`: Generates random points and calculates the approximation.
   - `IsInCircle(Point)`: Checks if a point lies inside the unit circle.
   - `GeneratePoint(Random)`: Creates a point with random \( X \) and \( Y \) coordinates.

4. **`Program.cs`**  
   Contains the application’s entry point. Invokes `PiService` to compute and display the result.

### How It Works

- **Point Generation**: Random points are generated within the square \([0, 1] \times [0, 1]\).
- **Circle Check**: Each point is tested to see if it lies within the unit circle (\( x^2 + y^2 \leq 1 \)).
- **Pi Approximation**: The ratio of points inside the circle to the total number of points, multiplied by 4, approximates Pi.

### Example Code Snippet

```csharp
var piApprox = new PiService();
Console.WriteLine(piApprox.ApproxPi());
```

## Usage

1. **Prerequisites**:  
   - .NET 6.0 or later installed on your system.

2. **Running the Application**:  
   - Open the terminal and navigate to the project directory.
   - Build the project:
     ```bash
     dotnet build
     ```
   - Run the application:
     ```bash
     dotnet run
     ```

3. **Example Output**:  
   After running, you’ll see an approximation of Pi:
   ```text
   3.141592
   ```

## Performance Details

The `PiService` uses an array to store points and a `List<Point>` for points within the circle. By default, it processes **1,000,000 points**. The program can be adjusted to run with different numbers of points to analyze the trade-off between precision and computation time.

### Customization

- Modify `_pointsArrayLength` in `PiService` to experiment with different sample sizes:
  ```csharp
  private readonly int _pointsArrayLength = 100000;
  ```

## Extensibility

- Add new approximation algorithms by implementing the `IPiService` interface.
- Use the `Point` class for other geometry-based simulations or enhancements.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Acknowledgments

- Monte Carlo Method: A foundational technique in computational mathematics.
- C# and .NET: Robust tools for building efficient numerical simulations.

