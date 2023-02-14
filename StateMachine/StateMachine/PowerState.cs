using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
public class PowerState
{
int state = 0;

string[] strs = new string[] {"Off", "Sleep", "On" };
public PowerState()
    {
        
    }

public string GetStateString ()
    {
    return strs[state];
    }

public int GetState ()
    {
    return state;
    }

public void SetState (int newState)
    {
    state = newState;
    }

}
}
