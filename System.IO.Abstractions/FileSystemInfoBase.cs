﻿namespace System.IO.Abstractions
{
    /// <inheritdoc cref="FileSystemInfo"/>
    [Serializable]
    public abstract class FileSystemInfoBase
    {
        private readonly string originalPath;

        protected FileSystemInfoBase(IFileSystem fileSystem, string path)
        {
            FileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
            originalPath = path ?? throw new ArgumentNullException(nameof(path));
        }

        [Obsolete("This constructor only exists to support mocking libraries.", error: true)]
        internal FileSystemInfoBase() { }

        /// <summary>
        /// Exposes the underlying filesystem implementation. This is useful for implementing extension methods.
        /// </summary>
        public IFileSystem FileSystem { get; }

        /// <inheritdoc cref="FileSystemInfo.Delete"/>
        public abstract void Delete();

        /// <inheritdoc cref="FileSystemInfo.Refresh"/>
        public abstract void Refresh();

        /// <inheritdoc cref="FileSystemInfo.Attributes"/>
        public abstract FileAttributes Attributes { get; set; }

        /// <inheritdoc cref="FileSystemInfo.CreationTime"/>
        public abstract DateTime CreationTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.CreationTimeUtc"/>
        public abstract DateTime CreationTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.Exists"/>
        public abstract bool Exists { get; }

        /// <inheritdoc cref="FileSystemInfo.Extension"/>
        public abstract string Extension { get; }

        /// <inheritdoc cref="FileSystemInfo.FullName"/>
        public abstract string FullName { get; }

        /// <inheritdoc cref="FileSystemInfo.LastAccessTime"/>
        public abstract DateTime LastAccessTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastAccessTimeUtc"/>
        public abstract DateTime LastAccessTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastWriteTime"/>
        public abstract DateTime LastWriteTime { get; set; }

        /// <inheritdoc cref="FileSystemInfo.LastWriteTimeUtc"/>
        public abstract DateTime LastWriteTimeUtc { get; set; }

        /// <inheritdoc cref="FileSystemInfo.Name"/>
        public abstract string Name { get; }

        public override string ToString()
        {
            return originalPath;
        }
    }
}
