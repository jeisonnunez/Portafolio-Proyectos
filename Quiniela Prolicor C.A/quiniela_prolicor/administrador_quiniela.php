<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>QUINIELA GANADORA</title>
<link rel="stylesheet" href="estilo_quiniela2.css">
<style>

.readonly{
	
	background-color:#D3D3D3;
	
	}
	
	

#principal{
	
		
	background-image:url(imagenes/football-world-cup-2018-3420784_1280.jpg);	
}

.button{
  font-size: 14px;
 
  color: white;
  padding: 6px 25px 0px 20px;
  
  cursor:pointer;
  display: inline-block;
  margin: 5px;
  text-decoration: none;
  width: 100px; 
 font-family:"Dusha V5";
  -webkit-border-radius: 5px; 
  -moz-border-radius: 5px; 
  border-radius: 5px; 
  background-color: #720E07; 
  -webkit-box-shadow: 0 3px #720E07; 
  -moz-box-shadow: 0 3px #720E07;  
  box-shadow: 0 3px #720E07; 
  transition: all 0.1s linear 0s; 
  top: 0px;
  position: relative;
}

.button:hover {
  top: 3px;
  background-color:#720E07;
  -webkit-box-shadow: none; 
  -moz-box-shadow: none; 
  box-shadow: none;
  
}

#principal:before{
	
	content:"";
	width:100%;
	height:2460px;
	position:absolute;
	background-color:#4169E1;
	opacity:0.5;
	
	}

@media (max-width:715px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:3970px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}	
	
	
	
	}
	
	@media (max-width:400px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:3620px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}
	}
</style>


<script>

function isNumberKey(evt)
        {
         var charCode = (evt.which) ? evt.which : event.keyCode
         if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;
 
         return true;
        }

</script>
</head>

<body>

<?php

	session_start();
	
	$_usuario=$_SESSION["usuario"];
	
	$_perfil=$_SESSION["perfil"];
	
	if(!isset($_SESSION["usuario"])){
		
		header("location:sistema_desarrollo/sistema_login/login_encriptado.php");			
		
	}
	
	if($_perfil!="administrador"){
		
		header("location:sistema_desarrollo/sistema_login/cierre.php");	
		
		
	}
	

?>

<header id="encabezado">

<div id="banner">

<img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1> <img id="logo1" src="imagenes/logo_nb.png">   
 </div>
 
 <nav id="menu">
   		<ul>
             <li><a href="administrador_quiniela.php">Quiniela Ganadora</a></li>
             <li><a href="quinielas_usuarios.php">Quinielas</a></li>
             <li><a href="usuarios.php">Usuarios</a></li>
             <li><a href="clasificacion.php">Clasificacion</a></li>
             <li><a href="sistema_desarrollo/sistema_login/cierre.php">Cerrar Sesion</a></li>
            
         </ul>
</nav>	
</header>

<p class='usuario'>Administrador: <?php echo $_SESSION["usuario"] ?> </p><br><br>


<?php

include("sistema_desarrollo/crud/conexion_crud.php");

?>	
		
     
<?php					
					
//----------------------------------------------------------Carga la quiniela ganadora-------------------------------------------					
		
						$suma_goles=0;		
						$i=1;	
						$j=2;
						
						for($con=1;$con<=64;$con++){
							
						$valores=$base->prepare("select valor_1, valor_2, actualizado_1, actualizado_2 from quiniela_ganadora where posicion='$con'");
						$valores->execute(array());
						
						$record = $valores->fetchAll();
					
							foreach ($record as $row) {
								
							${"indice".$i."s"}=$row["valor_1"];
							${"actualizado".$i}=$row["actualizado_1"];
							
									
							${"indice".$j."s"}=$row["valor_2"];
							${"actualizado".$j}=$row["actualizado_2"];
							
							}
							
						if($con<=48){
							
						$suma_goles=$suma_goles+${"indice".$i."s"}+${"indice".$j."s"};
						}
						
						$i=$i+2;
						$j=$j+2;	
						}
					
//--------------------------------------------------------actualiza valores en la base de datos-------------------------------------
						
	if(isset($_POST["actualizar"])){
		
							$suma_goles=0;	
							$h=1;
							$k=2;
							
							for($con=1;$con<=64;$con++){
								
								${'posicion'.$h.'s'}=$_POST["$h"];
								${'posicion'.$k.'s'}=$_POST["$k"];								
								
								$actualizar="update quiniela_ganadora set valor_1='${'posicion'.$h.'s'}', valor_2='${'posicion'.$k.'s'}' where posicion='$con'";
																
								$resultado_act=$base->prepare($actualizar);
						
								$resultado_act->execute();
								
								$h=$h+2;
								$k=$k+2;
								
							}
							
							
//-------------------------------------------------------puntajes-----------------------------------------------------------------------

						date_default_timezone_set('America/Asuncion');
								
						$time=time();

					    $fecha_actual=date("Y-m-d H:i:s", $time);
						
						
						
						
						$numero_quinielas=$base->prepare("select codigo_quiniela from usuarios_quiniela");
						
						$numero_quinielas->execute(array());
						
						$record_numero_quinielas = $numero_quinielas->fetchAll();
					
							foreach ($record_numero_quinielas as $row) {
								
							$puntaje_quiniela=0;
							
							$quiniela_actual=$row["codigo_quiniela"];
							
									$quiniela_ganadora=$base->prepare("select posicion, equipo_1, equipo_2, valor_1, valor_2 from quiniela_ganadora where fecha_partido<='$fecha_actual'");
						
									$quiniela_ganadora->execute(array());
						
									$record_quiniela_ganadora = $quiniela_ganadora->fetchAll();
									
							foreach ($record_quiniela_ganadora as $registro) {
											
											 $posicion=$registro["posicion"];
											 $equipo_1_ganadora=$registro["equipo_1"];
											 $equipo_2_ganadora=$registro["equipo_2"];
											 $valor_1_ganadora=$registro["valor_1"];
											 $valor_2_ganadora=$registro["valor_2"];
									
									$quiniela_usuario=$base->prepare("select equipo_1, equipo_2, valor_1, valor_2 from quinielas where posicion='$posicion' and codigo_quiniela='$quiniela_actual'");
						
									$quiniela_usuario->execute(array());
						
									$record_quiniela_usuario = $quiniela_usuario->fetchAll();
									
										foreach ($record_quiniela_usuario as $registro1) {
									
											 $equipo_1_usuario=$registro1["equipo_1"];
											 $equipo_2_usuario=$registro1["equipo_2"];
											 $valor_1_usuario=$registro1["valor_1"];
											 $valor_2_usuario=$registro1["valor_2"];
									
										}//end foreach $record_quiniela_usuario
										
										
//----------------------------------------------------------comparador-------------------------------------------------------------------

									$switch=0;
									
									if(($equipo_1_ganadora==$equipo_1_usuario) && ($equipo_2_ganadora==$equipo_2_usuario)){
													
										if(($valor_1_ganadora==$valor_1_usuario) && ($valor_2_ganadora==$valor_2_usuario) && ($switch==0)){
											
											$puntaje_quiniela=$puntaje_quiniela+5;
											
											$actualizar_puntajes="update usuarios_quiniela set puntaje='$puntaje_quiniela' where codigo_quiniela='$quiniela_actual'";
																
											$resultado_actualizar_puntajes=$base->prepare($actualizar_puntajes);
						
											$resultado_actualizar_puntajes->execute();
											
											$switch=1;
											
											
											}//end if puntaje perfecto
											
										if(($valor_1_ganadora==$valor_2_ganadora) && ($switch==0)){
											
											if($valor_1_usuario==$valor_2_usuario){
												
												$puntaje_quiniela=$puntaje_quiniela+1;
											
												$actualizar_puntajes="update usuarios_quiniela set puntaje='$puntaje_quiniela' where codigo_quiniela='$quiniela_actual'";
																
												$resultado_actualizar_puntajes=$base->prepare($actualizar_puntajes);
						
												$resultado_actualizar_puntajes->execute();	
												
											}
												
										$switch=1;
											
										}//end if empates		
														
										if(($valor_1_ganadora>$valor_2_ganadora) && ($switch==0)){
											
											if($valor_1_usuario>$valor_2_usuario){
												
												$puntaje_quiniela=$puntaje_quiniela+3;
											
												$actualizar_puntajes="update usuarios_quiniela set puntaje='$puntaje_quiniela' where codigo_quiniela='$quiniela_actual'";
																
												$resultado_actualizar_puntajes=$base->prepare($actualizar_puntajes);
						
												$resultado_actualizar_puntajes->execute();	
												
											}
												
										$switch=1;
										
										}//end if ganador equipo_1
										
										if(($valor_1_ganadora<$valor_2_ganadora) && ($switch==0)){
											
											if($valor_1_usuario<$valor_2_usuario){
												
												$puntaje_quiniela=$puntaje_quiniela+3;
											
												$actualizar_puntajes="update usuarios_quiniela set puntaje='$puntaje_quiniela' where codigo_quiniela='$quiniela_actual'";
																
												$resultado_actualizar_puntajes=$base->prepare($actualizar_puntajes);
						
												$resultado_actualizar_puntajes->execute();	
												
											}
												
										$switch=1;
										
										}//end if ganador equipo_2												
													
									}//end if de paises		
									
									$estado="readonly";
									
									$actualizar_estado="update quiniela_ganadora set actualizado_1='$estado', actualizado_2='$estado' where posicion='$posicion'";
																
									$resultado_actualizar_estado=$base->prepare($actualizar_estado);
						
									$resultado_actualizar_estado->execute();							
								
								}//end foreach $record_quiniela_ganadora	
								
						
						
						if($puntaje_quiniela==0){
							
							$actualizar_puntajes="update usuarios_quiniela set puntaje='$puntaje_quiniela' where codigo_quiniela='$quiniela_actual'";
																
							$resultado_actualizar_puntajes=$base->prepare($actualizar_puntajes);
						
							$resultado_actualizar_puntajes->execute();	
							
							
							}


}//end foreach numero de quinielas totales*/
//------------------------------------------------------asigno posicion----------------------------------------------------------

$asigna_posicion=$base->prepare("select codigo_quiniela, posicion from usuarios_quiniela order by puntaje desc");
	
						$asigna_posicion->execute(array());
						
						$record = $asigna_posicion->fetchAll();
						
						$i=1;
					
							foreach ($record as $row) {
							
								
							$codigo=$row["codigo_quiniela"];
							$posicion=$row["posicion"];
							
								$consulta="update usuarios_quiniela set posicion='$i' where codigo_quiniela='$codigo'";
								
								$actualizar=$base->prepare($consulta);
						
								$actualizar->execute();
							
							$i=$i+1;
						
							}
							
							
//--------------------------------------------------------envio correos---------------------------------------------------------------

$mensage='<style>

*{
	padding:0;
	margin:0;
	
	}
	

body{ 

	width:100%;
	overflow-x:hidden;
	
	
	
	
}
	

 
#principal #contenido{

z-index:1;
margin-top:100px;
margin-bottom:100px;

width:100%;	
	
	
}

#contenido table{
	
	margin:auto;
	width:50%;
	font-family:"Dusha V5";
	
}
 
.primera_fila{
	
	background:#1E2D24;
	color:#fff;
	height:40px;
	
	
	
	}
	
	
	
	.resultado{
		
		background:#EEEBD3;
		color:#000;
		
		
		
		
		}
		
		#puntaje{
			
			
			background:#6C5A49;
			color:#FFFFFF;
			
			
			
			}




#principal #seleccion{
	
	z-index:1;
	margin-top:30px;
	
}
	
.usuario{
	
	text-align:left;
	font-size:22px;
font-family:"Dusha V5";
	color:#fff;
	padding:10px;
	margin-top:40px;
	position:fixed;
	z-index:99;
	
	
	
	}	
	


table{
	
	border-collapse:collapse; 

	width:100%;
	cellpadding:11px;
	
	}
	
 td{
	
	
	/*border:1px solid #000000;*/
	text-align:center;
	height:25px;
	font-size:16px;
	font-family:"Dusha V5";
	
	
	}
	
	
	
	

.informacion{
	
	color:#000;
	font-size:0.6em;
	font-family:"Dusha V5";
	text-align:center;
	
	}
	
	@media (max-width:1616px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:1300px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}
		
	}
	
	@media (max-width:815px) {
	#titulo{
	
	margin-left:5%;
	font-size:26px;
	
	}
	
	#menu li a{
	
	
	font-size:1.2em;
	
	
}
	
	}
	
	@media (max-width:690px) {
	#titulo{
	
	margin-left:5%;
	font-size:22px;
	
	
	}
	
	#menu li a{
	
	
	font-size:1.0em;
	
	
}

#principal{
	
	margin-top:110px;
	
	
	
	}

	
	}
	
	
	@media (max-width:540px) {
	#titulo{
	
	margin-left:2%;
	font-size:20px;
	
	}
	
	#menu li a{
	
	
	font-size:0.9em;
	
	
}
	
	}
	
	@media (max-width:480px) {
	#titulo{
	
	margin-left:2%;
	font-size:16px;
	
	}
	
	#logo{
	
	width:15%;
	
	
}

#principal{
	
	margin-top:110px;
	
	
	
	}
	
	
	}

@media (max-width:453px) {
		
	#principal{
	
	margin-top:130px;
	
	
	
	}
}
	@media (max-width:380px) {
		
	#titulo{
	
	margin-left:2%;
	font-size:14px;
	
	}	
	
	#menu li a{
	
	
	padding:0px 1px;
	
	
}

#principal{
	
	margin-top:115px;
	
	
	
	}
	
	}
	
	@media (max-width:325px) {
		
	#titulo{
	
	
	font-size:12px;
	margin-left:0px;
	
	}	
	
	#logo{
	
	width:12%;
	
	
}
	
	}
	
	@media (max-width:715px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:2590px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}	
	
	
	
	}
	@media (max-width:400px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:2320px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}
	
	

	
	
	.informacion{
	
	font-size:8px;
	
	}
	
	.imagen{
	
	width:25px;
	
	
	}
	
	.cuadro{
	
	width:15px;	
	height:15px;
	
	}
	
	}


</style>

<body id="principal">

<div id="contenido">

<form action=""  method="post">

  <table width="50%" border="0" align="center">
   
   <tr><td colspan="4" style="text-align:center">QUINIELA PROLICOR NUBE AZUL</td>
   
   </tr>
    <tr>
      <td class="primera_fila"><p>Posicion</p></td>
      <td class="primera_fila"><p>Codigo Quiniela</p></td>
      <td class="primera_fila"><p>Cedula</p></td>
      <td class="primera_fila"><p>Puntaje</p></td>
    
    </tr>'

;

$sql_total="select codigo_quiniela, cedula, puntaje, posicion from usuarios_quiniela order by puntaje desc";	

	$resultado=$base->prepare($sql_total);
	
	$resultado->execute(array());
	
	$i=1;
				
		foreach ($resultado as $row) {
						
							
			$codigo=$row["codigo_quiniela"];
			
			$consulta="update usuarios_quiniela set posicion='$i' where codigo_quiniela='$codigo'";
							
			$actualizar=$base->prepare($consulta);
				
			$actualizar->execute();
						
			$i=$i+1;
				
			}
	
//----------------------------------------------------------------------------------------------------------------------------

	
require ("PHPMailer_5.2.4/class.phpmailer.php");		
		
		
$mail = new PHPMailer;
$mail->isSMTP();
$mail->Host = 'smtp.prolicor.com.ve';
$mail->Port = 465;
$mail->SMTPSecure = 'ssl';
$mail->SMTPAuth = true;
$mail->Username = "operaciones.oasis@prolicor.com.ve";
$mail->Password = "pro123456";
$mail->setFrom('operaciones.oasis@prolicor.com.ve', 'Quiniela Prolicor');

$clasificacion_puntaje=$base->query("select posicion, codigo_quiniela, cedula, puntaje from usuarios_quiniela                         order by posicion");
							
						foreach($clasificacion_puntaje as $datos){
							
						$mensage.= 	'<tr class="agrandar"><td id="puntaje"><p>';
						$mensage.= $datos['posicion'];
						$mensage.='</p></td>';
						
						$mensage.='<td class="resultado"><p>';
						$mensage.= $datos['codigo_quiniela'];
						$mensage.='</p></td>';
						
						$mensage.='<td class="resultado"><p>';
						$mensage.= $datos['cedula'];
						$mensage.='</p></td>';
						
						$mensage.='<td class="resultado"><p>';
						$mensage.= $datos['puntaje'];
						$mensage.='</p></td>';
						
						$mensage.='</tr>';
						
						}

				$mensage.='
				   
				</table>
				</form>
				 
				</div>
				</body>
				</html>';

$usuarios="select cedula, correo from datos_usuarios";	

	$resultado_usuarios=$base->prepare($usuarios);	
	$resultado_usuarios->execute(array());	
		
		foreach ($resultado_usuarios as $row) {					
										 
			 $correo=$row["correo"];	
			 $cedula=$row["cedula"];			 
			 
		                $mail->clearAddresses();
						$mail->addAddress($correo,$cedula);
						
						$mail->Subject = 'Clasificacion FECHA DE ACTUALIZACION: ' . $fecha_actual;
						$mail->IsHTML(true); 
						
		$mail->Body=$mensage;
		
		if (!$mail->send()) {
		   echo "Mailer Error: " . $mail->ErrorInfo;
		} else {
		
		   
		}
		

 
 }
					
							
							
//--------------------------------------------------------recupera valores en la base de datos------------------------------------------				
						$i=1;	
						$j=2;						
						
						for($con=1;$con<=64;$con++){
							
						$valores=$base->prepare("select valor_1, valor_2, actualizado_1, actualizado_2 from quiniela_ganadora where posicion='$con'");
						$valores->execute(array());
						
						$record = $valores->fetchAll();
					
							foreach ($record as $row) {
								
							${"indice".$i."s"}=$row["valor_1"];
							${"actualizado".$i}=$row["actualizado_1"];
							
									
							${"indice".$j."s"}=$row["valor_2"];
							${"actualizado".$j}=$row["actualizado_2"];
							
							}
							
						if($con<=48){
							
						$suma_goles=$suma_goles+${"indice".$i."s"}+${"indice".$j."s"};
						
						}
						
						$i=$i+2;
						$j=$j+2;	
						}	
						
						?>
                            
                            <script language='javascript'> 	
							alert('Quiniela actualizada');
							</script>                            
						
						<?php
						
					}//end actualizar	
							
							
						
						
	//-------------------------------------------------------identifica los paises de cada grupo-----------------------------

if($suma_goles!=0){
			
	$grupo="A";
	
	for($w=1;$w<=8;$w++){
	
					$sql_equipos = $base->prepare("select distinct equipo_1 from quiniela_ganadora where grupo='$grupo'");						
					$sql_equipos->execute(array());
					$equipos_grupos = $sql_equipos->fetchAll();
					
					$i=1;
				
					foreach ($equipos_grupos as $paises) {
						
						${"pais".$i."s"}=$paises["equipo_1"];
						
						$i=$i+1;
						
						
					}
					
//------------------------------------------------------------------------recorre los partidos---------------------------------------
							
					
					$p1=0;
					$p2=0;
					$p3=0;
					$p4=0;
					$e=1;
					$g=3;
					$goles_anotados1=0;
					$goles_anotados2=0;
					$goles_anotados3=0;
					$goles_anotados4=0;					
					$goles_recibidos1=0;
					$goles_recibidos2=0;
					$goles_recibidos3=0;
					$goles_recibidos4=0;
					$diferencia_goles1;
					$diferencia_goles2;
					$diferencia_goles3;
					$diferencia_goles4;					
					
					$sql_partidos = $base->prepare("select equipo_1, valor_1, valor_2 from quiniela_ganadora where grupo='$grupo'");
						
					$sql_partidos->execute(array());
					$partidos = $sql_partidos->fetchAll();
					
				foreach ($partidos as $row) {
						
						$pais=$row["equipo_1"];
						$valor_1=$row["valor_1"];
						$valor_2=$row["valor_2"];
					
					for($j=1; $j<=4; $j++){
						
						if($pais==${"pais".$j."s"}){
							
							${"goles_anotados".$j}=${"goles_anotados".$j}+$valor_1;
							
							${"goles_recibidos".$j}=${"goles_recibidos".$j}+$valor_2;
							
							if($valor_1>$valor_2){
								
								${"p".$j}=${"p".$j}+$g;
								}
								
							if($valor_1==$valor_2){
								
								${"p".$j}=${"p".$j}+$e;
								}//fin if
							
						}//fin if						
					}//fin for
				}//fin foreach
//-------------------------------------------------------------segundo contador------------------------------------------------------	
			
				$sql_partidos1 = $base->prepare("select equipo_2, valor_1, valor_2 from quiniela_ganadora where grupo='$grupo'");
						
					$sql_partidos1->execute(array());
					$partidos1 = $sql_partidos1->fetchAll();
					
				foreach ($partidos1 as $row2) {
						
						$pais=$row2["equipo_2"];
						$valor_1=$row2["valor_1"];
						$valor_2=$row2["valor_2"];
					
					for($j=1; $j<=4; $j++){
						
						if($pais==${"pais".$j."s"}){
							
							${"goles_anotados".$j}=${"goles_anotados".$j}+$valor_2;
							
							${"goles_recibidos".$j}=${"goles_recibidos".$j}+$valor_1;
							
							if($valor_2>$valor_1){
								
								${"p".$j}=${"p".$j}+$g;
								}
								
							if($valor_2==$valor_1){
								
								${"p".$j}=${"p".$j}+$e;
								}//fin if
							
						}//fin if						
					}//fin for
				}//fin foreach*/
				
				$j=0;	
				
				for ($i=1;$i<=4;$i++){
				
				 ${"pais".$i."s"};				
				${"p".$i};
				 ${"goles_anotados".$i};
				 ${"goles_recibidos".$i};				
				${"diferencia_goles".$i}=${"goles_anotados".$i}-${"goles_recibidos".$i} ;
				
				}
				
				
 //---------------------------------------------------------------vector diferencia de goles-----------------------------------------
				
				 $diferencia_goles_array[0]=$diferencia_goles1.$pais1s;
				$diferencia_goles_array[1]=$diferencia_goles2.$pais2s;
				$diferencia_goles_array[2]=$diferencia_goles3.$pais3s;
				$diferencia_goles_array[3]=$diferencia_goles4.$pais4s;
				 
 
	//---------------------------------------------------------------vector goles marcados de goles----------------------------------
				
				 $goles_marcados_array[0]=$goles_anotados1.$pais1s;
				 $goles_marcados_array[1]=$goles_anotados2.$pais2s;
				 $goles_marcados_array[2]=$goles_anotados3.$pais3s;
				 $goles_marcados_array[3]=$goles_anotados4.$pais4s;
				 
 
//--------------------------------------------------------------------ordena por puntos--------------------------------------------------
				
				$clasificacion_puntos = array($pais1s=>$p1, $pais2s=>$p2, $pais3s=>$p3, $pais4s=>$p4);
				arsort($clasificacion_puntos,SORT_NUMERIC);					
				
				$i=0;
				
					foreach ($clasificacion_puntos as $pais=>$puntaje) {
												
						 $clasificacion_paises[$i]=$puntaje . $pais;							
						
						$i=$i+1;	
					}
					
				
//-------------------------------------------------------verifica si hay puntajes repetidos----------------------------------------------
					
				$arreglo=(array_count_values($clasificacion_puntos));
				
				$sw=0;

				foreach ($arreglo as $key => $val) {
				
					
					 if($val>1){
		
						 $sw=1; //variable usada para saber si hay puntajes repetidos
		
					 }
				}					
				
//----------------------------------------------------------------funcion repeticion-----------------------------------------------------	
	
	if($sw==1){				
				$k=1;
				$j=0;
				$d=0;
				
//------------------------------------------------------------------inicializar el vector------------------------------------------------

for($i=0;$i<=3;$i++){
	
	$primer[$i]="x";
	
	}				
				$segundo=array();
				
				for($i=0;$i<=3; $i++){
					
					if($i==0){
						
						$primer[$j]=$clasificacion_paises[$i];							
						
						}//end if
						else
						{
							
							if(intval($clasificacion_paises[$i])==intval($primer[$j])){
							
							$primer[$k]=$clasificacion_paises[$i];	
							$k=$k+1;
							
							}//end if
							else
							{								
									if($k==1){
										
										if($d==0){
										
										$segundo[$d]=$clasificacion_paises[$i];										
										$d=$d+1;
										
										}//end if
											else
												{
												
													if(intval($segundo[$j])==intval($clasificacion_paises[$i])){
														
														$segundo[$d]=$clasificacion_paises[$i];														
														$d=$d+1;
														
													}//end if												
												}//end else										
									}//end if									
							}//end else						
						}//end else											
					}//end for			
							
//------------------------------------------------------------desempates-------------------------------------------------------------				
			
			
			$clasificacion_final=array();		
						
			if ($primer[1]!="x"){//reviso si hay mas de un primer lugar

					$i=0;
					$k=0;
					$vector_desempate=array();				
				
					foreach ($primer as $puntos) {		
							
							for($j=0; $j<=3; $j++){
									
							$mystring=$primer[$i];
							$desempate=$diferencia_goles_array[$j];
							$findme=substr($desempate,strlen(intval($desempate)),(strlen($desempate)-strlen(intval($desempate))));
							$pos = strpos($mystring, $findme);								
	
								if ($pos==true) {
										
									$vector_desempate[$k]=$diferencia_goles_array[$j];									
									$k=$k+1;	   
								}																
							}
					$i=$i+1;					
					}
						
//-------------------------------------------------------------------desempate por diferencia goles----------------------------------	
						arsort($vector_desempate,SORT_NUMERIC);					
									
						$i=0;
								
							foreach ($vector_desempate as $puntaje) {
																
								$vector_desempate[$i]=$puntaje;		
								
								$clasificacion_final[$i]=$vector_desempate[$i];	
								
								$i=$i+1;	
							}
						
						$primer_lugar=substr($clasificacion_final[0],strlen(intval($clasificacion_final[0])),(strlen($clasificacion_final[0])-strlen(intval($clasificacion_final[0]))));
						$segundo_lugar=substr($clasificacion_final[1],strlen(intval($clasificacion_final[1])),(strlen($clasificacion_final[1])-strlen(intval($clasificacion_final[1]))));
						
						
						
				}else{//desempate segundo lugar
					
					$i=0;
					$k=0;
					$vector_desempate_2=array();				
				
					foreach ($segundo as $puntos) {		
							
							for($j=0; $j<=3; $j++){
									
							$mystring_2=$segundo[$i];
							$desempate_2=$diferencia_goles_array[$j];
							$findme_2=substr($desempate_2,strlen(intval($desempate_2)),(strlen($desempate_2)-strlen(intval($desempate_2))));
	
							$pos_2 = strpos($mystring_2, $findme_2);								
	
								if ($pos_2==true) {
										
									$vector_desempate_2[$k]=$diferencia_goles_array[$j];
									
									$k=$k+1;	   
								}																
							}
					$i=$i+1;					
					}
						
//-----------------------------------------------------------------desempate por diferencia goles-----------------------------------------	
							arsort($vector_desempate_2,SORT_NUMERIC);					
							$f=0;			
							$i=0;		
									
							
							foreach ($vector_desempate_2 as $puntaje) {
																
								$vector_desempate_2[$i]=$puntaje;		
								$clasificacion_final[$i]=$vector_desempate_2[$i];								
									
								
								$i=$i+1;	
							}
					
										
//------------------------------------------------------------------clasificados------------------------------------------------------
						
						
							
						$primer_lugar=substr($primer[0],strlen(intval($primer[0])),(strlen($primer[0])-strlen(intval($primer[0]))));
						
						$segundo_lugar=substr($clasificacion_final[0],strlen(intval($clasificacion_final[0])),(strlen($clasificacion_final                        [0])-strlen(intval($clasificacion_final[0]))));
						
				}
				
		}else{
		
		
		$primer_lugar=substr($clasificacion_paises[0],strlen(intval($clasificacion_paises[0])),(strlen($clasificacion_paises[0])-strlen(intval($clasificacion_paises[0]))));
		$segundo_lugar=substr($clasificacion_paises[1],strlen(intval($clasificacion_paises[1])),(strlen($clasificacion_paises[1])-strlen(intval($clasificacion_paises[1]))));
		
		
		}
	
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
if($grupo=="A"){	
	
	$clasificado1a=$primer_lugar;
	$clasificado2a=$segundo_lugar;	
	
}

if($grupo=="B"){
	
	 $clasificado1b=$primer_lugar;
	 $clasificado2b=$segundo_lugar;	
	
}

if($grupo=="C"){
	
	$clasificado1c=$primer_lugar;
	$clasificado2c=$segundo_lugar;
	
}

if($grupo=="D"){
	
	$clasificado1d=$primer_lugar;
	$clasificado2d=$segundo_lugar;
	
	
}

if($grupo=="E"){
	
	$clasificado1e=$primer_lugar;
	$clasificado2e=$segundo_lugar;
	
	
}

if($grupo=="F"){
	
	$clasificado1f=$primer_lugar;
	$clasificado2f=$segundo_lugar;
	
	
}

if($grupo=="G"){
	
	$clasificado1g=$primer_lugar;
	$clasificado2g=$segundo_lugar;
	
	
}

if($grupo=="H"){
	
	$clasificado1h=$primer_lugar;
	$clasificado2h=$segundo_lugar;
	
}

	if($w==1){
		
		$grupo="B";		
	}
	
	if($w==2){
		
		$grupo="C";		
	}
	
	if($w==3){
		
		$grupo="D";		
	}
	
	if($w==4){
		
		$grupo="E";		
	}
	
	if($w==5){
		
		$grupo="F";		
	}
	
	if($w==6){
		
		$grupo="G";		
	}
	
	if($w==7){
		
		$grupo="H";		
	}
	
}//end for
	
//------------------------------------------------------Inserta clasificados en la quiniela del usuario-------------------------------

							for($con=49;$con<=56;$con++){
								
								if($con==49){
									
									$equipo_1=$clasificado1a;
									$equipo_2=$clasificado2b;
									
									}
									
								if($con==50){
									
									$equipo_1=$clasificado1c;
									$equipo_2=$clasificado2d;
									
									
									}
								
								if($con==51){
									
									$equipo_1=$clasificado1e;
									$equipo_2=$clasificado2f;
									
									
									}
									
								if($con==52){
									
									$equipo_1=$clasificado1g;
									$equipo_2=$clasificado2h;
									
									
									}
									
								if($con==53){
									
									$equipo_1=$clasificado1b;
									$equipo_2=$clasificado2a;
									
									}
									
								if($con==54){
									
									$equipo_1=$clasificado1d;
									$equipo_2=$clasificado2c;
									
									
									}
									
								if($con==55){
									
									$equipo_1=$clasificado1f;
									$equipo_2=$clasificado2e;
									
									}
									
								if($con==56){
									
									$equipo_1=$clasificado1h;
									$equipo_2=$clasificado2g;
									
								}
								
								$octavos_actualizar="update quiniela_ganadora set equipo_1='$equipo_1', equipo_2='$equipo_2' where posicion='$con'";
								
								$resultado_actualizar=$base->prepare($octavos_actualizar);
						
								$resultado_actualizar->execute();
								
								
						
							}
		
							
//--------------------------------------------------comparo clasificados con los equipos de la  base de datos ---------------------

		
							$h=1;
							$k=2;
							$g=0;
							
							for($con=49;$con<=56;$con++){
								
								$equipos_clasificados= $base->prepare("select equipo_1 from quiniela_ganadora where posicion='$con'");
						
								$equipos_clasificados->execute(array());
								
								$equipos_clasificados_array = $equipos_clasificados->fetchAll();
								
									foreach ($equipos_clasificados_array as $row) {
							
													$comparador1=$row["equipo_1"];
													
													}
								
								for($j=1;$j<=32;$j++){
									
									$paises_participantes=$base->prepare("select pais from equipos_participantes where codigo_equipo='$j'");
									$paises_participantes->execute(array());
									
									$paises_participantes_array = $paises_participantes->fetchAll();
								
									foreach ($paises_participantes_array as $row) {
							
													 $comparador2=$row["pais"];
													
													}
													
									
										if($comparador1==$comparador2){		
																
											$pais_identificado=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo='$j'");
											$pais_identificado->execute(array());
											
											$arreglo_paises = $pais_identificado->fetchAll();
											
												foreach ($arreglo_paises as $datos_paises) {
							
													   
													 $paises_octavos[$g]=$datos_paises["pais"];	
													 $logo[$g]=$datos_paises["bandera"];
													  
													}
											
											$g=$g+1;
											$j=33;
										}//end if
								}//end for
								
								
									
								$equipos_clasificados_1= $base->prepare("select equipo_2 from quiniela_ganadora where posicion='$con'");
						
								$equipos_clasificados_1->execute(array());
								
								$equipos_clasificados_array = $equipos_clasificados_1->fetchAll();
								
									foreach ($equipos_clasificados_array as $row) {
							
													 $comparador1=$row["equipo_2"];
													
													}
								
								for($j=1;$j<=32;$j++){
									
									$paises_participantes=$base->prepare("select pais from equipos_participantes where codigo_equipo='$j'");
									$paises_participantes->execute(array());
									
										$paises_participantes_array = $paises_participantes->fetchAll();
									
										foreach ($paises_participantes_array as $row) {
								
													 $comparador2=$row["pais"];
														
														}
									
										if($comparador1==$comparador2){	
										
											$pais_identificado=$base->prepare("select pais, bandera from equipos_participantes where  codigo_equipo='$j'");
											
											$pais_identificado->execute(array());
											
											$arreglo_paises = $pais_identificado->fetchAll();
											
												foreach ($arreglo_paises as $datos_paises) {
							
													 $paises_octavos[$g]=$datos_paises["pais"];
													  
													$logo[$g]=$datos_paises["bandera"];
													  
													}
											
											$g=$g+1;
											$j=33;
										}//end if	
								}//end for	
									
}//end for

}//end suma goles

else{
//---------------------------------------------------introducir pais indefinido en octavos----------------------------------------------

		$indefinido=$base->prepare("select pais from equipos_participantes where codigo_equipo=33");
											
		$indefinido->execute(array());
											
	    $indefinido_array = $indefinido->fetchAll();
											
		    foreach ($indefinido_array as $datos_paises) {
							
			$pais_indefinido=$datos_paises["pais"];
													  
			}
			
		for($con=49;$con<=56;$con++){
			
		$octavos_actualizar="update quiniela_ganadora set equipo_1='$pais_indefinido', equipo_2='$pais_indefinido' where posicion='$con'";
								
		$resultado_actualizar=$base->prepare($octavos_actualizar);
						
	    $resultado_actualizar->execute();
		
		}
//-------------------------------------------------tomo de equipos participantes la bandera y pais indefinido-------------------------
for($i=0;$i<16;$i++){
	
$datos_indefinido=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
$datos_indefinido->execute(array());
											
$arreglo_paises_indefinido = $datos_indefinido->fetchAll();
											
	foreach ($arreglo_paises_indefinido as $datos_paises) {
							
		$paises_octavos[$i]=$datos_paises["pais"];
													  
		$logo[$i]=$datos_paises["bandera"];
													  
	}
}
}//end else
						
//-----------------------------------------------------compara resultados de octavos------------------------------------------------------
	$empate=0;
	$p=0;
	$q=1;
	$c=0;
	$k=97;
	$h=98;
		
for($i=0;$i<8;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_cuartos[$c]=$paises_octavos[$p];
		$logo_cuartos[$c]=$logo[$p];
		
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_cuartos[$c]=$paises_octavos[$q];
		$logo_cuartos[$c]=$logo[$q];
		
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_cuartos[$c]=$datos_paises["pais"];
													  
			$logo_cuartos[$c]=$datos_paises["bandera"];
													  
			}
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

	}
		
//-------------------------------------------------------------Inserta equipos a cuartos de final-----------------------------------

	$i=0;
	$j=1;
	
	for($con=57;$con<=60;$con++){
		
		$cuartos_actualizar="update quiniela_ganadora set equipo_1='$paises_cuartos[$i]', equipo_2='$paises_cuartos[$j]' where posicion='$con'";
								
		$resultado_actualizar_cuartos=$base->prepare($cuartos_actualizar);
						
		$resultado_actualizar_cuartos->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}
	
	
//-------------------------------------------------------------compara resultados de semi----------------------------------------------
	$p=0;
	$q=1;
	$c=0;
	$k=113;
	$h=114;
		
for($i=0;$i<4;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_semi[$c]=$paises_cuartos[$p];
		$logo_semi[$c]=$logo_cuartos[$p];
		
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_semi[$c]=$paises_cuartos[$q];
		$logo_semi[$c]=$logo_cuartos[$q];
		
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_semi[$c]=$datos_paises["pais"];
													  
			$logo_semi[$c]=$datos_paises["bandera"];
													  
			}
		
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

}
	
//-------------------------------------------------------------Inserta equipos a semifinales-----------------------------------	
	$i=0;
	$j=1;
	
	for($con=61;$con<=62;$con++){
		
		$semi_actualizar="update quiniela_ganadora set equipo_1='$paises_semi[$i]', equipo_2='$paises_semi[$j]' where posicion='$con'";
								
		$resultado_actualizar_semi=$base->prepare($semi_actualizar);
						
		$resultado_actualizar_semi->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}

//------------------------------------------------compara resultados de final y 3 lugar----------------------------------------------
	$p=0;
	$q=1;
	$c=0;
	$k=121;
	$h=122;
		
for($i=0;$i<2;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_final[$c]=$paises_semi[$q];
		$logo_final[$c]=$logo_semi[$q];
		
		$paises_final[$c+2]=$paises_semi[$p];
		$logo_final[$c+2]=$logo_semi[$p];
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_final[$c]=$paises_semi[$p];
		$logo_final[$c]=$logo_semi[$p];
		
		$paises_final[$c+2]=$paises_semi[$q];
		$logo_final[$c+2]=$logo_semi[$q];
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_final[$c]=$datos_paises["pais"];
													  
			$logo_final[$c]=$datos_paises["bandera"];
													  
			}
			
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_final[$c+2]=$datos_paises["pais"];
													  
			$logo_final[$c+2]=$datos_paises["bandera"];
													  
			}
		
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

}


//-------------------------------------------------------------Inserta equipos a 3 lugar-----------------------------------	
	$i=0;
	$j=1;
	
	for($con=63;$con<=64;$con++){
		
		$final_actualizar="update quiniela_ganadora set equipo_1='$paises_final[$i]', equipo_2='$paises_final[$j]' where posicion='$con'";
								
		$resultado_actualizar_final=$base->prepare($final_actualizar);
						
		$resultado_actualizar_final->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}
		
//-----------------------------------------------------------Campeon----------------------------------------------------------------

if($indice127s>$indice128s){
		
		$campeon=$paises_final[2];
		$logo_campeon=$logo_final[2];
			
	}
	
	else if($indice127s<$indice128s){
		
		$campeon=$paises_final[3];
		$logo_campeon=$logo_final[3];
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$campeon=$datos_paises["pais"];
													  
			$logo_campeon=$datos_paises["bandera"];
													  
			}
			
	}

//------------------------------------------------------------------------------------------------------------------------------
if($empate==1 && isset($_POST["actualizar"])){
	
	?>
                            
    <script language='javascript'>
	alert('Hay un empate en uno de las llaves. Desempate para continuar');
	</script>
    
    <?php
	
	
	}
	


//----------------------------------------------------------------------------------------------------------------------------------------
	

?>
	
<section id="principal">




<div id="col1">

    <div id="grupo_a">
    
    <form name="formulario_fase_grupo" method="post" action="" id="formulario_fase_grupo">
        
     <table id="equipos_grupo_a">
         
       <th id="titulo_grupo_a" colspan="6">         
             <p>Grupo A</p>           
        </th>
        
        <tr id="a_partido_1">
        
            <td><p class="informacion"><strong>RUSSIA</strong></p></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><input type="text" name="1" id="a_local_1" class="cuadro <?php echo $actualizado1 ?>" <?php echo $actualizado1 ?> value="<?php echo $indice1s ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="2" id="a_visitante_1" class="cuadro <?php echo $actualizado2 ?>" <?php echo $actualizado2 ?> value="<?php echo $indice2s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_2">
        
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><input type="text" name="3" id="a_local_2" class="cuadro <?php echo $actualizado3 ?>" <?php echo $actualizado3 ?> value="<?php echo $indice3s ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="4" id="a_visitante_2" class="cuadro <?php echo $actualizado4 ?>" <?php echo $actualizado4 ?> value="<?php echo $indice4s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><p class="informacion"><strong>URUGUAY</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_3">
        
            <td><p class="informacion"><strong>RUSSIA</strong></p></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><input type="text" name="5" id="a_local_3" class="cuadro <?php echo $actualizado5 ?>" <?php echo $actualizado5 ?> value="<?php echo $indice5s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="6" id="a_visitante_3" class="cuadro <?php echo $actualizado6 ?>" <?php echo $actualizado6 ?> value="<?php echo $indice6s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_4">
        
            <td><p class="informacion"><strong>URUGUAY</p></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><input type="text" name="7" id="a_local_4" class="cuadro <?php echo $actualizado7 ?>" <?php echo $actualizado7 ?> value="<?php echo $indice7s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="8" id="a_visitante_4" class="cuadro <?php echo $actualizado8 ?>" <?php echo $actualizado8 ?> value="<?php echo $indice8s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_5">
        
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><input type="text" name="9" id="a_local_5" class="cuadro <?php echo $actualizado9 ?>" <?php echo $actualizado9 ?> value="<?php echo $indice9s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="10" id="a_visitante_5" class="cuadro <?php echo $actualizado10 ?>" <?php echo $actualizado10 ?> value="<?php echo $indice10s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_6">
        
            <td><p class="informacion"><strong>URUGUAY</strong></p></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><input type="text" name="11" id="a_local_6" class="cuadro <?php echo $actualizado11 ?>" <?php echo $actualizado11 ?> value="<?php echo $indice11s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="12" id="a_visitante_6" class="cuadro <?php echo $actualizado12 ?>" <?php echo $actualizado12 ?> value="<?php echo $indice12s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><p class="informacion"><strong>RUSIA</strong></p></td>
         
         </tr>
        
        </table>      
        
         
    </div>
  
  <div id="grupo_b">
    
   
        
     <table id="equipos_grupo_b">
         
       <th id="titulo_grupo_b" colspan="6">         
             <p>Grupo B</p>           
        </th>
        
        <tr id="b_partido_1">
        
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><input type="text" name="13" id="b_local_1" class="cuadro <?php echo $actualizado13 ?>" <?php echo $actualizado13 ?> value="<?php echo $indice13s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="14" id="b_visitante_1" class="cuadro <?php echo $actualizado14 ?>" <?php echo $actualizado14 ?> value="<?php echo $indice14s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_2">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="15" id="b_local_2" class="cuadro <?php echo $actualizado15 ?>" <?php echo $actualizado15 ?> value="<?php echo $indice15s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="16" id="b_visitante_2" class="cuadro <?php echo $actualizado16 ?>" <?php echo $actualizado16 ?> value="<?php echo $indice16s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_3">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="17" id="b_local_3" class="cuadro <?php echo $actualizado17 ?>" <?php echo $actualizado17 ?> value="<?php echo $indice17s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="18" id="b_visitante_3" class="cuadro <?php echo $actualizado18 ?>" <?php echo $actualizado18 ?> value="<?php echo $indice18s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_4">
        
            <td><p class="informacion"><strong>IRÁN</p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="19" id="b_local_4" class="cuadro <?php echo $actualizado19 ?>" <?php echo $actualizado19 ?> value="<?php echo $indice19s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="20" id="b_visitante_4" class="cuadro <?php echo $actualizado20 ?>" <?php echo $actualizado20 ?> value="<?php echo $indice20s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_5">
        
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><input type="text" name="21" id="b_local_5" class="cuadro <?php echo $actualizado21 ?>" <?php echo $actualizado21 ?> value="<?php echo $indice21s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="22" id="b_visitante_5" class="cuadro <?php echo $actualizado22 ?>" <?php echo $actualizado22 ?> value="<?php echo $indice22s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_6">
        
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="23" id="b_local_6" class="cuadro <?php echo $actualizado23 ?>" <?php echo $actualizado23 ?> value="<?php echo $indice23s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="24" id="b_visitante_6" class="cuadro <?php echo $actualizado24 ?>" <?php echo $actualizado24 ?> value="<?php echo $indice24s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
  
  <div id="grupo_c">
    
     <table id="equipos_grupo_c">
         
       <th id="titulo_grupo_c" colspan="6">         
             <p>Grupo C</p>           
        </th>
        
        <tr id="c_partido_1">
        
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><input type="text" name="25" id="c_local_1" class="cuadro <?php echo $actualizado25 ?>" <?php echo $actualizado25 ?> value="<?php echo $indice25s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="26" id="c_visitante_1" class="cuadro <?php echo $actualizado26 ?>" <?php echo $actualizado26 ?> value="<?php echo $indice26s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_2">
        
            <td><p class="informacion"><strong>PERU</strong></p></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><input type="text" name="27" id="c_local_2" class="cuadro <?php echo $actualizado27 ?>" <?php echo $actualizado27 ?> value="<?php echo $indice27s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="28" id="c_visitante_2" class="cuadro <?php echo $actualizado28 ?>" <?php echo $actualizado28 ?> value="<?php echo $indice28s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_3">
        
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><input type="text" name="29" id="c_local_3" class="cuadro <?php echo $actualizado29 ?>" <?php echo $actualizado29 ?> value="<?php echo $indice29s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="30" id="c_visitante_3" class="cuadro <?php echo $actualizado30 ?>" <?php echo $actualizado30 ?> value="<?php echo $indice30s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_4">
        
            <td><p class="informacion"><strong>DINAMARCA</p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="31" id="c_local_4" class="cuadro <?php echo $actualizado31 ?>" <?php echo $actualizado31 ?> value="<?php echo $indice31s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="32" id="c_visitante_4" class="cuadro <?php echo $actualizado32 ?>" <?php echo $actualizado32 ?> value="<?php echo $indice32s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_5">
        
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
            <td><img src="equipos mundial/png/024-australia.png"  class="imagen"></td>
            <td><input type="text" name="33" id="c_local_5" class="cuadro <?php echo $actualizado33 ?>" <?php echo $actualizado33 ?> value="<?php echo $indice33s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="34" id="c_visitante_5" class="cuadro <?php echo $actualizado34 ?>" <?php echo $actualizado34 ?> value="<?php echo $indice34s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_6">
        
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="35" id="c_local_6" class="cuadro <?php echo $actualizado35 ?>" <?php echo $actualizado35 ?> value="<?php echo $indice35s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="36" id="c_visitante_6" class="cuadro <?php echo $actualizado36 ?>" <?php echo $actualizado36 ?> value="<?php echo $indice36s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_d">
    
     <table id="equipos_grupo_d">
         
       <th id="titulo_grupo_d" colspan="6">         
             <p>Grupo D</p>           
        </th>
        
        <tr id="d_partido_1">
        
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><input type="text" name="37" id="d_local_1" class="cuadro <?php echo $actualizado37 ?>" <?php echo $actualizado37 ?> value="<?php echo $indice37s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="38" id="d_visitante_1" class="cuadro <?php echo $actualizado38 ?>" <?php echo $actualizado38 ?> value="<?php echo $indice38s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_2">
        
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><input type="text" name="39" id="d_local_2" class="cuadro <?php echo $actualizado39 ?>" <?php echo $actualizado39 ?> value="<?php echo $indice39s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="40" id="d_visitante_2" class="cuadro <?php echo $actualizado40 ?>" <?php echo $actualizado40 ?> value="<?php echo $indice40s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_3">
        
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><input type="text" name="41" id="d_local_3" class="cuadro <?php echo $actualizado41 ?>" <?php echo $actualizado41 ?> value="<?php echo $indice41s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="42" id="d_visitante_3" class="cuadro <?php echo $actualizado42 ?>" <?php echo $actualizado42 ?> value="<?php echo $indice42s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_4">
        
            <td><p class="informacion"><strong>NIGERIA</p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="43" id="d_local_4" class="cuadro <?php echo $actualizado43 ?>" <?php echo $actualizado43 ?> value="<?php echo $indice43s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="44" id="d_visitante_4" class="cuadro <?php echo $actualizado44 ?>" <?php echo $actualizado44 ?> value="<?php echo $indice44s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_5">
        
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><input type="text" name="45" id="d_local_5" class="cuadro <?php echo $actualizado45 ?>" <?php echo $actualizado45 ?> value="<?php echo $indice45s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="46" id="d_visitante_5" class="cuadro <?php echo $actualizado46 ?>" <?php echo $actualizado46 ?> value="<?php echo $indice46s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_6">
        
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="47" id="d_local_6" class="cuadro <?php echo $actualizado47 ?>" <?php echo $actualizado47 ?> value="<?php echo $indice47s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="48" id="d_visitante_6" class="cuadro <?php echo $actualizado48 ?>" <?php echo $actualizado48 ?> value="<?php echo $indice48s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
         
         </tr>
        
        </table>           
  
  		</div>
   
    </div>
 
 <div id="col2">
  <div id="grupo_e">
    
    
     <table id="equipos_grupo_e">
         
       <th id="titulo_grupo_e" colspan="6">         
             <p>Grupo E</p>           
        </th>
        
        <tr id="e_partido_1">
        
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><input type="text" name="49" id="e_local_1" class="cuadro <?php echo $actualizado49 ?>" <?php echo $actualizado49 ?> value="<?php echo $indice49s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="50" id="e_visitante_1" class="cuadro <?php echo $actualizado50 ?>" <?php echo $actualizado50 ?> value="<?php echo $indice50s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_2">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="51" id="e_local_2" class="cuadro <?php echo $actualizado51 ?>" <?php echo $actualizado51 ?> value="<?php echo $indice51s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="52" id="e_visitante_2" class="cuadro <?php echo $actualizado52 ?>" <?php echo $actualizado52 ?> value="<?php echo $indice52s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_3">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="53" id="e_local_3" class="cuadro <?php echo $actualizado53 ?>" <?php echo $actualizado53 ?> value="<?php echo $indice53s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="54" id="e_visitante_3" class="cuadro <?php echo $actualizado54 ?>" <?php echo $actualizado54 ?> value="<?php echo $indice54s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_4">
        
            <td><p class="informacion"><strong>SERBIA</p></td>
            <td><img src="equipos mundial/png/021-serbia.png"  class="imagen"></td>
            <td><input type="text" name="55" id="e_local_4" class="cuadro <?php echo $actualizado55 ?>" <?php echo $actualizado55 ?> value="<?php echo $indice55s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="56" id="e_visitante_4" class="cuadro <?php echo $actualizado56 ?>" <?php echo $actualizado56 ?> value="<?php echo $indice56s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_5">
        
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><input type="text" name="57" id="e_local_5" class="cuadro <?php echo $actualizado57 ?>" <?php echo $actualizado57 ?> value="<?php echo $indice57s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="58" id="e_visitante_5" class="cuadro <?php echo $actualizado58 ?>" <?php echo $actualizado58 ?> value="<?php echo $indice58s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_6">
        
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><input type="text" name="59" id="e_local_6" class="cuadro <?php echo $actualizado59 ?>" <?php echo $actualizado59 ?> value="<?php echo $indice59s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="60" id="e_visitante_6" class="cuadro <?php echo $actualizado60 ?>" <?php echo $actualizado60 ?> value="<?php echo $indice60s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/017-brazil.png"  class="imagen"></td>
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_f">
    
    
     <table id="equipos_grupo_f">
         
       <th id="titulo_grupo_f" colspan="6">         
             <p>Grupo F</p>           
        </th>
        
        <tr id="f_partido_1">
        
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><input type="text" name="61" id="f_local_1" class="cuadro <?php echo $actualizado61 ?>" <?php echo $actualizado61 ?> value="<?php echo $indice61s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="62" id="f_visitante_1" class="cuadro <?php echo $actualizado62 ?>" <?php echo $actualizado62 ?> value="<?php echo $indice62s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_2">
        
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><input type="text" name="63" id="f_local_2" class="cuadro <?php echo $actualizado63 ?>" <?php echo $actualizado63 ?> value="<?php echo $indice63s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="64" id="f_visitante_2" class="cuadro <?php echo $actualizado64 ?>" <?php echo $actualizado64 ?> value="<?php echo $indice64s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_3">
        
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><input type="text" name="65" id="f_local_3" class="cuadro <?php echo $actualizado65 ?>" <?php echo $actualizado65 ?> value="<?php echo $indice65s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="66" id="f_visitante_3" class="cuadro <?php echo $actualizado66 ?>" <?php echo $actualizado66 ?> value="<?php echo $indice66s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_4">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="67" id="f_local_4" class="cuadro <?php echo $actualizado67 ?>" <?php echo $actualizado67 ?> value="<?php echo $indice67s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="68" id="f_visitante_4" class="cuadro <?php echo $actualizado68 ?>" <?php echo $actualizado68 ?> value="<?php echo $indice68s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_5">
        
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><input type="text" name="69" id="f_local_5" class="cuadro <?php echo $actualizado69 ?>" <?php echo $actualizado69 ?> value="<?php echo $indice69s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="70" id="f_visitante_5" class="cuadro <?php echo $actualizado70 ?>" <?php echo $actualizado70 ?> value="<?php echo $indice70s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_6">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="71" id="f_local_6" class="cuadro <?php echo $actualizado71 ?>" <?php echo $actualizado71 ?> value="<?php echo $indice71s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="72" id="f_visitante_6" class="cuadro <?php echo $actualizado72 ?>" <?php echo $actualizado72 ?> value="<?php echo $indice72s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_g">
    
    
     <table id="equipos_grupo_g">
         
       <th id="titulo_grupo_g" colspan="6">         
             <p>Grupo G</p>           
        </th>
        
        <tr id="g_partido_1">
        
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><input type="text" name="73" id="g_local_1" class="cuadro <?php echo $actualizado73 ?>" <?php echo $actualizado73 ?> value="<?php echo $indice73s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="74" id="g_visitante_1" class="cuadro <?php echo $actualizado74 ?>" <?php echo $actualizado74 ?> value="<?php echo $indice74s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_2">
        
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><input type="text" name="75" id="g_local_2" class="cuadro <?php echo $actualizado75 ?>" <?php echo $actualizado75 ?> value="<?php echo $indice75s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="76" id="g_visitante_2" class="cuadro <?php echo $actualizado76 ?>" <?php echo $actualizado76 ?> value="<?php echo $indice76s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_3">
        
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><input type="text" name="77" id="g_local_3" class="cuadro <?php echo $actualizado77 ?>" <?php echo $actualizado77 ?> value="<?php echo $indice77s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="78" id="g_visitante_3" class="cuadro <?php echo $actualizado78 ?>" <?php echo $actualizado78 ?> value="<?php echo $indice78s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_4">
        
            <td><p class="informacion"><strong>INGLATERRA</p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="79" id="g_local_4" class="cuadro <?php echo $actualizado79 ?>" <?php echo $actualizado79 ?> value="<?php echo $indice79s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="80" id="g_visitante_4" class="cuadro <?php echo $actualizado80 ?>" <?php echo $actualizado80 ?> value="<?php echo $indice80s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_5">
        
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><input type="text" name="81" id="g_local_5" class="cuadro <?php echo $actualizado81 ?>" <?php echo $actualizado81 ?> value="<?php echo $indice81s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="82" id="g_visitante_5" class="cuadro <?php echo $actualizado82 ?>" <?php echo $actualizado82 ?> value="<?php echo $indice82s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_6">
        
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="83" id="g_local_6" class="cuadro <?php echo $actualizado83 ?>" <?php echo $actualizado83 ?> value="<?php echo $indice83s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="84" id="g_visitante_6" class="cuadro <?php echo $actualizado84 ?>" <?php echo $actualizado84 ?> value="<?php echo $indice84s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_h">
    
    
     <table id="equipos_grupo_h">
         
       <th id="titulo_grupo_h" colspan="6">         
             <p>Grupo H</p>           
        </th>
        
        <tr id="h_partido_1">
        
            <td><p class="informacion"><strong>POLONIA</strong></p></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><input type="text" name="85" id="h_local_1" class="cuadro <?php echo $actualizado85 ?>" <?php echo $actualizado85 ?> value="<?php echo $indice85s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="86" id="h_visitante_1" class="cuadro <?php echo $actualizado86 ?>" <?php echo $actualizado86 ?> value="<?php echo $indice86s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>

         
         </tr>
         
         <tr id="h_partido_2">
        
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><input type="text" name="87" id="h_local_2" class="cuadro <?php echo $actualizado87 ?>" <?php echo $actualizado87 ?> value="<?php echo $indice87s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="88" id="h_visitante_2" class="cuadro <?php echo $actualizado88 ?>" <?php echo $actualizado88 ?> value="<?php echo $indice88s  ?>"></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_3">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="89" id="h_local_3" class="cuadro <?php echo $actualizado89 ?>" <?php echo $actualizado89 ?> value="<?php echo $indice89s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="90" id="h_visitante_3" class="cuadro <?php echo $actualizado90 ?>" <?php echo $actualizado90 ?> value="<?php echo $indice90s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_4">
        
            <td><p class="informacion"><strong>POLONIA</p></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><input type="text" name="91" id="h_local_4" class="cuadro <?php echo $actualizado91 ?>" <?php echo $actualizado91 ?> value="<?php echo $indice91s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="92" id="h_visitante_4" class="cuadro <?php echo $actualizado92 ?>" <?php echo $actualizado92 ?> value="<?php echo $indice92s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_5">
        
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><input type="text" name="93" id="h_local_5" class="cuadro <?php echo $actualizado93 ?>" <?php echo $actualizado93 ?> value="<?php echo $indice93s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="94" id="h_visitante_5" class="cuadro <?php echo $actualizado94 ?>" <?php echo $actualizado94 ?> value="<?php echo $indice94s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_6">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="95" id="h_local_6" class="cuadro <?php echo $actualizado95 ?>" <?php echo $actualizado95 ?> value="<?php echo $indice95s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="96" id="h_visitante_6" class="cuadro <?php echo $actualizado96 ?>" <?php echo $actualizado96 ?> value="<?php echo $indice96s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><p class="informacion"><strong>POLONIA</strong></p></td>
         
         </tr>
        
        </table>   
       
    
    </div>
    
 <!-- ---------------------------------------------cuadro de octavos de final ----------------------------------------------------- -->
   
   </div> 
   
   <div id="cuadro_eliminatoria">
  
   <table id="eliminatoria">
    
    <th class="titulo" colspan="24"><p class="parrafo">ELIMINATORIAS MUNDIAL RUSSIA 2018</p></th>
    <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>

    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="97"  class="cuadro <?php echo $actualizado97 ?>" value="<?php echo $indice97s  ?>" <?php echo $actualizado97 ?>  onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="105"  class="cuadro <?php echo $actualizado105 ?>" value="<?php echo $indice105s  ?>" <?php echo $actualizado105 ?>  onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[8];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[8] ?></strong></p></td> 
      
  
    </tr>
    
     <tr>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="113"  class="cuadro <?php echo $actualizado113 ?>" value="<?php echo $indice113s  ?>" <?php echo $actualizado113 ?> onkeypress="return isNumberKey(this);"></td>  
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum2"><input type="text" name="117"  class="cuadro <?php echo $actualizado117 ?>" value="<?php echo $indice117s  ?>" <?php echo $actualizado117 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[4];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[4] ?></strong></p></td>
  <td>&nbsp;</td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    
    
    <tr>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[1] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="98"  class="cuadro <?php echo $actualizado98 ?>" value="<?php echo $indice98s  ?>" <?php echo $actualizado98 ?>  onkeypress="return isNumberKey(this);"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum2"><input type="text" name="106"  class="cuadro <?php echo $actualizado106 ?>" value="<?php echo $indice106s  ?>" <?php echo $actualizado106 ?>  onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[9];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[9] ?></strong></p></td> 
    
    </tr>
    
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>       
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="121"  class="cuadro <?php echo $actualizado121 ?>" value="<?php echo $indice121s  ?>" <?php echo $actualizado121 ?>  onkeypress="return isNumberKey(this);"></td> 
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td colspan="2" rowspan="4"><img id="copa" src="imagenes/copa_del_mundo.png" class="copa"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="123"  class="cuadro <?php echo $actualizado123 ?>" value="<?php echo $indice123s  ?>" <?php echo $actualizado123 ?>  onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[2];?>" class="imagen"></td>  
    <td  class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[2] ?></strong></p></td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="99"  class="cuadro <?php echo $actualizado99 ?>" value="<?php echo $indice99s  ?>" <?php echo $actualizado99 ?>  onkeypress="return isNumberKey(this);"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="107"  class="cuadro <?php echo $actualizado107 ?>" value="<?php echo $indice107s  ?>" <?php echo $actualizado107 ?>  onkeypress="return isNumberKey(this);"></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[10];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[10] ?></strong></p></td>
    
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[1] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="114"  class="cuadro <?php echo $actualizado114 ?>" value="<?php echo $indice114s  ?>" <?php echo $actualizado114 ?>  onkeypress="return isNumberKey(this);"></td> 
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum2"><input type="text" name="118"  class="cuadro <?php echo $actualizado118 ?>" value="<?php echo $indice118s  ?>" <?php echo $actualizado118 ?> onkeypress="return isNumberKey(this);"></td>  
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[5];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[5] ?></strong></p></td> 
    <td>&nbsp;</td>  
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[3] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[3];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="100"  class="cuadro <?php echo $actualizado100 ?>" value="<?php echo $indice100s  ?>" <?php echo $actualizado100 ?> onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="108"  class="cuadro <?php echo $actualizado108 ?>" value="<?php echo $indice108s  ?>" <?php echo $actualizado108 ?> onkeypress="return isNumberKey(this);"></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[11];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[11] ?></strong></p></td>
    
   
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     
     
     <td colspan="2"><p class="final"><strong>Gran Final</strong></p></td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>   
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    
    </tr> 
    
    
     
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="127"  class="cuadro <?php echo $actualizado127 ?>" value="<?php echo $indice127s  ?>" <?php echo $actualizado127 ?>  onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   
     <td class="colum2"><input type="text" name="128"  class="cuadro <?php echo $actualizado128 ?>" value="<?php echo $indice128s  ?>" <?php echo $actualizado128 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[3];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[3] ?></strong></p></td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr>   
    
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
       <td>&nbsp;</td>
        <td>&nbsp;</td>     
     <td colspan="2"><p class="final"><strong>Campeon</strong><br><img id="campeon" src="/intranet/uploads/<?php echo $logo_campeon;?>" class="imagen_campeon"></p></td>
     
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr> 
    
    
    
    <tr>
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[4] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[4];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="101"  class="cuadro <?php echo $actualizado101 ?>" value="<?php echo $indice101s  ?>" <?php echo $actualizado110 ?> onkeypress="return isNumberKey(this);"></td>
   	<td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum2"><input type="text" name="109"  class="cuadro <?php echo $actualizado109 ?>" value="<?php echo $indice109s  ?>" <?php echo $actualizado109 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[12];?>" class="imagen"></td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[12] ?></strong></p></td>
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
        <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="115"  class="cuadro <?php echo $actualizado115 ?>" value="<?php echo $indice115s  ?>" <?php echo $actualizado115 ?> onkeypress="return isNumberKey(this);"></td> 
 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
     <td class="colum2"><input type="text" name="119"  class="cuadro <?php echo $actualizado119 ?>" value="<?php echo $indice119s  ?>" <?php echo $actualizado119 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[6];?>" class="imagen"></td>  
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[6] ?></strong></p></td>
   <td>&nbsp;</td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    <tr>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[5] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[5];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="102"  class="cuadro <?php echo $actualizado102 ?>" value="<?php echo $indice102s  ?>" <?php echo $actualizado102 ?> onkeypress="return isNumberKey(this);"></td>
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="110"  class="cuadro <?php echo $actualizado110 ?>" value="<?php echo $indice110s  ?>" <?php echo $actualizado110 ?> onkeypress="return isNumberKey(this);"></td> 
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[13];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[13] ?></strong></p></td>
    
    </tr>
    
     
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[1] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="122"  class="cuadro <?php echo $actualizado122 ?>" value="<?php echo $indice122s  ?>" <?php echo $actualizado122 ?> onkeypress="return isNumberKey(this);"></td>   
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
	 <td class="colum2"><input type="text" name="124"  class="cuadro <?php echo $actualizado124 ?>" value="<?php echo $indice124s  ?>" <?php echo $actualizado124 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[3];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[3] ?></strong></p></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>    
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
     
    </tr> 
    
    <tr>
    
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[6] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[6];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="103"  class="cuadro <?php echo $actualizado103 ?>" value="<?php echo $indice103s  ?>" <?php echo $actualizado103 ?> onkeypress="return isNumberKey(this);"></td>  
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="111"  class="cuadro <?php echo $actualizado111 ?>" value="<?php echo $indice111s  ?>" <?php echo $actualizado111 ?> onkeypress="return isNumberKey(this);"></td>   
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[14];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[14] ?></strong></p></td> 
       
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
     <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[3] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[3];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="116"  class="cuadro <?php echo $actualizado116 ?>" value="<?php echo $indice116s  ?>" <?php echo $actualizado116 ?> onkeypress="return isNumberKey(this);"></td>   
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
   
    <td class="colum2"><input type="text" name="120"  class="cuadro <?php echo $actualizado120 ?>" value="<?php echo $indice120s  ?>" <?php echo $actualizado120 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[7];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[7] ?></strong></p></td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[7] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[7];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="104"  class="cuadro <?php echo $actualizado104 ?>" value="<?php echo $indice104s  ?>" <?php echo $actualizado104 ?>  onkeypress="return isNumberKey(this);"></td> 
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="112"  class="cuadro <?php echo $actualizado112 ?>" value="<?php echo $indice112s  ?>" <?php echo $actualizado112 ?> onkeypress="return isNumberKey(this);"></td>       
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[15];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[15] ?></strong></p></td> 
   
    </tr>
    
    <tr>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td colspan="2"><p class="final"><strong>3er Lugar</strong></p></td>
    
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr> 
    
    <tr>
    
   <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>    
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[0];?>" class="imagen"></td> 
    <td class="colum2"><input type="text" name="125"  class="cuadro <?php echo $actualizado125 ?>" value="<?php echo $indice125s  ?>" <?php echo $actualizado125 ?> onkeypress="return isNumberKey(this);"></td>  
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="126"  class="cuadro <?php echo $actualizado126 ?>" value="<?php echo $indice126s  ?>" <?php echo $actualizado126 ?> onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[1] ;?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[1] ?></strong></p></td>
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
   
    </tr>
</table>
  



<input type="submit" name="actualizar" id="actualizar" class="button" value="Actualizar">
   </form>



</section>
  				
  </body>
</html>

