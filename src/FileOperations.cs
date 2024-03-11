using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMUtilities
{

    // This class is designed to handle file operations. Methods to manage files (e.g., read, write, move, delete) can be added here as needed.
    public class FileOperations
    {

        // Searches for files with a specified extension in the source directory and copies or moves them to the target directory.
        public void CopyFilesByExtension(string sourceDirectory, string targetDirectory, string extension, bool overwriteFiles = false, bool moveFiles = false)
        {
            // Ensure the source directory exists.
            if (!Directory.Exists(sourceDirectory))
            {
                throw new DirectoryNotFoundException($"The source directory was not found: {sourceDirectory}");
            }

            // Ensure the target directory exists; if not, create it.
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            // Get all files in the source directory with the specified extension.
            var filesToCopy = Directory.EnumerateFiles(sourceDirectory, $"*.{extension}", SearchOption.AllDirectories);

            foreach (var file in filesToCopy)
            {
                // Construct the path for the copied or moved file in the target directory.
                var targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(file));

                // Check if the file should be moved instead of copied.
                if (moveFiles)
                {
                    // Move the file.
                    if (File.Exists(targetFilePath) && overwriteFiles)
                    {
                        File.Delete(targetFilePath); // Ensure the target file is deleted before moving if overwrite is enabled.
                    }
                    File.Move(file, targetFilePath);
                }
                else
                {
                    // Copy the file.
                    File.Copy(file, targetFilePath, overwriteFiles); // Overwrites if the file already exists and overwriteFiles is true.
                }
            }

            Console.WriteLine($"All files with extension .{extension} have been {(moveFiles ? "moved" : "copied")} from {sourceDirectory} to {targetDirectory}.");
        }

        // Displays all files within a directory, including files in subdirectories.
        public void DisplayAllFiles(string directoryPath)
        {
            // Ensure the directory exists.
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"The directory was not found: {directoryPath}");
            }

            // Get all files in the directory and subdirectories, then order them by extension.
            var allFiles = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                            .OrderBy(file => Path.GetExtension(file));

            Console.WriteLine($"Files in {directoryPath}:");
            foreach (var file in allFiles)
            {
                Console.WriteLine(file);
            }
        }

    }
}
