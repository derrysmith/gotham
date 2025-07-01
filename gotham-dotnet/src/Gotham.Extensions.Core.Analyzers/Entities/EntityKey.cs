namespace Gotham.Extensions.Core.Entities;

public record EntityKey
{
	public string Prefix { get; }
	public string Suffix { get; }

	public string FileName { get; }

	public string TypeName      { get; }
	public string TypeNamespace { get; }

	public EntityKey(string fileName, string typeName, string typeNamespace, string prefix = "", string suffix = "")
	{
		this.FileName      = fileName;
		this.TypeName      = typeName;
		this.TypeNamespace = typeNamespace;
		this.Prefix        = prefix;
		this.Suffix        = suffix;
	}
}