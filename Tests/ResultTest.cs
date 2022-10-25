using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        List<int> arr = new List<int>(){1, 1, 2, 2, 3};

        var expected = 1;

        var actual = Result.migratoryBirds(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        List<int> arr = new List<int>(){4, 4, 2, 2, 3};

        var expected = 2;

        var actual = Result.migratoryBirds(arr);

        Assert.Equal(expected, actual);
    }
}