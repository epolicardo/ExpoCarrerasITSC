<?php
$nombre= $_GET['nombre'];
$edad= $_GET['edad'];
$email= $_GET['email'];
$carrera= $_GET['carrera'];
echo "<h2>Información recibida </h2>";
echo "el nombre recibido es:" . $nombre . "<br/>";

echo "el edad recibido es:" . $edad . "<br/>";

echo "el email recibido es:" . $email . "<br/>";

echo " la carrera de interes es:" . $carrera . "<br/>";

echo "gracias";
?>