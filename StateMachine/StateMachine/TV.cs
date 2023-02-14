using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{

public class TV
{
public PowerState State = new PowerState();

public void SetState (PowerState powerState)
    {
    int newState = powerState.GetState();
    if (State.GetState() == 0 && newState == 1)
        return;

    State.SetState(newState);
    }

public void PowerOff ()
    {
    State.SetState(0);
    }

}
}
