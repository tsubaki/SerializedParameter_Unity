using UnityEngine;

public class SampleComponent : MonoBehaviour
{
	[SerializeParam]
	public string msg = string.Empty;
	public int count = 0;
	[SerializeParam]
	public int serializeCount = 0;
}