# Add a new language

As an example, we're adding `Typescript`

## Find the grammar for the language

[src](https://github.com/tree-sitter/tree-sitter-typescript)

## Add it as a submodule to the `/langs-native` directory

```shell
git submodule add https://github.com/tree-sitter/tree-sitter-typescript
```

## Make The Project

```shell
cd tree-sitter-typescript
make
```

## Add .Net Project

Run this in the root of the repository

```shell
dotnet new classlib -o TreeSitter.Typescript
dotnet sln add ./TreeSitter.Typescript/TreeSitter.Typescript.csproj
```

## Add TreeSitter as a reference to new Project

I did this by hand after fiddling too long with dotnet cli commands

## Add the grammar to the Build.py script

```python
    build_lang("typescript", "Typescript", "parser.c", "scanner.c")
```

## Run Script

```shell
python build.py
```
