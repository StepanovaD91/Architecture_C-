using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IServiceLocator<T> 
{
    TP Register<TP>(TP newService) where TP : T;
    void Unregister<TP>(TP service) where TP : T;
    TP Get<TP>() where TP : T;
}
