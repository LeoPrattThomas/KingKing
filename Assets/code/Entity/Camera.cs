using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

  public GameObject Player;
  private Vector3 _endPoint;

  private const float DISTANCE_THRESHOLD = 6.0f;

  void Start () {
    if (this.Player != null) {
      this._endPoint = this.Player.transform.position;
    }
  }

  void Update () {
    if (this.Player != null) {
      // Check if the distance between the player and the ball is big enough to start moving
      if (Vector3.Distance(this.Player.transform.position, this.transform.position) > DISTANCE_THRESHOLD) {
        // Start moving towards the player
        this.transform.position = Vector3.Slerp(this.transform.position, this._endPoint, Time.deltaTime);
      }
      // Check if the tracker has finally reached its end point. If it hasn't, keep on moving.
      if (this.transform.position != this._endPoint) {
        this.transform.position = Vector3.Slerp(this.transform.position, this._endPoint, Time.deltaTime);
      }
      

      // Update the last frame's player position
      this._endPoint = this.Player.transform.position;
    }
  }
}