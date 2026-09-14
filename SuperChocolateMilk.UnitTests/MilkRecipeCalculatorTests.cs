namespace SuperChocolateMilk.UnitTests;

using Xunit;
using SuperChocolateMilk.Core;

public class MilkRecipeCalculatorTests
{
    [Fact]
    public void CalculateChocolateSyrup_RegularRichness_ReturnsTenPercentRatio()
    {

        int milkVolume = 100;
        string richness = "Regular";

        decimal result = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        Assert.Equal(100m, result);
    }

    [Theory]
    [InlineData(1000, "Light", 75)]
    [InlineData(1000, "Extra", 150)]
    [InlineData(1000, "ultra_choco", 200)]
    [InlineData(0, "Regular", 0)]

    public void CalculateChocolateSyrup_VariousScenarious_ReturnsExpectedAmount(
        int milkVolume, string richness, int expectedSyrup)
    {
        decimal actualresult = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        
        Assert.Equal(expectedSyrup, actualresult);
    }
}   