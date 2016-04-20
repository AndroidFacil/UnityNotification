using UnityEngine;
using System.Collections;

public class NotificationTest : MonoBehaviour {

    float sleepUntil = 0;
	
	void OnGUI () {

        GUI.enabled = sleepUntil < Time.time;

        if (GUILayout.Button("EM 5 SEGUNDOS", GUILayout.Height(Screen.height * 0.2f)))
        {
            LocalNotification.SendNotification(1, 5, "TITULO: 5s", "coloque a msg aqui", new Color32(0xff, 0x44, 0x44, 255));
            sleepUntil = Time.time + 5;
        }

        if (GUILayout.Button("EM 5 SEGUNDOS COM ICON", GUILayout.Height(Screen.height * 0.2f)))
        {
            LocalNotification.SendNotification(1, 5, "TITULO: 5S ICON", "mensagem com icone", new Color32(0xff, 0x44, 0x44, 255), true, true, true, "app_icon");
            sleepUntil = Time.time + 5;
        }

        if (GUILayout.Button("A CADA 5 SEGUNDOS", GUILayout.Height(Screen.height * 0.2f)))
        {
            LocalNotification.SendRepeatingNotification(1, 5, 5, "TITULO de 5 em 5", "msg de 5 em 5", new Color32(0xff, 0x44, 0x44, 255));
            sleepUntil = Time.time + 99999;
        }

        if (GUILayout.Button("EM EXATOS 10 SEGUNDOS", GUILayout.Height(Screen.height * 0.2f)))
        {
            LocalNotification.SendNotification(1, 10, "TITULO: EXATO 10", "mensagem enviada em 10s", new Color32(0xff, 0x44, 0x44, 255), executeMode: LocalNotification.NotificationExecuteMode.ExactAndAllowWhileIdle);
            sleepUntil = Time.time + 10;
        }

        GUI.enabled = true;

        if (GUILayout.Button("PARAR", GUILayout.Height(Screen.height * 0.2f)))
        {
            LocalNotification.CancelNotification(1);
            sleepUntil = 0;
        }
	}
}
