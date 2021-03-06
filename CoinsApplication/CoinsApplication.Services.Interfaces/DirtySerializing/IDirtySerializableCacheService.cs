﻿using System;

namespace CoinsApplication.Services.Interfaces.DirtySerializing
{
    public interface IDirtySerializableCacheService
    {
        bool IsEmpty { get; }

        void Add(IDirtySerializable serializable);

        void Remove(IDirtySerializable serializable);

        void Commit();

        event EventHandler CacheChanged;
    }
}
