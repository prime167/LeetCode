using System;
using Xunit;
using LeetCode;
using System.Collections.Generic;
using Xunit.Abstractions;
using System.Collections;

namespace Test;

public class UnitTest1 : IDisposable
{
    private readonly Problems _problems;
    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        _problems = new Problems();
        this.output = output;
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
    [InlineData(121, 121)]
    [InlineData(-121, -121)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(1534236469, 0)]
    [InlineData(2147483647, 0)]// int.max
    [InlineData(-2147483648, 0)]// int.min 溢出，返回0
    [InlineData(-1563847412, 0)] // 溢出，返回0
    public void Test0007(int a, int expected)
    {
        var r1 = _problems.Reverse(a);
        output.WriteLine(r1.ToString());
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

    [Fact]
    //[InlineData("(]{}", false)]
    public void Test0021()
    {
        var n1 = new ListNode { val = 1 };
        var n2 = new ListNode { val = 3 };
        var n3 = new ListNode { val = 5 };
        var n4 = new ListNode { val = 7 };
        var n5 = new ListNode { val = 9 };
        var a1 = BuildList(n1, n2, n3, n4, n5, n5);

        var n11 = new ListNode { val = 2 };
        var n12 = new ListNode { val = 4 };
        var n13 = new ListNode { val = 6 };
        var n14 = new ListNode { val = 8 };
        var a2 = BuildList(n11, n12, n13, n14);

        var rr = BuildList(n1, n11, n2, n12, n3, n13, n4, n14, n5);
        var r1 = _problems.MergeTwoLists(a1,a2);
        Assert.Equal(rr, r1);
    }

    public static IEnumerable<object[]> SplitCountData
    {
        get
        {
            var n1 = new ListNode { val = 1 };
            var n2 = new ListNode { val = 3 };
            var n3 = new ListNode { val = 5 };
            var n4 = new ListNode { val = 7 };
            var n5 = new ListNode { val = 9 };
            BuildList(n1, n2, n3, n4, n5, n5);

            var n11 = new ListNode { val = 2 };
            var n12 = new ListNode { val = 4 };
            var n13 = new ListNode { val = 6 };
            var n14 = new ListNode { val = 8 };
            BuildList(n11, n12, n13, n14);
            return new List<object[]>
            {
                new object[] { "xUnit", 1 },
                new object[] { "is fun", 2 },
                new object[] { "to test with", 3 }
            };
        }
    }

    public static ListNode BuildList(params ListNode[] nodes)
    {
        if (nodes == null || nodes.Length == 0)
        {
            return null;
        }

        if (nodes.Length == 1)
        {
            return nodes[0];
        }

        ListNode head = new ListNode();
        ListNode current;

        head.val = nodes[0].val;
        head.next = null;
        current = head;

        for (int i = 1; i < nodes.Length; i++)
        {
            ListNode x = new ListNode();
            x.val = nodes[i].val;
            x.next = null;
            current.next = x;
            current = x;
        }

        return head;
    }
}