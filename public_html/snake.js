
function checkSupported() {
  canvas = document.getElementById('canvas');
  if (canvas.getContext){
    ctx = canvas.getContext('2d');
    this.g =10;
    start();
  } 
  else {
    // Canvas is not supported
    alert("We're sorry, but your browser does not support the canvas tag. Please use any web browser other than Internet Explorer.");
  }
}

function start(){
  ctx.clearRect(0,0,canvas.width, canvas.height);
  this.pos = {
    'x':50,
    'y':50,
  }
  sBody = [];
  sLength = 3;
  updateScore();
  makeFood();
  draw();
  d = 'R';
  play();
}

function restart(){
  pause();
  start();
}

function pause(){
  clearInterval(i);
  allowPressKeys = false;
}

function play(){
  i = setInterval(move,100);
  allowPressKeys = true;
}

function draw(){
  if(sBody.some(collide)) {
    endGame();
    return false;
  }
  sBody.push([pos['x'],pos['y']]);
  ctx.fillStyle = "rgb(0,200,100)";
  ctx.fillRect(pos['x'],pos['y'],g,g);
  if(sBody.length > sLength) {
    var rem = sBody.shift();
    ctx.clearRect(rem[0],rem[1],g,g);
  }
  if(pos['x'] == sp[0] && pos['y'] ==sp[1]){
    makeFood();
    sLength += 1;
    updateScore();
  }
}

function Lpos(){
  return pos['x'] - g;
}
function Rpos(){
  return pos['x'] + g;
}
function Upos(){
  return pos['y'] - g;
}
function Dpos(){
  return pos['y'] + g;
}

function chooseDirection(axis){
  if(axis == 'x'){
    a = (pos['x'] > canvas.width / 2) ? Lmove() : Rmove();
  }
  else {
    a = (pos['y'] > canvas.height / 2) ? Umove() : Dmove();
  }
}

function Umove() {
  if(Upos() >= 0) {
    move('U', 'y', Upos());
  }
  else {
    chooseDirection('x');
  }
}
function Dmove() {
  if(Dpos() < canvas.height) {
    move('D', 'y', Dpos());
  }
  else {
    chooseDirection('x');
  }
}
function Lmove() {
  if(Lpos() >= 0){
    move('L','x',Lpos());
  }
  else {
    chooseDirection('y');
  }
}
function Rmove() {
  if(Rpos() < canvas.width){
    move('R','x',Rpos);
  }
  else {
    chooseDirection('y');
  }
}

function move(dVal,axis,aVal) {
  d = dVal;
  pos[axis] = aVal;
  draw();
}

function makeFood(){
  sp = [Math.floor(Math.random()*(canvas.width/g))*g, Math.floor(Math.random()*(canvas.height/g))*g];
  if(sBody.some(hasPoint)) {
    makeFood();
  }
  else {
    ctx.fillStyle = "rgb(0,0,200)";
    ctx.fillRect(sp[0],sp[1],g,g);
  }
}

function hasPoint(ele, idx, arr) {
  return (ele[0] == sp[0] && ele[1] == sp[1]);
}
function collide(ele,idx,arr) {
  return(ele[0] == pos['x'] && ele[1]  == pos['y']);
}
function endGame(){
  var score = (sLength-3)*10;
  pause();
  alert("Game Over! Score: " + score);
  ctx.clearRect(0,0,canvas.height,canvas.width);
  document.getElementById('play_menu').style.display='none';
  document.getElementById('restart_menu').style.display='block';
}

function updateScore(){
  var score = (sLength-3)*10;
  document.getElementById('score').innerText = score;
}
document.onkeydown = function(event) {
  if(!allowPressKeys){
    return null;
  }
  var keyCode;
  if(event == null) {
    keyCode = window.event.keyCode;
  }
  else {
    keyCode = event.keyCode;
  }
  switch(keyCode) {
    case 37: 
      if(d != 'R') {
        Lmove();
      }
      break;
    case 38:
      if(d != 'D') {
        Umove();
      }
      break;
    case 39:
      if(d != 'L'){
        Rmove();
      }
      break;
    case 40:
      if(d != 'U') {
        Dmove();
      }
      break;
    default:
      break;
  }
}
  