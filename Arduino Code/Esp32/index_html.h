char webpage[] = R"=(
<html>
<body>
  <div style="background:#FFFFFF; width:400px; height:200px">
    <div style="background:#FFFFFF; width:100%; height:10%">
      <h2 align="center">ON</h2>
    </div>
    <div id="LEDn" style="background:#77FF77; width:100%; height:100%"></div> 
  </div>
  <div style="background:#FFFFFF; width:400px; height:200px">
    <div style="background:#FFFFFF; width:100%; height:10%">
      <h2 align="center">PWM plus</h2>
    </div>
    <div id="pwmplus" style="background:#00EE00; width:100%; height:100%"></div>
  </div>
  <div style="background:#FFFFFF; width:400px; height:200px">
    <div style="background:#FFFFFF; width:100%; height:10%">
      <h2 align="center">PWM minus</h2>
    </div>
    <div id="pwmminus" style="background:#CCFFCC; width:100%; height:100%"></div>
  </div>
</body>
<script>
  window.addEventListener('load', function(){
    var n = document.getElementById('LEDn') 
    var minus = document.getElementById('pwmminus') 
    var plus = document.getElementById('pwmplus') 
    
    var xhr = new XMLHttpRequest();
    n.onmousedown = function(){
      xhr.open("GET", "LEDon", true);
      xhr.send();  
    }
    n.onmouseup = function(){
      xhr.open("GET", "LEDoff", true);
      xhr.send();  
    }
    n.addEventListener('touchstart', function(e){
      xhr.open("GET", "LEDon", true);
      xhr.send();
    }, false)
    n.addEventListener('touchend', function(e){
      xhr.open("GET", "LEDoff", true);
      xhr.send();
    }, false)
    plus.onmousedown = function(){
      xhr.open("GET", "plus", true);
      xhr.send();  
    }
    plus.onmouseup = function(){
      xhr.open("GET", "stop", true);
      xhr.send();  
    }
    plus.addEventListener('touchstart', function(e){
      xhr.open("GET", "plus", true);
      xhr.send();
    }, false)
    plus.addEventListener('touchend', function(e){
      xhr.open("GET", "stop", true);
      xhr.send();
    }, false)
    minus.onmousedown = function(){
      xhr.open("GET", "minus", true);
      xhr.send();  
    }
    minus.onmouseup = function(){
      xhr.open("GET", "stop", true);
      xhr.send();  
    }
    minus.addEventListener('touchstart', function(e){
      xhr.open("GET", "minus", true);
      xhr.send();
    }, false)
    minus.addEventListener('touchend', function(e){
      xhr.open("GET", "stop", true);
      xhr.send();
    }, false)
  },false)
</script>
</html>
)=";