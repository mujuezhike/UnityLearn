
@script ExecuteInEditMode

private var gui : GUIText;

private var updateInterval = 1.0;
private var lastInterval : double; // Last interval end time
private var frames = 0; // Frames over current interval
var dir : Vector3 = Vector3.zero;

function Start()
{
	Application.targetFrameRate = 60;
	Screen.sleepTimeout = SleepTimeout.NeverSleep;
    lastInterval = Time.realtimeSinceStartup;
    Screen.sleepTimeout = SleepTimeout.NeverSleep;
    frames = 0;
}

function OnDisable ()
{
	if (gui)
		DestroyImmediate (gui.gameObject);
}

function Update()
{
	if (Input.GetKey ("escape")) {
        Application.Quit();
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
    if (Input.GetKey( KeyCode.Menu ) ) {
        	Application.LoadLevel (Application.loadedLevelName);
    }

    
#if !UNITY_FLASH
    ++frames;
    var timeNow = Time.realtimeSinceStartup;
    if (timeNow > lastInterval + updateInterval)
    {
		if (!gui)
		{
			var go : GameObject = new GameObject("FPS Display", GUIText);
			go.hideFlags = HideFlags.HideAndDontSave;
			go.transform.position = Vector3(0,0,0);
			gui = go.GetComponent.<GUIText>();
			gui.pixelOffset = Vector2(20,30);
		}

        var fps : float = frames / (timeNow - lastInterval);
		//var ms : float = 1000.0f / Mathf.Max (fps, 0.00001);
		//gui.text = ms.ToString("f1") + "ms " + fps.ToString("f2") + " FPS";// 
		gui.text = "  " + fps.ToString("f2") + " FPS";// 
        frames = 0;
        lastInterval = timeNow;
    }
#endif
}
