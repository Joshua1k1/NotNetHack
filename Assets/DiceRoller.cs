using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{	
	[SerializeField]
	private int _d2; //Backing store
	// This following variable doesn't appear even when serialised
	public int d2
	{
		// This is so that I can just call the d2, and it all happens for me by magic.
		get
		{
			_d2 = Random.Range(1,3);
			// This checks the working of the random number.
			if ((_d2 > 0) && (_d2 < 3))
			{
				return _d2;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d2 > 0) && (_d2 < 3))
			{
				_d2 = value;
			}
		}
	}
	
	[SerializeField]
	private int _d4; //Backing store
	// This following variable doesn't appear even when serialised
	public int d4
	{
		// This is so that I can just call the d4, and it all happens for me by magic.
		get
		{
			_d4 = Random.Range(1,5);
			// This checks the working of the random number.
			if ((_d4 > 0) && (_d4 < 5))
			{
				return _d4;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d4 > 0) && (_d4 < 5))
			{
				_d4 = value;
			}
		}
	}
	
	[SerializeField]
	private int _d6; //Backing store
	// This following variable doesn't appear even when serialised
	public int d6
	{
		// This is so that I can just call the d6, and it all happens for me by magic.
		get
		{
			_d6 = Random.Range(1,7);
			// This checks the working of the random number.
			if ((_d6 > 0) && (_d6 < 7))
			{
				return _d6;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d6 > 0) && (_d6 < 7))
			{
				_d6 = value;
			}
		}
	}
	
	[SerializeField]
	private int _d8; //Backing store
	// This following variable doesn't appear even when serialised
	public int d8
	{
		// This is so that I can just call the d8, and it all happens for me by magic.
		get
		{
			_d8 = Random.Range(1,9);
			// This checks the working of the random number.
			if ((_d8 > 0) && (_d8 < 9))
			{
				return _d8;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d8 > 0) && (_d8 < 9))
			{
				_d8 = value;
			}
		}
	}

	[SerializeField]
	private int _d10; //Backing store
	// This following variable doesn't appear even when serialised
	public int d10
	{
		// This is so that I can just call the d10, and it all happens for me by magic.
		get
		{
			_d10 = Random.Range(1,11);
			// This checks the working of the random number.
			if ((_d10 > 0) && (_d10 < 11))
			{
				return _d10;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d10 > 0) && (_d10 < 11))
			{
				_d10 = value;
			}
		}
	}
	
	[SerializeField]
	private int _d12; //Backing store
	// This following variable doesn't appear even when serialised
	public int d12
	{
		// This is so that I can just call the d12, and it all happens for me by magic.
		get
		{
			_d12 = Random.Range(1,13);
			// This checks the working of the random number.
			if ((_d12 > 0) && (_d12 < 13))
			{
				return _d12;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d12 > 0) && (_d12 < 13))
			{
				_d12 = value;
			}
		}
	}
	
	[SerializeField]
	private int _d20; //Backing store
	// This following variable doesn't appear even when serialised
	public int d20
	{
		// This is so that I can just call the d20, and it all happens for me by magic.
		get
		{
			_d20 = Random.Range(1,21);
			// This checks the working of the random number.
			if ((_d20 > 0) && (_d20 < 21))
			{
				return _d20;
			}
			else
			{
				Debug.Log("the dice roller has failed.");
				return 0;
			}
		}
		// It needs a set accessor because it has a get accessor. Idk why.
		set
		{
			if ((_d20 > 0) && (_d20 < 21))
			{
				_d20 = value;
			}
		}
	}

	// Start is called before the first frame update
    void Start()
    {
		d2 = d2;
		d4 = d4;
		d6 = d6;
		d8 = d8;
		d10 = d10;
		d12 = d12;
		d20 = d20;
	}

    // Update is called once per frame
    void Update()
    {
        d2 = d2;
		d4 = d4;
		d6 = d6;
		d8 = d8;
		d10 = d10;
		d12 = d12;
		d20 = d20;
    }
}





