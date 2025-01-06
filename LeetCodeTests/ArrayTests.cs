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
}
