<!doctype html>
<html>
    
    <head>
    
        <meta charset="utf-8">
        <title>Documento sin título</title>
        
        <link rel="stylesheet" href="../estilo_login.css">

<style>

#principal{
	
		
	background-image:url(../imagenes/football-1269438_1280.jpg);	
}

#principal:before{
	
	content:"";
	width:100%;
	height:710px;
	position:absolute;
	background-color:#4169E1;
	opacity:0.7;
	
	}


html{
  background-color: #ffffff;
}

.testbox {
  margin: 20px auto;
  width: 343px; 
  height: 360px; 
  -webkit-border-radius: 8px/7px; 
  -moz-border-radius: 8px/7px; 
  border-radius: 8px/7px; 
  background-color: #fff; 
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  border: solid 1px #cbc9c9;
}

input[type=radio] {
  visibility: hidden;
}

form{
  margin: 0 30px;
}

label.radio {
	cursor: pointer;
  text-indent: 35px;
  overflow: visible;
  display: inline-block;
  position: relative;
  margin-bottom: 15px;
}

label.radio:before {
  background: #3a57af;
  content:'';
  position: absolute;
  top:2px;
  left: 0;
  width: 20px;
  height: 20px;
  border-radius: 100%;
}

label.radio:after {
	opacity: 0;
	content: '';
	position: absolute;
	width: 0.5em;
	height: 0.25em;
	background: transparent;
	top: 7.5px;
	left: 4.5px;
	border: 3px solid #ffffff;
	border-top: none;
	border-right: none;

	-webkit-transform: rotate(-45deg);
	-moz-transform: rotate(-45deg);
	-o-transform: rotate(-45deg);
	-ms-transform: rotate(-45deg);
	transform: rotate(-45deg);
}

input[type=radio]:checked + label:after {
	opacity: 1;
}

hr{
  color: #B22222;
  font-family:"Dusha V5";
  opacity: 0.3;
}

input[type=text],input[type=password], input[type=email]{
  width: 200px; 
  font-family:"Dusha V5";
  height: 39px; 
  -webkit-border-radius: 0px 4px 4px 0px/5px 5px 4px 4px; 
  -moz-border-radius: 0px 4px 4px 0px/0px 0px 4px 4px; 
  border-radius: 0px 4px 4px 0px/5px 5px 4px 4px; 
  background-color: #fff; 
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  border: solid 1px #cbc9c9;
  margin-left: -5px;
  margin-top: 45px; 
  padding-left: 10px;
}

input[type=email]{
  margin-bottom: 25px;
}

#icon {
	font-family:"Dusha V5";
  display: inline-block;
  width: 30px;
  background-color: #B22222;
  padding: 8px 0px 8px 15px;
  margin-left: 15px;
  -webkit-border-radius: 4px 0px 0px 4px; 
  -moz-border-radius: 4px 0px 0px 4px; 
  border-radius: 4px 0px 0px 4px;
  color: white;
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.09);
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  border: solid 0px #cbc9c9;
}

.gender {
  margin-left: 30px;
  margin-bottom: 30px;
}

.accounttype{
  margin-left: 8px;
  margin-top: 20px;
}

.button {
	font-family:"Dusha V5";
  font-size: 14px;
  font-weight: 600;
  color: white;
  padding: 6px 25px 0px 20px;
  margin: 10px 8px 20px 0px;
  display: inline-block;
  float: right;
  text-decoration: none;
  width: 100px; height: 27px; 
  -webkit-border-radius: 5px; 
  -moz-border-radius: 5px; 
  border-radius: 5px; 
  background-color: #B22222	; 
  -webkit-box-shadow: 0 3px rgba(153,0,0,1); 
  -moz-box-shadow: 0 3px rgba(153,0,0,1); 
  box-shadow: 0 3px rgba(153,0,0,1);
  transition: all 0.1s linear 0s; 
  top: 0px;
  position: relative;
}

.button:hover {
  top: 3px;
  background-color:#B22222;
  -webkit-box-shadow: none; 
  -moz-box-shadow: none; 
  box-shadow: none;
  
}

.focus:focus {
    border-color:#6e8095;
    outline: none;
	background:#FFE4E1;
	
  }

h1, p{text-align:center;
font-family:"Dusha V5";
color:#B22222;}






</style>
</head>



<body id="principal">

<header id="encabezado">

<div id="banner">

<img id="logo" src="../imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1>  <img id="logo1" src="../imagenes/logo_nb.png">       
 </div>
 
 <nav id="menu"><ul><li>&nbsp;</li></ul>
   		
</nav>	
</header>

<div id="contenido">
<div class="testbox">
  <h1>RECUPERAR CLAVE</h1>

  <form action="sistema_login/comprueba_datos.php" method="post" name="formulario_registro" id="formulario_registro">
      <hr>
   

 
  <label id="icon" for="n_usu"><i class="icon-user"></i></label>
  <input type="text" class="focus" name="n_usu" placeholder="Name" required/>
   <label id="icon" for="c_usu"><i class="icon-envelope "></i></label>
  <input type="email" class="focus" name="c_usu"   placeholder="Email" required/>
  
  
   
   <input type="submit" class="button" value="Registrar">
  </form>
</div>
</div>
</body>
</html>