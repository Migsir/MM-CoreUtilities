using System;
using System.IO;
using System.IO.Compression;

namespace MMUtilities
{
    public class ZipExtractor
    {
        public void ExtractZipFiles(string inputFolder, string outputFolder, bool overrideFiles = false, string moveZipsFolder = null)
        {
            // Verify that the input directory exists.
            if (!Directory.Exists(inputFolder))
            {
                throw new DirectoryNotFoundException($"Input directory was not found: {inputFolder}");
            }

            // Create the output directory if it doesn't exist.
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // Optionally, create the directory to move ZIP files into, if specified.
            if (!string.IsNullOrEmpty(moveZipsFolder))
            {
                if (!Directory.Exists(moveZipsFolder))
                {
                    Directory.CreateDirectory(moveZipsFolder);
                }
            }

            // Get all ZIP files in the input directory.
            string[] zipFiles = Directory.GetFiles(inputFolder, "*.zip");

            foreach (var zipFilePath in zipFiles)
            {
                try
                {
                    // Create a subfolder in the output directory named after the ZIP file.
                    string zipFileName = Path.GetFileNameWithoutExtension(zipFilePath);
                    string zipOutputPath = outputFolder;
                    Directory.CreateDirectory(zipOutputPath);

                    // Extract the ZIP file into the subfolder.
                    ZipFile.ExtractToDirectory(zipFilePath, zipOutputPath, overrideFiles);
                    Console.WriteLine($"File extracted: {zipFilePath} to {zipOutputPath}");

                    // Move the ZIP file if the moveZipsFolder is specified.
                    if (!string.IsNullOrEmpty(moveZipsFolder))
                    {
                        string newZipPath = Path.Combine(moveZipsFolder, Path.GetFileName(zipFilePath));
                        if (File.Exists(newZipPath))
                        {
                            File.Delete(newZipPath); // Delete the existing file if it exists.
                        }
                        File.Move(zipFilePath, newZipPath);
                        Console.WriteLine($"File moved: {zipFilePath} to {newZipPath}");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error extracting file {zipFilePath}: {ex.Message}");
                }
            }
        }
    }
}
