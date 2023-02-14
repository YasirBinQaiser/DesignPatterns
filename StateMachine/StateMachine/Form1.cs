using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateMachine
{
public partial class Form1 : Form
{
TV _TV          = new TV();
Remote _Remote  = new Remote();


PowerState tvState      = new PowerState();
PowerState remoteState  = new PowerState();

public Form1()
    {
    InitializeComponent();
    }

void ShowStates ()
    {
    pictureBox1.Image = tvImages.Images[_TV.State.GetStateString()];
    lbl_Status.Text = "TV: " + _TV.State.GetStateString() + ", Remote: " + _Remote.State.GetStateString();
    }

private void btn_Power_Click(object sender, EventArgs e)
    {
    _Remote.NextState();
    if (chk_BlockSignal.Checked == false)
        _TV.SetState(_Remote.State);

    ShowStates ();

    //States = Off (0), Sleep (1), On (2)
    //Set Remote State
    //int rState = remoteState.GetState();
    //if (rState == 0 || rState == 1)
    //    rState = 2;
    //else if (rState == 2)
    //    rState = 1;
    //else
    //    rState = 0;
    //remoteState.SetState(rState);


    //int tState = tvState.GetState();
    //if (tState == 0 || tState == 1)             //tv is off or sleep
    //    { 
    //    if (rState == 0 || rState == 1)         //but the signal recieved is for sleep
    //        return;                             //no change in tv State
    //    else
    //        tState = 2;
    //    }
    //else if (tState == 2)                       //tv is sleep
    //    {
    //    if (rState == 2)                        // no change in tv State
    //        return;
    //    else 
    //        tState = rState;                    //
    //    }

    //tvState.SetState(tState);

    }

private void btn_PowerOff_Click(object sender, EventArgs e)
    {
    _TV.PowerOff();
    ShowStates();
    }
}
}
