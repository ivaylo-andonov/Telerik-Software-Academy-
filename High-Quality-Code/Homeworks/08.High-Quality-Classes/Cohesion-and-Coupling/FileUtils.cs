namespace CohesionAndCoupling
{
    using System;
    using Abstraction.Validator;

    internal static class FileUtils
    {
        internal static string GetFileExtension(string fileName)
        {
            Validator.CheckIfStringIsNullOrEmpty(fileName, "You can not pass null or empty parameter");

            int indexOfLastDot = FindLastIndexOfDot(fileName);
            if (indexOfLastDot == -1)
            {
                ////Consider using throw new ArgumentException instead of returning string.Empty may not be a very good idea 
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        internal static string GetFileNameWithoutExtension(string fileName)
        {
            Validator.CheckIfStringIsNullOrEmpty(fileName, "You can not pass null or empty parameter");

            int indexOfLastDot = FindLastIndexOfDot(fileName);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string nameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return nameWithoutExtension;
        }

        private static int FindLastIndexOfDot(string input)
        {
            return input.LastIndexOf(".");
        }
    }
}