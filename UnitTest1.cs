namespace IDE0058_Test;

public class UnitTest1
{
	private class Customer
	{
		public string? Name { get; set; }
		public int Age { get; set; }
	}

	[Fact]
	public void Assignment_ShouldSucceed()
	{
		Customer? customer = new();
		customer?.Name = "Default Name";
		Assert.Equal("Default Name", customer?.Name);
    }

    [Fact]
	public void Assignment_ShouldFail()
	{
		Customer? customer = null;
		customer?.Name = "Default Name";
		Assert.Null(customer?.Name);
    }
}
