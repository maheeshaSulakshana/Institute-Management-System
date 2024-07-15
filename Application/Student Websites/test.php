<?php 
    date_default_timezone_set('Asia/Colombo');

    $time = date("h");

    echo $time;

    $timezone = date_default_timezone_get();

    echo "<br> " .$timezone;
?>

<html>
    <head>
        <script src = "JQuery.js"></script>

        <script>
            $(function(){
                $("#heading").fadeOut(1000);
            });
        </script>
    </head>

    <Body>
        <h1 id = "heading">Hello World</h1>
    </Body>
</html>