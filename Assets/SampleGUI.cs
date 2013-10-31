using UnityEngine;

public class SampleGUI : MonoBehaviour
{
	public SampleComponent[] objectList;
	
	void OnGUI ()
	{
		foreach (SampleComponent component in objectList) {
			GUILayout.Label (string.Format ("objectName:{0}, serializeCount:{1}, count{2}", component.gameObject.name, component.serializeCount, component.count));
			GUILayout.BeginHorizontal ();
			
			if (GUILayout.Button ("scount", GUILayout.Width (70))) {
				component.serializeCount ++;
			}
			if (GUILayout.Button ("count", GUILayout.Width (70))) {
				component.count ++;
			}
			component.msg = GUILayout.TextArea (component.msg);
		
			
			GUILayout.EndHorizontal ();
		}
	}
}
