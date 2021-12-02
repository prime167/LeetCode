using System;
using Xunit;
using LeetCode;

namespace Test;

public class UnitTest1 : IDisposable
{
    private readonly Problems _problems;

    public UnitTest1()
    {
        _problems = new Problems();
    }

    public void Dispose()
    {

    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void Test0001(int[] array, int b, int[] expected)
    {
        var r1 = _problems.TwoSum(array, b);
        Assert.Equal(expected, r1);
    }

    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(12, false)]
    [InlineData(0, true)]
    public void Test0009(int a, bool expected)
    {
        var r1 = _problems.IsPalindrome(a);
        Assert.Equal(expected, r1);
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Test0013(string str, int expected)
    {
        var r1 = _problems.RomanToInt(str);
        Assert.Equal(expected, r1);
    }

    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight"}, "fl")]
    [InlineData(new string[] { "a"}, "a")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void Test0014(string[] strs, string expected)
    {
        var r1 = _problems.LongestCommonPrefix(strs);
        Assert.Equal(expected, r1);
    }

    [Theory]
    [InlineData("", false)]
    [InlineData("[", false)]
    [InlineData("[]", true)]
    [InlineData("{}", true)]
    [InlineData("()", true)]
    [InlineData("([])", true)]
    [InlineData("({})", true)]
    [InlineData("()[]{}", true)]
    [InlineData("([)]", false)]
    [InlineData("(]{}", false)]
    public void Test0020(string str, bool expected)
    {
        var r1 = _problems.IsValid(str);
        Assert.Equal(expected, r1);
    }
}