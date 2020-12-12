using System.Collections.Generic;
using UnityEngine;

using Zenject;

namespace App.Section3.Example
{
    public interface IExample {}

    public class Example: IExample
    {
        public Example(string args){}
    }

    public class ExampleMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IExample>()
                     .To<Example>()
                     .FromNew()             //通常のコンストラクタで生成
                     .AsSingle()            //ひとつ生成したら使い回す
                     .WithArguments("imo"); //初期化時に "imo" を引数で渡す（コンストラクタの引数がstringのため）
        }
    }
}