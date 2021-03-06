﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Throne.Framework.Utilities
{
    /// <summary>
    ///     General use class to read files line for line.
    /// </summary>
    /// <remarks>
    ///     Ignores empty lines and lines prefixed with '!', ';', '#', '//', or '--'.
    ///     Supports including of files via 'include {file}' and 'require {file}'.
    ///     Require raises an exception if the file couldn't be found.
    /// </remarks>
    /// <example>
    ///     <code>
    /// 	using (var fr = new FileReader(filePath))
    /// 	{
    /// 		foreach (string line in fr)
    /// 		{
    /// 			// Do something with line
    /// 		}
    /// 	}
    /// 	</code>
    /// </example>
    public class FileReader : IEnumerable<string>, IDisposable
    {
        private readonly string _filePath;
        private readonly string _relativePath;
        private readonly StreamReader _streamReader;
        private readonly IFileCryptography _fileCryptography;

        public FileReader(string filePath, IFileCryptography crypto = null)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File '" + filePath + "' not found.");

            _fileCryptography = crypto;
            _filePath = filePath;
            _relativePath = Path.GetDirectoryName(Path.GetFullPath(filePath));

            if (_fileCryptography != null)
            {
                var data = File.ReadAllBytes(filePath);
                _fileCryptography.Decrypt(data);
                _streamReader = new StreamReader(new MemoryStream(data));
                return;
            }

            _streamReader = new StreamReader(filePath);
        }

        public int CurrentLine { get; protected set; }

        public void Dispose()
        {
            _streamReader.Close();
        }

        public IEnumerator<string> GetEnumerator()
        {
            string line;

            // Until EOF
            while ((line = _streamReader.ReadLine()) != null)
            {
                CurrentLine++;

                line = line.Trim();

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Ignore very short or commented lines
                if (line.Length < 2 || line[0] == '!' || line[0] == ';' || line[0] == '#' || line.StartsWith("//") ||
                    line.StartsWith("--"))
                    continue;

                // Include files
                bool require = false, divert = false;
                if (line.StartsWith("include ") || (require = line.StartsWith("require ")) ||
                    (divert = line.StartsWith("divert ")))
                {
                    string fileName = line.Substring(line.IndexOf(' ')).Trim(' ', '"');
                    string includeFilePath = Path.Combine((!fileName.StartsWith("/") ? _relativePath : ""),
                        fileName.TrimStart('/'));

                    // Prevent recursive including
                    if (includeFilePath != _filePath)
                    {
                        // Silently ignore failed includes, only raise an
                        // exception on require.
                        if (File.Exists(includeFilePath))
                        {
                            using (var fr = new FileReader(includeFilePath, _fileCryptography))
                            {
                                foreach (string incLine in fr)
                                    yield return incLine;
                            }

                            // Stop reading current file if divert was successful
                            if (divert)
                                yield break;
                        }
                        else if (require)
                            throw new FileNotFoundException("Required file '" + includeFilePath + "' not found.");
                    }

                    continue;
                }

                yield return line;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}