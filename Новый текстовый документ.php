<?php
$firstname = $_POST['Firstname'];
$name = $_POST['Name'];
$conn = new mysqli("localhost", "****_****", "******");
if(!$conn)
{
    echo("Error: ".mysqli_connect_error());
}
&sql = "INSERT INTO `users`(`firstname`, `lastname`) VALUES ('".$firstname."', '".$name."')";
if(mysqli_query($conn, $sql))
{
    echo "its ok";
}
else
{
    echo "Error: ".mysqli_error($conn);
}
mysqli_close($conn);
?>