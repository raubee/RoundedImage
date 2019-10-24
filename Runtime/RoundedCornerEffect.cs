using UnityEngine;
using UnityEngine.UI;

namespace AdLucem.UI
{
	[ExecuteInEditMode]
	public class RoundedCornerEffect : BaseMeshEffect
	{
		[SerializeField] private float _radius = 1.0f;

		public override void ModifyMesh(VertexHelper vh)
		{
			UIVertex vertex = new UIVertex();
			for (int i = 0; i < vh.currentVertCount; i++)
			{
				vh.PopulateUIVertex(ref vertex, i);
				vertex.uv1 = new Vector2(GetComponent<RectTransform>().rect.width, GetComponent<RectTransform>().rect.height);
				vertex.uv2 = new Vector2(_radius, 0f);
				vh.SetUIVertex(vertex, i);
			}
		}
	}
}