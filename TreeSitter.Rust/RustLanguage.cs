using System.Runtime.InteropServices;

namespace TreeSitter.Rust;

public static class RustLanguage
{
    private const string DllName = "tree-sitter-rust";

    [DllImport(DllName)]
    private static extern IntPtr tree_sitter_rust();

    public static Language Create() => new Language(tree_sitter_rust());
}
