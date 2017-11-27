using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;

    // Attributes
    private int stamina;
    private int endurance;
    private int strength;
    private int intellect;

    private Animator animation;
    private Vector2 direction;
    public float speed;

    private void Start()
    {
        direction = Vector2.zero;
        animation = GetComponent<Animator>();
    }

    private void Update()
    {
        GetInput();
        Move();
    }

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public void initiateCharacterOnScreen()
    {
    
        Debug.Log("oi");
    }

    /*
     * Character Attribute initialization
     */
    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

    /*
     * Movement Methods
     */
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        AnimateMovement();
    }

    public void AnimateMovement()
    {
        animation.SetFloat("x", direction.x);
        animation.SetFloat("y", direction.y);
    }

    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction+= Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction+= Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction+= Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction+= Vector2.right;
        }
    }
}
