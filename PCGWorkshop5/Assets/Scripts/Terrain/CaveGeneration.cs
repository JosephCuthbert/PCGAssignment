using UnityEngine;
using LibNoise;
using LibNoise.Generator;
using LibNoise.Operator;

public class CaveGeneration : MonoBehaviour
{


    public float frequency = 1.0f;
    public float lacu = 1.0f;
    public int octaves = 6;
    public float persist = 1.0f;
    public float threshold = 0.5f;
    public float falloff = 0.25f;

    public Terrain terrain;

    public float sampleSizeX = 4.0f; // perlin sample size
    public float sampleSizeY = 4.0f; 

    public float sampleOffsetX = 6.0f; 
    public float sampleOffsetY = 1.0f;

    public int length = 512;
    public int height = 50;
    public int width = 512;

    public void Generate()

    {
        TerrainData terrainData = terrain.terrainData;

        Debug.Log("Working");
        var generator = new RidgedMultifractal(sampleSizeX, sampleSizeY, octaves, (int)(Random.value * 0xffffff), QualityMode.High);

        var clamped = new Select(new Const(0.0f), new Const(1.0f),generator);
       
        clamped.SetBounds(0f, threshold);
        clamped.FallOff = falloff;

        terrainData.size = new Vector3(length,height,width);    
     
        var noise = new Noise2D(terrainData.heightmapResolution, clamped);

     
        noise.GeneratePlanar(sampleOffsetX,sampleOffsetX + sampleSizeX,sampleOffsetY,sampleOffsetY + sampleSizeY );
       
        float[,] heights = noise.GetNormalizedData(true, 0, 0);

        terrainData.SetHeights(0, 0, heights);

        
    }
}
