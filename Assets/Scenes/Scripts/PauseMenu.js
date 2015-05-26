#pragma strict

var panelPauseCanvas : Canvas;
var pauseOpen = false;
function Start () {

}

function Update () {

}
function RestartLevel()
{
Application.LoadLevel(Application.loadedLevelName);

}

function PausePanel () 
{
	if (pauseOpen == false)
	{
		pauseOpen=true;
		panelPauseCanvas.enabled=true;
	}
	else if (pauseOpen == true)
	{
		pauseOpen=false;
		panelPauseCanvas.enabled=false;
	}
}