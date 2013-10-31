PersistentAmongPlayMode_Unity
=========================

エディタ上でゲーム実行時に変更したフィールド変数を保持します。

![pre game](https://raw.github.com/tsubaki/SerializedParameter_Unity/gh-pages/01.jpg)

![playing game](https://raw.github.com/tsubaki/SerializedParameter_Unity/gh-pages/02.jpg)  
起動後に値を変更

![exit game](https://raw.github.com/tsubaki/SerializedParameter_Unity/gh-pages/03.jpg)  
プレイ終了後も値を保持

#使い方

publicの変数に[PersistentAmongPlayMode]を付ける。  
構造体・クラス・プリミティブな値どれでも可…だと思う。

```
using UnityEngine;

public class SampleComponent : MonoBehaviour
{
	[PersistentAmongPlayMode]
	public string msg = string.Empty;

	public int count = 0;

	[PersistentAmongPlayMode]
	public int serializeCount = 0;
}
```

--
This software is released under the MIT License, see LICENSE.txt.