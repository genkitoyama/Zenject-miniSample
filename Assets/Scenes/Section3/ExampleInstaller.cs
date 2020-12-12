using UnityEngine;
using Zenject;

using App.Section3;

public class ExampleInstaller : MonoInstaller
{
    // [SerializeField]
    // private FooBehaviour fooBehaviourPrefab;

    public override void InstallBindings()
    {
        //FooをBindし、一つだけしか存在しないことを保証する
        // Container.Bind<Foo>().AsSingle();

        //WithIdで固有IDを振れる
        // Container.Bind<Foo>().WithId("A").AsSingle();

        //interfaceに対するBindは、To<ResultType>で型変換する
        Container.Bind<IFoo>().To<Foo>().AsCached();

        //インスペクタ上で設定したprefabを生成元にしてFooBehaviourをBindする
        // Container.Bind<FooBehaviour>()
        //          .FromComponentInNewPrefab(this.fooBehaviourPrefab)
        //          .AsCached();
    }
}