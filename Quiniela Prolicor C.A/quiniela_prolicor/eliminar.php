<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
</head>

<body>

	<script type="text/javascript">
	
        function confirma_eliminacion() {
			
		<?php
		
		include("sistema_desarrollo/crud/conexion_crud.php");
		$ced=$_GET['ced'];
		
		?>
		
		var usuario = <?php echo $ced; ?>
       
			if (confirm("¿Esta seguro que desea eliminar a este usuario?")) {
				
			<?php

			$base->query("delete from datos_usuarios where cedula='$ced'");
	
			?>	
				
			alert("¡Usuario Eliminado!");
		    window.location('index_crud.php');
			}
			
			
			//Detectamos si el usuario denegó el mensaje
			else {
				
			alert("¡Haz denegado el mensaje!");
			window.location('index_crud.php');
			
			}
			
			
		
        }
        </script>
<?php
header("location:usuarios.php");
?>
</body>
</html>