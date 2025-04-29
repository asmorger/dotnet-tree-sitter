using System.Runtime.InteropServices;

namespace TreeSitter.CSharp;

public static class CSharpLanguage
    {
        private const string DllName = "tree-sitter-csharp";

        [DllImport(DllName)]
        private static extern IntPtr tree_sitter_csharp();

        public static Language Create() => new Language(tree_sitter_csharp());
    }
