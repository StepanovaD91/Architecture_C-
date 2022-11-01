using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ServiceBase : IService
{
    public int Version { get; }

    public ServiceBase(int version)
    {
        Version = version;
    }
}
