using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform piecePrefab;

    private int EmptyLocation;
    private int size;
    
    //Create de game setup with size x size pieces.
    /*private void CreateGamePieces(float gapThickness)
    {
        //This is the width of each title
        float width = 1 / float(size);
        for(int row = 0; row < size; row++)
        {
            for(int col = 0; col < size; col++)
            {
                Transform piece = Instantiate(piecePrefab, gameTransform);
                //Pieces will be in a game board from -1 to +1.
                piece.localPosition = new Vector3(-1 + (2 * width * col),
                                                  +1 + (2 * width * col),
                                                  0);
                piece.localScale = ((2 * width) - gapThickness) * Vector3.one;
                piece.name= $"{(row + size) + col}";
                //We want an empty space in the botton right
                if((row == size - 1) && (col == size - 1))
                {
                    empty.Location = (size * size) - 1;
                    piece.gameObject.SetActive(false);
                }
                else
                {
                    //We want to map the UV coordinates appropiately, they are 0->1.
                    UI[0] = new Vector2((width * col) + gap, 1 - ((width * (row + 1)) - gap));
                    UI[1] = new Vector2((width * col) + gap, 1 - ((width * (row + 1)) - gap));
                    UI[2] = new Vector2((width * col) + gap, 1 - ((width * (row + 1)) - gap));
                    UI[3] = new Vector2((width * col) + gap, 1 - ((width * (row + 1)) - gap));
                }
            }
        }





    }*/

    // Start is called before the first frame update
    void Start()
    {
        size = 3;
        //CreateGamePieces(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
