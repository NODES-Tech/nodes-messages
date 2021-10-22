using System;

namespace Nodes.Messages
{
    public class NodesMessages
    {
        /// <summary>
        /// NodesMessages semantic version, read from assembly 
        /// </summary>
        public static Version Version { get; } = typeof(NodesMessages).Assembly.GetName().Version;
    }
}