using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocatorExample : MonoBehaviour
{
    private IServiceLocator<IService> _locator;
   private void Awake()
   {
        _locator = new ServiceLocator<IService>();
        var analytics = new AnalyticsService(1);
        _locator.Register(analytics);
   }
   private void Start()
   {
        var analytics = _locator.Get<AnalyticsService>();
        Debug.Log($"AnalyticsService version: {analytics.Version}");
   }
}
