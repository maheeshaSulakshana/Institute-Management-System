<?php
    include_once "DbConnection.php";
    $st_name=$_POST['studentname'];

    $query="delete from test_students where student_name = '".$st_name."'";

    mysqli_query($con,$query);

    echo'DELETED';
?>