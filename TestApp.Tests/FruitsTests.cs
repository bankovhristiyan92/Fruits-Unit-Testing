using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
        {
            { "apple", 5 },
            { "banana", 10 }
        };
        string fruitName = "apple";

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
        {
            { "apple", 5 }
        };
        string fruitName = "orange";

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>();
        string fruitName = "apple";

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        string fruitName = "apple";

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        var fruitDictionary = new Dictionary<string, int>
        {
            { "apple", 5 }
        };
        string? fruitName = null;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}