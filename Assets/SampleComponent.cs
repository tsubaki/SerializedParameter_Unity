using UnityEngine;

public class SampleComponent : MonoBehaviour
{
	[PersistentAmongPlayMode]
	public string msg = string.Empty;
	public int count = 0;
	[PersistentAmongPlayMode]
	public int serializeCount = 0;
}