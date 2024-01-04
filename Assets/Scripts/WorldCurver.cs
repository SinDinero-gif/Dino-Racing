using UnityEngine;

[ExecuteInEditMode]
public class WorldCurver : MonoBehaviour
{
	[Range(-0.0006f, 0.0006f)]
	public float curveStrength = 0.01f;

    int m_CurveStrengthID;

    private void OnEnable()
    {
        m_CurveStrengthID = Shader.PropertyToID("_Sideways_Strength");
    }

	void Update()
	{
		Shader.SetGlobalFloat(m_CurveStrengthID, curveStrength);
	}
}
