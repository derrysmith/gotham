namespace Gotham.Extensions.Core.Entities;

[AttributeUsage(AttributeTargets.Struct)]
public class EntityKeyAttribute : Attribute
{
	public string Prefix { get; set; } = string.Empty;
	public string Suffix { get; set; } = string.Empty;
}