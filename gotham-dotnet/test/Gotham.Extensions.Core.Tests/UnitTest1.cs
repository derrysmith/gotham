using Gotham.Extensions.Core.Entities;

namespace Gotham.Extensions.Core.Tests;

public class UnitTest1
{
	[Fact]
	public void Parse_returnsEntityKey()
	{
		// arrange
		const string value = "utk_01JZ3CH413DEBQMAG82T7FXGJE_key";
		
		// act
		var unitTestKey = UnitTestKey.Parse(value);
		
		// assert
		unitTestKey.ToString().ShouldStartWith("utk_");
		unitTestKey.ToString().ShouldEndWith("_key");
	}

	[Fact]
	public void Parse_throwsError_whenKeyValueHasNoSuffix()
	{
		// arrange
		const string value = "utk_01JZ3CH413DEBQMAG82T7FXGJE";
		
		// act
		Should.Throw<ArgumentException>(() => UnitTestKey.Parse(value));
	}
	
	[Fact]
	public void Parse_throwsError_whenKeyValueHasNoPrefix()
	{
		// arrange
		const string value = "01JZ3CH413DEBQMAG82T7FXGJE_key";
		
		// act
		Should.Throw<ArgumentException>(() => UnitTestKey.Parse(value));
	}
}

[EntityKey(Prefix = "utk_", Suffix = "_key")]
public readonly partial record struct UnitTestKey;