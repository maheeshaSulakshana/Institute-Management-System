<?php 
    include_once "DbConnection.php";

    date_default_timezone_set("Asia/Colombo");

    $studentID = $_POST['studentID'];
    $courseID = $_POST['courseID'];
    $date = date("m/d/Y");
    $time = date("h:i");

    $query = "Select studentID from attendance where studentID = ".$studentID." and courseID = ".$courseID." and date = '".$date."'";

    $res = mysqli_query($con, $query);
    
    $rows = mysqli_num_rows($res);
    
    if ($rows == 0) {
        $query = "insert into attendance values(".$studentID.", ".$courseID.", '".$date."', '".$time."')";

        $res = mysqli_query($con, $query);
    }
?>

<html>
    <head>
        <style>
            div{
                width: 75%;
                height: 60%;
                background-color: honeydew;
                border: 1px double black;
                position: relative;
                left: 150px;
                top: 100px;
                display: none;
            }

            table{
                position: relative;
                top: 150px;
                font-size: 40px; 
                font-family: monospace;
                color: darkcyan;
            }
        </style>
    </head>

    <body>
        <?php if ($rows == 0){ ?>
            <div class = "div">
                <table align = "center">
                    <tr>
                        <th>
                            Attendance Marked Successfully
                        </th>
                    </tr>
                    <tr>
                        <td style = "text-align: center;">
                            <br>
                            <a href = "home.php">Click here to go to home</a>
                        </td>
                    </tr>
                </table>
            </div>
        <?php }
        else{ ?>
            <div class = "div">
                <table align = "center">
                    <tr>
                        <th>
                            Student has already marked attendance for today
                        </th>
                    </tr>
                    <tr>
                        <td style = "text-align: center;">
                            <br>
                            <a href = "home.php">Click here to go to home</a>
                        </td>
                    </tr>
                </table>
            </div>
        <?php } ?>

    <script src = "JQuery.js"></script>

    <script>
        $(function(){
            $('.div').fadeIn(1000);
        });
    </script>

    </body>
</html>