using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ProjectInstaller", menuName = "Installers/ProjectInstaller")]
public class ProjectInstaller : ScriptableObjectInstaller<ProjectInstaller>
{
    public override void InstallBindings()
    {
    }
}