using UnityEngine;
using System.Collections;
///
/// 掛載物件：不掛載
/// 作用：介面類，方便其他指令碼繼承此介面
/// 注意：
///
public interface IControl
{
    //生成遊戲物件的方法
    void Spawn();
    //銷燬遊戲物件
    void UnSpwan();
}