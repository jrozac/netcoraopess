﻿using System;

namespace NetCoreAopEssentials.Cache
{

    /// <summary>
    /// Cacheable attribute 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheableAttribute : Attribute
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="keyTemplate"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="groupId"></param>
        /// <param name="provider"></param>
        /// <param name="useCustomProvider"></param>
        public CacheableAttribute(string keyTemplate, long timeoutMs = 0, string groupId = null, 
            EnumCacheProvider provider = EnumCacheProvider.Memory, bool useCustomProvider = false)
        {
            KeyTemplate = keyTemplate;
            TimeoutMs = timeoutMs;
            GroupId = groupId;
            Provider = useCustomProvider ? new EnumCacheProvider?(provider) : null;
        }

        /// <summary>
        /// Custom cache provider
        /// </summary>
        public EnumCacheProvider? Provider { get; private set; }

        /// <summary>
        /// Key template 
        /// </summary>
        public string KeyTemplate { get; private set; }

        /// <summary>
        /// Group id 
        /// </summary>
        public string GroupId { get; private set; }

        /// <summary>
        /// Timeout 
        /// </summary>
        public long TimeoutMs { get; private set; }
    }
}
