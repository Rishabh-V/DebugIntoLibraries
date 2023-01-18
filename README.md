# Debug Into Libraries

This is a sample app to see if we can step into the library code while debugging after doing the required settings.

We need to add the following XML element (with value true) to a `<PropertyGroup>` element in the project file.

```
<CopyDebugSymbolFilesFromPackages>true</CopyDebugSymbolFilesFromPackages>
```
