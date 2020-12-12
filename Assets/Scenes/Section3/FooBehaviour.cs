using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;

namespace App.Section3
{
    public interface IFoo {}
    public class Foo: IFoo {}

    public class FooBehaviour : MonoBehaviour
    {
        private Foo foo;

        // [Inject]
        // public void Construct(Foo foo)
        // // public void Construct([Inject(Id = "A")]Foo foo)    //IDをつけてのinjection
        // {
        //     this.foo = foo;
        //     Debug.Log(this.foo);
        // }

        //interfaceに対してのinjection
        [Inject]
        public void Construct(IFoo foo)
        {
            Debug.Log(foo);
        }
        
    }
}