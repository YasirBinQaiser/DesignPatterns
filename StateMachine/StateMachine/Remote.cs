using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
class Remote
{
public PowerState State = new PowerState();

public void NextState()
    {
    int state = State.GetState();
    if (state == 0 || state == 1)
        state = 2;
    else if (state == 2)
        state = 1;
    else
        state = 0;

    State.SetState(state);

    }
}
}