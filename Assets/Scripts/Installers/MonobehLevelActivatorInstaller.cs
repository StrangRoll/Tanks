using GameLogic.LevelActivators;
using UnityEngine;
using Zenject;

public class MonobehLevelActivatorInstaller : MonoInstaller
{
    [SerializeField] private MonobehLevelActivator activator;
    public override void InstallBindings()
    {
        Container
            .Bind<MonobehLevelActivator>()
            .FromInstance(activator)
            .AsSingle();
    }
}