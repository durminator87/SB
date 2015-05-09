#pragma strict

function Start () 
{

}

function Update () 
{

}
//this function loads the level1
function StartGame () 
{
Application.LoadLevel("Level1");

}

function MainMenu ()
{
Application.LoadLevel("MainMenu");

}
//this function exits the game
function ExitGame () 
{
Application.Quit();

}