
using FluentAssertions;

namespace Daf.PiApprox.Cli.Tests;

public class PiServiceTests
{
    [Theory]
    [MemberData(nameof(PointsData))]
    public void GivenPointWhenIsPointInCircleShouldReturnExpected(Point point, bool expected)
    {
        // When
        var actual = PiService.IsInCircle(point);
        // Should
        actual.Should().Be(expected);
    }

    [Fact]
    public void WhenApproxReturnsExpected()
    {
        // Given
        var sut = new PiService();
        var expectedPi = Math.Round(Math.PI, 2);
        var result = Math.Round(sut.ApproxPi(), 2);
        // Should
        result.Should().Be(expectedPi);
    }

    public static TheoryData<Point, bool> PointsData() 
        => new()
        {
            {new Point{X = 0.5, Y =  0.5}, true },
            {new Point{X = 0.9, Y =  0.9}, false },
        };
}