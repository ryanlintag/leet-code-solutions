using LeetCodeSolutions;
namespace LeetCodeTests;

public class ArrayTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
    [InlineData(new int[] { 4, 5, 6, 7, 8, 9, 10 }, 4, new int[] { })]
    public void TwoSum_Test(int[] nums, int target, int[] expected)
    {
        //Arrange 
        var sut = new ArraySolutions();
        //Act
        var result = sut.TwoSum(nums, target);
        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[]{}, new int[]{})]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 })]
    public void RemoveIntegerDuplicatesInSortedArray_Test(int[] nums, int[] expected)
    {
        //Arrange 
        var sut = new ArraySolutions();
        //Act
        var result = sut.RemoveIntegerDuplicatesInSortedArray(nums);
        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[]{}, 0)]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 1)]
    public void RemoveArrayDuplicates_ReturnLength_Test(int[] nums, int acceptedLength)
    {
        //Arrange 
        var sut = new ArraySolutions();
        //Act
        var result = sut.RemoveArrayDuplicates(nums);
        //Assert
        Assert.Equal(acceptedLength, result);
    }
}
