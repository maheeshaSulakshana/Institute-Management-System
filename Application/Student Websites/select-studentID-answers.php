<?php
    include_once 'DbConnection.php';

    $query = "Select distinct studentid from q_a";

    $res = mysqli_query($con, $query);

    $no_rows = mysqli_num_rows($res);

    $c = 1;
?>

<html>
    <head>
        <title>Select StudentID</title>

        <style>
            label{
                font-size: 40px;
            }

            select{
                font-size : 30px;
                width : 400px;
                position: relative;
                left: 55px;
            }

            button{
                font-size: 40px;
            }

            table{
                width: 80%;
                position: relative;
                top: 100px;
            }

            td{
                text-align: center;
            }

            div{
                color:darkseagreen;
                font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
                font-size: 50px;
                font-style: italic;
                text-align: center;
                width: 100%;
                position: relative;
                top: 200px;
            }
        </style>
    </head>

    <body>
        <table border = "2" align = "center" cellpadding = "5px" cellspacing = "0px">
            <tr>
                <td>
                    <form action="answers-page.php" method = "POST">
                        <label for="studentID">Student ID</label>
                            <select required name = "studentID">
                                <option value="">Please Select StudentID</option>
                                <?php while ( $c <= $no_rows ) {$row = mysqli_fetch_assoc($res);?>
                                <option value = '<?php echo $row['studentid'];?>'>
                                <?php echo $row['studentid'];?>
                                </option>
                                <?php $c = $c + 1; } ?>
                            </select> <br> <br> <br>

                        <button type = "submit">View Results</button>
                    </form>
                </td>
             </tr>
        </table>

        <div>To Continue...</div>
    </body>
</html>