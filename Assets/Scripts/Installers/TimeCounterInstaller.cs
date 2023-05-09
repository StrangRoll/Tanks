using Systems;
using UnityEngine;
using Zenject;

public class TimeCounterInstaller : MonoInstaller
{
    [SerializeField] private TimeCounter timeCounter;
    
    public override void InstallBindings()
    {
        timeCounter = Instantiate(timeCounter);
        DontDestroyOnLoad(timeCounter);
        
        Container
            .Bind<TimeCounter>()
            .FromInstance(timeCounter)
            .AsSingle();
    }
}