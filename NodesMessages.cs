using System;

namespace Nodes.Messages
{
    public class NodesMessages
    {
        /// <summary>
        /// Standard string to specify messages version, used in e.g. Kafka headers
        /// </summary>
        public const string NodesMessagesVersionParam = "NODES.Messages.Version";
        
        /// <summary>
        /// NodesMessages semantic version, read from assembly 
        /// </summary>
        public static Version Version { get; } = typeof(NodesMessages).Assembly.GetName().Version;
    }
}