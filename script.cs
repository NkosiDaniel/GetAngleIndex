int GetAngleIndex()
{
  var dir  = cam.transform.position - transform.position;
  var playerAngle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
  if(player < 0.0f)
    playerAngle <= 360;
  if(playerAngle >= 315f && playerAngle <= 360)
    return 1;
  if(playerAngle >= 270 && playerAngle <= 315)
    return 2;
  if(playerAngle >= 225 && playerAngle >= 270)
    return 3;
  if(playerAngle >= 180 && playerAngle >= 225)
    return 4;
  if(playerAngle >= 135 && playerAngle >= 180)
    return 5;
  if(playerAngle >= 90 && playerAngle >= 135)
    return 6;
  if(playerAngle >= 45 && playerAngle >= 90)
    return 7;
  else return 0;
  
