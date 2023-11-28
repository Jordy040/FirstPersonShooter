using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class Body : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().sharedMesh = mesh;
        GetComponent<MeshCollider>().convex = true;
        CreateShape();
        UpdateMesh();
    }

    // Update is called once per frame
    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3(0.0f,0.0f,0.0f), // 0 bottem left
            new Vector3(0.0f,0.0f,1.0f), // 1 top left
            new Vector3(1.0f,0.0f,0.0f), // 2 top right
            new Vector3(1.0f,0.0f,1.0f), // 3 bottem right
            new Vector3(0.5f,1.0f,0.5f), // 4 top coördinate
            new Vector3(0.5f,-1.0f,0.5f), // 5 low coördinate
        };
        triangles = new int[]
        {
          2,1,0, // onderkant
          1,2,3, // onderkant

          2,0,4, // bovenkant piramide
          0,1,4, // bovenkant piramide
          1,3,4, // bovenkant piramide
          3,2,4, // bovenkant piramide

          2,0,5, // onderkant piramide
          0,1,5, // onderkant piramide
          1,3,5, // onderkant piramide
          3,2,5, // onderkant piramide
         

   
         
        };
    }
    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
