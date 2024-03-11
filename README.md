[
# MMUtilities

## Description
`MMUtilities` is a C# utility library designed to facilitate various file and directory management operations. It includes functionalities for extracting ZIP files and for copying, moving, and listing files based on specific criteria such as file extension.

## Installation
To use `MMUtilities`, first clone the repository to your local machine using:
```
git clone https://your-repository/MMUtilities.git
```
Then, include `MMUtilities` in your C# project to start using the provided tools.

## Usage

### ZIP File Extraction
The `ZipExtractor` class provides functionalities for decompressing ZIP files, with options to overwrite existing files and move ZIP files after decompression.

#### Usage Example:
```csharp
var zipExtractor = new MMUtilities.ZipExtractor();
zipExtractor.ExtractZipFiles(inputFolder: @"C:\path	o\input",
                             outputFolder: @"C:\path	o\output",
                             overrideFiles: true,
                             moveZipsFolder: @"C:\path	o\move\zips");
```

### File Operations
The `FileOperations` class includes methods for copying or moving files based on file extension, as well as for listing all files within a directory, sorted by extension.

#### Copy or Move Files by Extension
```csharp
var fileOps = new MMUtilities.FileOperations();
fileOps.CopyFilesByExtension(sourceDirectory: @"C:\path	o\source",
                             targetDirectory: @"C:\path	o	arget",
                             extension: "txt",
                             overwriteFiles: true,
                             moveFiles: false);
```

#### List All Files in a Directory
```csharp
fileOps.DisplayAllFiles(directoryPath: @"C:\path	o\directory");
```

## Contributing
If you would like to contribute to `MMUtilities`, please feel free to fork the repository, make your changes, and open a pull request for review.

## License
`MMUtilities` is distributed under the MIT License. See the `LICENSE` file in the repository for more information.
](https://github.com/Migsir/MM-CoreUtilities.git)https://github.com/Migsir/MM-CoreUtilities.git
