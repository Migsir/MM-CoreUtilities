static void ZipExtractor() 
{
    MMUtilities.ZipExtractor extractor = new MMUtilities.ZipExtractor();

    //ZIP Extractor
    string _sourcePath      = @"C:\path\to\source";
    string _destinationPath = @"C:\path\to\target";
    string _backupPath      = @"C:\path\to\backup";

    bool _overrideFiles = true;

    extractor.ExtractZipFiles(_sourcePath, _destinationPath, _overrideFiles, _backupPath);
}

static void CopyMoveFiles() 
{

    string sourceDirectory = @"C:\Users\JMMena\Downloads\Coleccion de Libros";
    string targetDirectory = @"C:\Users\JMMena\Downloads\MaineBookFiles";
    string extension = "lit"; // For example, looking for .pdf files
    bool overwriteFiles = true; // Set to true to overwrite existing files
    bool moveFiles = true; // Set to true to move files instead of copying

    var fileOps = new MMUtilities.FileOperations();
    fileOps.CopyFilesByExtension(sourceDirectory, targetDirectory, extension, overwriteFiles, moveFiles);
}

static void DisplayAllTheFiles() 
{
    //string directoryPath = @"C:\path\to\your\directory";
    string directoryPath = @"C:\Users\JMMena\Downloads\Coleccion de Libros";

    var fileOps = new MMUtilities.FileOperations();
    fileOps.DisplayAllFiles(directoryPath);
}


//ZipExtractor();
//CopyMoveFiles();
DisplayAllTheFiles();


Console.WriteLine("process completed...");
