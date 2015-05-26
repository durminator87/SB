#pragma strict
var panelCreditCanvas : Canvas;
var infoOpen = false;

var panelSettingsCanvas : Canvas;
var settingsOpen = false;

function Start () {

}

function Update () {

}
//this function loads the level1
function StartGame () {
Application.LoadLevel("Level1");

}

function MainMenu (){
Application.LoadLevel("MainMenu");

}
//this function exits the game
function ExitGame () {
Application.Quit();
}
function InfoPanel () 
{
	if (infoOpen == false)
	{
		infoOpen=true;
		panelCreditCanvas.enabled=true;
	}
	else if (infoOpen == true)
	{
		infoOpen=false;
		panelCreditCanvas.enabled=false;
	}
}

function SettingsPanel () 
{
	if (settingsOpen == false)
	{
		settingsOpen=true;
		panelSettingsCanvas.enabled=true;
	}
	else if (settingsOpen == true)
	{
		settingsOpen=false;
		panelSettingsCanvas.enabled=false;
	}
}