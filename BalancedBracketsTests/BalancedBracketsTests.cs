namespace BalancedBracketsTests;

using BalancedBrackets; 
using System;



[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.
    [TestMethod]

    public void MismatchReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch[]"));
    }
    [TestMethod]

    public void StringwithBracketOutOfOrder()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
    }
    [TestMethod]

    public void BracketsInFront()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
    }
    [TestMethod]

    public void OnlyClosedBracketReturnsFalse()
    {
        Assert.IsFalse (BalancedBrackets.HasBalancedBrackets("Launch]"));
    }
    [TestMethod]

    public void OnlyOpenBracketWithStringReturnsFalse()
    {        
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch"));
    }
    [TestMethod]

    public void StringAndBracketsReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
    }
    [TestMethod]

    public void StringInBracketReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
    }
    [TestMethod]

    public void BracketsInWrongOrder()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
    }
    [TestMethod]

    public void OneBracketReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
    }
    [TestMethod]

    public void EmptyStringReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
    }
    [TestMethod] 

    public void OnlyBracketsReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }
    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }
}
