using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace App.Section2
{
    public class BarBehaviour : MonoBehaviour
    {
        //フィールドインジェクション
        // [Inject]
        // private FooBehaviour _fooBehaviour;

        //プロパティインジェクション
        // [Inject]
        // public FooBehaviour FooBehaviourProperty
        // {
        //     get;
        //     private set;
        // }

        //インスペクタ確認用にあえてpublic
        public FooBehaviour fooBehaviour;

        //メソッドインジェクション
        //DiContainerにBindしたComponent(FooBehaviour)をContextがinjectする
        [Inject]
        public void Construct(FooBehaviour fooBehaviour)
        {
            this.fooBehaviour = fooBehaviour;
        }
    }
}