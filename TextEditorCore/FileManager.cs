using System.IO;
using System.Text;

namespace TextEditorCore
{
    /// <summary>
    ///   The "IFileManager" interface represents the implementation of the data access logic.
    /// </summary>
    public interface IFileManager
    {
        bool IsFileExists(string FilePath);
        int GetSymbCount(string content);
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
    }

    /// <summary>
    ///     The FileManager class provides data to the client by implementing the IFileManager interface.
    ///     Data provider: text document in ".txt" format.
    /// </summary>
    public class FileManager : IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsFileExists(string FilePath)
        {
            var isExists = File.Exists(FilePath);

            return isExists;
        }

        public  int GetSymbCount(string content)
        {
            var count = content.Length;

            return count;
        }

        public string GetContent(string filePath)
        {

            return GetContent(filePath, _defaultEncoding);
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            var content = File.ReadAllText(filePath, encoding);

            return content;
        }

        public void SaveContent(string content, string filePath)
        {

            SaveContent(content, filePath, _defaultEncoding);
        }

        public void SaveContent(string content, string filePath, Encoding encoding)
        {

            File.WriteAllText(filePath, content, encoding);
        }

    }
}
