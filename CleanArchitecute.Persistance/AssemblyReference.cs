using System.Reflection;

namespace CleanArchitecute.Persistance;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
